using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JO_Kursuse
{
    public partial class JO_Form2 : Form
    {
        List<Color> MyColors = new List<Color>();
        int kx = 3, ky = 4;
        int k;
        Button[] JO_btn;
        Color[] JO_btnColor;
        Random rand = new Random();
        int n1, n2;

        public JO_Form2()
        {
            InitializeComponent();
            JO_MyColor_Create();
            JO_btn_Create();
            k = kx * ky;
            JO_btnColor = new Color[k];
        }

        public void JO_MyColor_Create()
        {
            MyColors.Clear();
            MyColors.Add(Color.Pink);
            MyColors.Add(Color.Green);
            MyColors.Add(Color.Blue);
            MyColors.Add(Color.Purple);
            MyColors.Add(Color.Black);
            MyColors.Add(Color.Yellow);
        }

        public void JO_btn_Create()
        {
            int dx = JO_panel1.Width / kx;
            int dy = JO_panel1.Height / ky;
            k = kx * ky;
            JO_btn = new Button[k];
            for (int i = 0; i < k; i++)
            {
                JO_btn[i] = new Button();
                JO_panel1.Controls.Add(JO_btn[i]);
                JO_btn[i].Click += new EventHandler(JO_btn_Click);
                JO_btn[i].Width = dx;
                JO_btn[i].Height = dy;
                int veerg = i % kx;
                int rida = i / kx;
                JO_btn[i].Left = veerg * dx;
                JO_btn[i].Top = rida * dy;
                int v = i % MyColors.Count;
                JO_btn[i].BackColor = MyColors[v];
            }
        }

        private void JO_timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < k; i++)
            {
                JO_btn[i].BackColor = Color.Transparent;
            }
            JO_timer1.Enabled = false;
        }

        private void JO_timer2_Tick(object sender, EventArgs e)
        {
            if (JO_btnColor[n1] == JO_btnColor[n2])
            {
                JO_btn[n1].Visible = false;
                JO_btn[n2].Visible = false;
            }
            else
            {
                JO_btn[n1].BackColor = Color.Transparent;
                JO_btn[n2].BackColor = Color.Transparent;
            }
            n1 = n2 = -1;
            JO_timer2.Enabled = false;
        }

        private void JO_btnUus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < k; i++)
            {
                JO_btnColor[i] = Color.Transparent;
            }
            int kk = k / 2;
            for (int i = 0; i < kk; i++)
            {
                int juhus;
                do
                {
                    juhus = rand.Next(k);
                } while (JO_btnColor[juhus] != Color.Transparent);
                JO_btnColor[juhus] = MyColors[i];
                do
                {
                    juhus = rand.Next(k);
                } while (JO_btnColor[juhus] != Color.Transparent);
                JO_btnColor[juhus] = MyColors[i];
            }
            for (int i = 0; i < k; i++)
            {
                JO_btn[i].BackColor = JO_btnColor[i];
                JO_btn[i].Visible = true;
            }
            JO_timer1.Interval = 5000;
            JO_timer1.Enabled = true;
            JO_timer1.Start();
            n1 = n2 = -1;
        }

        public void JO_btn_Click(object sender, EventArgs e)
        {
            /*
            Button JO_btn = sender as Button;
            if (JO_btn.BackColor == Color.Black)
            {
                JO_btn.BackColor = Color.Transparent;
            }
            */
            int number = Array.IndexOf(JO_btn, (Button)sender);
            JO_btn[number].BackColor = JO_btnColor[number];
            if (n1 == -1)
                n1 = number;
            else
            {
                n2 = number;
                JO_timer2.Interval = 1000;
                JO_timer2.Enabled = true;
            }
        }
    }
}
