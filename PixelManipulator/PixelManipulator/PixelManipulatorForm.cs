using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelManipulator
{
    public partial class PixelManipulatorForm : Form
    {
        private PixelController pixelCon1;
        public Thread workerThread;
        public PixelManipulatorForm()
        {
            InitializeComponent();
            Bitmap img = new Bitmap("C://git/PixelManipulator/PixelManipulator/64x64pic.png");
            pixelCon1 = new PixelController(img);
            WorkerThread.pixelCon1ref = pixelCon1;
            WorkerThread.pixelBoxEffectref = pictureBoxEffect;
            WorkerThread.Parent = this;
            workerThread = new Thread(WorkerThread.DoWork);
            workerThread.Start();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            WorkerThread.WorkRequested = true;
            Debug.WriteLine("Someone pressed the Start Button");
        }

        private void loadPicButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Someone pressed the Load Pic Button");
            pictureBoxLoadedPic.Image = pixelCon1.originalBitmap;
        }

        private void PixelManipulatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            workerThread.Abort();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pixelCon1.Reset();
            pictureBoxEffect.Image = pixelCon1.animatedBitmap;
        }
    }
}
