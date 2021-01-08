using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ColorSwitch
{
    public partial class FrmColorSwitch : Form
    {
        #region Global variables
        private static Image m_baseImage;
        private enum ReplaceMode { RGB, HSB, Restore };

        // Necessary for drag mode. So the app can calculate mouse movement.
        private Point m_oldMouseLocation;

        // For Ctr + Z and Ctr + Y feature so the user can go back and forth on any edit.
        private Stack<object[]> m_pileImgBack;
        private Stack<object[]> m_pileImgFore;
        private object[] m_currentSettings;

        // Different mode the user will be able to use
        private bool m_dragMode;
        private bool m_pickerEnabled;
        private bool m_zoomMode;
        private bool m_rgbMode;

        // Useful to not trigger the value change when a trackbar is updating by the code
        private bool m_trackbarsAutoUpdating;
        #endregion

        public FrmColorSwitch()
        {
            InitializeComponent();

            #region Initialize form settings
            // Setting the maximum size of the screen.
            Rectangle screenResolution = Screen.PrimaryScreen.Bounds;
            MaximumSize = new Size(screenResolution.Width, screenResolution.Height);
            Size = new Size(431, 480);

            pbImage.Cursor = new Cursor(Properties.Resources.picker_icon.GetHicon()); // Changing cursor icon
            pbImage.MouseWheel += pbImage_MouseWheel; // Adding mouse wheel event
            pbImage.InterpolationMode = InterpolationMode.NearestNeighbor; // Change the quality of the image on zoom to be a more raw pixel view

            tbHue.Location = tbRed.Location;
            lblHue.Location = lblRed.Location;
            lblHUEValue.Location = lblRedValue.Location;

            tbSaturation.Location = tbGreen.Location;
            lblSaturation.Location = lblGreen.Location;
            lblSaturationValue.Location = lblGreenValue.Location;

            tbBrightness.Location = tbBlue.Location;
            lblBrightness.Location = lblBlue.Location;
            lblBrightValue.Location = lblBlueValue.Location;

            cdNewColor.Color = pnlNewColor.BackColor;
            cdOldColor.Color = pnlOldColor.BackColor;

            cbAutoMode.Checked = true;
            #endregion

            #region Initialize global variables

            m_baseImage = pbImage.Image;
            m_pickerEnabled = true;
            m_zoomMode = false;
            m_rgbMode = false;

            m_pileImgBack = new Stack<object[]>();
            m_pileImgFore = new Stack<object[]>();

            #endregion

            #region Initialize edition requirement
            UpdateTrackBars(false);
            SaveSettings();
            SwitchRGBMode();

            tmrMove.Interval = 1; // Interval to check the image location on drag mode
            KeyPreview = true; // Necessary for shortcuts that are not from the menu
            #endregion
        }

        #region Methodes

        #region Update
        /// <summary>
        /// Change the value of the new color and replace the image if auto mode is on.
        /// </summary>
        private void UpdateNewColor()
        {
            if (m_trackbarsAutoUpdating)
                return;

            // Generate the color depending of the color mode.
            Color c = m_rgbMode ?
                Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value) :
                Colorer.FromAhsb(255, tbHue.Value, tbSaturation.Value / 100f, tbBrightness.Value / 100f);

            cdNewColor.Color = c;
            pnlNewColor.BackColor = c;

            if (cbAutoMode.Checked)
            {
                if (m_rgbMode)
                    ReplaceImage(ReplaceMode.RGB);
                else
                    ReplaceImage(ReplaceMode.HSB);
            }
        }

        /// <summary>
        /// Auto update trackbars when the new color is from a right click or a color dialog.
        /// If the color is from a color dialog, it takes the value of the dialog.
        /// Else it takes the value of the panel
        /// </summary>
        /// <param name="fromdialog"></param>
        private void UpdateTrackBars(bool fromdialog)
        {
            // Do modifications without triggering valuechange so the new color value don't change.
            m_trackbarsAutoUpdating = true;

            if (m_rgbMode)
            {
                tbRed.Value = pnlNewColor.BackColor.R;
                tbGreen.Value = pnlNewColor.BackColor.G;
                tbBlue.Value = pnlNewColor.BackColor.B;
            }
            else
            {
                tbHue.Value = fromdialog ? (int)cdNewColor.Color.GetHue() : (int)pnlNewColor.BackColor.GetHue();
                float sat = fromdialog ? cdNewColor.Color.GetSaturation() : pnlNewColor.BackColor.GetSaturation();

                tbSaturation.Value = (int)(sat * 100f);
                tbBrightness.Value = (int)(pnlNewColor.BackColor.GetBrightness() * 100f);
            }

            m_trackbarsAutoUpdating = false;
        }
        #endregion

        #region Settings
        /// <summary>
        /// Save the current settings of the app.
        /// </summary>
        private void SaveSettings()
        {
            m_currentSettings = new object[] {
                pbImage.Image, pnlOldColor.BackColor, pnlNewColor.BackColor,
                tbTolerance.Value, tbHue.Value, tbSaturation.Value, tbBrightness.Value,
                tbRed.Value, tbGreen.Value, tbBlue.Value
            };
        }

        /// <summary>
        /// Restore the old setting of the app. For example after a Ctr + Z.
        /// </summary>
        /// <param name="settings">The settings to restore</param>
        private void RestoreSettings(object[] settings)
        {
            pbImage.Image = (Image)settings[0];

            cdOldColor.Color = (Color)settings[1];
            pnlOldColor.BackColor = cdOldColor.Color;
            cdNewColor.Color = (Color)settings[2];
            pnlNewColor.BackColor = cdNewColor.Color;

            tbTolerance.Value = (int)settings[3];

            tbHue.Value = (int)settings[4];
            tbSaturation.Value = (int)settings[5];
            tbBrightness.Value = (int)settings[6];

            tbRed.Value = (int)settings[7];
            tbGreen.Value = (int)settings[8];
            tbBlue.Value = (int)settings[9];
        }

        /// <summary>
        /// Add the current settings of the app in a list.
        /// </summary>
        private void AddSettingsLogs()
        {
            m_pileImgBack.Push(m_currentSettings);
            m_pileImgFore.Clear();

            if (m_pileImgBack.Count > 150)
            {
                List<object[]> test = m_pileImgBack.ToList();
                test.RemoveAt(0);
                m_pileImgBack = new Stack<object[]>(test);
            }

            SaveSettings();
        }
        #endregion

        #region Color dialog
        /// <summary>
        /// Open the color dialog of the pnlOldColor to change its back color.
        /// </summary>
        public void OpenOldColorFrm()
        {
            if (cdOldColor.ShowDialog() == DialogResult.OK)
            {
                pnlOldColor.BackColor = cdOldColor.Color;
                AddSettingsLogs();
            }
        }

        /// <summary>
        /// Open the color dialog of the pnlNewColor to change its back color.
        /// </summary>
        public void openNewColorFrm()
        {
            if (cdNewColor.ShowDialog() == DialogResult.OK)
            {
                pnlNewColor.BackColor = cdNewColor.Color;

                UpdateTrackBars(true);
                AddSettingsLogs();
            }
        }
        #endregion

        #region Edition
        /// <summary>
        /// It replaces the image of the picture box.
        /// </summary>
        /// <param name="replaceMode">The way the image must be changed.</param>
        private void ReplaceImage(ReplaceMode replaceMode)
        {
            Color notToChangeC = cbSpriteMode.Checked ? pnlSpriteMode.BackColor : Color.Empty;

            if (replaceMode == ReplaceMode.HSB)
                pbImage.Image = Colorer.ReplaceColor((Image)m_currentSettings[0], pnlOldColor.BackColor, tbTolerance.Value, tbHue.Value, tbSaturation.Value / 100f, tbBrightness.Value / 100f, new List<Color>() { notToChangeC });
            else if (replaceMode == ReplaceMode.RGB)
                pbImage.Image = Colorer.ReplaceColor((Image)m_currentSettings[0], pnlOldColor.BackColor, pnlNewColor.BackColor, tbTolerance.Value, new List<Color>() { notToChangeC }, cbAutoMode.Checked);
            else
                pbImage.Image = m_baseImage;

            // Change the old panel color so the good color is always edited. 
            if (!cbAutoMode.Checked)
            {
                cdOldColor.Color = pnlNewColor.BackColor;
                pnlOldColor.BackColor = cdOldColor.Color;
            }
        }

        /// <summary>
        /// Switch the edition mode. By RGB or HSB.
        /// </summary>
        private void SwitchRGBMode()
        {
            m_rgbMode = !m_rgbMode;

            tbRed.Visible = m_rgbMode;
            lblRed.Visible = m_rgbMode;
            lblRedValue.Visible = m_rgbMode;

            tbGreen.Visible = m_rgbMode;
            lblGreen.Visible = m_rgbMode;
            lblGreenValue.Visible = m_rgbMode;

            tbBlue.Visible = m_rgbMode;
            lblBlue.Visible = m_rgbMode;
            lblBlueValue.Visible = m_rgbMode;

            tbHue.Visible = !m_rgbMode;
            lblHue.Visible = !m_rgbMode;
            lblHUEValue.Visible = !m_rgbMode;

            tbSaturation.Visible = !m_rgbMode;
            lblSaturation.Visible = !m_rgbMode;
            lblSaturationValue.Visible = !m_rgbMode;

            tbBrightness.Visible = !m_rgbMode;
            lblBrightness.Visible = !m_rgbMode;
            lblBrightValue.Visible = !m_rgbMode;

            btnEditMode.Text = m_rgbMode ? "HSB" : "RGB";
        }
        #endregion

        #endregion

        #region Events

        #region Picture box
        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {
            tmrMove.Enabled = true;
            pbImage.Cursor = m_dragMode ?
                new Cursor(Properties.Resources.drag_go_icon.GetHicon()) :
                pbImage.Cursor = new Cursor(Properties.Resources.picker_icon.GetHicon());
        }

        private void PbImage_MouseUp(object sender, MouseEventArgs e)
        {
            tmrMove.Enabled = false;
            m_oldMouseLocation = new Point(0, 0);

            pbImage.Cursor = m_dragMode ?
                new Cursor(Properties.Resources.drag_icon.GetHicon()) :
                pbImage.Cursor = new Cursor(Properties.Resources.picker_icon.GetHicon());
        }

        private void pbImage_MouseWheel(object sender, MouseEventArgs e)
        {
            if (tbZoom.Value + e.Delta / 5 >= tbZoom.Minimum &&
                tbZoom.Value + e.Delta / 5 <= tbZoom.Maximum && m_zoomMode)
                tbZoom.Value += e.Delta / 5;
        }

        private void pbImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_dragMode)
                return;

            double zoom = tbZoom.Value / 100d;

            int x = (int)(e.X / zoom);
            int y = (int)(e.Y / zoom);

            // Select the color of a panel depending of the button clicked.
            if (e.Button == MouseButtons.Left)
            {
                cdOldColor.Color = ((Bitmap)pbImage.Image).GetPixel(x, y);
                pnlOldColor.BackColor = cdOldColor.Color;
            }
            else if (e.Button == MouseButtons.Right)
            {
                cdNewColor.Color = ((Bitmap)pbImage.Image).GetPixel(x, y);
                pnlNewColor.BackColor = cdNewColor.Color;
                UpdateTrackBars(false);
            }
            else if (cbSpriteMode.Checked && e.Button == MouseButtons.Middle)
                pnlSpriteMode.BackColor = ((Bitmap)pbImage.Image).GetPixel(x, y);

            AddSettingsLogs();
        }
        #endregion

        #region Panel
        private void pnlOldColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Switch the color of the panel
                Color c = pnlOldColor.BackColor;
                pnlOldColor.BackColor = pnlNewColor.BackColor;
                pnlNewColor.BackColor = c;

                UpdateTrackBars(false);
            }
            else
                OpenOldColorFrm();
        }

        private void pnlNewColor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Switch the color of the panel
                Color c = pnlOldColor.BackColor;
                pnlOldColor.BackColor = pnlNewColor.BackColor;
                pnlNewColor.BackColor = c;

                UpdateTrackBars(false);
            }
            else
                openNewColorFrm();
        }
        #endregion

        #region Trackbars

        private void TrackBars_MouseUp(object sender, MouseEventArgs e)
        {
            AddSettingsLogs();

            // Change the old panel color so the good color is always edited.
            if (cbAutoMode.Checked)
            {
                cdOldColor.Color = pnlNewColor.BackColor;
                pnlOldColor.BackColor = cdOldColor.Color;
            }
        }

        private void tbZoom_ValueChanged(object sender, EventArgs e)
        {
            lblZoomValue.Text = (tbZoom.Value / 100).ToString() + (tbZoom.Value % 100).ToString("00") + " %";
            Size zoomSz = new Size(m_baseImage.Size.Width * tbZoom.Value / 100, m_baseImage.Size.Height * tbZoom.Value / 100);
            pbImage.Size = zoomSz;

            // Reset the location so the image stay in the visible zone.
            pbImage.Location = new Point(pnlBg.Width, menu.Height);
        }

        #region Trackbars HSB
        private void tbTolerance_ValueChanged(object sender, EventArgs e)
        {
            lblToleranceValue.Text = tbTolerance.Value.ToString();
            UpdateNewColor();
        }

        private void tbHUE_ValueChanged(object sender, EventArgs e)
        {
            lblHUEValue.Text = tbHue.Value.ToString();
            UpdateNewColor();
        }

        private void tbSaturation_ValueChanged(object sender, EventArgs e)
        {
            lblSaturationValue.Text = tbSaturation.Value.ToString();
            UpdateNewColor();

        }

        private void tbBrightness_ValueChanged(object sender, EventArgs e)
        {
            lblBrightValue.Text = tbBrightness.Value.ToString();
            UpdateNewColor();
        }
        #endregion

        #region Trackbars RGB
        private void tbRed_ValueChanged(object sender, EventArgs e)
        {
            lblRedValue.Text = tbRed.Value.ToString();
            UpdateNewColor();
        }

        private void tbGreen_ValueChanged(object sender, EventArgs e)
        {
            lblGreenValue.Text = tbGreen.Value.ToString();
            UpdateNewColor();
        }

        private void tbBlue_ValueChanged(object sender, EventArgs e)
        {
            lblBlueValue.Text = tbBlue.Value.ToString();
            UpdateNewColor();
        }
        #endregion

        #endregion

        #region Icons

        #region Replace arrow
        private void pbArrow_MouseEnter(object sender, EventArgs e)
        {
            pbArrow.Location = new Point(pbArrow.Location.X + 1, pbArrow.Location.Y);
        }

        private void pbArrow_MouseLeave(object sender, EventArgs e)
        {
            pbArrow.Location = new Point(pbArrow.Location.X - 1, pbArrow.Location.Y);
        }

        private void pbArrow_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_rgbMode)
            {
                ReplaceImage(ReplaceMode.RGB);
                if (cbAutoMode.Checked)
                {
                    cdOldColor.Color = pnlNewColor.BackColor;
                    pnlOldColor.BackColor = cdOldColor.Color;
                }
            }
            else
                ReplaceImage(ReplaceMode.HSB);

            AddSettingsLogs();
        }
        #endregion

        #region Restart arrow
        private void pbRestart_MouseEnter(object sender, EventArgs e)
        {
            pbRestart.Size = new Size(pbRestart.Width + 5, pbRestart.Height + 2);
            pbRestart.Location = new Point(pbRestart.Location.X - 1, pbRestart.Location.Y - 2);
        }

        private void pbRestart_MouseLeave(object sender, EventArgs e)
        {
            pbRestart.Size = new Size(pbRestart.Width - 5, pbRestart.Height - 2);
            pbRestart.Location = new Point(pbRestart.Location.X + 1, pbRestart.Location.Y + 2);
        }

        private void pbRestart_MouseClick(object sender, MouseEventArgs e)
        {
            ReplaceImage(ReplaceMode.Restore);
            AddSettingsLogs();
        }
        #endregion

        #endregion

        #region Form
        private void FrmColorSwitch_SizeChanged(object sender, EventArgs e)
        {
            pnlBg.Height = Size.Height;
        }

        private void FrmColorSwitch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                m_dragMode = true;
                if (m_pickerEnabled)
                {
                    pbImage.Cursor = new Cursor(Properties.Resources.drag_icon.GetHicon());
                    m_pickerEnabled = false;
                }

                if (e.Alt)
                    m_zoomMode = true;
                else if (e.KeyCode == Keys.Z && m_pileImgBack.Count > 0)
                {
                    m_pileImgFore.Push(m_currentSettings);

                    m_currentSettings = m_pileImgBack.Pop();
                    if (cbAutoMode.Checked)
                    {
                        m_trackbarsAutoUpdating = true;
                        RestoreSettings(m_currentSettings);
                        m_trackbarsAutoUpdating = false;
                    }
                    else
                        RestoreSettings(m_currentSettings);
                }
                else if (e.KeyCode == Keys.Y && m_pileImgFore.Count > 0)
                {
                    m_pileImgBack.Push(m_currentSettings);

                    m_currentSettings = m_pileImgFore.Pop();
                    if (cbAutoMode.Checked)
                    {
                        m_trackbarsAutoUpdating = true;
                        RestoreSettings(m_currentSettings);
                        m_trackbarsAutoUpdating = false;
                    }
                    else
                        RestoreSettings(m_currentSettings);
                }
            }
        }

        private void FrmColorSwitch_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                m_dragMode = false;
                pbImage.Cursor = new Cursor(Properties.Resources.picker_icon.GetHicon());
                m_pickerEnabled = true;
            }

            if (!e.Control || !e.Alt)
                m_zoomMode = false;

        }
        #endregion

        #region Menu

        #region File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG image|*.png|Gif image|*.gif";
            saveDialog.FileName = "image1.png";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImage.Image.Save(saveDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG image|*.png|Gif image|*.gif";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    m_baseImage = Image.FromFile(openFile.FileName);
                    pbImage.Image = m_baseImage;
                    tbZoom_ValueChanged(this, null); // triger a valuechange to resize the form correctly.
                    m_pileImgBack.Clear();
                    m_pileImgFore.Clear();

                    SaveSettings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Image

        #region Edition controls
        private void setColorToReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenOldColorFrm();
        }

        private void setNewColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewColorFrm();
        }

        private void replaceByPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_rgbMode)
                ReplaceImage(ReplaceMode.RGB);
            else
                ReplaceImage(ReplaceMode.HSB);

            AddSettingsLogs();
        }

        private void restoreOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceImage(ReplaceMode.Restore);
            AddSettingsLogs();
        }
        #endregion

        #region Edition modes
        private void AutoUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbAutoMode.Checked = autoUpdateToolStripMenuItem.Checked;
        }

        private void cbAutoMode_CheckedChanged(object sender, EventArgs e)
        {
            autoUpdateToolStripMenuItem.Checked = cbAutoMode.Checked;
        }

        private void spriteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbSpriteMode.Checked = spriteModeToolStripMenuItem.Checked;
        }

        private void cbSpriteMode_CheckedChanged(object sender, EventArgs e)
        {
            spriteModeToolStripMenuItem.Checked = cbSpriteMode.Checked;
            pnlSpriteMode.Visible = cbSpriteMode.Checked;
        }

        private void hSBModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchRGBMode();
            hSBModeToolStripMenuItem.Checked = !m_rgbMode;
        }
        #endregion

        #endregion

        #region Help
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello,\n if you have any question, feel free to contact me at \"aurelende@protonmail.com\"" +
                "\n\n I hope you find this app simple and useful. \n Aurele NT", "Help", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        #endregion

        #endregion

        #region Timer
        private void tmrMove_Tick(object sender, EventArgs e)
        {
            if (!m_dragMode)
                return;

            if (m_oldMouseLocation.X == 0 && m_oldMouseLocation.Y == 0)
            {
                m_oldMouseLocation = new Point(MousePosition.X, MousePosition.Y);
                return;
            }

            int deltaX = MousePosition.X - m_oldMouseLocation.X;
            int deltaY = MousePosition.Y - m_oldMouseLocation.Y;

            int x = pbImage.Location.X + deltaX;
            int y = pbImage.Location.Y + deltaY;

            // Check if the image can be deplaced and fix the limit.
            if (deltaX > 0 && x > pnlBg.Width || deltaX < 0 && x + pbImage.Width < Width) // horizontal drag
                x = pbImage.Location.X;

            int imageHeightWitoutY = y < 0 ? pbImage.Height - Math.Abs(y) : pbImage.Height; // the height of the visible image and invisible bottom

            if (deltaY < 0 && imageHeightWitoutY < Height - menu.Height || deltaY > 0 && y > menu.Height) // vertical drag
                y = pbImage.Location.Y;

            pbImage.Location = new Point(x, y);
            m_oldMouseLocation = new Point(MousePosition.X, MousePosition.Y);
        }
        #endregion

        #region Button
        private void btnEditMode_Click(object sender, EventArgs e)
        {
            SwitchRGBMode();
            hSBModeToolStripMenuItem.Checked = !m_rgbMode;
        }

        private void btnEditMode_MouseEnter(object sender, EventArgs e)
        {
            btnEditMode.ForeColor = Color.FromArgb(93, 196, 24);
        }

        private void btnEditMode_MouseLeave(object sender, EventArgs e)
        {
            btnEditMode.ForeColor = Color.FromArgb(107, 24, 196);
        }
        #endregion

        #endregion
    }
}
