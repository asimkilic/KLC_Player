using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLC_Player
{
    public partial class Form1 : Form
    {
        Button activeButton;
        public Form1()
        {
            InitializeComponent();
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
        private void ButtonActive(object sender,EventArgs e)
        {
            if(activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(50, 50, 50);
            }
            activeButton = sender as Button;
            activeButton.BackColor = Color.FromArgb(31, 31, 31);
        }

        #region Button Clicks

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonActive(sender, e);
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
        #endregion
    }
}
