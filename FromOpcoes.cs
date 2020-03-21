using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmOpcoes : Form
    {

        public frmOpcoes()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // Nomes dos jogadores

            if (txtPlayer1Name.Text == txtPlayer2Name.Text) //Verificar se os nomes dos jogadores são iguais
            {
                MessageBox.Show("Os jogadores não podem ter o mesmo nome!", "Erro");
                return;
            }

            if (txtPlayer1Name.Text != "") //Verificar se o nome do player1 está inserido
            {
                Variaveis.player1Name = txtPlayer1Name.Text;
            } else
            {
                MessageBox.Show("Insere o nome do Player1!", "Erro");
                return;
            }

            if (txtPlayer2Name.Text != "") //Verificar se o nome do player2 está inserido
            {
                Variaveis.player2Name = txtPlayer2Name.Text;
            } else
            {
                MessageBox.Show("Insere o nome do Player2!", "Erro");
                return;
            }


            //BounceSteakLimit e WinScore
            Variaveis.bounceStreakLimit = Convert.ToInt16(numUpDownBounceStreak.Value);
            Variaveis.winScore = Convert.ToInt16(numUpDownWinScore.Value);


            //Single ou Multiplayer
            if (rd1Player.Checked)
            {
                Variaveis.singlePlayer = true;
            } 
            else if (rd2Player.Checked)
            {
                Variaveis.singlePlayer = false;
            }

            


            //Dificuldade
            if (cmbDifficulty.SelectedIndex >= 0)
            {
                Variaveis.Difficulty = cmbDifficulty.SelectedIndex;
            } else
            {
                Variaveis.Difficulty = 0;
            }


            try
            {
                Variaveis.DifficultyString = cmbDifficulty.SelectedItem.ToString();
            } 
            catch
            {
                Variaveis.DifficultyString = "Fácil";
            }



            //Ecrã Inteiro
            if (chkBoxFullScreen.Checked)
            {
                Variaveis.fullScreen = true;
            } else
            {
                Variaveis.fullScreen = false;
            }


            //Sons
            if (chkBoxSounds.Checked)
            {
                Variaveis.sounds = true;
            } else
            {
                Variaveis.sounds = false;
            }
            


            this.Close();
        }

        private void Rd2Player_CheckedChanged(object sender, EventArgs e)
        {
            cmbDifficulty.SelectedIndex = -1;
            cmbDifficulty.Enabled = false;
            txtPlayer2Name.Text = Variaveis.player2Name;
            txtPlayer2Name.Enabled = true;
        }

        private void Rd1Player_CheckedChanged(object sender, EventArgs e)
        {
            cmbDifficulty.SelectedIndex = 0;
            cmbDifficulty.Enabled = true;
            txtPlayer2Name.Text = "CPU";
            txtPlayer2Name.Enabled = false;
        }

        private void frmOpcoes_Load(object sender, EventArgs e)
        {


            txtPlayer1Name.Text = Variaveis.player1Name;
            txtPlayer2Name.Text = Variaveis.player2Name;

            if (rd1Player.Checked)
            {
                txtPlayer2Name.Text = "CPU";
            }

            cmbDifficulty.SelectedIndex = 0;
        }

        private void btnPlayer1Color_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialogPlayer1 = new ColorDialog();
            ColorDialogPlayer1.Color = Color.White;
            ColorDialogPlayer1.FullOpen = true;
            ColorDialogPlayer1.ShowDialog();
            btnPlayer1Color.BackColor = ColorDialogPlayer1.Color;

            if (ColorDialogPlayer1.Color != Color.Black) //Não permitir o utilizador selecionar a cor preta
            Variaveis.player1Color = ColorDialogPlayer1.Color;
        }

        private void btnPlayer2Color_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialogPlayer2 = new ColorDialog();
            ColorDialogPlayer2.Color = Color.White;
            ColorDialogPlayer2.FullOpen = true;
            ColorDialogPlayer2.ShowDialog();
            btnPlayer2Color.BackColor = ColorDialogPlayer2.Color;

            if (ColorDialogPlayer2.Color != Color.Black) //Não permitir o utilizador selecionar a cor preta
                Variaveis.player2Color = ColorDialogPlayer2.Color;
        }

        private void btnBallColor_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialogBall = new ColorDialog();
            ColorDialogBall.Color = Color.White;
            ColorDialogBall.FullOpen = true;
            ColorDialogBall.ShowDialog();
            btnBallColor.BackColor = ColorDialogBall.Color;

            if (ColorDialogBall.Color != Color.Black) //Não permitir o utilizador selecionar a cor preta
                Variaveis.ballColor = ColorDialogBall.Color;
        }
    }
}
