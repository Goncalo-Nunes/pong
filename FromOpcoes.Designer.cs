namespace Pong
{
    partial class frmOpcoes
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
            this.lblPlayer1Color = new System.Windows.Forms.Label();
            this.lblPlayer2Color = new System.Windows.Forms.Label();
            this.rd1Player = new System.Windows.Forms.RadioButton();
            this.rd2Player = new System.Windows.Forms.RadioButton();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblBallColor = new System.Windows.Forms.Label();
            this.lblBounceStreak = new System.Windows.Forms.Label();
            this.numUpDownBounceStreak = new System.Windows.Forms.NumericUpDown();
            this.lblWinScore = new System.Windows.Forms.Label();
            this.numUpDownWinScore = new System.Windows.Forms.NumericUpDown();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.chkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.btnPlayer1Color = new System.Windows.Forms.Button();
            this.btnPlayer2Color = new System.Windows.Forms.Button();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.chkBoxSounds = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBounceStreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWinScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1Color
            // 
            this.lblPlayer1Color.AutoSize = true;
            this.lblPlayer1Color.Location = new System.Drawing.Point(68, 110);
            this.lblPlayer1Color.Name = "lblPlayer1Color";
            this.lblPlayer1Color.Size = new System.Drawing.Size(61, 13);
            this.lblPlayer1Color.TabIndex = 1;
            this.lblPlayer1Color.Text = "Cor Player1";
            // 
            // lblPlayer2Color
            // 
            this.lblPlayer2Color.AutoSize = true;
            this.lblPlayer2Color.Location = new System.Drawing.Point(215, 110);
            this.lblPlayer2Color.Name = "lblPlayer2Color";
            this.lblPlayer2Color.Size = new System.Drawing.Size(61, 13);
            this.lblPlayer2Color.TabIndex = 2;
            this.lblPlayer2Color.Text = "Cor Player2";
            // 
            // rd1Player
            // 
            this.rd1Player.AutoSize = true;
            this.rd1Player.Checked = true;
            this.rd1Player.Location = new System.Drawing.Point(65, 382);
            this.rd1Player.Name = "rd1Player";
            this.rd1Player.Size = new System.Drawing.Size(72, 17);
            this.rd1Player.TabIndex = 8;
            this.rd1Player.TabStop = true;
            this.rd1Player.Text = "1 Jogador";
            this.rd1Player.UseVisualStyleBackColor = true;
            this.rd1Player.CheckedChanged += new System.EventHandler(this.Rd1Player_CheckedChanged);
            // 
            // rd2Player
            // 
            this.rd2Player.AutoSize = true;
            this.rd2Player.Location = new System.Drawing.Point(65, 405);
            this.rd2Player.Name = "rd2Player";
            this.rd2Player.Size = new System.Drawing.Size(83, 17);
            this.rd2Player.TabIndex = 9;
            this.rd2Player.Text = "2 Jogadores";
            this.rd2Player.UseVisualStyleBackColor = true;
            this.rd2Player.CheckedChanged += new System.EventHandler(this.Rd2Player_CheckedChanged);
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(65, 39);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(67, 20);
            this.txtPlayer1Name.TabIndex = 0;
            this.txtPlayer1Name.Text = "Player1";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Enabled = false;
            this.txtPlayer2Name.Location = new System.Drawing.Point(215, 39);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(64, 20);
            this.txtPlayer2Name.TabIndex = 1;
            this.txtPlayer2Name.Text = "Player2";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(62, 23);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(73, 13);
            this.lblPlayer1Name.TabIndex = 8;
            this.lblPlayer1Name.Text = "Nome Player1";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(212, 23);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(73, 13);
            this.lblPlayer2Name.TabIndex = 9;
            this.lblPlayer2Name.Text = "Nome Player2";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(42, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Ca&ncelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(192, 464);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 30);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "&Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblBallColor
            // 
            this.lblBallColor.AutoSize = true;
            this.lblBallColor.Location = new System.Drawing.Point(68, 195);
            this.lblBallColor.Name = "lblBallColor";
            this.lblBallColor.Size = new System.Drawing.Size(47, 13);
            this.lblBallColor.TabIndex = 12;
            this.lblBallColor.Text = "Cor Bola";
            // 
            // lblBounceStreak
            // 
            this.lblBounceStreak.AutoSize = true;
            this.lblBounceStreak.Location = new System.Drawing.Point(59, 287);
            this.lblBounceStreak.Name = "lblBounceStreak";
            this.lblBounceStreak.Size = new System.Drawing.Size(78, 13);
            this.lblBounceStreak.TabIndex = 14;
            this.lblBounceStreak.Text = "Bounce Streak";
            // 
            // numUpDownBounceStreak
            // 
            this.numUpDownBounceStreak.Location = new System.Drawing.Point(68, 306);
            this.numUpDownBounceStreak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBounceStreak.Name = "numUpDownBounceStreak";
            this.numUpDownBounceStreak.Size = new System.Drawing.Size(57, 20);
            this.numUpDownBounceStreak.TabIndex = 6;
            this.numUpDownBounceStreak.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblWinScore
            // 
            this.lblWinScore.AutoSize = true;
            this.lblWinScore.Location = new System.Drawing.Point(201, 287);
            this.lblWinScore.Name = "lblWinScore";
            this.lblWinScore.Size = new System.Drawing.Size(86, 13);
            this.lblWinScore.TabIndex = 16;
            this.lblWinScore.Text = "Score vencedor:";
            // 
            // numUpDownWinScore
            // 
            this.numUpDownWinScore.Location = new System.Drawing.Point(214, 306);
            this.numUpDownWinScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownWinScore.Name = "numUpDownWinScore";
            this.numUpDownWinScore.Size = new System.Drawing.Size(57, 20);
            this.numUpDownWinScore.TabIndex = 7;
            this.numUpDownWinScore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(212, 195);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(63, 13);
            this.lblDifficulty.TabIndex = 18;
            this.lblDifficulty.Text = "Dificuldade:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Difícil"});
            this.cmbDifficulty.Location = new System.Drawing.Point(214, 211);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(61, 21);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // chkBoxFullScreen
            // 
            this.chkBoxFullScreen.AutoSize = true;
            this.chkBoxFullScreen.Location = new System.Drawing.Point(215, 383);
            this.chkBoxFullScreen.Name = "chkBoxFullScreen";
            this.chkBoxFullScreen.Size = new System.Drawing.Size(80, 17);
            this.chkBoxFullScreen.TabIndex = 10;
            this.chkBoxFullScreen.Text = "Ecrâ Inteiro";
            this.chkBoxFullScreen.UseVisualStyleBackColor = true;
            // 
            // btnPlayer1Color
            // 
            this.btnPlayer1Color.Location = new System.Drawing.Point(66, 130);
            this.btnPlayer1Color.Name = "btnPlayer1Color";
            this.btnPlayer1Color.Size = new System.Drawing.Size(58, 19);
            this.btnPlayer1Color.TabIndex = 2;
            this.btnPlayer1Color.Text = "Cor...";
            this.btnPlayer1Color.UseVisualStyleBackColor = true;
            this.btnPlayer1Color.Click += new System.EventHandler(this.btnPlayer1Color_Click);
            // 
            // btnPlayer2Color
            // 
            this.btnPlayer2Color.Location = new System.Drawing.Point(215, 130);
            this.btnPlayer2Color.Name = "btnPlayer2Color";
            this.btnPlayer2Color.Size = new System.Drawing.Size(58, 19);
            this.btnPlayer2Color.TabIndex = 3;
            this.btnPlayer2Color.Text = "Cor...";
            this.btnPlayer2Color.UseVisualStyleBackColor = true;
            this.btnPlayer2Color.Click += new System.EventHandler(this.btnPlayer2Color_Click);
            // 
            // btnBallColor
            // 
            this.btnBallColor.Location = new System.Drawing.Point(65, 213);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(58, 19);
            this.btnBallColor.TabIndex = 4;
            this.btnBallColor.Text = "Cor...";
            this.btnBallColor.UseVisualStyleBackColor = true;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // chkBoxSounds
            // 
            this.chkBoxSounds.AutoSize = true;
            this.chkBoxSounds.Checked = true;
            this.chkBoxSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxSounds.Location = new System.Drawing.Point(215, 406);
            this.chkBoxSounds.Name = "chkBoxSounds";
            this.chkBoxSounds.Size = new System.Drawing.Size(50, 17);
            this.chkBoxSounds.TabIndex = 11;
            this.chkBoxSounds.Text = "Sons";
            this.chkBoxSounds.UseVisualStyleBackColor = true;
            // 
            // frmOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 506);
            this.Controls.Add(this.chkBoxSounds);
            this.Controls.Add(this.btnBallColor);
            this.Controls.Add(this.btnPlayer2Color);
            this.Controls.Add(this.btnPlayer1Color);
            this.Controls.Add(this.chkBoxFullScreen);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.numUpDownWinScore);
            this.Controls.Add(this.lblWinScore);
            this.Controls.Add(this.numUpDownBounceStreak);
            this.Controls.Add(this.lblBounceStreak);
            this.Controls.Add(this.lblBallColor);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.rd2Player);
            this.Controls.Add(this.rd1Player);
            this.Controls.Add(this.lblPlayer2Color);
            this.Controls.Add(this.lblPlayer1Color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOpcoes";
            this.Text = "Opções de Jogo";
            this.Load += new System.EventHandler(this.frmOpcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBounceStreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWinScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayer1Color;
        private System.Windows.Forms.Label lblPlayer2Color;
        private System.Windows.Forms.RadioButton rd1Player;
        private System.Windows.Forms.RadioButton rd2Player;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblBallColor;
        private System.Windows.Forms.Label lblBounceStreak;
        private System.Windows.Forms.NumericUpDown numUpDownBounceStreak;
        private System.Windows.Forms.Label lblWinScore;
        private System.Windows.Forms.NumericUpDown numUpDownWinScore;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.CheckBox chkBoxFullScreen;
        private System.Windows.Forms.Button btnPlayer1Color;
        private System.Windows.Forms.Button btnPlayer2Color;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.CheckBox chkBoxSounds;
    }
}