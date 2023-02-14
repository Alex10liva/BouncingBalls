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
            positionRandomX = random.Next(ballSize + 5, 800 - ballSize);
            positionRandomY = random.Next(ballSize + 5, 450 - ballSize);

            // Initialize the ball's position and velocity
            ballPosition = new Point(positionRandomX, positionRandomY);
            ballVelocity = new Size(velocityRandom, velocityRandom);
        }
    }
}
