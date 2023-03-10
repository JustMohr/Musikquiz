using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace Musik
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();//=Mediaplayer1
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();//=Mediaplayer2
        WMPLib.WindowsMediaPlayer player3 = new WMPLib.WindowsMediaPlayer();//=Mediaplayer3

        //Timer
        Timer pretimer = new Timer();
        Timer quiztimer = new Timer();
        Timer rfshow = new Timer();

        //Variable
        public int pret = 3;
        public int quizt = 70;
        public int quiznumber =0;
        public int rftime = 2;
        public int richtig =0;
        public int falsch = 0;

        public bool answer;


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void StQuiz_Click(object sender, EventArgs e)
        {
            StQuiz.Visible = false;
            StLable.Visible = false;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            rf.Visible = false;
            lbltext.Visible = false;
            eins.ForeColor = System.Drawing.Color.Black;
            zwei.ForeColor = System.Drawing.Color.Gray;
            drei.ForeColor = System.Drawing.Color.Gray;

            panelquizelement.Visible = true; //pnltimer ist auf panelquizelement gezeichnet
            pnltimer.Visible = true;

            prestart();

        }

        private void prestart()
        {
            StQuiz.Visible = false;
            StLable.Visible = false;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            rf.Visible = false;
            //Endpanel
            endpanel.Visible = false;



            pretimer.Interval = 1000;
            pretimer.Tick += new EventHandler(pre1_Tick);
            pretimer.Start();
            //Console.WriteLine("no");
        }

        private void pre1_Tick(object sender, EventArgs e)
        {
            pret--;
            pretimeshow.Text = pret.ToString();

            if (pret == 0)
            {
                pretimer.Stop();
                pret = 3;

                Mainquiz();
                eins.Visible = true;
                zwei.Visible = true;
                drei.Visible = true;

            }
        }

        private void Mainquiz()
        {
            panelquizelement.Visible = true; //pnltimer ist auf panelquizelement gezeichnet
            pnltimer.Visible = false;


            if (quiznumber == 0)
            {
                player1.URL = "Lieder\\3.mp3";
                player1.controls.play();
                eins.Visible = true;
                zwei.Visible = true;
                drei.Visible = true;
                eins.ForeColor = System.Drawing.Color.Black;
                zwei.ForeColor = System.Drawing.Color.Gray;
                drei.ForeColor = System.Drawing.Color.Gray;

            }
            else if (quiznumber == 1)
            {
                player2.URL = "Lieder\\1.mp3";
                player2.controls.play();
                eins.Visible = true;
                zwei.Visible = true;
                drei.Visible = true;
                eins.ForeColor = System.Drawing.Color.Gray;
                zwei.ForeColor = System.Drawing.Color.Black;
                drei.ForeColor = System.Drawing.Color.Gray;

            }
            else if(quiznumber == 2)
            {
                player3.URL = "Lieder\\2.mp3";
                player3.controls.play();
                eins.Visible = true;
                zwei.Visible = true;
                drei.Visible = true;
                eins.ForeColor = System.Drawing.Color.Gray;
                zwei.ForeColor = System.Drawing.Color.Gray;
                drei.ForeColor = System.Drawing.Color.Black;

            }

            if (quiznumber == 0)
            {
                quiztimer.Tick += new EventHandler(quiztimer_Tick);
                quiztimer.Interval = 1000;
                quiztimer.Start();
            }
            else
            {
                quiztimer.Start();
            }

        }





        private void quiztimer_Tick(object sender, EventArgs e)
        {

            quizt--;

            timershow.Text = quizt.ToString();

            if (quizt == 69)
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
            }
            else if (quizt == 10)
            {

            }else if (quizt == 0)
            {
                /*quiztimer.Stop();
                quizt = 70;*/
                answer = false;

                checke();
            }
        }





        private void checke()
        {
            quiztimer.Stop();
            quizt = 70;
            quiznumber++;

            eins.Visible = false;
            zwei.Visible = false;
            drei.Visible = false;

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;

            pnltimer.Visible = true;
            readylbl.Visible = false;
            pretimeshow.Visible = false;

            rf.Visible = true;

            if (quiznumber == 1)
            {
                //Timer rftimer
                rfshow.Tick += new EventHandler(rfshow_Tick);
                rfshow.Interval = 1000;
            }


            if (answer== true)
            {
                rf.ForeColor = System.Drawing.Color.Green;
                rf.Text = "richtig";
                //answer = false;

                richtig++;
            }
            else
            {
                rf.ForeColor = System.Drawing.Color.Red;
                rf.Text = "falsch";
                //answer = false;

                falsch++;
            }

            answer = false;
            rfshow.Start();
            
            
        }

        private void rfshow_Tick(object sender, EventArgs e)
        {
            rftime--;
            if (rftime == 0)
            {
                if (quiznumber == 3)
                {
                    ende();
                }
                else
                {
                    rfshow.Stop();
                    rftime = 3;
                    player1.controls.stop();
                    player2.controls.stop();
                    player3.controls.stop();

                    readylbl.Visible = true;
                    pretimeshow.Visible = true;
                    rf.Visible = false;

                    pretimeshow.Text = "3";
                    rftime = 2;
                    timershow.Text = "70";

                    pretimer.Start();
                }
            }
        }

        private void ende()
        {
            player1.controls.stop();
            player2.controls.stop();
            player3.controls.stop();

            endpanel.Visible = true;
            lblr.Text = richtig + " richtig";
            lblf.Text = falsch + " falsch";

            lblr.ForeColor = System.Drawing.Color.Green;
            lblf.ForeColor = System.Drawing.Color.Red;

            if (falsch == 0)
            {
                lblrichtig.ForeColor = System.Drawing.Color.Orange;
                lblrichtig.Visible = true;
                richtig = 0;
                falsch = 0;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }








        private void button1_Click(object sender, EventArgs e)
        {

            if (quiznumber == 1)
            {
                answer = true;
                checke();
            }
            else
            {
                answer = false;
                checke();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (quiznumber == 0)
            {
                answer = true;
                checke();
            }
            else
            {
                answer = false;
                checke();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quiznumber == 2)
            {
                answer = true;
                checke();
            }
            else
            {
                answer = false;
                checke();
            }
        }








        private void panelquizelement_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rf_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void eins_Click(object sender, EventArgs e)
        {

        }

        private void pnltimer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
