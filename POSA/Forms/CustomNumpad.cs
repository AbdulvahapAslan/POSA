using System;

namespace POSA.Forms
{
    public partial class CustomNumpad : Form
    {
        private Random random;
        private Point originalLocation;
        private int shakeAmplitude = 7; // Titreşim genliği
        private int shakeDuration = 20; // Titreşim süresi (tick sayısı)
        private int shakeCount = 0;
        public CustomNumpad()
        {
            InitializeComponent();
            this.TopMost = true;
            random = new Random();
            originalLocation = this.Location;
            tmr.Interval = 40; // Timer interval süresi
            tmr.Enabled = false;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CustomNumpad_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            var tb = Sales.FocusedTB;
            if (tb is not null)
            {
                if (tb.Text.Length > 0)
                {
                    tb.Text += ".";
                }
                else
                {
                    StartShake();
                }
            }
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (shakeCount < shakeDuration)
            {
                int offsetX = random.Next(-shakeAmplitude, shakeAmplitude);
                int offsetY = random.Next(-shakeAmplitude, shakeAmplitude);
                this.Location = new Point(originalLocation.X + offsetX, originalLocation.Y + offsetY);
                shakeCount++;
            }
            else
            {
                this.Location = originalLocation; // Orijinal konuma geri döndür
                tmr.Enabled = false; // Titreme bittiğinde Timer'ı durdur
            }
        }
        private void StartShake()
        {
            shakeCount = 0;
            originalLocation = this.Location;
            tmr.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Sales.FocusedTB.Text = "";
        }
        private void btnGeneralNumbers_Click(object sender, EventArgs e)
        {
            var tb = Sales.FocusedTB;
            if (tb is not null)
            {
                tb.Text += (sender as Button).Text;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Sales.FocusedTB.Focus();
            SendKeys.Send("{ENTER}");
        }
    }
}
