using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey_V1.Models
{
    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Button Shape { get; set; }
        public Point Location { get; set; }
        public int Speed { get; set; }
        public Size Borders { get; set; }

        public Player(string name, Button btn, Size borders)
        {
            this.Name = name;
            Score = 0;
            Shape = btn;
            Speed = 15;
            Location = btn.Location;
            Borders = borders;
        }

        public void Move(Moves move)
        {
            switch(move)
            {
                case Moves.UP:
                    int y = Shape.Location.Y - Speed > 0 ? Shape.Location.Y - Speed : Shape.Location.Y;
                    Shape.Location = new Point(Shape.Location.X, y);
                    break;
                case Moves.DOWN:
                    int y2 = Shape.Location.Y + Speed < (this.Borders.Height - Shape.Height - 40) ? Shape.Location.Y + Speed : Shape.Location.Y;
                    Shape.Location = new Point(Shape.Location.X, y2);
                    break;
                case Moves.LEFT:
                    int x2 = Shape.Location.X - Speed > 0 ? Shape.Location.X - Speed : Shape.Location.X;
                    Shape.Location = new Point(x2, Shape.Location.Y);
                    break;
                case Moves.RIGHT:
                    int x = (Shape.Location.X + Speed + Shape.Width) < Borders.Width / 2 ? Shape.Location.X + Speed : Shape.Location.X;
                    Shape.Location = new Point(x, Shape.Location.Y);
                    break;
            }
        }
    }
}
