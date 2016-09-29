using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                vScrollBar2.Value = vScrollBar1.Value;
            }

            textBox1.Text = vScrollBar1.Value.ToString();
            textBox2.Text = vScrollBar2.Value.ToString();
            
            this.textBox3.Text = Convert.ToString(DateTime.Today.Year - vScrollBar1.Value);
            this.textBox4.Text = Convert.ToString(DateTime.Today.Year + vScrollBar2.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                vScrollBar1.Value = vScrollBar2.Value;
            }

            textBox1.Text = vScrollBar1.Value.ToString();
            textBox2.Text = vScrollBar2.Value.ToString();

            this.textBox3.Text = Convert.ToString(DateTime.Today.Year - vScrollBar1.Value);
            this.textBox4.Text = Convert.ToString(DateTime.Today.Year + vScrollBar2.Value);
        }

    }
}
