namespace CSharpe_Game1_Shelby
{
    partial class Form1
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
            this.scoreText = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.bottomBoundary = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topboundary = new System.Windows.Forms.PictureBox();
            this.rock3 = new System.Windows.Forms.PictureBox();
            this.rock4 = new System.Windows.Forms.PictureBox();
            this.fakecar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBoundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topboundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakecar)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(98, 69);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(35, 13);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "label1";
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Location = new System.Drawing.Point(98, 99);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(35, 13);
            this.endText1.TabIndex = 5;
            this.endText1.Text = "label2";
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.Location = new System.Drawing.Point(98, 126);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(35, 13);
            this.endText2.TabIndex = 6;
            this.endText2.Text = "label3";
            // 
            // gameDesigner
            // 
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.Location = new System.Drawing.Point(98, 161);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(35, 13);
            this.gameDesigner.TabIndex = 7;
            this.gameDesigner.Text = "label4";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ground
            // 
            this.ground.Image = global::CSharpe_Game1_Shelby.Properties.Resources.road__1_;
            this.ground.Location = new System.Drawing.Point(-8, 215);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1022, 395);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::CSharpe_Game1_Shelby.Properties.Resources.rock_clipart_3__1_;
            this.pipeTop.Location = new System.Drawing.Point(321, 226);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(61, 50);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::CSharpe_Game1_Shelby.Properties.Resources.rock_clipart_3__1_;
            this.pipeBottom.Location = new System.Drawing.Point(204, 516);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(61, 50);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::CSharpe_Game1_Shelby.Properties.Resources.speedRacer__1_;
            this.flappyBird.Location = new System.Drawing.Point(54, 400);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(31, 18);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // bottomBoundary
            // 
            this.bottomBoundary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bottomBoundary.Location = new System.Drawing.Point(0, 584);
            this.bottomBoundary.Name = "bottomBoundary";
            this.bottomBoundary.Size = new System.Drawing.Size(499, 17);
            this.bottomBoundary.TabIndex = 8;
            this.bottomBoundary.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CSharpe_Game1_Shelby.Properties.Resources.road__1_;
            this.pictureBox2.Location = new System.Drawing.Point(1011, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1022, 395);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // topboundary
            // 
            this.topboundary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topboundary.Location = new System.Drawing.Point(0, 203);
            this.topboundary.Name = "topboundary";
            this.topboundary.Size = new System.Drawing.Size(499, 17);
            this.topboundary.TabIndex = 10;
            this.topboundary.TabStop = false;
            this.topboundary.Click += new System.EventHandler(this.topboundary_Click);
            // 
            // rock3
            // 
            this.rock3.Image = global::CSharpe_Game1_Shelby.Properties.Resources.rock_clipart_3__1_;
            this.rock3.Location = new System.Drawing.Point(953, 414);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(61, 50);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock3.TabIndex = 11;
            this.rock3.TabStop = false;
            // 
            // rock4
            // 
            this.rock4.Image = global::CSharpe_Game1_Shelby.Properties.Resources.rock_clipart_3__1_;
            this.rock4.Location = new System.Drawing.Point(455, 302);
            this.rock4.Name = "rock4";
            this.rock4.Size = new System.Drawing.Size(61, 59);
            this.rock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock4.TabIndex = 12;
            this.rock4.TabStop = false;
            // 
            // fakecar
            // 
            this.fakecar.Image = global::CSharpe_Game1_Shelby.Properties.Resources.speedRacer__1_;
            this.fakecar.Location = new System.Drawing.Point(12, 371);
            this.fakecar.Name = "fakecar";
            this.fakecar.Size = new System.Drawing.Size(141, 66);
            this.fakecar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fakecar.TabIndex = 13;
            this.fakecar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 601);
            this.Controls.Add(this.fakecar);
            this.Controls.Add(this.rock4);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.topboundary);
            this.Controls.Add(this.bottomBoundary);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBoundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topboundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakecar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bottomBoundary;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox topboundary;
        private System.Windows.Forms.PictureBox rock3;
        private System.Windows.Forms.PictureBox rock4;
        private System.Windows.Forms.PictureBox fakecar;
    }
}

