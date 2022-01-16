using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Lader_game
{
    public partial class Form1 : Form
    {
        bool player0orPlayer1;
        int ran;
           player p0,p1,p;

        public void btmRestart_Click(object sender, EventArgs e)
        {
            btnRoll.Visible = true;
            Application.Restart();
        }

        public Form1()
        {
            InitializeComponent();

            p0 = new player(lblStatus1,token1Pic);
            p1 = new player(lblStatus2,token2Pic);
            player0orPlayer1 = false;


        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            

            if (!player0orPlayer1)
            {
                p = p0;
                lblPlayer.Text = "Player # :" + 1;
            }

            else
            {
                p = p1;
                lblPlayer.Text = "Player # :" + 2;
            }
            player0orPlayer1 = !player0orPlayer1;

            ran = dice.diceRoll(dicePic);
            lblDice.Text = "Dice: " + ran;
            if (p.tokenActive)
            {
                p.currentPoint += ran;
                p.currentPoint = p.snakeTail(p.currentPoint);
                p.currentPoint = p.ladderPosition(p.currentPoint);
                lblPointer.Text = "Current Pointer: " + (p.currentPoint + 1);
                dice.CheckWinner(p, btnRoll, p.currentPoint);

                p.x = p.pointers[p.currentPoint, 0];
                p.y = p.pointers[p.currentPoint, 1];

                p.tokenPic.Location = new Point(p.x,p.y);
                lblX.Text = "X:" + p.x;
                lblY.Text = "Y:" + p.y;
            }
            if (!p.tokenActive && ran == 6)
            {
                if(p==p0)
                    p.lblStatus.Text = "Your Red Piece is ***OUT***";
                else if(p==p1)
                    p.lblStatus.Text = "Your Green Piece is ***OUT***";
                p.tokenActive = true;
                lblX.Text = "X:" + p.x;
                lblY.Text = "Y:" + p.y;
                p.currentPoint = -1;
            }


        }
    }
}

