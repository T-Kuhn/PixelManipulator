using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelManipulator
{
    class PixelData
    {
        public bool targetReached;
        public Point startPos;
        public Point goalPos;
        public Point currentPos;
        public Color pixelColor;
        private Random ran;
        
        public PixelData(Point glPs, Point strtPos, Color pxlclr, int seed)
        {
            ran = new Random(seed);
            targetReached = false;
            goalPos = glPs;
            pixelColor = pxlclr;
            // set some startvalues
            startPos = strtPos;
            currentPos = new Point(startPos.X, startPos.Y);
        }

        /// <summary>
        /// Update the animation
        /// </summary>
        public bool Update()
        {
            int ranValX = ran.Next(0, 10);
            int ranValY = ran.Next(0, 10);
            if (currentPos.X == goalPos.X && currentPos.Y == goalPos.Y)
            {
                // if we reached the goalpos
                targetReached = true;
                return true;
            }
            if (goalPos.X - currentPos.X > 0)
            {
                // if the goalpos is more positive then the current pos
                if (ranValX > 3)
                {
                    currentPos.X++;
                }
                else
                {
                    currentPos.X--;
                }
            }
            else if(goalPos.X - currentPos.X < 0)
            {
                // if the goalpos is more negative then the current pos
                if (ranValX > 3)
                {
                    currentPos.X--;
                }
                else
                {
                    currentPos.X++;
                }
            }
            if (goalPos.Y - currentPos.Y > 0)
            {
                // if the goalpos is more positive then the current pos
                if (ranValY > 3)
                {
                    currentPos.Y++;
                }
                else
                {
                    currentPos.Y--;
                }
            }
            else if (goalPos.Y - currentPos.Y < 0)
            {
                // if the goalpos is more negative then the current pos
                if (ranValY > 3)
                {
                    currentPos.Y--;
                }
                else
                {
                    currentPos.Y++;
                }
            }
            return false;
        }

        public void Reset()
        {
            targetReached = false;
            currentPos = new Point(startPos.X, startPos.Y);
        }
    }
}
