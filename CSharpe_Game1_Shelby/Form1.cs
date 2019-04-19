using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpe_Game1_Shelby
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 0;
        int Inscore = 0;
        int timePassed = 0;

        public Form1()
        {
            InitializeComponent();
            

            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
           

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            rock3.Left -= pipeSpeed;
            rock4.Left -= pipeSpeed;
            ground.Left -= pipeSpeed;
            pictureBox2.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            fakecar.Top += gravity;
            scoreText.Text = "" + Inscore;
            timePassed += 1;
            
            if(timePassed == 50)
            {
                pipeSpeed += 1;
                timePassed = 0;
            }

            if (pictureBox2.Left < -1022)
            {
                pictureBox2.Left = 1040;
            }
            else if (ground.Left < -1022)
            {
                ground.Left = 1042;
            }




            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }
            else if(rock4.Left < - 200)
            {
                rock4.Left = 2500;
                Inscore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                Inscore += 1;
            }
            else if (rock3.Left < -75)
            {
                rock3.Left = 1500;
                Inscore += 1;
            }


            if (flappyBird.Bounds.IntersectsWith(bottomBoundary.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(topboundary.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(rock3.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(rock4.Bounds))
            {
                endGame();
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(gameTimer.Enabled == false)
                {
                    pipeBottom.Left =1500;
                    pipeTop.Left = 7150;
                    rock4.Left = 2500;
                    rock3.Left = 5700;
                    Inscore = 0;
                    flappyBird.Top = 350;
                    fakecar.Top = 350;
                    pipeSpeed = 5;
                    endText1.Visible = false;
                    endText2.Visible = false;
                    gameDesigner.Visible = false;
                    gameTimer.Enabled = true;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                jumping = true;
                gravity = -4;

            }

            if(e.KeyCode == Keys.Down)
            {
                jumping = true;
                gravity = 4;
            }

            if(e.KeyCode == Keys.Space)
            {
                if(gameTimer.Enabled == true)
                {
                    gameTimer.Enabled = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jumping = false;
                gravity = 0;

            }
            if(e.KeyCode == Keys.Down)
            {
                jumping = false;
                gravity = 0;
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score is: " + Inscore;
            gameDesigner.Text = "Game Designed By Shelby Shelby";
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }

        private void topboundary_Click(object sender, EventArgs e)
        {

        }
    }
}