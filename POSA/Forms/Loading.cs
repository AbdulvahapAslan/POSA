﻿using System.Data;
namespace POSA.Forms
{
    public partial class Loading : Form
    {
        public Loading(string requestedPage, int interval)
        {
            InitializeComponent();
            RequestedPage = requestedPage;
            Interval = interval;
        }
        public string RequestedPage = "";
        public int Interval = 1000;
        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Interval = Interval;
            if (RequestedPage.Contains("TAKE"))
            {
                var sp = new NewProduct(Convert.ToInt32(RequestedPage.Split('-')[1]));
                sp.Name = "TAKE";
                sp.Show();
            }
            else
            {
                switch (RequestedPage)
                {
                    case "Mainpage":
                        var mp = new Mainpage();
                        mp.Name = "Anasayfa";
                        mp.Show();
                        break;
                    case "NewProduct":
                        var sp = new NewProduct(0);
                        sp.Name = "Ürün Giriş";
                        sp.Show();
                        break;
                    default:
                        break;
                }
            }
            
        }
        int tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick > 0)
            {
                this.Close();
                timer1.Enabled = false;
                Form frm;
                if (RequestedPage.Contains("TAKE"))
                {
                    frm = Application.OpenForms.Cast<Form>().Where(x => x.Name.Contains("TAKE")).FirstOrDefault();
                }
                else
                {
                    switch (RequestedPage)
                    {
                        case "Mainpage":
                            frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Anasayfa").FirstOrDefault();
                            break;
                        case "NewProduct":
                            frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Ürün Giriş").FirstOrDefault();
                            break;
                        default:
                            frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "Anasayfa").FirstOrDefault();
                            break;
                    }
                }
                
                frm.Opacity = 100;
            }
            tick++;
        }
    }
}
