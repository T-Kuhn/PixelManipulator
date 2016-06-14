using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelManipulator
{
    class PixelController
    {
        public Bitmap originalBitmap;
        public Bitmap animatedBitmap;
        private int nmbrOfPixels;
        private PixelData[] pixelDataArr;
        private Random ran;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="bmap">The target Bitmap from which the Pixeldata will be extracted. </param>
        public PixelController(Bitmap bmap)
        {
            ran = new Random();
            originalBitmap = bmap;
            animatedBitmap = new Bitmap(originalBitmap);
            ResetAnimatedBitmap();
            ExtractPixelNmbr();
            pixelDataArr = new PixelData[nmbrOfPixels];
            ExtractPixelInformation();
        }

        /// <summary>
        /// Extract the number of Pixels with an alpha value of 1 or more from the Bitmap.
        /// </summary>
        private void ExtractPixelNmbr()
        {
            nmbrOfPixels = 0;
            for (int xx = 0; xx < originalBitmap.Width; xx++)
            {
                for (int yy = 0; yy < originalBitmap.Height; yy++)
                {
                    if (originalBitmap.GetPixel(xx, yy).A > 0)
                        nmbrOfPixels++;
                }
            }
            Debug.WriteLine("number of pixels in Bitmap: " + nmbrOfPixels);
        }

        /// <summary>
        /// Extract all the Color and position information from the Pixels in the Bitmap.
        /// </summary>
        private void ExtractPixelInformation()
        {
            int tmpcntr = 0;
            for (int xx = 0; xx < originalBitmap.Width; xx++)
            {
                for (int yy = 0; yy < originalBitmap.Height; yy++)
                {
                    if (originalBitmap.GetPixel(xx, yy).A > 0) { 
                        pixelDataArr[tmpcntr++] = new PixelData(new Point(xx, yy), new Point(originalBitmap.Width / 2, originalBitmap.Height),  originalBitmap.GetPixel(xx, yy), ran.Next());
                    }
                }
            }
        }

        private void ResetAnimatedBitmap()
        {
            for (int xx = 0; xx < animatedBitmap.Width; xx++)
            {
                for (int yy = 0; yy < animatedBitmap.Height; yy++)
                {
                    Color col = new Color();
                    col = Color.FromArgb(0);
                    animatedBitmap.SetPixel(xx, yy, col);
                }
            }
        }

        public bool Update()
        {
            ResetAnimatedBitmap();
            bool tmpRet = true;
            for(int ii = 0; ii < nmbrOfPixels; ii++)
            {
                if (!pixelDataArr[ii].Update())
                {
                    tmpRet = false;
                }
                // test weather or not the current positions are inside the thing or not
                if(PointInsideBitmapTest(ii))
                    animatedBitmap.SetPixel(pixelDataArr[ii].currentPos.X, pixelDataArr[ii].currentPos.Y, pixelDataArr[ii].pixelColor);
            }
            return tmpRet;
        }

        public void Reset()
        {
            for (int i = 0; i < pixelDataArr.Length; i++)
            {
                pixelDataArr[i].Reset();
            }
            ResetAnimatedBitmap();
        }

        private bool PointInsideBitmapTest(int ii)
        {
            // if either of the current pos vars is minus we are out!
            if(pixelDataArr[ii].currentPos.X < 0 || pixelDataArr[ii].currentPos.Y < 0)
                return false;
            if (pixelDataArr[ii].currentPos.X >= animatedBitmap.Width ||
                pixelDataArr[ii].currentPos.Y >= animatedBitmap.Height)
                return false;
            return true;
        }
    }
}
