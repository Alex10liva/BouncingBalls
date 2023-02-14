using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace collision
{
    public class BallsList
    {
        public List<Ball> Balls;

        public BallsList() 
        {
            Balls = new List<Ball>();
        }

        public void resolveCollision()
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                for (int j = 0; j < Balls.Count; j++)
                {
                    if(i != j)
                    {
                        if (CheckCollision(Balls[i], Balls[j]))
                        {
                            Balls[i].ballVelocity.Width = -Balls[i].ballVelocity.Width;
                            Balls[i].ballVelocity.Height = -Balls[i].ballVelocity.Height;

                            Balls[j].ballVelocity.Width = -Balls[j].ballVelocity.Width;
                            Balls[j].ballVelocity.Height = -Balls[j].ballVelocity.Height;
                            CheckMove();
                        }
                    }
                }
            }
        }
        public bool CheckCollision(Ball a, Ball b)
        {
            float dx = a.ballPosition.X - b.ballPosition.X;
            float dy = a.ballPosition.Y - b.ballPosition.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            return ((distance) < (a.radius + b.radius));
        }

        public void CheckMove()
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                Balls[i].ballPosition.X += Balls[i].ballVelocity.Width;
                Balls[i].ballPosition.Y += Balls[i].ballVelocity.Height;

                if (Balls[i].ballPosition.X <= 0 || Balls[i].ballPosition.X + Balls[i].ballSize >= 804)
                {
                    Balls[i].ballVelocity.Width = -Balls[i].ballVelocity.Width;
                }
                if (Balls[i].ballPosition.Y <= 0 || Balls[i].ballPosition.Y + Balls[i].ballSize >= 452)
                {
                    Balls[i].ballVelocity.Height = -Balls[i].ballVelocity.Height;
                }
            }
        }
    }
}
