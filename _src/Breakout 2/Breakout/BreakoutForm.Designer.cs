namespace Breakout
{
    partial class BreakoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakoutForm));
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.GameMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPaddle.Image = ((System.Drawing.Image)(resources.GetObject("picPaddle.Image")));
            this.picPaddle.Location = new System.Drawing.Point(334, 515);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(116, 12);
            this.picPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaddle.TabIndex = 1;
            this.picPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(374, 459);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(32, 32);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBall.TabIndex = 2;
            this.picBall.TabStop = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Alien Encounters", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(69, 57);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(670, 54);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "Level  Complete!";
            this.lblGameOver.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stone_block.png");
            this.imageList1.Images.SetKeyName(1, "blue_block.png");
            this.imageList1.Images.SetKeyName(2, "brown_block.png");
            this.imageList1.Images.SetKeyName(3, "green_block.png");
            this.imageList1.Images.SetKeyName(4, "pink_block.png");
            this.imageList1.Images.SetKeyName(5, "red_block.png");
            this.imageList1.Images.SetKeyName(6, "skyblue_block.png");
            this.imageList1.Images.SetKeyName(7, "violet_block.png");
            this.imageList1.Images.SetKeyName(8, "yellow_block.png");
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.Color.Transparent;
            this.GameMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameMenu.BackgroundImage")));
            this.GameMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameMenu.Controls.Add(this.label1);
            this.GameMenu.Controls.Add(this.btnQuit);
            this.GameMenu.Controls.Add(this.btnResume);
            this.GameMenu.Controls.Add(this.btnNewGame);
            this.GameMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameMenu.Location = new System.Drawing.Point(200, 150);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(400, 300);
            this.GameMenu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alien Encounters", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "BREAKOUT GAME MENU";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Gold;
            this.btnQuit.Font = new System.Drawing.Font("Alien Encounters", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(60, 201);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(300, 35);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Gold;
            this.btnResume.Enabled = false;
            this.btnResume.Font = new System.Drawing.Font("Alien Encounters", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(60, 133);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(300, 35);
            this.btnResume.TabIndex = 1;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Gold;
            this.btnNewGame.Font = new System.Drawing.Font("Alien Encounters", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(60, 70);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(300, 35);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Alien Encounters", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "SCORE:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Alien Encounters", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(131, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 19);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "00000";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdown.Font = new System.Drawing.Font("Alien Encounters", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.Yellow;
            this.lblCountdown.Location = new System.Drawing.Point(647, 220);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(92, 75);
            this.lblCountdown.TabIndex = 7;
            this.lblCountdown.Text = "3";
            this.lblCountdown.Visible = false;
            // 
            // BreakoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 599);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameMenu);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPaddle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "BreakoutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BreakOut";
            this.Load += new System.EventHandler(this.BreakoutForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BreakoutForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakoutForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BreakoutForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel GameMenu;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCountdown;
    }
}

