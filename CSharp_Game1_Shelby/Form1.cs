using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Game1_Shelby
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 8;
        int gravity = 5;
        int Inscore = 0;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Enabled = true;
            endText1.Text = "Game Over!";
            endText2.Text = "Your Final Score is: " + Inscore;
            gameDesigner.Text = "Game designed by Shelby Shelby\nPress [enter] to play again.";

            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;

            scoreText.Text = "" + Inscore;

            //if(flappyBird.Bounds.IntersectsWith(ground.Bounds))
            //{
            //    endGame();
            //}
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }

            if(pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }

            if(pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                Inscore += 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gameTimer.Enabled == false)
                {
                    pipeBottom.Left = 800;
                    pipeTop.Left = 1150;
                    Inscore = 0;
                    flappyBird.Top = 200;
                    endText1.Visible = false;
                    endText2.Visible = false;
                    gameDesigner.Visible = false;
                    gameTimer.Enabled = true;
                }
            }
            if(e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Text = "Game Over!";
            endText2.Text = "Your Final Score is: " + Inscore;
            gameDesigner.Text = "Game designed by Shelby Shelby\nPress [enter] to play again.";

            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }
    }
}
