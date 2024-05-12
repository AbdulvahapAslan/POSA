using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSA.Forms
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        
        private void Loading_Load(object sender, EventArgs e)
        {
            var mp = new Mainpage();
            mp.Name = "Anasayfa";
            mp.Show();
        }
        int tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick > 0)
            {
                this.Hide();
                timer1.Enabled = false;
                var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Anasayfa").FirstOrDefault();
                frm.Opacity = 100;
            }
            tick++;
        }
    }
}
