using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey_V1.Models
{
    class Ball
    {
        public Point Location { get; set; }
        public Button Shape { get; set; }
        public int Speed { get; set; }
        public int Direction { get; set; }
        public bool IsMoving { get; set; }

        public Ball(Button button)
        {
            Shape = button;
            Speed = 15;
            Location = button.Location;
            Direction = 1;
            IsMoving = false;
        }

        public void OnCollision(Player player)
        {
            int startYPoint = player.Shape.Location.Y;
            int endYPoint = player.Shape.Location.Y + player.Shape.Height;

            int XPoint = player.Shape.Location.X + player.Shape.Width;

            if (((Shape.Location.Y >= startYPoint && Shape.Location.Y <= endYPoint) || (Shape.Location.Y + Shape.Height >= startYPoint && Shape.Location.Y + Shape.Height <= endYPoint)) && (Shape.Location.X >= player.Shape.Location.X && Shape.Location.X <= XPoint))
            {
                Direction = Math.Abs(Direction);
                Shape.Location = new Point(Shape.Location.X + Speed * Direction, Shape.Location.Y);
                IsMoving = true;
            }
            else if(
                    ((Shape.Location.Y >= startYPoint && Shape.Location.Y <= endYPoint) || (Shape.Location.Y + Shape.Height >= startYPoint && Shape.Location.Y + Shape.Height <= endYPoint)) && (Shape.Location.X + Shape.Width >= player.Shape.Location.X && Shape.Location.X + Shape.Width <= XPoint)
                )
            {
                Direction *= -1;
                IsMoving = true;
            }
        }

        public void Move(int Direction)
        {
            if(IsMoving)
            {
                Shape.Location = new Point(Shape.Location.X + Speed * Direction, Shape.Location.Y);
            }
        }
    }
}
