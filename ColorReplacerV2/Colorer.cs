using System;
using System.Drawing;
using System.Collections.Generic;

namespace ColorSwitch
{
    public class Colorer
    {
        #region Set/get color values
        //https://stackoverflow.com/questions/3837449/image-hue-modification-in-c-sharp
        /// <summary>
        /// Creates a Color from alpha, hue, saturation and brightness.
        /// </summary>
        /// <param name="alpha">The alpha channel value.</param>
        /// <param name="hue">The hue value.</param>
        /// <param name="saturation">The saturation value.</param>
        /// <param name="brightness">The brightness value.</param>
        /// <returns>A Color with the given values.</returns>
        public static Color FromAhsb(int alpha, float hue, float saturation, float brightness)
        {

            if (0 > alpha || 255 < alpha)
            {
                throw new ArgumentOutOfRangeException("alpha", alpha,
                  "Value must be within a range of 0 - 255.");
            }
            if (0f > hue || 360f < hue)
            {
                throw new ArgumentOutOfRangeException("hue", hue,
                  "Value must be within a range of 0 - 360.");
            }
            if (0f > saturation || 1f < saturation)
            {
                throw new ArgumentOutOfRangeException("saturation", saturation,
                  "Value must be within a range of 0 - 1.");
            }
            if (0f > brightness || 1f < brightness)
            {
                throw new ArgumentOutOfRangeException("brightness", brightness,
                  "Value must be within a range of 0 - 1.");
            }

            if (0 == saturation)
            {
                return Color.FromArgb(alpha, Convert.ToInt32(brightness * 255),
                  Convert.ToInt32(brightness * 255), Convert.ToInt32(brightness * 255));
            }

            float fMax, fMid, fMin;
            int iSextant, iMax, iMid, iMin;

            if (0.5 < brightness)
            {
                fMax = brightness - (brightness * saturation) + saturation;
                fMin = brightness + (brightness * saturation) - saturation;
            }
            else
            {
                fMax = brightness + (brightness * saturation);
                fMin = brightness - (brightness * saturation);
            }

            iSextant = (int)Math.Floor(hue / 60f);
            if (300f <= hue)
            {
                hue -= 360f;
            }
            hue /= 60f;
            hue -= 2f * (float)Math.Floor(((iSextant + 1f) % 6f) / 2f);
            if (0 == iSextant % 2)
            {
                fMid = hue * (fMax - fMin) + fMin;
            }
            else
            {
                fMid = fMin - hue * (fMax - fMin);
            }

            iMax = Convert.ToInt32(fMax * 255);
            iMid = Convert.ToInt32(fMid * 255);
            iMin = Convert.ToInt32(fMin * 255);

            switch (iSextant)
            {
                case 1:
                    return Color.FromArgb(alpha, iMid, iMax, iMin);
                case 2:
                    return Color.FromArgb(alpha, iMin, iMax, iMid);
                case 3:
                    return Color.FromArgb(alpha, iMin, iMid, iMax);
                case 4:
                    return Color.FromArgb(alpha, iMid, iMin, iMax);
                case 5:
                    return Color.FromArgb(alpha, iMax, iMin, iMid);
                default:
                    return Color.FromArgb(alpha, iMax, iMid, iMin);
            }
        }

        /// <summary>
        /// According to the author, it is better than the built-in GetBrightness method.
        /// The built-in GetBrightness method "returns the same value (0.5f) for red, magenta, cyan, blue and yellow (!). This is better:"
        /// </summary>
        /// <param name="c">Color to get the brightness</param>
        /// <returns>Color brightness</returns>
        //https://stackoverflow.com/questions/28759764/c-sharp-sethue-or-alternatively-convert-hsl-to-rgb-and-set-rgb
        public static float GetBrightness(Color c)
        {
            return (c.R * 0.299f + c.G * 0.587f + c.B * 0.114f) / 256f;
        }


        /// <summary>
        /// Add or remove a percentage of a certain value.
        /// </summary>
        /// <param name="pNewValue">The value that should add or remove percentage to the old one</param>
        /// <param name="pOldValue">The value we want to add or remove a percentage</param>
        /// <param name="pMaxValue">The maximum range value of pOldValue and pNewValue</param>
        /// <returns></returns>
        private static float AdjustValue(float pNewValue, float pOldValue, float pMaxValue)
        {
            // y = ax + b  ===exemple===>  0 = 0.5a - 1
            // If we want to adjust a pixel brightness value. The pMaxValue will be 1.
            // If pNewValue = 0.5, then the percentage to adjust will be 0%.
            // So the variation rate, AKA a, is 1/0.5 so 2.

            float a = 1 / (pMaxValue / 2);

            if (pNewValue > pMaxValue / 2)
                return pOldValue + (pMaxValue - pOldValue) * (pNewValue * a - 1);

            return pOldValue + (pOldValue * (pNewValue * a - 1));
        }

        private static int SetValueBetween(int value, int min, int max)
        {
            if (value > max)
                return max;
            else if (value < min)
                return min;
            else return value;
        }
        #endregion

        #region Replace color values
        // If we don't want to edit a part of an image with two colors which look alike because of a replacement,
        // it may be interesting to consider using two images. One to get the color, the other to edit the image.

        // A lot of code parts from replaceColor methodes are not from me.
        // https://www.codeproject.com/articles/42869/color-replacer
        /// <summary>
        /// Replace the color of an image by playing with RGB values.
        /// </summary>
        /// <param name="pImage">Image to edit</param>
        /// <param name="pOldColor">Color to edit</param>
        /// <param name="pNewColor">Color that will replace the old color</param>
        /// <param name="pTolerance">Accepted difference value between the pixel of the image and the color to edit.</param>
        /// <param name="pColorNotToChange">The color we don't want to edit.</param>
        /// <param name="pSoftMode">Less contrast.</param>
        /// <returns>Image with all the required edits</returns>
        public static Image ReplaceColor(Image pImage, Color pOldColor, Color pNewColor, int pTolerance, List<Color> pColorNotToChange, bool pSoftMode)
        {
            // Need to clone so the base image don't change.
            Bitmap bmpImage = (Bitmap)pImage.Clone();

            // minimum and maximum tolerance
            int imgMinR = Math.Max(pOldColor.R - pTolerance, 0);
            int imgMaxR = Math.Min(pOldColor.R + pTolerance, 255);

            int imgMinG = Math.Max(pOldColor.G - pTolerance, 0);
            int imgMaxG = Math.Min(pOldColor.G + pTolerance, 255);

            int imgMinB = Math.Max(pOldColor.B - pTolerance, 0);
            int imgMaxB = Math.Min(pOldColor.B + pTolerance, 255);

            int deltaR = pNewColor.R - pOldColor.R;
            int deltaG = pNewColor.G - pOldColor.G;
            int deltaB = pNewColor.B - pOldColor.B;

            Dictionary<int, Color> lstModifiedColors = new Dictionary<int, Color>();
            lstModifiedColors.Add(pOldColor.ToArgb(), pNewColor);

            for (int x = 0; x < bmpImage.Width; x++)
            {
                for (int y = 0; y < bmpImage.Height; y++)
                {
                    Color c = bmpImage.GetPixel(x, y);

                    bool isOkToChange = true;
                    foreach (Color color in pColorNotToChange)
                    {
                        if (c.ToArgb() == color.ToArgb())
                            isOkToChange = false;
                    }

                    if (c.R >= imgMinR && c.R <= imgMaxR &&
                        c.G >= imgMinG && c.G <= imgMaxG &&
                        c.B >= imgMinB && c.B <= imgMaxB && isOkToChange)
                    {
                        // if tolerance is OK edit the pixel
                        Color finalColor;

                        if (!lstModifiedColors.ContainsKey(c.ToArgb()))
                        {
                            int finalR = SetValueBetween(c.R + deltaR, 0, 255);
                            int finalG = SetValueBetween(c.G + deltaG, 0, 255);
                            int finalB = SetValueBetween(c.B + deltaB, 0, 255);

                            if (!pSoftMode)
                            {
                                int oldDeltaR = c.R - pOldColor.R;
                                int oldDeltaG = c.G - pOldColor.G;
                                int oldDeltaB = c.B - pOldColor.B;

                                finalR = SetValueBetween(finalR + oldDeltaR, 0, 255);
                                finalG = SetValueBetween(finalG + oldDeltaG, 0, 255);
                                finalB = SetValueBetween(finalB + oldDeltaB, 0, 255);
                            }

                            finalColor = Color.FromArgb(c.A, finalR, finalG, finalB);
                            lstModifiedColors.Add(c.ToArgb(), finalColor);
                        }
                        else
                            finalColor = lstModifiedColors[c.ToArgb()];

                        bmpImage.SetPixel(x, y, finalColor);
                    }
                }
            }
            return bmpImage;
        }

        /// <summary>
        /// Replace the color of an image by changing HSB values.
        /// </summary>
        /// <param name="pImage">Image to edit</param>
        /// <param name="pOldColor">Color to edit</param>
        /// <param name="pTolerance">Accepted difference value between the pixel of the image and the color to edit.</param>
        /// <param name="pHue">The hue of the final image</param>
        /// <param name="pSaturation">The saturation of the final image</param>
        /// <param name="pBrightness">The brightness of the final image</param>
        /// <param name="pColorNotToChange">The color we don't want to edit.</param>
        /// <returns>Image with all the required edits</returns>
        public static Image ReplaceColor(Image pImage, Color pOldColor, int pTolerance, float pHue, float pSaturation, float pBrightness, List<Color> pColorNotToChange)
        {
            Bitmap bmpImage = (Bitmap)pImage.Clone();

            // minimum and maximum tolerance
            int imgMinR = Math.Max(pOldColor.R - pTolerance, 0);
            int imgMaxR = Math.Min(pOldColor.R + pTolerance, 255);

            int imgMinG = Math.Max(pOldColor.G - pTolerance, 0);
            int imgMaxG = Math.Min(pOldColor.G + pTolerance, 255);

            int imgMinB = Math.Max(pOldColor.B - pTolerance, 0);
            int imgMaxB = Math.Min(pOldColor.B + pTolerance, 255);

            for (int x = 0; x < bmpImage.Width; x++)
            {
                for (int y = 0; y < bmpImage.Height; y++)
                {
                    Color c = bmpImage.GetPixel(x, y);

                    bool isOkToChange = true;
                    foreach (Color color in pColorNotToChange)
                    {
                        if (c.ToArgb() == color.ToArgb())
                            isOkToChange = false;
                    }

                    if (c.R >= imgMinR && c.R <= imgMaxR &&
                        c.G >= imgMinG && c.G <= imgMaxG &&
                        c.B >= imgMinB && c.B <= imgMaxB && isOkToChange)
                    {
                        // if tolerance is OK and the pixel color is not the same as the color not to change, edit the pixel
                        float oldBri = GetBrightness(c);
                        float oldSat = c.GetSaturation();

                        float finalSat = AdjustValue(pSaturation, oldSat, 1);
                        float finalBright = AdjustValue(pBrightness, oldBri, 1);

                        Color newColor = FromAhsb(c.A, pHue, finalSat, finalBright);
                        bmpImage.SetPixel(x, y, newColor);


                    }
                }
            }

            return bmpImage;
        }
        #endregion
    }
}