namespace Pong
{
    partial class frmJogo
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblBounceStreak = new System.Windows.Forms.Label();
            this.lblClickToPlay = new System.Windows.Forms.Label();
            this.lblMatchPoint = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.lblPause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.GameTick);
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.BackColor = System.Drawing.Color.Black;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Score.Location = new System.Drawing.Point(200, 12);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(25, 25);
            this.lblPlayer1Score.TabIndex = 0;
            this.lblPlayer1Score.Text = "0";
            this.lblPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.BackColor = System.Drawing.Color.Black;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Score.Location = new System.Drawing.Point(564, 12);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(25, 25);
            this.lblPlayer2Score.TabIndex = 3;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBounceStreak
            // 
            this.lblBounceStreak.AutoSize = true;
            this.lblBounceStreak.BackColor = System.Drawing.Color.Black;
            this.lblBounceStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBounceStreak.ForeColor = System.Drawing.Color.White;
            this.lblBounceStreak.Location = new System.Drawing.Point(352, 9);
            this.lblBounceStreak.Name = "lblBounceStreak";
            this.lblBounceStreak.Size = new System.Drawing.Size(99, 13);
            this.lblBounceStreak.TabIndex = 4;
            this.lblBounceStreak.Text = "Bounce Streak: ";
            this.lblBounceStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClickToPlay
            // 
            this.lblClickToPlay.AutoSize = true;
            this.lblClickToPlay.BackColor = System.Drawing.Color.Black;
            this.lblClickToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToPlay.ForeColor = System.Drawing.Color.White;
            this.lblClickToPlay.Location = new System.Drawing.Point(298, 281);
            this.lblClickToPlay.Name = "lblClickToPlay";
            this.lblClickToPlay.Size = new System.Drawing.Size(315, 39);
            this.lblClickToPlay.TabIndex = 5;
            this.lblClickToPlay.Text = "Clica ou pressiona o \'Espaço\' para começares a jogar!\r\n\r\n ";
            this.lblClickToPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatchPoint
            // 
            this.lblMatchPoint.AutoSize = true;
            this.lblMatchPoint.BackColor = System.Drawing.Color.Black;
            this.lblMatchPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchPoint.ForeColor = System.Drawing.Color.White;
            this.lblMatchPoint.Location = new System.Drawing.Point(363, 352);
            this.lblMatchPoint.Name = "lblMatchPoint";
            this.lblMatchPoint.Size = new System.Drawing.Size(88, 16);
            this.lblMatchPoint.TabIndex = 6;
            this.lblMatchPoint.Text = "Match Point";
            this.lblMatchPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMatchPoint.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.ErrorImage = null;
            this.ball.Location = new System.Drawing.Point(393, 204);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(823, 162);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(17, 100);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(12, 162);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(17, 100);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Black;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(352, 217);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(109, 16);
            this.lblPause.TabIndex = 7;
            this.lblPause.Text = "Jogo Pausado";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPause.Visible = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.lblMatchPoint);
            this.Controls.Add(this.lblClickToPlay);
            this.Controls.Add(this.lblBounceStreak);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmJogo";
            this.Text = "Pong!";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.SizeChanged += new System.EventHandler(this.frmJogo_SizeChanged);
            this.Click += new System.EventHandler(this.frmJogo_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJogo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmJogo_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmJogo_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblBounceStreak;
        private System.Windows.Forms.Label lblClickToPlay;
        private System.Windows.Forms.Label lblMatchPoint;
        private System.Windows.Forms.Label lblPause;
    }
}