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
    public partial class Recent : UserControl
    {
        public Recent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemSelected.Invoke(((PictureBox)sender).Tag, e);
        }
        public event EventHandler ItemSelected = null;
    }
}
