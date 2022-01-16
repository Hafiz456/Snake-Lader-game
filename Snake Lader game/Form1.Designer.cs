
namespace Snake_Lader_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boardPic = new System.Windows.Forms.PictureBox();
            this.token3Pic = new System.Windows.Forms.PictureBox();
            this.token4Pic = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.dicePic = new System.Windows.Forms.PictureBox();
            this.lblDice = new System.Windows.Forms.Label();
            this.token2Pic = new System.Windows.Forms.PictureBox();
            this.token1Pic = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.lblPointer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boardPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.token3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.token4Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.token2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.token1Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPic
            // 
            this.boardPic.Image = global::Snake_Lader_game.Properties.Resources.board;
            this.boardPic.Location = new System.Drawing.Point(41, 0);
            this.boardPic.Name = "boardPic";
            this.boardPic.Size = new System.Drawing.Size(992, 837);
            this.boardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boardPic.TabIndex = 0;
            this.boardPic.TabStop = false;
            // 
            // token3Pic
            // 
            this.token3Pic.Image = global::Snake_Lader_game.Properties.Resources.goti2;
            this.token3Pic.Location = new System.Drawing.Point(1154, 51);
            this.token3Pic.Name = "token3Pic";
            this.token3Pic.Size = new System.Drawing.Size(34, 38);
            this.token3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.token3Pic.TabIndex = 1;
            this.token3Pic.TabStop = false;
            // 
            // token4Pic
            // 
            this.token4Pic.Image = global::Snake_Lader_game.Properties.Resources.goti3;
            this.token4Pic.Location = new System.Drawing.Point(1278, 51);
            this.token4Pic.Name = "token4Pic";
            this.token4Pic.Size = new System.Drawing.Size(35, 38);
            this.token4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.token4Pic.TabIndex = 2;
            this.token4Pic.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRoll.Location = new System.Drawing.Point(1139, 753);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(186, 51);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Dice Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // dicePic
            // 
            this.dicePic.Image = global::Snake_Lader_game.Properties.Resources.dice;
            this.dicePic.Location = new System.Drawing.Point(1111, 506);
            this.dicePic.Name = "dicePic";
            this.dicePic.Size = new System.Drawing.Size(250, 241);
            this.dicePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dicePic.TabIndex = 4;
            this.dicePic.TabStop = false;
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Location = new System.Drawing.Point(1044, 156);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(55, 25);
            this.lblDice.TabIndex = 5;
            this.lblDice.Text = "Dice :";
            // 
            // token2Pic
            // 
            this.token2Pic.Image = global::Snake_Lader_game.Properties.Resources.goti3;
            this.token2Pic.Location = new System.Drawing.Point(75, 775);
            this.token2Pic.Name = "token2Pic";
            this.token2Pic.Size = new System.Drawing.Size(34, 38);
            this.token2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.token2Pic.TabIndex = 6;
            this.token2Pic.TabStop = false;
            // 
            // token1Pic
            // 
            this.token1Pic.Image = global::Snake_Lader_game.Properties.Resources.goti2;
            this.token1Pic.Location = new System.Drawing.Point(25, 775);
            this.token1Pic.Name = "token1Pic";
            this.token1Pic.Size = new System.Drawing.Size(34, 37);
            this.token1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.token1Pic.TabIndex = 7;
            this.token1Pic.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(1044, 191);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(27, 25);
            this.lblX.TabIndex = 9;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(1044, 230);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 25);
            this.lblY.TabIndex = 10;
            this.lblY.Text = "Y:";
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Location = new System.Drawing.Point(1188, 374);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(0, 25);
            this.lblStatus1.TabIndex = 11;
            // 
            // lblPointer
            // 
            this.lblPointer.AutoSize = true;
            this.lblPointer.BackColor = System.Drawing.SystemColors.Control;
            this.lblPointer.Location = new System.Drawing.Point(1039, 269);
            this.lblPointer.Name = "lblPointer";
            this.lblPointer.Size = new System.Drawing.Size(144, 25);
            this.lblPointer.TabIndex = 12;
            this.lblPointer.Text = " Current Pointer: ";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(1039, 314);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(89, 25);
            this.lblPlayer.TabIndex = 13;
            this.lblPlayer.Text = " Player # :";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(1188, 419);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(0, 25);
            this.lblStatus2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1039, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = " Status Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1044, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = " Status Player 2";
            // 
            // btmRestart
            // 
            this.btmRestart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btmRestart.Location = new System.Drawing.Point(1139, 810);
            this.btmRestart.Name = "btmRestart";
            this.btmRestart.Size = new System.Drawing.Size(186, 51);
            this.btmRestart.TabIndex = 17;
            this.btmRestart.Text = " Restart Game";
            this.btmRestart.UseVisualStyleBackColor = false;
            this.btmRestart.Click += new System.EventHandler(this.btmRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 873);
            this.Controls.Add(this.btmRestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPointer);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.token1Pic);
            this.Controls.Add(this.token2Pic);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.dicePic);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.token4Pic);
            this.Controls.Add(this.token3Pic);
            this.Controls.Add(this.boardPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boardPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.token3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.token4Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.token2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.token1Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boardPic;
        private System.Windows.Forms.PictureBox token3Pic;
        private System.Windows.Forms.PictureBox token4Pic;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox dicePic;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.PictureBox token2Pic;
        private System.Windows.Forms.PictureBox token1Pic;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblPointer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btmRestart;
    }
}

