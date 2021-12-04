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
      class game
    {
        public  int moves;
        public  int matchCount;
        public int level;
        public int allowedMoves;
        public List<PictureBox> picBox = new List<PictureBox>();
        public int pictureBoxID; 
        public game()
        {
            moves = 0;
            level = 0;
            allowedMoves = 10000;
        }
         public void initializePicture(PictureBox pb1,PictureBox pb2,PictureBox pb3,PictureBox pb4,PictureBox pb5,PictureBox pb6, PictureBox pb7,PictureBox pb8,PictureBox pb9, PictureBox pb10, PictureBox pb11, PictureBox pb12, PictureBox pb13, PictureBox pb14, PictureBox pb15, PictureBox pb16)
          {
            picBox.Add(pb1); picBox.Add(pb2); picBox.Add(pb3); picBox.Add(pb4);
            picBox.Add(pb5); picBox.Add(pb6); picBox.Add(pb7); picBox.Add(pb8);
            picBox.Add(pb9); picBox.Add(pb10); picBox.Add(pb11); picBox.Add(pb12);
            picBox.Add(pb13); picBox.Add(pb14); picBox.Add(pb15); picBox.Add(pb16);
            
            }

        public void startscreen(Label gamename,Button start,Label time,Label timevalue,Button playagain,Button reset,Button pause,Button resume,Label movesLab,Label movesCount,Label levelDet,Label lab1,Button exit,Button levelSelect,Button lev1 ,Button lev2,Button back )
        {
            gamename.Show();
            start.Show();
            time.Hide();
            timevalue.Hide();
            playagain.Hide();
            reset.Hide();
            pause.Hide();
            resume.Hide();
            hidePictureBox();
            movesLab.Hide();
            movesCount.Hide();
            levelDet.Hide();
            lab1.Hide();
            exit.Show();
            levelSelect.Show();
            lev1.Hide();
            lev2.Hide();
            back.Hide();

        }
          public void pictureBoxClick(int i,Timer t2,Timer t3)
          {
             if( gamewindows.pendingPB1!=null && gamewindows.pendingPB2!=null)
             {
                 if (match(gamewindows.pendingPB1, gamewindows.pendingPB2) == true)
                 {
                     if (i % 2 == 0)
                         doMatchOperations(i, i + 1);
                     else if (i % 2 != 0)
                         doMatchOperations(i, i - 1);
                     if (isFinish(matchCount))
                     {
                         t3.Start();
                     }
                 }
                 else
                 {
                     moves++;
                     t2.Start();            
                 }
                }
              
            
          }
        public void doPictureOperations(int j)
        {
           
           
            if (gamewindows.pendingPB1 == null)
            {
                gamewindows.pendingPB1 = picBox[j];
            }
            else if (gamewindows.pendingPB1 != null && gamewindows.pendingPB1 != picBox[j] && gamewindows.pendingPB2 == null)
            {
                gamewindows.pendingPB2 = picBox[j];
            }            
        }
        public void doMatchOperations(int j,int k)
        {
              matchCount++;
              moves++;
              gamewindows.pendingPB1 = null;
              gamewindows.pendingPB2 = null;
              picBox[j].Enabled = false;
              picBox[k].Enabled = false;
              picBox[j].Cursor = Cursors.No;
              picBox[k].Cursor = Cursors.No;
        }
        public bool match(PictureBox p1, PictureBox p2)
        {
            return p1.Tag == p2.Tag;
        }
        public  bool isFinish(int m)
        {
                         
                return m == 8;
        }
        public  void finish(Label timeValuelabel,Label time, Button playagain, Button reset,Button pause )
        {
            hidePictureBox();
            timeValuelabel.Text = Convert.ToString(0);
            timeValuelabel.Hide();
             playagain.Show();
            reset.Hide(); pause.Hide(); time.Hide();
        }
        public void hidePictureBox()
        {
            for (int i = 0; i < 16; i++)
                picBox[i].Hide();
            
        }
        public void pause(Button pause,Button resume, Button exit,Button reset,Label timeValue)
        {
            pause.Hide(); reset.Hide();
            exit.Show(); resume.Show();     
        }
        public void resume(Button pause,Button resume, Button exit,Button reset,Label timeValue)
        {
            pause.Show(); reset.Show();
            exit.Hide(); resume.Hide();
        }
    }
     
}