using System;
using System.Runtime.CompilerServices;

namespace collision
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Ball ball1, ball2, ball3, ball4, ball5;
        BallsList ballList1;

        public Form1()
        {
            InitializeComponent();

            ball1 = new Ball();
            ball2 = new Ball();
            ball3 = new Ball();
            ball4 = new Ball();
            ball5 = new Ball();

            ballList1 = new BallsList();
            ballList1.Balls.Add(ball1);
            ballList1.Balls.Add(ball2);
            ballList1.Balls.Add(ball3);
            ballList1.Balls.Add(ball4);
            ballList1.Balls.Add(ball5);

            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            ballList1.resolveCollision();

            ballList1.CheckMove();

            Paint();
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