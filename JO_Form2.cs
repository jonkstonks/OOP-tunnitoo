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

        public JO_Form2()
        {
            InitializeComponent();
            JO_MyColor_Create();
            k = kx * ky;
        }

        public void JO_MyColor_Create()
        {
            MyColors.Clear();
            MyColors.Add(Color.Pink);
            MyColors.Add(Color.Green);
            MyColors.Add(Color.Blue);
            MyColors.Add(Color.Purple);
            MyColors.Add(Color.DarkOrchid);
            MyColors.Add(Color.Black);
            MyColors.Add(Color.Gainsboro);
        }
    }
}
