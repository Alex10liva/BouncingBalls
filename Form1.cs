using System;
using System.Runtime.CompilerServices;

namespace collision
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Ball ball1, ball2, ball3, ball4, ball5;

        public Form1()
        {
            InitializeComponent();

            ball1 = new Ball();
            ball2 = new Ball();
            ball3 = new Ball();
            ball4 = new Ball();
            ball5 = new Ball();

            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Ball 1
            if (CheckCollision(ball1, ball2))
            {
                ball1.ballVelocity.Width = -ball1.ballVelocity.Width;
                ball1.ballVelocity.Height = -ball1.ballVelocity.Height;

                ball2.ballVelocity.Width = -ball2.ballVelocity.Width;
                ball2.ballVelocity.Height = -ball2.ballVelocity.Height;
            }
            if (CheckCollision(ball1, ball3))
            {
                ball1.ballVelocity.Width = -ball1.ballVelocity.Width;
                ball1.ballVelocity.Height = -ball1.ballVelocity.Height;

                ball3.ballVelocity.Width = -ball3.ballVelocity.Width;
                ball3.ballVelocity.Height = -ball3.ballVelocity.Height;
            }
            if (CheckCollision(ball1, ball4))
            {
                ball1.ballVelocity.Width = -ball1.ballVelocity.Width;
                ball1.ballVelocity.Height = -ball1.ballVelocity.Height;

                ball4.ballVelocity.Width = -ball4.ballVelocity.Width;
                ball4.ballVelocity.Height = -ball4.ballVelocity.Height;
            }
            if (CheckCollision(ball1, ball5))
            {
                ball1.ballVelocity.Width = -ball1.ballVelocity.Width;
                ball1.ballVelocity.Height = -ball1.ballVelocity.Height;

                ball5.ballVelocity.Width = -ball5.ballVelocity.Width;
                ball5.ballVelocity.Height = -ball5.ballVelocity.Height;
            }

            //Ball 2
            if (CheckCollision(ball2, ball3))
            {
                ball2.ballVelocity.Width = -ball2.ballVelocity.Width;
                ball2.ballVelocity.Height = -ball2.ballVelocity.Height;

                ball3.ballVelocity.Width = -ball3.ballVelocity.Width;
                ball3.ballVelocity.Height = -ball3.ballVelocity.Height;
            }
            if (CheckCollision(ball2, ball4))
            {
                ball2.ballVelocity.Width = -ball2.ballVelocity.Width;
                ball2.ballVelocity.Height = -ball2.ballVelocity.Height;

                ball4.ballVelocity.Width = -ball4.ballVelocity.Width;
                ball4.ballVelocity.Height = -ball4.ballVelocity.Height;
            }
            if (CheckCollision(ball2, ball5))
            {
                ball2.ballVelocity.Width = -ball2.ballVelocity.Width;
                ball2.ballVelocity.Height = -ball2.ballVelocity.Height;

                ball5.ballVelocity.Width = -ball5.ballVelocity.Width;
                ball5.ballVelocity.Height = -ball5.ballVelocity.Height;
            }

            //Ball 3
            if (CheckCollision(ball3, ball4))
            {
                ball3.ballVelocity.Width = -ball3.ballVelocity.Width;
                ball3.ballVelocity.Height = -ball3.ballVelocity.Height;

                ball4.ballVelocity.Width = -ball4.ballVelocity.Width;
                ball4.ballVelocity.Height = -ball4.ballVelocity.Height;
            }
            if (CheckCollision(ball3, ball5))
            {
                ball3.ballVelocity.Width = -ball3.ballVelocity.Width;
                ball3.ballVelocity.Height = -ball3.ballVelocity.Height;

                ball5.ballVelocity.Width = -ball5.ballVelocity.Width;
                ball5.ballVelocity.Height = -ball5.ballVelocity.Height;
            }

            //Ball 4
            if (CheckCollision(ball4, ball5))
            {
                ball4.ballVelocity.Width = -ball4.ballVelocity.Width;
                ball4.ballVelocity.Height = -ball4.ballVelocity.Height;

                ball5.ballVelocity.Width = -ball5.ballVelocity.Width;
                ball5.ballVelocity.Height = -ball5.ballVelocity.Height;
            }

            ball1.CheckMove();
            ball2.CheckMove();
            ball3.CheckMove();
            ball4.CheckMove();
            ball5.CheckMove();

            Paint();
        }

        private bool CheckCollision(Ball a, Ball b)
        {
            float dx = a.ballPosition.X - b.ballPosition.X;
            float dy = a.ballPosition.Y - b.ballPosition.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            return (distance) < (a.radius + b.radius);
        }

        private void Paint()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            // Draw the ball at its current position
            g.FillEllipse(Brushes.Red, ball1.ballPosition.X, ball1.ballPosition.Y, ball1.ballSize, ball1.ballSize);
            g.FillEllipse(Brushes.Blue, ball2.ballPosition.X, ball2.ballPosition.Y, ball2.ballSize, ball2.ballSize);
            g.FillEllipse(Brushes.Yellow, ball3.ballPosition.X, ball3.ballPosition.Y, ball3.ballSize, ball3.ballSize);
            g.FillEllipse(Brushes.Orange, ball4.ballPosition.X, ball4.ballPosition.Y, ball4.ballSize, ball4.ballSize);
            g.FillEllipse(Brushes.Pink, ball5.ballPosition.X, ball5.ballPosition.Y, ball5.ballSize, ball5.ballSize);
        }
    }
}