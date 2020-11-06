namespace AirHockey_V1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCenterLine = new System.Windows.Forms.Panel();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnBall = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlCenterLine
            // 
            this.pnlCenterLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCenterLine.Location = new System.Drawing.Point(699, 2);
            this.pnlCenterLine.Name = "pnlCenterLine";
            this.pnlCenterLine.Size = new System.Drawing.Size(22, 723);
            this.pnlCenterLine.TabIndex = 2;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1.Location = new System.Drawing.Point(226, 232);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(92, 248);
            this.btnPlayer1.TabIndex = 3;
            this.btnPlayer1.Text = "Player1";
            this.btnPlayer1.UseVisualStyleBackColor = false;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2.Location = new System.Drawing.Point(1235, 232);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(99, 248);
            this.btnPlayer2.TabIndex = 4;
            this.btnPlayer2.Text = "Player 2";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            // 
            // btnBall
            // 
            this.btnBall.BackColor = System.Drawing.Color.Yellow;
            this.btnBall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBall.Location = new System.Drawing.Point(431, 315);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(33, 34);
            this.btnBall.TabIndex = 5;
            this.btnBall.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1420, 723);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.pnlCenterLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCenterLine;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Timer timer1;
    }
}

