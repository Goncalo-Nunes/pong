namespace Pong
{
    partial class frmPrincipal
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
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnHistoricoJogos = new System.Windows.Forms.Button();
            this.lblPong = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.BorderSize = 0;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnJogar.ForeColor = System.Drawing.Color.Black;
            this.btnJogar.Location = new System.Drawing.Point(0, 59);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(178, 82);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(0, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(178, 82);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnInfo.Location = new System.Drawing.Point(0, 323);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(178, 82);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "&Informações";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcoes.FlatAppearance.BorderSize = 0;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpcoes.Location = new System.Drawing.Point(0, 147);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(178, 82);
            this.btnOpcoes.TabIndex = 1;
            this.btnOpcoes.Text = "&Opções de Jogo";
            this.btnOpcoes.UseVisualStyleBackColor = false;
            this.btnOpcoes.Click += new System.EventHandler(this.BtnOpcoes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnMute);
            this.panel1.Controls.Add(this.btnHistoricoJogos);
            this.panel1.Controls.Add(this.btnJogar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnOpcoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 552);
            this.panel1.TabIndex = 4;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMute.FlatAppearance.BorderSize = 0;
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.Image = global::Pong.Properties.Resources.volume1;
            this.btnMute.Location = new System.Drawing.Point(0, 516);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(38, 36);
            this.btnMute.TabIndex = 11;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnHistoricoJogos
            // 
            this.btnHistoricoJogos.FlatAppearance.BorderSize = 0;
            this.btnHistoricoJogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoricoJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnHistoricoJogos.Location = new System.Drawing.Point(0, 235);
            this.btnHistoricoJogos.Name = "btnHistoricoJogos";
            this.btnHistoricoJogos.Size = new System.Drawing.Size(178, 82);
            this.btnHistoricoJogos.TabIndex = 2;
            this.btnHistoricoJogos.Text = "&Histórico de Jogos";
            this.btnHistoricoJogos.UseVisualStyleBackColor = true;
            this.btnHistoricoJogos.Click += new System.EventHandler(this.btnHistoricoJogos_Click);
            // 
            // lblPong
            // 
            this.lblPong.AutoSize = true;
            this.lblPong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblPong.ForeColor = System.Drawing.Color.White;
            this.lblPong.Location = new System.Drawing.Point(414, 26);
            this.lblPong.Name = "lblPong";
            this.lblPong.Size = new System.Drawing.Size(131, 39);
            this.lblPong.TabIndex = 9;
            this.lblPong.Text = "PONG!";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.ErrorImage = null;
            this.ball.Location = new System.Drawing.Point(472, 275);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 7;
            this.ball.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(194, 226);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(17, 100);
            this.player1.TabIndex = 8;
            this.player1.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(747, 226);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(17, 100);
            this.player2.TabIndex = 6;
            this.player2.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(776, 552);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.lblPong);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label lblPong;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnHistoricoJogos;
        private System.Windows.Forms.Button btnMute;
    }
}

