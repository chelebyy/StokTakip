using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.InteropServices;

namespace StokTakip
{
    public partial class Form1 : Form
    {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        //private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);

            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(23, 21, 32);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

                }
            }
        }



        SqliteBaglanti bgl = new SqliteBaglanti();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDesign()
        {
            //panelUrunSubmenu.Visible = false;
            panelStokSubmenu.Visible = false;
            panelAyarSubmenu.Visible = false;

        }

        private void HideSubMenu()
        {
            //if (panelUrunSubmenu.Visible==true)

            //    panelUrunSubmenu.Visible = false;
            if (panelStokSubmenu.Visible == true)
                panelStokSubmenu.Visible = false;
            if (panelAyarSubmenu.Visible == true)
                panelAyarSubmenu.Visible = false;
        }
        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }



        private void btnStokislem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ShowSubmenu(panelStokSubmenu);
        }
        #region StokSubMenu
        private void btnStok_Click(object sender, EventArgs e)
        {
            openChilForm(new FrmStok());
            //ActiveButton(sender);
            HideSubMenu();
        }

        private void btnStokDus_Click(object sender, EventArgs e)
        {
            openChilForm(new FrmStokIslemleri());
            //ActiveButton(sender);
            HideSubMenu();
        }
 #endregion
        private void butnAyarlar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            ShowSubmenu(panelAyarSubmenu);
        }
        #region  AyarlarSubMenu     
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            openChilForm(new FrmKategori());
            HideSubMenu();
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            openChilForm(new FrmBirimEkle());
            HideSubMenu();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            openChilForm(new FrmUrunEkle());
            HideSubMenu();
        }

        private void btnVeritabaniYedekle_Click_1(object sender, EventArgs e)
        {
            //ActiveButton(sender);
            openChilForm(new FrmVeriTabani());
            HideSubMenu();
        }



        #endregion

        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            //ActiveButton(btnSender);
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //advancedDataGridView1.Controls.Add(childForm);
            //advancedDataGridView1.Tag = childForm;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

       

        private void btnAra_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            HideSubMenu();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            HideSubMenu();
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChilForm(new FrmHakkinda());
            HideSubMenu();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(23, 21, 32);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            if (MessageBox.Show("Programı Kapatmak İstiyor musunuz ? ","</>", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChilForm(new FrmRapor());
            HideSubMenu();
        }
    }

}