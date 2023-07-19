using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{

    
    public partial class GestaoClientes : Form

    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public GestaoClientes()
        {
            InitializeComponent();
            // referencia da classe Panel
            leftBorderBtn = new Panel();
            // Ajustando o tamanho do painel
            leftBorderBtn.Size = new Size(7, 50);
            // adicionando o tamanho ajustado no painel de menus
            panelLista.Controls.Add(leftBorderBtn);
        }

        private void panelLista_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private void iconHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
        }

        private void iconInserir_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new InserirCliente());
        } 

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new ListarCliente());
        }
    }
}
