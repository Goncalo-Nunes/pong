
using System;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmJogo : Form
    {
        #region Variaveis

        int player1Speed = 5;
        int player2Speed = 3 + Variaveis.Difficulty;

        bool moveUpPlayer1;
        bool moveDownPlayer1;
        bool moveUpPlayer2;
        bool moveDownPlayer2;

        int ballSpeedXDefault = 6;
        int ballSpeedX = 6;
        int ballSpeedYDeafault = 3;
        double ballSpeedY = 3;

        int player1Score = 0;
        int player2Score = 0;

        int bounceStreak = 0;
        int bounceStreakLimit = Variaveis.bounceStreakLimit;

        int difficulty = 30 / (Variaveis.Difficulty + 1); //Quanto menor, maior a dificuldade
        const int marginSide = 12;
        const int marginTop = 30;

        const int ballSpeedXBonus = 2;

        string winner;
        int winScore = Variaveis.winScore;

        bool clickToContinue = true;

        bool isPaused = false;



        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.player); //Carregar o ficheiro player.wav
        System.Media.SoundPlayer wall = new System.Media.SoundPlayer(Properties.Resources.wall); //Carregar o ficheiro player.wav
        System.Media.SoundPlayer reset = new System.Media.SoundPlayer(Properties.Resources.reset); //Carregar o ficheiro player.wav


        #endregion



        public frmJogo()
        {
            InitializeComponent();
        }


        private void frmJogo_SizeChanged(object sender, EventArgs e)
        {
            DrawObjects(); //Posicionar todos os Controls na sua posição correta
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            timer.Stop();
            DrawObjects(); //Posicionar todos os Controls na sua posição correta

            if (Variaveis.singlePlayer)  //Adicionar à propriedade 'Text' do form o modo de jogo
            {
                this.Text += " - 1 Jogador";
            }
            else
            {
                this.Text += " - 2 Jogadores";
            }

            //Adicionar à propriedade 'Text' do form o nome dos jogadores
            this.Text += " - " + Variaveis.player1Name + " vs " + Variaveis.player2Name;

            //Alterar as cores dos jogadores e da bola para as selecionadas anteriormente no frmOpcoes
            player1.BackColor = Variaveis.player1Color;
            player2.BackColor = Variaveis.player2Color;
            ball.BackColor = Variaveis.ballColor;

           

            if (Variaveis.fullScreen) //Ajustar os valores de velocidade caso o FormJogo esteja maximizado
            {
                ballSpeedXDefault = 7;
                ballSpeedX = 7;
                ballSpeedYDeafault = 6;
                ballSpeedY = 6;

                player1Speed = 10;

                if (Variaveis.singlePlayer)
                    player2Speed = 5 + (Variaveis.Difficulty); 
                else
                    player2Speed = player1Speed;


                //Maximizar o FormJogo
                WindowState = FormWindowState.Maximized;
            } else
            {
                WindowState = FormWindowState.Normal;
            }
        }



        private void frmJogo_KeyDown(object sender, KeyEventArgs e)
        {
            //Jogador 1
            if (e.KeyCode == Keys.W)
            {
                moveUpPlayer1 = true;
            }

            if (e.KeyCode == Keys.S)
            {
                moveDownPlayer1 = true;
            }


            //Jogador 2
            if (e.KeyCode == Keys.Up)
            {
                moveUpPlayer2 = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDownPlayer2 = true;
            }


            //Pausa
            if (e.KeyCode == Keys.P) 
            {
                PauseGame();
            }
        }

        private void frmJogo_KeyUp(object sender, KeyEventArgs e)
        {
            //Jogador 1
            if (e.KeyCode == Keys.W)
            {
                moveUpPlayer1 = false;
            }

            if (e.KeyCode == Keys.S)
            {
                moveDownPlayer1 = false;
            }

            //Jogador 2
            if (e.KeyCode == Keys.Up)
            {
                moveUpPlayer2 = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                moveDownPlayer2 = false;
            }
        }



        private void GameTick(object sender, EventArgs e) //Função chamada a cada 5 milissigundos
        {
            Player1Movement();
            Player2Movement();

            CheckColisions();
            BallMovement();
            DrawScores();
        }

        private void Player1Movement() //Movimento do jogador 1
        {
            if (moveUpPlayer1 && player1.Top >= 0)
            {
                player1.Top -= player1Speed;
            }
            if (moveDownPlayer1 && player1.Bottom <= ClientSize.Height)
            {
                player1.Top += player1Speed;
            }
        }

        private void Player2Movement() //Movimento do jogador 2
        {
            if (Variaveis.singlePlayer) //Caso o modo de jogo selecionado seja Single Player, o movimento do player2 é controlado pelo computador
            {
                if (ballSpeedX < 0)
                {
                    if (ball.Top < (player2.Top + difficulty) && player2.Top >= 0)
                    {
                        player2.Top -= player2Speed;
                    }
                    else if (ball.Bottom > (player2.Bottom - difficulty) && (player2.Bottom <= ClientSize.Height))
                    {
                        player2.Top += player2Speed;
                    }
                }
            } else //Caso contrário o movimento do Player2 será controlado por uma pessoa
            {
                player2Speed = player1Speed;
                if (moveUpPlayer2 && player2.Top >= 0)
                {
                    player2.Top -= player2Speed;
                }
                if (moveDownPlayer2 && player2.Bottom <= ClientSize.Height)
                {
                    player2.Top += player2Speed;
                }
            }
        }

        private void BallMovement()
        {
            //Movimento da bola
            ball.Top += Convert.ToInt16(ballSpeedY);
            ball.Left -= ballSpeedX;

            if (ball.Top <= 0 || (ball.Bottom >= ClientSize.Height)) //Refletir a bola caso bata no teto ou no chão
            {
                PlaySound(wall); //Reproduzir o som de quando a bola colide com o as paredes
                ballSpeedY = -ballSpeedY;
            } 
             
            if (ball.Left <= 0) //Verificar se o jogador 2 marcou ponto
            {
                ballSpeedX = ballSpeedXDefault; //Inverter o sentido da bola no eixo X para que seja o jogador que perdeu a servir na ronda seguinte
                player2Score++; //Incrementar 1 unidade à pontuação do jogador 2

                ResetBall(); //Dar reset à bola
                CheckWinner(); //Verificar se algum dos jogadores ganhou o jogo
            } 
            else if (ball.Right >= ClientSize.Width) //Verificar se o jogador 1 marcou ponto
            {
                ballSpeedX = -ballSpeedXDefault; //Inverter o sentido da bola no eixo X para que seja o jogador que perdeu a servir na ronda seguinte
                player1Score++; //Incrementar 1 unidade à pontuação do jogador 1
               
                ResetBall();
                CheckWinner();
            }
          
        }

        private void CheckColisions()
        {
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                PlaySound(player); //Reproduzir o som de quando a bola colide com o jogador
                bounceStreak++; //Incrementar 1 unidade à Bounce Streak

                if (ball.Bounds.IntersectsWith(player1.Bounds)) //Caso a bola intersete com o jogador 1...
                {
                    //Alterar a velocidade no eixo Y da bola consoante a distância a que esta colidiu do centro do jogador1
                    double deltaY = ball.Top - (player1.Top + player1.Height / 2);
                    ballSpeedY = deltaY * 0.15;
                } 
                else if (ball.Bounds.IntersectsWith(player2.Bounds)) //Caso a bola intersete com o jogador 2...
                {
                    //Alterar a velocidade da bola no eixo Y consoante a distância a que esta colidiu do centro do jogador2
                    double deltaY = ball.Top - (player2.Top + player2.Height / 2);
                    ballSpeedY = deltaY * 0.15;
                }

                if (bounceStreak == bounceStreakLimit) //Aumentar a velocidade da bola quando a bounceStreak for igual ao limite definido pelo utilizador no FormOpções
                {
                    ballSpeedX = ballSpeedX * ballSpeedXBonus;
                }

               ballSpeedX = -ballSpeedX; //Inverter a velocidade da bola no eixo X (Refletir a bola)
                
            }
        }

        private void DrawScores()
        {
            lblPlayer1Score.Text = player1Score.ToString();
            lblPlayer2Score.Text = player2Score.ToString();
            lblBounceStreak.Text = "Bounce Streak: " + bounceStreak.ToString();
        }

        private void ResetBall()
        {
            PlaySound(reset);
            //Criar um número aleatório para que cada serviço seja diferente
            Random random = new Random();

            bounceStreak = 0;
            ballSpeedY = random.Next(-ballSpeedYDeafault, ballSpeedYDeafault+1);
 
            ball.Top = (ClientSize.Height / 2) - (ball.Height / 2);
            ball.Left = (ClientSize.Width / 2) - (ball.Width / 2);
            ResetPlayers(); // Posicionar os jogadores no meio do ecrã
            ClickToContinue();

        }

        private void CheckWinner()
        {

            //Verificar se algum dos jogadores ganhou
            if (player1Score >= winScore || player2Score >= winScore)
            {
                if (player1Score >= winScore) //Verificar quem foi o vencedor
                { 
                    winner = Variaveis.player1Name;
                }
                else 
                {
                    winner = Variaveis.player2Name;
                }

                MessageBox.Show(winner + " venceu!", "Fim do Jogo");




                //Caso algúem tenha ganho, os dados do jogo vão ser gravados num ficheiro .txt
                try //Tentar gravar os dados
                { 
                    System.IO.StreamWriter obj;
                    obj = new System.IO.StreamWriter(Variaveis.filePath, true);

                    obj.WriteLine("************************************************");
                    obj.WriteLine("   Data: " + DateTime.Now);
                    obj.WriteLine("   Jogadores: " + Variaveis.player1Name + " vs " + Variaveis.player2Name);
                    obj.WriteLine("   Pontuação: " + player1Score.ToString() + " - " + player2Score.ToString());
                    obj.WriteLine("   Vencedor: " + winner);
                    obj.Write("   Modo de Jogo: ");
                    if (Variaveis.singlePlayer)
                    {
                        obj.WriteLine("1 Jogador");
                        obj.WriteLine("   Dificuldade: " + Variaveis.DifficultyString);
                    }
                    else
                    {
                        obj.WriteLine("2 Jogadores");
                    }
                    obj.WriteLine("************************************************");
                    obj.WriteLine();
                    obj.Close();
                } catch { }


                //Dar reset às pontuações dos jogadores
                player1Score = 0;
                player2Score = 0;

            }

            if (player1Score == winScore-1 || player2Score == winScore-1) //Mostrar a label de Match Point caso algum dos jogadores esteja prestes a ganhar
            {
                lblMatchPoint.Visible = true;
            } else
            {
                lblMatchPoint.Visible = false;
            }
        }

        private void DrawObjects() //Posicionar todos os controladores na posição correta independentemente do tamanho da janela
        {
            //Bola
            ball.Top = ClientSize.Height / 2 - ball.Height/2;
            ball.Left = (ClientSize.Width / 2) - (ball.Width / 2);

            //Jogadores
            ResetPlayers();

            //Bounce Streak
            lblBounceStreak.Top = 0 + marginTop;
            lblBounceStreak.Left = ClientSize.Width / 2 - lblBounceStreak.Width / 2;

            //Player1 Score
            lblPlayer1Score.Top = 0 + marginTop;
            lblPlayer1Score.Left = ClientSize.Width / 4 - lblPlayer1Score.Width / 2;

            //Player2 Score
            lblPlayer2Score.Top = 0 + marginTop;
            lblPlayer2Score.Left = ClientSize.Width * 3 / 4 - lblPlayer1Score.Width / 2;

            //Click to play
            lblClickToPlay.Left = ClientSize.Width / 2 - lblClickToPlay.Width / 2;
            lblClickToPlay.Top = ClientSize.Height * 3/4;

            //MatchPoint
            lblMatchPoint.Top = ClientSize.Height * 5 / 6;
            lblMatchPoint.Left = ClientSize.Width / 2 - lblMatchPoint.Width / 2;

            //Pausa
            lblPause.Top = ClientSize.Height / 2;
            lblPause.Left = ClientSize.Width / 2 - lblPause.Width / 2;
        }

        private void ResetPlayers() //Posicionar os jogadores no meio da janela
        {
            player1.Top = ClientSize.Height / 2 - player1.Height / 2;
            player1.Left = marginSide;
            player2.Top = ClientSize.Height / 2 - player2.Height / 2;
            player2.Left = ClientSize.Width - marginSide - player2.Width;
        }

        private void ClickToContinue() //Clicar para continuar
        {
            timer.Stop(); //Parar o timer
            lblClickToPlay.Visible = true;
            clickToContinue = true;
        }

        private void frmJogo_Click(object sender, EventArgs e)
        {
            ContinueGame();
        }

        private void frmJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space) //Se o utilizador clicar no 'Espaço' o jogo continua
            {
                ContinueGame();
            }            
        }

        private void ContinueGame() //Resumir o jogo
        {
            if (clickToContinue)
            {
                lblClickToPlay.Visible = false;
                lblMatchPoint.Visible = false;
                clickToContinue = false;
                timer.Start();

            }
        }

        private void PauseGame() //Pausar o jogo e Resumir o jogo
        {
            if (!isPaused) //Caso o jogo esteja em progresso este deverá ficar em pausa
            {
                timer.Stop();
                lblPause.Visible = true;
                isPaused = true;
            } 
            else //Caso o jogo esteja em Pausa este deverá resumir
            {
                timer.Start();
                lblPause.Visible = false;
                isPaused = false;
            }
        }


        private void PlaySound(System.Media.SoundPlayer sound) 
        {
            if (Variaveis.sounds)
            {
                sound.Play();
            }
        }
    }
}
