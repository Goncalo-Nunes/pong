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
    public partial class frmPrincipal : Form
    {
        int playerSpeed = 5;
        int ballSpeedX = 6;
        double ballSpeedY = 3;
        int difficulty = 15;

        bool isMuted = false;

        System.Media.SoundPlayer themesong = new System.Media.SoundPlayer(Properties.Resources.themesong); //Carregar o ficheiro themesong.wav


        //Tornar o Form sem Border movivel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AudioStart();
        }
        

        private void btnJogar_Click(object sender, EventArgs e)
        {
            AudioStop();  //Parar Audio
            timer.Stop(); //Parar o timer
            frmJogo frmJogo= new frmJogo(); //Criar uma instância do FormJogo
            this.Hide();
            frmJogo.ShowDialog();
            this.Show();

            if (!isMuted)
                AudioStart(); //Voltar a tocar o audio caso o butão mute não tenha sido clicado

            timer.Start(); //Voltar a ativar o timer
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo();
            frmInfo.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOpcoes_Click(object sender, EventArgs e)
        {
            frmOpcoes frmOpcoes = new frmOpcoes();   
            frmOpcoes.ShowDialog();

            //Trocar as cores dos jogadores e da bola para as selecionas no frmOpções
            player1.BackColor = Variaveis.player1Color;
            player2.BackColor = Variaveis.player2Color;
            ball.BackColor = Variaveis.ballColor;
        }

        private void btnHistoricoJogos_Click(object sender, EventArgs e)
        {
            frmHistoricoJogos frmHistoricoJogos = new frmHistoricoJogos();
            frmHistoricoJogos.ShowDialog();
        }


        #region Jogo Inicial
        private void timer_Tick(object sender, EventArgs e)
        {
            player1Movement();
            player2Movement();
            BallMovement();
        }


        private void player1Movement()
        {
            if (ballSpeedX > 0)
            {
                if (ball.Top < (player1.Top + difficulty) && player1.Top >= 0)
                {
                    player1.Top -= playerSpeed;
                }
                else if (ball.Bottom > (player1.Bottom - difficulty) && (player1.Bottom <= ClientSize.Height))
                {
                    player1.Top += playerSpeed;
                }
            }
        }

        private void player2Movement()
        {
            if (ballSpeedX < 0)
            {

                if (ball.Top < (player2.Top + difficulty) && player2.Top >= 0)
                {
                    player2.Top -= playerSpeed;
                }
                else if (ball.Bottom > (player2.Bottom - difficulty) && (player2.Bottom <= ClientSize.Height))
                {
                    player2.Top += playerSpeed;
                }
            }
        }



        private void BallMovement()
        {
            ball.Top += Convert.ToInt32(ballSpeedY);
            ball.Left -= ballSpeedX;

            if (ball.Top <= 0 || (ball.Bottom >= ClientSize.Height)) //Refletir a bola caso bata no teto ou no chão
            {
                ballSpeedY = -ballSpeedY;
            }

            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                ballSpeedX = -ballSpeedX; //Inverter a velocidade (Refletir a bola)

                if (ball.Bounds.IntersectsWith(player1.Bounds))
                {
                    double deltaY = ball.Top - (player1.Top + player1.Height / 2);
                    ballSpeedY = deltaY * 0.10;
                }
                else if (ball.Bounds.IntersectsWith(player2.Bounds))
                {
                    double deltaY = ball.Top - (player2.Top + player2.Height / 2);
                    ballSpeedY = deltaY * 0.10;
                }
            }
        }
        #endregion



        #region Audio
        private void btnMute_Click(object sender, EventArgs e)
        {
            if (!isMuted) 
            {
                //Parar de tocar a musica do ecrã principal
                AudioStop();
                btnMute.Image = Properties.Resources.mute1;
                isMuted = true;
            }
            else
            {
                //Tocar a musica do ecrã principal
                AudioStart();
                btnMute.Image = Properties.Resources.volume1;
                isMuted = false;
            }
        }

        private void AudioStart() //Tocar música
        {
            try
            {
                themesong.Play();
            }
            catch { }
        }

        private void AudioStop() //Parar música
        {
            try
            {
                themesong.Stop();
            }
            catch { }

        }

        #endregion

    }
}
