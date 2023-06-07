using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class FrmUrunIslemleri : Form
    {
        public FrmUrunIslemleri()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;

                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondColor;
                }
            }
            //label1.ForeColor = ThemeColor.SecondColor;
            //label2.ForeColor = ThemeColor.PrimaryColor;



        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUrunIslemleri_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
