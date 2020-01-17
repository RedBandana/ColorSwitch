namespace ColorSwitch
{
    partial class FrmColorSwitch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColorSwitch));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNewColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceByPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSBModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlNewColor = new System.Windows.Forms.Panel();
            this.pnlOldColor = new System.Windows.Forms.Panel();
            this.cdOldColor = new System.Windows.Forms.ColorDialog();
            this.cdNewColor = new System.Windows.Forms.ColorDialog();
            this.tbTolerance = new System.Windows.Forms.TrackBar();
            this.lblToleranceValue = new System.Windows.Forms.Label();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.tbZoom = new System.Windows.Forms.TrackBar();
            this.lblZoomValue = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.pnlBg = new System.Windows.Forms.Panel();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblBrightValue = new System.Windows.Forms.Label();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.lblHUEValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblHue = new System.Windows.Forms.Label();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblSaturationValue = new System.Windows.Forms.Label();
            this.tbHue = new System.Windows.Forms.TrackBar();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.tbSaturation = new System.Windows.Forms.TrackBar();
            this.pnlSpriteMode = new System.Windows.Forms.Panel();
            this.lblGreen = new System.Windows.Forms.Label();
            this.cbSpriteMode = new System.Windows.Forms.CheckBox();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.cbAutoMode = new System.Windows.Forms.CheckBox();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.pbImage = new RedCell.UI.Controls.PixelBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).BeginInit();
            this.pnlBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu.BackgroundImage = global::ColorSwitch.Properties.Resources.menu_color;
            this.menu.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(415, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setColorToReplaceToolStripMenuItem,
            this.setNewColorToolStripMenuItem,
            this.replaceByPixelToolStripMenuItem,
            this.restoreOriginalToolStripMenuItem,
            this.autoUpdateToolStripMenuItem,
            this.spriteModeToolStripMenuItem,
            this.hSBModeToolStripMenuItem});
            this.imageToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // setColorToReplaceToolStripMenuItem
            // 
            this.setColorToReplaceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.setColorToReplaceToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.setColorToReplaceToolStripMenuItem.Name = "setColorToReplaceToolStripMenuItem";
            this.setColorToReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.setColorToReplaceToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setColorToReplaceToolStripMenuItem.Text = "Color to replace";
            this.setColorToReplaceToolStripMenuItem.Click += new System.EventHandler(this.setColorToReplaceToolStripMenuItem_Click);
            // 
            // setNewColorToolStripMenuItem
            // 
            this.setNewColorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.setNewColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.setNewColorToolStripMenuItem.Name = "setNewColorToolStripMenuItem";
            this.setNewColorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.setNewColorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.setNewColorToolStripMenuItem.Text = "New color";
            this.setNewColorToolStripMenuItem.Click += new System.EventHandler(this.setNewColorToolStripMenuItem_Click);
            // 
            // replaceByPixelToolStripMenuItem
            // 
            this.replaceByPixelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.replaceByPixelToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.replaceByPixelToolStripMenuItem.Name = "replaceByPixelToolStripMenuItem";
            this.replaceByPixelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.replaceByPixelToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.replaceByPixelToolStripMenuItem.Text = "Replace color";
            this.replaceByPixelToolStripMenuItem.Click += new System.EventHandler(this.replaceByPixelToolStripMenuItem_Click);
            // 
            // restoreOriginalToolStripMenuItem
            // 
            this.restoreOriginalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.restoreOriginalToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.restoreOriginalToolStripMenuItem.Name = "restoreOriginalToolStripMenuItem";
            this.restoreOriginalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.restoreOriginalToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.restoreOriginalToolStripMenuItem.Text = "Restore image";
            this.restoreOriginalToolStripMenuItem.Click += new System.EventHandler(this.restoreOriginalToolStripMenuItem_Click);
            // 
            // autoUpdateToolStripMenuItem
            // 
            this.autoUpdateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.autoUpdateToolStripMenuItem.CheckOnClick = true;
            this.autoUpdateToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.autoUpdateToolStripMenuItem.Name = "autoUpdateToolStripMenuItem";
            this.autoUpdateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.autoUpdateToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.autoUpdateToolStripMenuItem.Text = "Auto mode";
            this.autoUpdateToolStripMenuItem.Click += new System.EventHandler(this.AutoUpdateToolStripMenuItem_Click);
            // 
            // spriteModeToolStripMenuItem
            // 
            this.spriteModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.spriteModeToolStripMenuItem.CheckOnClick = true;
            this.spriteModeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.spriteModeToolStripMenuItem.Name = "spriteModeToolStripMenuItem";
            this.spriteModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.spriteModeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.spriteModeToolStripMenuItem.Text = "Sprite mode";
            this.spriteModeToolStripMenuItem.Click += new System.EventHandler(this.spriteModeToolStripMenuItem_Click);
            // 
            // hSBModeToolStripMenuItem
            // 
            this.hSBModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.hSBModeToolStripMenuItem.CheckOnClick = true;
            this.hSBModeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hSBModeToolStripMenuItem.Name = "hSBModeToolStripMenuItem";
            this.hSBModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.hSBModeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.hSBModeToolStripMenuItem.Text = "HSB mode";
            this.hSBModeToolStripMenuItem.Click += new System.EventHandler(this.hSBModeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem1.Text = "help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // pnlNewColor
            // 
            this.pnlNewColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(196)))), ((int)(((byte)(24)))));
            this.pnlNewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewColor.Location = new System.Drawing.Point(74, 36);
            this.pnlNewColor.Name = "pnlNewColor";
            this.pnlNewColor.Size = new System.Drawing.Size(25, 24);
            this.pnlNewColor.TabIndex = 2;
            this.pnlNewColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlNewColor_MouseClick);
            // 
            // pnlOldColor
            // 
            this.pnlOldColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.pnlOldColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOldColor.Location = new System.Drawing.Point(13, 36);
            this.pnlOldColor.Name = "pnlOldColor";
            this.pnlOldColor.Size = new System.Drawing.Size(25, 24);
            this.pnlOldColor.TabIndex = 3;
            this.pnlOldColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlOldColor_MouseClick);
            // 
            // cdOldColor
            // 
            this.cdOldColor.FullOpen = true;
            // 
            // cdNewColor
            // 
            this.cdNewColor.FullOpen = true;
            // 
            // tbTolerance
            // 
            this.tbTolerance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbTolerance.Location = new System.Drawing.Point(8, 85);
            this.tbTolerance.Maximum = 255;
            this.tbTolerance.Name = "tbTolerance";
            this.tbTolerance.Size = new System.Drawing.Size(116, 45);
            this.tbTolerance.TabIndex = 9;
            this.tbTolerance.TickFrequency = 85;
            this.tbTolerance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbTolerance.Value = 50;
            this.tbTolerance.ValueChanged += new System.EventHandler(this.tbTolerance_ValueChanged);
            this.tbTolerance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // lblToleranceValue
            // 
            this.lblToleranceValue.AutoSize = true;
            this.lblToleranceValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblToleranceValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToleranceValue.Location = new System.Drawing.Point(116, 85);
            this.lblToleranceValue.Name = "lblToleranceValue";
            this.lblToleranceValue.Size = new System.Drawing.Size(27, 19);
            this.lblToleranceValue.TabIndex = 10;
            this.lblToleranceValue.Text = "50";
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTolerance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblTolerance.Location = new System.Drawing.Point(12, 107);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(58, 15);
            this.lblTolerance.TabIndex = 11;
            this.lblTolerance.Text = "Tolerance";
            // 
            // tbZoom
            // 
            this.tbZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbZoom.Location = new System.Drawing.Point(8, 329);
            this.tbZoom.Maximum = 1000;
            this.tbZoom.Minimum = 1;
            this.tbZoom.Name = "tbZoom";
            this.tbZoom.Size = new System.Drawing.Size(116, 45);
            this.tbZoom.TabIndex = 1;
            this.tbZoom.TickFrequency = 200;
            this.tbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZoom.Value = 100;
            this.tbZoom.ValueChanged += new System.EventHandler(this.tbZoom_ValueChanged);
            // 
            // lblZoomValue
            // 
            this.lblZoomValue.AutoSize = true;
            this.lblZoomValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblZoomValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoomValue.Location = new System.Drawing.Point(116, 329);
            this.lblZoomValue.Name = "lblZoomValue";
            this.lblZoomValue.Size = new System.Drawing.Size(46, 19);
            this.lblZoomValue.TabIndex = 14;
            this.lblZoomValue.Text = "100 %";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblZoom.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblZoom.Location = new System.Drawing.Point(12, 351);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(40, 15);
            this.lblZoom.TabIndex = 16;
            this.lblZoom.Text = "Zoom";
            // 
            // pnlBg
            // 
            this.pnlBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlBg.Controls.Add(this.lblBrightness);
            this.pnlBg.Controls.Add(this.lblBlue);
            this.pnlBg.Controls.Add(this.lblBrightValue);
            this.pnlBg.Controls.Add(this.btnEditMode);
            this.pnlBg.Controls.Add(this.lblHUEValue);
            this.pnlBg.Controls.Add(this.lblBlueValue);
            this.pnlBg.Controls.Add(this.lblHue);
            this.pnlBg.Controls.Add(this.lblTolerance);
            this.pnlBg.Controls.Add(this.lblSaturation);
            this.pnlBg.Controls.Add(this.lblRedValue);
            this.pnlBg.Controls.Add(this.lblSaturationValue);
            this.pnlBg.Controls.Add(this.lblToleranceValue);
            this.pnlBg.Controls.Add(this.tbHue);
            this.pnlBg.Controls.Add(this.tbBrightness);
            this.pnlBg.Controls.Add(this.lblRed);
            this.pnlBg.Controls.Add(this.tbSaturation);
            this.pnlBg.Controls.Add(this.pnlSpriteMode);
            this.pnlBg.Controls.Add(this.lblGreen);
            this.pnlBg.Controls.Add(this.cbSpriteMode);
            this.pnlBg.Controls.Add(this.tbRed);
            this.pnlBg.Controls.Add(this.lblGreenValue);
            this.pnlBg.Controls.Add(this.cbAutoMode);
            this.pnlBg.Controls.Add(this.tbGreen);
            this.pnlBg.Controls.Add(this.lblZoom);
            this.pnlBg.Controls.Add(this.tbBlue);
            this.pnlBg.Controls.Add(this.pbArrow);
            this.pnlBg.Controls.Add(this.pbRestart);
            this.pnlBg.Controls.Add(this.pnlOldColor);
            this.pnlBg.Controls.Add(this.pnlNewColor);
            this.pnlBg.Controls.Add(this.lblZoomValue);
            this.pnlBg.Controls.Add(this.tbZoom);
            this.pnlBg.Controls.Add(this.tbTolerance);
            this.pnlBg.Location = new System.Drawing.Point(0, 0);
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Size = new System.Drawing.Size(175, 628);
            this.pnlBg.TabIndex = 17;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBrightness.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblBrightness.Location = new System.Drawing.Point(12, 604);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(64, 15);
            this.lblBrightness.TabIndex = 26;
            this.lblBrightness.Text = "Brightness";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBlue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblBlue.Location = new System.Drawing.Point(12, 290);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 15);
            this.lblBlue.TabIndex = 26;
            this.lblBlue.Text = "Blue";
            // 
            // lblBrightValue
            // 
            this.lblBrightValue.AutoSize = true;
            this.lblBrightValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBrightValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightValue.Location = new System.Drawing.Point(116, 574);
            this.lblBrightValue.Name = "lblBrightValue";
            this.lblBrightValue.Size = new System.Drawing.Size(26, 19);
            this.lblBrightValue.TabIndex = 25;
            this.lblBrightValue.Text = "43";
            // 
            // btnEditMode
            // 
            this.btnEditMode.BackgroundImage = global::ColorSwitch.Properties.Resources.menu_color;
            this.btnEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMode.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMode.Image = global::ColorSwitch.Properties.Resources.menu_color;
            this.btnEditMode.Location = new System.Drawing.Point(120, 36);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(42, 24);
            this.btnEditMode.TabIndex = 30;
            this.btnEditMode.Text = "HSB";
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            this.btnEditMode.MouseEnter += new System.EventHandler(this.btnEditMode_MouseEnter);
            this.btnEditMode.MouseLeave += new System.EventHandler(this.btnEditMode_MouseLeave);
            // 
            // lblHUEValue
            // 
            this.lblHUEValue.AutoSize = true;
            this.lblHUEValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblHUEValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHUEValue.Location = new System.Drawing.Point(116, 452);
            this.lblHUEValue.Name = "lblHUEValue";
            this.lblHUEValue.Size = new System.Drawing.Size(26, 19);
            this.lblHUEValue.TabIndex = 19;
            this.lblHUEValue.Text = "95";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblBlueValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(115, 268);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(26, 19);
            this.lblBlueValue.TabIndex = 25;
            this.lblBlueValue.Text = "24";
            // 
            // lblHue
            // 
            this.lblHue.AutoSize = true;
            this.lblHue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblHue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblHue.Location = new System.Drawing.Point(12, 482);
            this.lblHue.Name = "lblHue";
            this.lblHue.Size = new System.Drawing.Size(29, 15);
            this.lblHue.TabIndex = 20;
            this.lblHue.Text = "Hue";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSaturation.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblSaturation.Location = new System.Drawing.Point(12, 543);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(64, 15);
            this.lblSaturation.TabIndex = 23;
            this.lblSaturation.Text = "Saturation";
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRedValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(115, 146);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(25, 19);
            this.lblRedValue.TabIndex = 19;
            this.lblRedValue.Text = "92";
            // 
            // lblSaturationValue
            // 
            this.lblSaturationValue.AutoSize = true;
            this.lblSaturationValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSaturationValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaturationValue.Location = new System.Drawing.Point(116, 513);
            this.lblSaturationValue.Name = "lblSaturationValue";
            this.lblSaturationValue.Size = new System.Drawing.Size(26, 19);
            this.lblSaturationValue.TabIndex = 22;
            this.lblSaturationValue.Text = "78";
            // 
            // tbHue
            // 
            this.tbHue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbHue.Location = new System.Drawing.Point(8, 452);
            this.tbHue.Maximum = 359;
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(116, 45);
            this.tbHue.SmallChange = 2;
            this.tbHue.TabIndex = 18;
            this.tbHue.TickFrequency = 90;
            this.tbHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHue.Value = 95;
            this.tbHue.ValueChanged += new System.EventHandler(this.tbHUE_ValueChanged);
            this.tbHue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // tbBrightness
            // 
            this.tbBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbBrightness.Location = new System.Drawing.Point(8, 574);
            this.tbBrightness.Maximum = 100;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(116, 45);
            this.tbBrightness.TabIndex = 24;
            this.tbBrightness.TickFrequency = 25;
            this.tbBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBrightness.Value = 43;
            this.tbBrightness.ValueChanged += new System.EventHandler(this.tbBrightness_ValueChanged);
            this.tbBrightness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRed.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblRed.Location = new System.Drawing.Point(12, 168);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(28, 15);
            this.lblRed.TabIndex = 20;
            this.lblRed.Text = "Red";
            // 
            // tbSaturation
            // 
            this.tbSaturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbSaturation.Location = new System.Drawing.Point(8, 513);
            this.tbSaturation.Maximum = 100;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(116, 45);
            this.tbSaturation.TabIndex = 21;
            this.tbSaturation.TickFrequency = 25;
            this.tbSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSaturation.Value = 78;
            this.tbSaturation.ValueChanged += new System.EventHandler(this.tbSaturation_ValueChanged);
            this.tbSaturation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // pnlSpriteMode
            // 
            this.pnlSpriteMode.BackColor = System.Drawing.Color.Black;
            this.pnlSpriteMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpriteMode.Location = new System.Drawing.Point(73, 416);
            this.pnlSpriteMode.Name = "pnlSpriteMode";
            this.pnlSpriteMode.Size = new System.Drawing.Size(13, 13);
            this.pnlSpriteMode.TabIndex = 3;
            this.pnlSpriteMode.Visible = false;
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblGreen.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.lblGreen.Location = new System.Drawing.Point(12, 229);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 15);
            this.lblGreen.TabIndex = 23;
            this.lblGreen.Text = "Green";
            // 
            // cbSpriteMode
            // 
            this.cbSpriteMode.AutoSize = true;
            this.cbSpriteMode.Location = new System.Drawing.Point(92, 415);
            this.cbSpriteMode.Name = "cbSpriteMode";
            this.cbSpriteMode.Size = new System.Drawing.Size(82, 17);
            this.cbSpriteMode.TabIndex = 28;
            this.cbSpriteMode.Text = "Sprite mode";
            this.cbSpriteMode.UseVisualStyleBackColor = true;
            this.cbSpriteMode.CheckedChanged += new System.EventHandler(this.cbSpriteMode_CheckedChanged);
            // 
            // tbRed
            // 
            this.tbRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbRed.Location = new System.Drawing.Point(8, 146);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(116, 45);
            this.tbRed.SmallChange = 2;
            this.tbRed.TabIndex = 18;
            this.tbRed.TickFrequency = 85;
            this.tbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbRed.Value = 92;
            this.tbRed.ValueChanged += new System.EventHandler(this.tbRed_ValueChanged);
            this.tbRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblGreenValue.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(116, 207);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(31, 19);
            this.lblGreenValue.TabIndex = 22;
            this.lblGreenValue.Text = "195";
            // 
            // cbAutoMode
            // 
            this.cbAutoMode.AutoSize = true;
            this.cbAutoMode.Location = new System.Drawing.Point(92, 392);
            this.cbAutoMode.Name = "cbAutoMode";
            this.cbAutoMode.Size = new System.Drawing.Size(77, 17);
            this.cbAutoMode.TabIndex = 27;
            this.cbAutoMode.Text = "Auto mode";
            this.cbAutoMode.UseVisualStyleBackColor = true;
            this.cbAutoMode.CheckedChanged += new System.EventHandler(this.cbAutoMode_CheckedChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbGreen.Location = new System.Drawing.Point(8, 207);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(116, 45);
            this.tbGreen.TabIndex = 21;
            this.tbGreen.TickFrequency = 85;
            this.tbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGreen.Value = 195;
            this.tbGreen.ValueChanged += new System.EventHandler(this.tbGreen_ValueChanged);
            this.tbGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // tbBlue
            // 
            this.tbBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbBlue.Location = new System.Drawing.Point(8, 268);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(116, 45);
            this.tbBlue.TabIndex = 24;
            this.tbBlue.TickFrequency = 85;
            this.tbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBlue.Value = 24;
            this.tbBlue.ValueChanged += new System.EventHandler(this.tbBlue_ValueChanged);
            this.tbBlue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_MouseUp);
            // 
            // pbArrow
            // 
            this.pbArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbArrow.Image = global::ColorSwitch.Properties.Resources.arrow_icon;
            this.pbArrow.Location = new System.Drawing.Point(44, 36);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(24, 24);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArrow.TabIndex = 5;
            this.pbArrow.TabStop = false;
            this.pbArrow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbArrow_MouseClick);
            this.pbArrow.MouseEnter += new System.EventHandler(this.pbArrow_MouseEnter);
            this.pbArrow.MouseLeave += new System.EventHandler(this.pbArrow_MouseLeave);
            // 
            // pbRestart
            // 
            this.pbRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbRestart.Image = global::ColorSwitch.Properties.Resources.restart_icon;
            this.pbRestart.Location = new System.Drawing.Point(8, 397);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(50, 30);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestart.TabIndex = 8;
            this.pbRestart.TabStop = false;
            this.pbRestart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRestart_MouseClick);
            this.pbRestart.MouseEnter += new System.EventHandler(this.pbRestart_MouseEnter);
            this.pbRestart.MouseLeave += new System.EventHandler(this.pbRestart_MouseLeave);
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Image = global::ColorSwitch.Properties.Resources.color_switch;
            this.pbImage.Location = new System.Drawing.Point(175, 24);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(240, 240);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            this.pbImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseClick);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseDown);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseUp);
            // 
            // FrmColorSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(415, 636);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pnlBg);
            this.Controls.Add(this.pbImage);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(196)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(431, 480);
            this.Name = "FrmColorSwitch";
            this.Text = "Color Switch";
            this.SizeChanged += new System.EventHandler(this.FrmColorSwitch_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmColorSwitch_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmColorSwitch_KeyUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZoom)).EndInit();
            this.pnlBg.ResumeLayout(false);
            this.pnlBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlNewColor;
        private System.Windows.Forms.Panel pnlOldColor;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdOldColor;
        private System.Windows.Forms.ColorDialog cdNewColor;
        private System.Windows.Forms.ToolStripMenuItem replaceByPixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setColorToReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNewColorToolStripMenuItem;
        private System.Windows.Forms.TrackBar tbTolerance;
        private System.Windows.Forms.Label lblToleranceValue;
        private System.Windows.Forms.Label lblTolerance;
        private System.Windows.Forms.TrackBar tbZoom;
        private System.Windows.Forms.Label lblZoomValue;
        private RedCell.UI.Controls.PixelBox pbImage;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Panel pnlBg;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Label lblSaturation;
        private System.Windows.Forms.Label lblSaturationValue;
        private System.Windows.Forms.TrackBar tbSaturation;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Label lblHUEValue;
        private System.Windows.Forms.TrackBar tbHue;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblBrightValue;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbSpriteMode;
        private System.Windows.Forms.CheckBox cbAutoMode;
        private System.Windows.Forms.ToolStripMenuItem spriteModeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSpriteMode;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.ToolStripMenuItem hSBModeToolStripMenuItem;
    }
}

