using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Breakout
{
    public partial class BreakoutForm : Form
    {
        //Sounds for the game
        SoundPlayer startSound = new SoundPlayer(Breakout.Properties.Resources.start);
        SoundPlayer quitSound = new SoundPlayer(Breakout.Properties.Resources.quit);
        SoundPlayer countDownSound = new SoundPlayer(Breakout.Properties.Resources.countdown);
        SoundPlayer blockHitSound = new SoundPlayer(Breakout.Properties.Resources.Hit1);
        SoundPlayer blockSpeedSound = new SoundPlayer(Breakout.Properties.Resources.speed);
        SoundPlayer paddleTouchSound = new SoundPlayer(Breakout.Properties.Resources.paddle_touch);

        Timer gameTimer = new Timer();

        //Paddle speed
        int paddleSpeed = 30;

        //Ball variables
        int ballSpeed = 8;
        int ballDX = 1;
        int ballDY = 1;

        //Block variables
        Image[,] Blocks;
        int blockRows;
        int blockCols;
        int blockCount = 0;

        Random rand = new Random();

        //game variables
        bool gamePaused = true;
        int score = 0;

        public BreakoutForm()
        {
            InitializeComponent();            
        }

        private bool IsPaused()
        {
            return gamePaused;
        }

        private void PauseGame(bool Pause=true)
        {
            ShowMenu(Pause);
            gameTimer.Enabled = !Pause;
            gamePaused = Pause;
            btnResume.Enabled = Pause; 
        }

        private void ShowGameOver(string text="Game Over")
        {
            lblGameOver.Text = text;
            lblGameOver.Left = (ClientRectangle.Width - lblGameOver.Width) / 2;
            lblGameOver.Top = 60;
            lblGameOver.Visible = true;
            gameTimer.Enabled = false;

            quitSound.Play();

            for (int i = 0; i <10; ++i)
            {
                lblGameOver.Top += 15;
                Application.DoEvents();
                System.Threading.Thread.Sleep(45);
            }

            System.Threading.Thread.Sleep(2000);
            lblGameOver.Visible = false;
            PauseGame(true);
            btnResume.Enabled = false;
        }

        private void ShowMenu(bool Show = true)
        {
            GameMenu.Visible = Show;
            Invalidate(); //redraw
        }

        private int MakeBlocks(int rows, int cols)
        {
            blockRows = rows;
            blockCols = cols;

            Blocks = new Image[rows, cols];

            for (int i = 0; i < rows; ++i)
                for (int j = 0; j < cols; ++j)
                {
                    int index = rand.Next(0, imageList1.Images.Count);
                    Blocks[i, j] = imageList1.Images[index];
                    Blocks[i, j].Tag = index;
                }

            return rows * cols;
        }

        private void MovePaddle(int newXPos)
        {
            if (newXPos < 0)
                newXPos = 0;
            else if (newXPos > ClientRectangle.Width - picPaddle.Width)
                newXPos = ClientRectangle.Width - picPaddle.Width;

            picPaddle.Left = newXPos;
        }

        private void BreakoutForm_Load(object sender, EventArgs e)
        {
            //Center Game Paddle on Screen
            MovePaddle((ClientRectangle.Width - picPaddle.Width) / 2);

            //Center Ball on screen
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = 250;

            //Setup game timer
            gameTimer.Interval = 16;  //Call timer function every 16 ms
            gameTimer.Tick += GameTimer_Tick;
            
            //Prepare our blocks
            blockCount = MakeBlocks(3, imageList1.Images.Count);

            //Start the game paused
            PauseGame(true);
            btnResume.Enabled = false;

            startSound.Play();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //Ball movement
            Point pt = picBall.Location;

            pt.X += ballSpeed * ballDX;
            pt.Y += ballSpeed * ballDY;
            picBall.Location = pt;

            if (pt.X < 0 || pt.X > ClientRectangle.Width - picBall.Width)
                ballDX = -ballDX;

            if (pt.Y < 0 )
                ballDY = -ballDY;

            if (pt.Y > ClientRectangle.Height)
            {
                //Game Over
                ShowGameOver();
            }

            //Detect collision with game paddle
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds))
            {
                paddleTouchSound.Play();
                ballDY = -ballDY;
            }

            //Detect collision with blocks
            Point[] pts = new Point[]
            {
                new Point(pt.X, pt.Y),  //left-top
                new Point(pt.X + picBall.Width, pt.Y), //right-top
                new Point(pt.X, pt.Y+picBall.Height), //left-bottom
                new Point(pt.X+picBall.Width, pt.Y+picBall.Height) //Right-bottom
            };

            int blockHitCount = 0;
            foreach (Point ptBall in pts)
            {
                int imgWidth = imageList1.ImageSize.Width;
                int imgHeight = imageList1.ImageSize.Height;
                int xpos = (ClientRectangle.Width - imgWidth * blockCols) / 2;
                int ypos = 70;
                int row = ptBall.Y - ypos;
                int col = ptBall.X - xpos;

                col /= imgWidth;
                row /= imgHeight;

                if (col >= 0 && col < blockCols && row >= 0 && row < blockRows)
                {
                    if (Blocks[row, col] != null)
                    {
                        if ((int)Blocks[row, col].Tag ==0)
                        {
                            //We hit a stone block, increase ball speed
                            ballSpeed += 2;
                            if (blockHitCount == 0)
                                blockSpeedSound.Play();
                        }
                        else if (blockHitCount == 0)
                        {
                            blockHitSound.Play();
                        }

                        Blocks[row, col] = null;
                        Rectangle rc = new Rectangle(xpos + col * imgWidth, ypos + row * imgHeight, imgWidth, imgHeight);
                        Invalidate(rc);
                        ++blockHitCount;
                    }
                }
            }
            if (blockHitCount > 0)
            {
                //We have at least 1 block hit
                ballDY = -ballDY;

                score += blockHitCount;
                lblScore.Text = score.ToString("D5");
                blockCount -= blockHitCount; //decrease remainig blocks
                if (blockCount <=0)
                {
                    //Game or level is complete
                    ShowGameOver("Level Complete!");
                }
            }
        }

        private void BreakoutForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPaused())
                return;

            MovePaddle(e.X);            
        }

        private void BreakoutForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (GameMenu.Visible)
                return;

            int xpos;
            int ypos = 70;
            int imgWidth = imageList1.ImageSize.Width;
            int imgHeight = imageList1.ImageSize.Height;

            for (int i = 0; i < blockRows; ++i)
            {
                xpos = (ClientRectangle.Width - imgWidth * blockCols)/2;
                for (int j = 0; j < blockCols; ++j)
                {
                    if (Blocks[i,j ] != null)
                        g.DrawImage(Blocks[i, j], xpos, ypos);
                    xpos += imgWidth;
                }
                ypos += imgHeight;
            }
        }

        private void BreakoutForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    //Pause game
                    ShowMenu(!GameMenu.Visible);
                    if (!IsPaused())
                        PauseGame();
                    break;
                case Keys.Q:
                    //Quit the game
                    Close();
                    break;
                case Keys.Left:
                    if (!IsPaused())
                        MovePaddle(picPaddle.Left - paddleSpeed);
                    break;
                case Keys.Right:
                    if (!IsPaused())
                        MovePaddle(picPaddle.Left + paddleSpeed);
                    break;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString("D5");

            //Center Game Paddle on Screen
            MovePaddle((ClientRectangle.Width - picPaddle.Width) / 2);

            //Center Ball on screen
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = 250;

            //Prepare our blocks

            blockCount = MakeBlocks(rand.Next(3, 8), imageList1.Images.Count);

            //testing for fast game (level) complete
            //blockCount = MakeBlocks(1, 3);

            //Countdown
            lblCountdown.Text = "3";
            lblCountdown.Visible = true;
            ShowMenu(false);
            
            for (int i=3; i >=0; --i)
            {
                lblCountdown.Text = i.ToString();
                Application.DoEvents();
                countDownSound.Play();
                System.Threading.Thread.Sleep(1000);                
            }
            lblCountdown.Visible = false;
            //Start the game paused
            PauseGame(false);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            PauseGame(false);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
