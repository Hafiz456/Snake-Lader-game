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
    class player
    {
        
        public int[] positions;
        public int[,] pointers;
        public bool tokenActive;
        public int x, y;
        public int currentPoint;

        public PictureBox tokenPic;
        public Label lblStatus;
        public player(Label lblStatus,PictureBox tokenPic )
            {
                positions = new int[100];
                pointers = new int[105, 2];
                tokenActive = false;
                snakeBitingPositions();
                laddersPositions();
                initializePointers();
                this.lblStatus = lblStatus;
                this.tokenPic = tokenPic;
            }
           

        private void snakeBitingPositions()
        {
            positions[17] = 7;
            positions[54] = 34;
            positions[62] = 19;
            positions[64] = 60;
            positions[87] = 36;
            positions[93] = 73;
            positions[95] = 75;
            positions[98] = 79;

        }
        private void laddersPositions()
        {
            positions[1] = 38;
            positions[4] = 14;
            positions[9] = 31;
            positions[21] = 42;
            positions[28] = 84;
            positions[51] = 67;
            positions[72] = 91;
            positions[80] = 99;
        }
        private void initializePointers()
        {

            int j = 0, l = 0, m = 0;
            for (int i = 0; i < 100; i++)
            {
                if ((i >= 0 && i <= 9) || (i >= 20 && i <= 29)
                || (i >= 40 && i <= 49) || (i >= 60 && i <= 69)
                || (i >= 80 && i <= 89))
                {
                    if (i == 20 || i == 40
             || i == 60 || i == 80)
                    {

                        j = 0;
                        m += 83;

                    }
                    pointers[i, 0] = 150 + j;
                    j += 83;
                    pointers[i, 1] = 775 - m;
                }
                else
                {
                    if (i == 10 || i == 30
                    || i == 50 || i == 70 || i == 90)
                    {
                        l = 0;
                        m += 83;
                    }
                    pointers[i, 0] = 897 - l;
                    l += 83;
                    pointers[i, 1] = 775 - m;


                }

            }

        }
        private bool snakeBitted(int position)
        {
            position += 1;
            if (position == 17 || position == 54 || position == 62 || position == 64
                || position == 87 || position == 93 || position == 95 || position == 98)
                return true;
            else
                return false;
        }
        public int snakeTail(int currentPosition)
        {
            if (snakeBitted(currentPosition))
            {
                lblStatus.BackColor = Color.Red;
                lblStatus.Text = "You were Bitten at : " + (currentPosition + 1) + " to " + (positions[currentPosition + 1] );
                return positions[currentPosition + 1] - 1;
            }
            else
                return currentPosition;
        }
        private bool goUp(int position)
        {
            position += 1;
            if (position == 1 || position == 4 || position == 9 || position == 21
                || position == 28 || position == 51 || position == 72 || position == 80)
                return true;
            else
                return false;
        }
        public int ladderPosition(int currentPosition)
        {
            if (goUp(currentPosition))
            {
                lblStatus.BackColor = Color.Aqua;
                lblStatus.Text = "You went Up from : " + (currentPosition + 1) +" to "+ (positions[currentPosition + 1] );
                return positions[currentPosition + 1] - 1;
            }
            else
                return currentPosition;
        }
    }
}
