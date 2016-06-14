using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelManipulator
{
    static class WorkerThread
    {
        public static PixelController pixelCon1ref;
        public static PictureBox pixelBoxEffectref;
        public static Form Parent;
        public static bool WorkRequested;
        private delegate void UpdatePictureBoxCallback(Bitmap bmap);
        public static void DoWork()
        {
            while (true)
            {
                if (WorkRequested) { 
                    while (!pixelCon1ref.Update())
                    {
                        UpdatePictureBox(pixelCon1ref.animatedBitmap);
                        Debug.WriteLine("Sleep for a while.");
                        Thread.Sleep(2);
                    }
                    WorkRequested = false;
                }
            }
        }
        public static void UpdatePictureBox(Bitmap bmap)
        {
            if (pixelBoxEffectref.InvokeRequired)
            {
                UpdatePictureBoxCallback d = new UpdatePictureBoxCallback(UpdatePictureBox);
                Parent.Invoke(d, new object[] { bmap });
            }
            else
            {
                pixelBoxEffectref.Image = bmap;
            }
        }
    }
}
