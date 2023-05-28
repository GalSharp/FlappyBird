using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Game : Form
    {
        int screenWidth;
        int screenHeight;
        int score;
        int treeMoveSpeed;
        int pipeMoveSpeed;
        int birdGravity;
        PictureBox[] pipes;
        PictureBox[] trees;
        Coin[] coins;
        bool isPause;
        bool isReversed;
        bool isGameOvered;
        bool isGameStarted;
        Random random;
        public Game()
        {
            InitializeComponent();
            screenWidth = this.Width;
            screenHeight = this.Height;
            score = 0;
            birdGravity = 2;
            treeMoveSpeed = 2;
            pipeMoveSpeed = 4;
            trees = new PictureBox[]
            {
                firstTree,
                secondTree,
                thirdTree
            };
            pipes = new PictureBox[]
            {
                firstPipe,
                secondPipe,
                thirdPipe,
                fourthPipe,
                fifthPipe,
                sixthPipe
            };
            coins = new Coin[]
            {
                new Coin(firstCoin,false),
                new Coin(secondCoin,false),
                new Coin(thirdCoin,false)
            };
            isPause = false;
            isReversed = false;
            isGameOvered = false;
            random = new Random();
        }
        private void CoinMove()
        {
            if (!isReversed)
            {
                foreach (var coin in coins)
                {
                    if (coin.coinPB.Left >= -coin.coinPB.Width) coin.coinPB.Left -= pipeMoveSpeed;
                    else
                    {
                        coin.coinPB.Left = screenWidth;
                        coin.UnCheck();
                    }
                }
            }
            else
            {
                foreach (var coin in coins)
                {
                    if (coin.coinPB.Left < screenWidth + coin.coinPB.Width) coin.coinPB.Left += pipeMoveSpeed;
                    else
                    {
                        coin.coinPB.Left = -coin.coinPB.Width;
                        coin.UnCheck();
                    }
                }
            }
        }
        private void CoinCheck()
        {
            foreach (var coin in coins)
            {
                if (bird.Bounds.IntersectsWith(coin.coinPB.Bounds))
                {
                    if (!coin.isCheched) ScoreUpdate();
                    coin.Check();
                }
            }
        }
        private void TreeMove()
        {
            if (!isReversed)
            {
                foreach (var tree in trees)
                {
                    if (tree.Left >= -tree.Width) tree.Left -= treeMoveSpeed;
                    else tree.Left = screenWidth;
                }
            }
            else
            {
                foreach (var tree in trees)
                {
                    if (tree.Left < screenWidth + tree.Width) tree.Left += treeMoveSpeed;
                    else tree.Left = -tree.Width;
                }
            }
        }
        private void PipeMove()
        {
            if (!isReversed)
            {
                foreach (var pipe in pipes)
                {
                    if (pipe.Left >= -pipe.Width) pipe.Left -= pipeMoveSpeed;
                    else
                    {
                        pipe.Left = screenWidth;
                        PipeHeigth(pipe);
                    }
                }
            }
            else
            {
                foreach (var pipe in pipes)
                {
                    if (pipe.Left < screenWidth + pipe.Width) pipe.Left += pipeMoveSpeed;
                    else
                    {
                        pipe.Left = -pipe.Width;
                        PipeHeigth(pipe);
                    }
                }
            }
        }
        private void PipeCheck()
        {
            foreach (var pipe in pipes)
            {
                if (bird.Bounds.IntersectsWith(pipe.Bounds))
                {
                    GameOver();
                }
            }
        }
        private void PipeHeigth(PictureBox pipe)
        {
            bool isTagEven = int.Parse(pipe.Tag.ToString()) % 2 == 0;

            if (isTagEven) pipe.Location = new Point(pipe.Location.X, random.Next(-75, 0));
            else pipe.Location = new Point(pipe.Location.X, random.Next(274, 360));
        }
        private void SpeedCheck() 
        {
            if(score % 5 == 0)
            {
                GamePause();
                var speedIncrement = MessageBox.Show($"Поздравляем, вы набрали уже {score} очков\nЖелаете продолжить?", "Поздравления", MessageBoxButtons.OKCancel); 
                if (speedIncrement == DialogResult.OK)
                {
                    pipeMoveSpeed += 2;
                    treeMoveSpeed += 1;
                    GameStart();
                }
                else
                {
                    GameOver();
                }
            }
        }
        private void ScoreUpdate()
        {
            score++;
            scoreLB.Text = $"SCORE : {score}";
            SpeedCheck();
            if(score >= 50)
            {
                GamePause();
                MessageBox.Show("Поздравляем с победой","Победа");
                Application.Exit();
            }
        }
        private void GamePause()
        {
            timer.Stop();
            player.Stop();
        }
        private void GameStart()
        {
            timer.Start();
            player.Start();
            isGameStarted = true;
        }
        private void GameOver()
        {
            isGameOvered = true;
            GamePause();
            var gameOver = MessageBox.Show($"GAME OVER\nYOU LOOOOOOOSE\nYOUR SCORE : {score}", "GAME OVER", MessageBoxButtons.OK);
            if (gameOver == DialogResult.OK)
            {
                Form1 form = new Form1();
                form.Show();

                this.Hide();
            }
        }
        private void GameReverse()
        {
            if (!isReversed) bird.Location = new Point(730, bird.Location.Y);
            else bird.Location = new Point(0, bird.Location.Y);
        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isGameOvered)
            {
                GameStart();
                gameStartLB.Visible = false;
            }// для старта игры
            if (isGameStarted)
            {
                if (e.KeyCode == Keys.Escape && !isGameOvered)
                {
                    if (!isPause)
                    {
                        GamePause();
                        isPause = true;
                    }
                    else
                    {
                        GameStart();
                        isPause = false;
                    }
                } // для паузы
                if (e.KeyCode == Keys.R && !isGameOvered && !isPause)
                {
                    if (!isReversed)
                    {
                        GameReverse();
                        isReversed = true;
                    }
                    else
                    {
                        GameReverse();
                        isReversed = false;
                    }
                } // для переворота игры
                if (e.KeyCode == Keys.Space && !isGameOvered && !isPause) BirdJump(); // для прыжка
            }
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TreeMove();
            PipeMove();
            CoinMove();
            PipeCheck();
            CoinCheck();
        }
        private void player_Tick(object sender, EventArgs e)
        {
            if (bird.Top <= screenHeight - 100) bird.Top += birdGravity;
            else GameOver();
        }
        private void BirdJump()
        {
            bird.Top -= 20;
        }
    }
}
