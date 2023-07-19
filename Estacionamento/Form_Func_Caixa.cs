

using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Form_Func_Caixa : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private DateTime time;
        private DateTime tempo;
        public Form_Func_Caixa()
        {
            InitializeComponent();
            // referencia da classe Panel
            leftBorderBtn = new Panel();
            // Ajustando o tamanho do painel
            leftBorderBtn.Size = new Size(7, 60);
            // adicionando o tamanho ajustado no painel de menus
            panelMenus.Controls.Add(leftBorderBtn);
        }

        // cores em RGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 119, 176);
            public static Color color3 = Color.FromArgb(253, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 156);
            public static Color color5 = Color.FromArgb(24, 161, 251);

        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)

            {
                DesableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // borda esquerda do botao

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // icone de home
                iconHome.IconChar = currentBtn.IconChar;
                iconHome.IconColor = color;
            }
        }

        private void DesableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Aqua;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Aqua;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;

        }

        private void panelMenus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconHome_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Func_Caixa_Load(object sender, EventArgs e)
        {

        }

        private void iconGestaoClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new GestaoClientes());
        }

        private void iconGestaoVeiculos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new GestaoVeiculos());
        }

        private void iconGestaoVagas_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new GestaoVagas());
        }

        private void iconPagamentos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new Pagamento());
        }

        private void iconDefinicoes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new Definicoes());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaputure();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void panelNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaputure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconLogo_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void Reset()
        {
            DesableButton();
            leftBorderBtn.Visible = false;
            iconHome.IconChar = IconChar.Home;
            iconHome.IconColor = Color.FromArgb(128, 255, 255);
            labelHome.Text = "Inicio";
        }

        private void panelDesktop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Load(object sender, EventArgs e)
        {
            time = DateTime.Now; 
            labelTime.Text = time.ToLongTimeString();
           
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            labelTime.Text = time.ToLongTimeString();
        }

        private void labelDia_Click(object sender, EventArgs e)
        {
            time = DateTime.Now;
           
        }
    }
}
