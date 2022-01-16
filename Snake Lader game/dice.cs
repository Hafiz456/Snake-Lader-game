using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Snake_Lader_game
{
    class dice
    {
        public static int diceRoll(PictureBox pb) {

            int ran = 0;
            Random rand = new Random();
            ran = rand.Next(1, 7);
            pb.ImageLocation = ran + ".png";
            return ran;
        }
        public static void CheckWinner(player p,Button btnRoll,int point) {
            if (point >= 99)
            {
                p.lblStatus.Text = "You Won";
                btnRoll.Visible = false;
                
                string message = "Do you want to Restart?";
                string title = "Game Over";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else { 
                    
                }
            }
                
        }
        
        
    }
}
