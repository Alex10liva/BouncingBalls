using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collision
{

    public class Ball
    {
        public int ballSize;
        public int radius;

        public Size ballVelocity;
        public int velocityRandom;

        public Point ballPosition;
        public int positionRandomX;
        public int positionRandomY;

        public Ball()
        {
            Random random = new Random();
            ballSize = random.Next(20, 50);
            radius = ballSize / 2;
            velocityRandom = random.Next(3, 10);
            positionRandomX = random.Next(1, 790);
            positionRandomY = random.Next(1, 440);

            // Initialize the ball's position and velocity
            ballPosition = new Point(positionRandomX, positionRandomY);
            ballVelocity = new Size(velocityRandom, velocityRandom);
        }

        public void CheckMove()
        {
            ballPosition.X += ballVelocity.Width;
            ballPosition.Y += ballVelocity.Height;

            if (ballPosition.X <= 0 || ballPosition.X + ballSize >= 800)
            {
                ballVelocity.Width = -ballVelocity.Width;
            }
            if (ballPosition.Y <= 0 || ballPosition.Y + ballSize >= 450)
            {
                ballVelocity.Height = -ballVelocity.Height;
            }
        }
    }
}
