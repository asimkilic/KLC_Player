using KLC_Player.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLC_Player
{
    public partial class KLCPlayer : Form
    {
        Button activeButton;
        int ekranGenisligi, ekranYuksekligi;
      
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Resources";

        public KLCPlayer()
        {

            InitializeComponent();
            ekranGenisligi = Screen.PrimaryScreen.Bounds.Width;
            ekranYuksekligi = Screen.PrimaryScreen.Bounds.Height;
            this.Text = string.Empty;
            this.ControlBox = false;
            MiniTitleButtonsOff();
            
          

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MiniTitleButtonsOff()
        {
            button9.Visible = false;
            button22.Visible = false;
            button10.Visible = false;
            label1.Visible = true;

        }
        private void MiniTitleButtonsOn()
        {
            button9.Visible = true;
            button22.Visible = true;
            button10.Visible = true;
            label1.Visible = false;
        }

        private void ButtonHoverOn(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(255, 136, 0);
        }

        private void ButtonHoverOff(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(43, 43, 43);
        }
        private void ButtonActive(object sender, EventArgs e)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(50, 50, 50);
            }
            activeButton = sender as Button;
            activeButton.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
           

         
            // This will get the current PROJECT directory parents
             //projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName+ "\\Sounds\\esrarengizSarki-6snV.wav";

            axWindowsMediaPlayer1.URL = projectDirectory+ "\\esrarengizSarki-6snV.wav";      
            axWindowsMediaPlayer1.Ctlcontrols.play();
      
            label7.Text = "Esrarengiz Şarkı";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
            axWindowsMediaPlayer1.URL = projectDirectory + "\\araya-cikma-anonsV.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
         
            label7.Text = "Molaya Çıkma Anonsu";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
            axWindowsMediaPlayer1.URL = projectDirectory + "\\nihahahahaV.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
           
            label7.Text = "Kahkaha efekti";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button24.Visible = false;
            MiniTitleButtonsOff();
            panel1.Show();
            panel2.Show();
            panel3.Show();
            panel4.Show();
            panel6.Show();
            //panel7.Show();
            panel8.Show();
            panel9.Show();
            this.Size = new Size(1215, 721);
            //Point sagdakiPoint = this.Location;
            //this.Location = new Point(sagdakiPoint.X - this.Size.Width, (ekranYuksekligi / 2) - (this.Height / 2));
            ReallyCenterToScreen();
            this.Opacity = 1d;
            ButonIsimleriniBuyut();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MiniTitleButtonsOn();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel6.Hide();
            //panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            button6.Visible = true;
            button24.Visible = true;
            //this.Size = new Size(212, 542);
            this.Size = new Size(100, 542);
            ButonIsimleriniKucult();
            this.Location = new Point(ekranGenisligi - this.Size.Width, ekranYuksekligi / 2 - (this.Size.Height / 2));
            this.Opacity = 0.45d;

        }

        private void ButonIsimleriniKucult()
        {
            panel5.Width = this.Width - 1;
            button1.Text = " Esrarengiz";
            button2.Text = " Mola";
            button3.Text = " Kahkaha";
            button4.Text = " Gülme";
            button5.Text = " Yanlış Cevap";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextAlign = ContentAlignment.MiddleLeft;


            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void ButonIsimleriniBuyut()
        {
            panel5.Width = 206;
            button1.Text = "          Esrarengiz Şarkı";
            button2.Text = "          Araya Çıkma";
            button3.Text = "          Kahkaha";
            button4.Text = "          Gülme Efekti";
            button5.Text = "          Yanlış Cevap";

            button1.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextAlign = ContentAlignment.MiddleLeft;

        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void recent1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KLCPlayer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                ShowIcon = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;


        }

        private void KLCPlayer_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "KLC Player Hala Çalışıyor";
            notifyIcon1.BalloonTipTitle = "KLC Player";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = projectDirectory + "\\gulme-efektiV.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
           
            label7.Text = "Gülme Efekti ";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = projectDirectory + "\\yanlis-cevapV.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
          
            label7.Text = "Yanlış Cevap";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
         
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != null)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
          
        }

        private void button23_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = projectDirectory + "\\sinav-basladi.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();

            label7.Text = "SınaV Başladı";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        protected void ReallyCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
    }
}

#region How to use notifyicon

/*
* 
* How to use notifyIcon => https://www.youtube.com/watch?v=tCHOdDzUFIY&ab_channel=winforms
*/
#endregion
