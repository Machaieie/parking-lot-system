
namespace Estacionamento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.iconDataBse = new FontAwesome.Sharp.IconButton();
            this.iconPagamentos = new FontAwesome.Sharp.IconButton();
            this.iconClientes = new FontAwesome.Sharp.IconButton();
            this.funcionarios = new FontAwesome.Sharp.IconButton();
            this.iconAdmin = new FontAwesome.Sharp.IconButton();
            this.iconImage = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.iconDataBse);
            this.panelMenu.Controls.Add(this.iconPagamentos);
            this.panelMenu.Controls.Add(this.iconClientes);
            this.panelMenu.Controls.Add(this.funcionarios);
            this.panelMenu.Controls.Add(this.iconAdmin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 582);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconImage);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.iconPictureBox1);
            this.panelTitle.Controls.Add(this.iconMaximize);
            this.panelTitle.Controls.Add(this.iconMinimize);
            this.panelTitle.Controls.Add(this.iconExit);
            this.panelTitle.Controls.Add(this.home);
            this.panelTitle.Controls.Add(this.iconHome);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(758, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(50, 59);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(38, 15);
            this.home.TabIndex = 1;
            this.home.Text = "Inicio";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(758, 502);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMaximize.ForeColor = System.Drawing.SystemColors.Control;
            this.iconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMaximize.IconColor = System.Drawing.SystemColors.Control;
            this.iconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximize.IconSize = 25;
            this.iconMaximize.Location = new System.Drawing.Point(698, 0);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(26, 25);
            this.iconMaximize.TabIndex = 8;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconMinimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(663, 0);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(26, 25);
            this.iconMinimize.TabIndex = 7;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconExit.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(730, 0);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(28, 25);
            this.iconExit.TabIndex = 6;
            this.iconExit.TabStop = false;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 46;
            this.iconHome.Location = new System.Drawing.Point(6, 28);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(47, 46);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconDataBse
            // 
            this.iconDataBse.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconDataBse.FlatAppearance.BorderSize = 0;
            this.iconDataBse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDataBse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDataBse.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconDataBse.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconDataBse.IconColor = System.Drawing.Color.SkyBlue;
            this.iconDataBse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDataBse.Location = new System.Drawing.Point(0, 340);
            this.iconDataBse.Name = "iconDataBse";
            this.iconDataBse.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconDataBse.Size = new System.Drawing.Size(220, 69);
            this.iconDataBse.TabIndex = 5;
            this.iconDataBse.Text = "Base De Dados";
            this.iconDataBse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDataBse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDataBse.UseVisualStyleBackColor = true;
            this.iconDataBse.Click += new System.EventHandler(this.iconDataBse_Click);
            // 
            // iconPagamentos
            // 
            this.iconPagamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPagamentos.FlatAppearance.BorderSize = 0;
            this.iconPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPagamentos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPagamentos.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPagamentos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.iconPagamentos.IconColor = System.Drawing.Color.SkyBlue;
            this.iconPagamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagamentos.Location = new System.Drawing.Point(0, 280);
            this.iconPagamentos.Name = "iconPagamentos";
            this.iconPagamentos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconPagamentos.Size = new System.Drawing.Size(220, 60);
            this.iconPagamentos.TabIndex = 4;
            this.iconPagamentos.Text = "Pagamentos";
            this.iconPagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPagamentos.UseVisualStyleBackColor = true;
            this.iconPagamentos.Click += new System.EventHandler(this.iconPagamentos_Click);
            // 
            // iconClientes
            // 
            this.iconClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconClientes.FlatAppearance.BorderSize = 0;
            this.iconClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconClientes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconClientes.IconColor = System.Drawing.Color.SkyBlue;
            this.iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClientes.Location = new System.Drawing.Point(0, 220);
            this.iconClientes.Name = "iconClientes";
            this.iconClientes.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.iconClientes.Size = new System.Drawing.Size(220, 60);
            this.iconClientes.TabIndex = 3;
            this.iconClientes.Text = "Clientes";
            this.iconClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconClientes.UseVisualStyleBackColor = true;
            this.iconClientes.Click += new System.EventHandler(this.iconClientes_Click);
            // 
            // funcionarios
            // 
            this.funcionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionarios.FlatAppearance.BorderSize = 0;
            this.funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.funcionarios.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.funcionarios.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.funcionarios.IconColor = System.Drawing.Color.SkyBlue;
            this.funcionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.funcionarios.Location = new System.Drawing.Point(0, 160);
            this.funcionarios.Name = "funcionarios";
            this.funcionarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.funcionarios.Size = new System.Drawing.Size(220, 60);
            this.funcionarios.TabIndex = 2;
            this.funcionarios.Text = "Funcionarios";
            this.funcionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funcionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.funcionarios.UseVisualStyleBackColor = true;
            this.funcionarios.Click += new System.EventHandler(this.funcionarios_Click);
            // 
            // iconAdmin
            // 
            this.iconAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAdmin.FlatAppearance.BorderSize = 0;
            this.iconAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconAdmin.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconAdmin.IconColor = System.Drawing.Color.SkyBlue;
            this.iconAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdmin.Location = new System.Drawing.Point(0, 100);
            this.iconAdmin.Name = "iconAdmin";
            this.iconAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconAdmin.Size = new System.Drawing.Size(220, 60);
            this.iconAdmin.TabIndex = 1;
            this.iconAdmin.Text = "Administração ";
            this.iconAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAdmin.UseVisualStyleBackColor = true;
            this.iconAdmin.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconImage
            // 
            this.iconImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconImage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconImage.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconImage.IconSize = 82;
            this.iconImage.Location = new System.Drawing.Point(25, 12);
            this.iconImage.Name = "iconImage";
            this.iconImage.Size = new System.Drawing.Size(143, 82);
            this.iconImage.TabIndex = 0;
            this.iconImage.TabStop = false;
            this.iconImage.Click += new System.EventHandler(this.iconImage_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(584, 34);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(45, 46);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 582);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = " Admin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconPagamentos;
        private FontAwesome.Sharp.IconButton iconClientes;
        private FontAwesome.Sharp.IconButton funcionarios;
        private FontAwesome.Sharp.IconButton iconAdmin;
        private FontAwesome.Sharp.IconButton iconDataBse;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label home;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private FontAwesome.Sharp.IconPictureBox iconImage;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private FontAwesome.Sharp.IconPictureBox iconMaximize;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

