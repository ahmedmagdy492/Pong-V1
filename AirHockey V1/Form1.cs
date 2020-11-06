using AirHockey_V1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey_V1
{
    public partial class Form1 : Form
    {
        private List<Player> players;
        private Ball ball;
        private string score;
        private string playerName;
        public Form1(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
            Init();
        }

        private void Init()
        {
            players = new List<Player>();
            btnPlayer1.Text = this.playerName;
            btnPlayer2.Text = "Computer";
            players.Add(new Player(this.playerName, btnPlayer1, this.Size));
            players.Add(new Player("Computer", btnPlayer2, this.Size));
            ball = new Ball(btnBall);
            timer1.Enabled = true;
            score = $"{players[0].Name} Score : {players[0].Score}, {players[1].Name} Score : {players[1].Score}";
            this.Text = score;
        }

        private void Logic()
        {
            ball.OnCollision(players[0]);
            ball.OnCollision(players[1]);

            ball.Move(ball.Direction);
            if(ball.Shape.Location.X >= this.Width)
            {
                score = $"{players[0].Name} Score : {++players[0].Score}, {players[1].Name} Score : {players[1].Score}";
                this.Text = score;
                ball.IsMoving = false;
                ball.Shape.Location = new Point(431, 315);
                ball.Location = ball.Shape.Location;
            }
            else if(ball.Shape.Location.X <= 0)
            {
                score = $"{players[0].Name} Score : {players[0].Score}, {players[1].Name} Score : {++players[1].Score}";
                this.Text = score;
                ball.IsMoving = false;
                ball.Shape.Location = new Point(431, 315);
                ball.Location = ball.Shape.Location;
            }
        }

        private void Input(Keys keyData)
        {
            if (keyData == Keys.W)
            {
                players[0].Move(Moves.UP);
            }
            else if (keyData == Keys.S)
            {
                players[0].Move(Moves.DOWN);
            }
            else if (keyData == Keys.D)
            {
                players[0].Move(Moves.RIGHT);
            }
            else if (keyData == Keys.A)
            {
                players[0].Move(Moves.LEFT);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Input(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Logic();
        }

        ~Form1()
        {
            timer1.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
