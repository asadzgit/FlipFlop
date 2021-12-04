using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace flip_flop_1_
{
    public partial class gamewindows : Form
    { 
        game g = new game();
      public static  PictureBox pendingPB1;
       public static  PictureBox pendingPB2;
        Random Loc = new Random();
        List<Point> points = new List<Point>();
        public gamewindows()
        {
            InitializeComponent();
        }
        void getNewLocation()
        {
            for (int i = 0; i < 16; i++)
            {
                points.Add(g.picBox[i].Location);
            }

            for (int i = 0; i < 16; i++)
            {
                int next = Loc.Next(points.Count);
                Point p = points[next];
                g.picBox[i].Location = p;
                points.Remove(p);
            }
        }
        private void gamewindows_Load(object sender, EventArgs e)
        {
            
            g.initializePicture(pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9, pb10, pb11, pb12, pb13, pb14, pb15, pb16);
            g.startscreen(gamename, startButton, timeLabel, timeValueLabel, playagain, resetButton,pause_resume, resumeButton,movesLabel,movesCounter,levelDetail,label1,exitbutton,selectLevel,level1,level2,back);
            g.matchCount = 0;
            getNewLocation();
            updateMovesCounter();
        }
        private void updateMovesCounter()
        {
            movesCounter.Text = Convert.ToString(g.moves); 
        }
    
        private void pb1_Click(object sender, EventArgs e)
        {
            g.picBox[0].Image = Properties.Resources.i1;
            g.pictureBoxID = 0;
            g.doPictureOperations(0);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            g.picBox[1].Image = Properties.Resources.i2;
            g.pictureBoxID = 1;
            g.doPictureOperations(1);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            g.picBox[2].Image = Properties.Resources.i3;
            g.pictureBoxID = 2;
            g.doPictureOperations(2);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }
        private void pb4_Click(object sender, EventArgs e)
        {
            g.picBox[3].Image = Properties.Resources.i4;
            g.pictureBoxID = 3;
            g.doPictureOperations(3);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }
        private void pb7_Click(object sender, EventArgs e)
        {
            g.picBox[4].Image = Properties.Resources.i5;
            g.pictureBoxID = 4;
            g.doPictureOperations(4);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            g.picBox[5].Image = Properties.Resources.i6;
            g.pictureBoxID = 5;
            g.doPictureOperations(5);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }
        private void pb9_Click(object sender, EventArgs e)
        {
            g.picBox[6].Image = Properties.Resources.i7;
            g.pictureBoxID = 6;
            g.doPictureOperations(6);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }
        private void pb10_Click(object sender, EventArgs e)
        {
            g.picBox[7].Image = Properties.Resources.i8;
            g.pictureBoxID = 7;
            g.doPictureOperations(7);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }
      
        private void pb13_Click(object sender, EventArgs e)
        {
            g.picBox[8].Image = Properties.Resources.i9;
            g.pictureBoxID = 8;
            g.doPictureOperations(8);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter();
            checkLevelFailed();
        }

        private void pb14_Click(object sender, EventArgs e)
        {
            g.picBox[9].Image = Properties.Resources.i10;
            g.pictureBoxID = 9;
            g.doPictureOperations(9);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter(); 
            checkLevelFailed();

        }

        private void pb15_Click(object sender, EventArgs e)
        {
            g.picBox[10].Image = Properties.Resources.i11;
            g.pictureBoxID = 10;
            g.doPictureOperations(10);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter(); checkLevelFailed();
        }
       

        private void pb16_Click(object sender, EventArgs e)
        {
            g.picBox[11].Image = Properties.Resources.i12;
            g.pictureBoxID = 11;
            g.doPictureOperations(11);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter(); checkLevelFailed();
        }

        private void pb19_Click(object sender, EventArgs e)
        {
            g.picBox[12].Image = Properties.Resources.i13;
            g.pictureBoxID = 12;
            g.doPictureOperations(12);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter(); checkLevelFailed();
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            g.picBox[13].Image = Properties.Resources.i14;
            g.pictureBoxID = 13;
            g.doPictureOperations(13);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter(); checkLevelFailed();
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            g.picBox[14].Image = Properties.Resources.i15;
            g.pictureBoxID = 14;
            g.doPictureOperations(14);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            movesCounter.Text = Convert.ToString(g.moves);
            checkLevelFailed();
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            g.picBox[15].Image = Properties.Resources.i16;
            g.pictureBoxID = 15;
            g.doPictureOperations(15);
            g.pictureBoxClick(g.pictureBoxID, timer2, timer3);
            updateMovesCounter(); checkLevelFailed();
        }
        public void checkLevelFailed()
        {
            if (g.moves == g.allowedMoves && g.isFinish(g.matchCount) == false)
            timer3.Start();
        }
         private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pendingPB1.Image = Properties.Resources.cover;
            pendingPB2.Image = Properties.Resources.cover;
            pendingPB1 = null;
            pendingPB2 = null; movesCounter.Text = Convert.ToString(g.moves);

        }

        private void playagain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16;i++ )
            {
                g.picBox[i].Enabled = true;
            }
            for (int i = 0; i < 16;i++ )
            {
                g.picBox[i].Cursor = Cursors.Hand;
            }
                playagain.Hide();
            button1_Click(sender, e);
            movesCounter.Text = Convert.ToString(0);
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            levelDetail.Show();
            level1.Hide();
            level2.Hide();
            back.Hide();
            movesLabel.Show();
            movesCounter.Show();
            selectLevel.Hide();
            exitbutton.Hide();
            pause_resume.Show();
            cardsholder.Show();
            g.matchCount = 0;
            g.moves = 0;
            timer1.Start();
            pendingPB1 = null;
            pendingPB2 = null;
            for (int i = 0; i < 16; i++)
            {
                g.picBox[i].Image = Properties.Resources.cover;
            }
            startButton.Hide();
            label1.Show();
            gamename.Hide();
            timer1.Start();
            timeValueLabel.Text =Convert.ToString( timer1);
            timeLabel.Show();
            timeValueLabel.Show();
            resetButton.Show();
            for (int i = 0; i < 16; i++)
            {
                g.picBox[i].Show();
            }
            timeValueLabel.Text =Convert.ToString( 0);
            getNewLocation();
            if (g.level == 0)
                levelDetail.Text = "";
            else 
            levelDetail.Text = "Level: " + Convert.ToString(g.level) + "\nAllowed moves: " + Convert.ToString(g.allowedMoves) + "\n";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeValueLabel.Text =Convert.ToString( Convert.ToInt32( timeValueLabel.Text) +( 1));
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                g.picBox[i].Enabled = true;
            }
            for (int i = 0; i < 16; i++)
            {
                g.picBox[i].Cursor = Cursors.Hand;
            }
            button1_Click(sender, e);
            g.moves = 0;
            movesCounter.Text = Convert.ToString(0);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            g.finish(timeValueLabel, timeLabel, playagain, resetButton, pause_resume);
            movesCounter.Hide();
            movesLabel.Hide();
            levelDetail.Hide();
            if (g.moves == g.allowedMoves && g.isFinish(g.matchCount) == false)
                MessageBox.Show("You lost the game\n");
            else 
                MessageBox.Show("CONGATULATIONS\nYou finished the game in " + Convert.ToString(g.moves) + " moves\n");
                   }
        string s; 
        private void pause_resume_Click(object sender, EventArgs e)
        {
            timer1.Stop ();
            for (int i = 0, j = 0; i < 16; i++)
            {
                if (g.picBox[i].Cursor == Cursors.Hand)
                g.picBox[i].Enabled = false;
            }
            s = timeValueLabel.Text;
            g.pause(pause_resume,resumeButton,exitbutton,resetButton,timeValueLabel);
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            timeValueLabel.Text = s;
            timer1.Start();
            for (int i = 0; i < 16; i++)
            {
                if(g.picBox[i].Cursor==Cursors.Hand)
                g.picBox[i].Enabled = true;
            }
            g.resume(pause_resume, resumeButton, exitbutton, resetButton, timeValueLabel);
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void back_Click(object sender, EventArgs e)
        {
            back.Hide();
            selectLevel.Show();
            level2.Hide();
            level1.Hide();
        }

        private void selectLevel_Click(object sender, EventArgs e)
        {
            level1.Show();
            level2.Show();
            back.Show();
            selectLevel.Hide();
        }

      
        private void level2_Click(object sender, EventArgs e)
        {
            g.level = 2;
           g.allowedMoves = 15;
        }

        private void level1_Click(object sender, EventArgs e)
        {
            g.level = 1;
            g.allowedMoves = 25;
        }
        private void score_Click(object sender, EventArgs e)
        {

        }//fazool

        private void label1_Click_1(object sender, EventArgs e)
        {

        }//fazool
        private void label1_Click(object sender, EventArgs e)
        {

        }//fazool
        private void level1Detail_Click(object sender, EventArgs e)
        {

        }

        private void level2detail_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

    }
}