namespace FlappyBird
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gameStartLB = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Timer(this.components);
            this.scoreLB = new System.Windows.Forms.Label();
            this.firstCoin = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.sixthPipe = new System.Windows.Forms.PictureBox();
            this.fifthPipe = new System.Windows.Forms.PictureBox();
            this.fourthPipe = new System.Windows.Forms.PictureBox();
            this.thirdPipe = new System.Windows.Forms.PictureBox();
            this.secondPipe = new System.Windows.Forms.PictureBox();
            this.firstPipe = new System.Windows.Forms.PictureBox();
            this.groundPB = new System.Windows.Forms.PictureBox();
            this.backGroundPB = new System.Windows.Forms.PictureBox();
            this.firstTree = new System.Windows.Forms.PictureBox();
            this.secondTree = new System.Windows.Forms.PictureBox();
            this.thirdTree = new System.Windows.Forms.PictureBox();
            this.secondCoin = new System.Windows.Forms.PictureBox();
            this.thirdCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.firstCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // gameStartLB
            // 
            this.gameStartLB.AutoSize = true;
            this.gameStartLB.BackColor = System.Drawing.Color.Green;
            this.gameStartLB.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gameStartLB.Location = new System.Drawing.Point(225, 211);
            this.gameStartLB.Name = "gameStartLB";
            this.gameStartLB.Size = new System.Drawing.Size(396, 40);
            this.gameStartLB.TabIndex = 4;
            this.gameStartLB.Text = "PRESS ENTER FOR START ";
            // 
            // player
            // 
            this.player.Interval = 20;
            this.player.Tick += new System.EventHandler(this.player_Tick);
            // 
            // scoreLB
            // 
            this.scoreLB.AutoSize = true;
            this.scoreLB.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLB.Location = new System.Drawing.Point(12, 9);
            this.scoreLB.Name = "scoreLB";
            this.scoreLB.Size = new System.Drawing.Size(132, 33);
            this.scoreLB.TabIndex = 5;
            this.scoreLB.Text = "SCORE : 0";
            // 
            // firstCoin
            // 
            this.firstCoin.Image = global::FlappyBird.Properties.Resources.coin;
            this.firstCoin.Location = new System.Drawing.Point(151, 191);
            this.firstCoin.Name = "firstCoin";
            this.firstCoin.Size = new System.Drawing.Size(80, 70);
            this.firstCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstCoin.TabIndex = 6;
            this.firstCoin.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(0, 191);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // sixthPipe
            // 
            this.sixthPipe.BackColor = System.Drawing.Color.Chartreuse;
            this.sixthPipe.Location = new System.Drawing.Point(645, 274);
            this.sixthPipe.Name = "sixthPipe";
            this.sixthPipe.Size = new System.Drawing.Size(80, 182);
            this.sixthPipe.TabIndex = 2;
            this.sixthPipe.TabStop = false;
            this.sixthPipe.Tag = "7";
            // 
            // fifthPipe
            // 
            this.fifthPipe.BackColor = System.Drawing.Color.Chartreuse;
            this.fifthPipe.Location = new System.Drawing.Point(399, 274);
            this.fifthPipe.Name = "fifthPipe";
            this.fifthPipe.Size = new System.Drawing.Size(80, 182);
            this.fifthPipe.TabIndex = 2;
            this.fifthPipe.TabStop = false;
            this.fifthPipe.Tag = "5";
            // 
            // fourthPipe
            // 
            this.fourthPipe.BackColor = System.Drawing.Color.Chartreuse;
            this.fourthPipe.Location = new System.Drawing.Point(151, 274);
            this.fourthPipe.Name = "fourthPipe";
            this.fourthPipe.Size = new System.Drawing.Size(80, 182);
            this.fourthPipe.TabIndex = 2;
            this.fourthPipe.TabStop = false;
            this.fourthPipe.Tag = "3";
            // 
            // thirdPipe
            // 
            this.thirdPipe.BackColor = System.Drawing.Color.Chartreuse;
            this.thirdPipe.Location = new System.Drawing.Point(645, -2);
            this.thirdPipe.Name = "thirdPipe";
            this.thirdPipe.Size = new System.Drawing.Size(80, 168);
            this.thirdPipe.TabIndex = 2;
            this.thirdPipe.TabStop = false;
            this.thirdPipe.Tag = "6";
            // 
            // secondPipe
            // 
            this.secondPipe.BackColor = System.Drawing.Color.Chartreuse;
            this.secondPipe.Location = new System.Drawing.Point(399, -2);
            this.secondPipe.Name = "secondPipe";
            this.secondPipe.Size = new System.Drawing.Size(80, 168);
            this.secondPipe.TabIndex = 2;
            this.secondPipe.TabStop = false;
            this.secondPipe.Tag = "4";
            // 
            // firstPipe
            // 
            this.firstPipe.BackColor = System.Drawing.Color.Chartreuse;
            this.firstPipe.Location = new System.Drawing.Point(151, -2);
            this.firstPipe.Name = "firstPipe";
            this.firstPipe.Size = new System.Drawing.Size(80, 168);
            this.firstPipe.TabIndex = 2;
            this.firstPipe.TabStop = false;
            this.firstPipe.Tag = "2";
            // 
            // groundPB
            // 
            this.groundPB.BackColor = System.Drawing.Color.Yellow;
            this.groundPB.Location = new System.Drawing.Point(-5, 406);
            this.groundPB.Name = "groundPB";
            this.groundPB.Size = new System.Drawing.Size(811, 50);
            this.groundPB.TabIndex = 0;
            this.groundPB.TabStop = false;
            // 
            // backGroundPB
            // 
            this.backGroundPB.BackColor = System.Drawing.Color.Gold;
            this.backGroundPB.Location = new System.Drawing.Point(-5, 379);
            this.backGroundPB.Name = "backGroundPB";
            this.backGroundPB.Size = new System.Drawing.Size(811, 50);
            this.backGroundPB.TabIndex = 0;
            this.backGroundPB.TabStop = false;
            // 
            // firstTree
            // 
            this.firstTree.Image = ((System.Drawing.Image)(resources.GetObject("firstTree.Image")));
            this.firstTree.Location = new System.Drawing.Point(110, 274);
            this.firstTree.Name = "firstTree";
            this.firstTree.Size = new System.Drawing.Size(100, 116);
            this.firstTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstTree.TabIndex = 1;
            this.firstTree.TabStop = false;
            // 
            // secondTree
            // 
            this.secondTree.Image = ((System.Drawing.Image)(resources.GetObject("secondTree.Image")));
            this.secondTree.Location = new System.Drawing.Point(379, 274);
            this.secondTree.Name = "secondTree";
            this.secondTree.Size = new System.Drawing.Size(100, 116);
            this.secondTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondTree.TabIndex = 1;
            this.secondTree.TabStop = false;
            // 
            // thirdTree
            // 
            this.thirdTree.Image = ((System.Drawing.Image)(resources.GetObject("thirdTree.Image")));
            this.thirdTree.Location = new System.Drawing.Point(645, 274);
            this.thirdTree.Name = "thirdTree";
            this.thirdTree.Size = new System.Drawing.Size(100, 116);
            this.thirdTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdTree.TabIndex = 1;
            this.thirdTree.TabStop = false;
            // 
            // secondCoin
            // 
            this.secondCoin.Image = global::FlappyBird.Properties.Resources.coin;
            this.secondCoin.Location = new System.Drawing.Point(399, 191);
            this.secondCoin.Name = "secondCoin";
            this.secondCoin.Size = new System.Drawing.Size(80, 70);
            this.secondCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondCoin.TabIndex = 6;
            this.secondCoin.TabStop = false;
            // 
            // thirdCoin
            // 
            this.thirdCoin.Image = global::FlappyBird.Properties.Resources.coin;
            this.thirdCoin.Location = new System.Drawing.Point(645, 191);
            this.thirdCoin.Name = "thirdCoin";
            this.thirdCoin.Size = new System.Drawing.Size(80, 70);
            this.thirdCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdCoin.TabIndex = 6;
            this.thirdCoin.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.gameStartLB);
            this.Controls.Add(this.thirdCoin);
            this.Controls.Add(this.secondCoin);
            this.Controls.Add(this.firstCoin);
            this.Controls.Add(this.scoreLB);
            this.Controls.Add(this.sixthPipe);
            this.Controls.Add(this.fifthPipe);
            this.Controls.Add(this.fourthPipe);
            this.Controls.Add(this.thirdPipe);
            this.Controls.Add(this.secondPipe);
            this.Controls.Add(this.firstPipe);
            this.Controls.Add(this.groundPB);
            this.Controls.Add(this.backGroundPB);
            this.Controls.Add(this.firstTree);
            this.Controls.Add(this.secondTree);
            this.Controls.Add(this.thirdTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.firstCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixthPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox groundPB;
        private System.Windows.Forms.PictureBox backGroundPB;
        private System.Windows.Forms.PictureBox firstTree;
        private System.Windows.Forms.PictureBox secondTree;
        private System.Windows.Forms.PictureBox thirdTree;
        private System.Windows.Forms.PictureBox firstPipe;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox fourthPipe;
        private System.Windows.Forms.PictureBox secondPipe;
        private System.Windows.Forms.PictureBox thirdPipe;
        private System.Windows.Forms.PictureBox fifthPipe;
        private System.Windows.Forms.PictureBox sixthPipe;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label gameStartLB;
        private System.Windows.Forms.Timer player;
        private System.Windows.Forms.Label scoreLB;
        private System.Windows.Forms.PictureBox firstCoin;
        private System.Windows.Forms.PictureBox secondCoin;
        private System.Windows.Forms.PictureBox thirdCoin;
    }
}