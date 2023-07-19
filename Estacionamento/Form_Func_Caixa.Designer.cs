
namespace Estacionamento
{
    partial class Form_Func_Caixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelNav = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenus = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.iconDefinicoes = new FontAwesome.Sharp.IconButton();
            this.iconPagamentos = new FontAwesome.Sharp.IconButton();
            this.iconGestaoVagas = new FontAwesome.Sharp.IconButton();
            this.iconGestaoVeiculos = new FontAwesome.Sharp.IconButton();
            this.iconGestaoClientes = new FontAwesome.Sharp.IconButton();
            this.iconLogo = new FontAwesome.Sharp.IconPictureBox();
            this.panelNav.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenus.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.panelNav.Controls.Add(this.iconPictureBox3);
            this.panelNav.Controls.Add(this.iconPictureBox2);
            this.panelNav.Controls.Add(this.iconPictureBox1);
            this.panelNav.Controls.Add(this.labelHome);
            this.panelNav.Controls.Add(this.iconHome);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(188, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(776, 84);
            this.panelNav.TabIndex = 1;
            this.panelNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNav_MouseDown);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(45, 47);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(42, 19);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Inicio";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 121);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenus
            // 
            this.panelMenus.AutoSize = true;
            this.panelMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.panelMenus.Controls.Add(this.iconDefinicoes);
            this.panelMenus.Controls.Add(this.iconPagamentos);
            this.panelMenus.Controls.Add(this.iconGestaoVagas);
            this.panelMenus.Controls.Add(this.iconGestaoVeiculos);
            this.panelMenus.Controls.Add(this.iconGestaoClientes);
            this.panelMenus.Controls.Add(this.panelLogo);
            this.panelMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenus.Location = new System.Drawing.Point(0, 0);
            this.panelMenus.Name = "panelMenus";
            this.panelMenus.Size = new System.Drawing.Size(188, 598);
            this.panelMenus.TabIndex = 0;
            this.panelMenus.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenus_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.panelDesktop.Controls.Add(this.labelTime);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(188, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(776, 514);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint_1);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(260, 248);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 55);
            this.labelTime.TabIndex = 0;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(665, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(703, 3);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(741, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconHome.IconColor = System.Drawing.Color.White;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 50;
            this.iconHome.Location = new System.Drawing.Point(6, 22);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(57, 50);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // iconDefinicoes
            // 
            this.iconDefinicoes.FlatAppearance.BorderSize = 0;
            this.iconDefinicoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconDefinicoes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconDefinicoes.ForeColor = System.Drawing.Color.White;
            this.iconDefinicoes.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.iconDefinicoes.IconColor = System.Drawing.Color.White;
            this.iconDefinicoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDefinicoes.Location = new System.Drawing.Point(3, 511);
            this.iconDefinicoes.Name = "iconDefinicoes";
            this.iconDefinicoes.Size = new System.Drawing.Size(182, 66);
            this.iconDefinicoes.TabIndex = 7;
            this.iconDefinicoes.Text = "Definicoes";
            this.iconDefinicoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconDefinicoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconDefinicoes.UseVisualStyleBackColor = true;
            this.iconDefinicoes.Click += new System.EventHandler(this.iconDefinicoes_Click);
            // 
            // iconPagamentos
            // 
            this.iconPagamentos.FlatAppearance.BorderSize = 0;
            this.iconPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPagamentos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconPagamentos.ForeColor = System.Drawing.Color.White;
            this.iconPagamentos.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.iconPagamentos.IconColor = System.Drawing.Color.White;
            this.iconPagamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPagamentos.Location = new System.Drawing.Point(3, 414);
            this.iconPagamentos.Name = "iconPagamentos";
            this.iconPagamentos.Size = new System.Drawing.Size(182, 66);
            this.iconPagamentos.TabIndex = 6;
            this.iconPagamentos.Text = "Pagamentos";
            this.iconPagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPagamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPagamentos.UseVisualStyleBackColor = true;
            this.iconPagamentos.Click += new System.EventHandler(this.iconPagamentos_Click);
            // 
            // iconGestaoVagas
            // 
            this.iconGestaoVagas.FlatAppearance.BorderSize = 0;
            this.iconGestaoVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGestaoVagas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconGestaoVagas.ForeColor = System.Drawing.Color.White;
            this.iconGestaoVagas.IconChar = FontAwesome.Sharp.IconChar.Deskpro;
            this.iconGestaoVagas.IconColor = System.Drawing.Color.White;
            this.iconGestaoVagas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestaoVagas.Location = new System.Drawing.Point(3, 327);
            this.iconGestaoVagas.Name = "iconGestaoVagas";
            this.iconGestaoVagas.Size = new System.Drawing.Size(182, 60);
            this.iconGestaoVagas.TabIndex = 5;
            this.iconGestaoVagas.Text = "Gestao de Vagas";
            this.iconGestaoVagas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGestaoVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGestaoVagas.UseVisualStyleBackColor = true;
            this.iconGestaoVagas.Click += new System.EventHandler(this.iconGestaoVagas_Click);
            // 
            // iconGestaoVeiculos
            // 
            this.iconGestaoVeiculos.FlatAppearance.BorderSize = 0;
            this.iconGestaoVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGestaoVeiculos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconGestaoVeiculos.ForeColor = System.Drawing.Color.White;
            this.iconGestaoVeiculos.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconGestaoVeiculos.IconColor = System.Drawing.Color.White;
            this.iconGestaoVeiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestaoVeiculos.Location = new System.Drawing.Point(3, 226);
            this.iconGestaoVeiculos.Name = "iconGestaoVeiculos";
            this.iconGestaoVeiculos.Size = new System.Drawing.Size(182, 60);
            this.iconGestaoVeiculos.TabIndex = 4;
            this.iconGestaoVeiculos.Text = "Gestao de Veiculos";
            this.iconGestaoVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGestaoVeiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGestaoVeiculos.UseVisualStyleBackColor = true;
            this.iconGestaoVeiculos.Click += new System.EventHandler(this.iconGestaoVeiculos_Click);
            // 
            // iconGestaoClientes
            // 
            this.iconGestaoClientes.FlatAppearance.BorderSize = 0;
            this.iconGestaoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconGestaoClientes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconGestaoClientes.ForeColor = System.Drawing.Color.White;
            this.iconGestaoClientes.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconGestaoClientes.IconColor = System.Drawing.Color.White;
            this.iconGestaoClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconGestaoClientes.Location = new System.Drawing.Point(3, 139);
            this.iconGestaoClientes.Name = "iconGestaoClientes";
            this.iconGestaoClientes.Size = new System.Drawing.Size(182, 60);
            this.iconGestaoClientes.TabIndex = 1;
            this.iconGestaoClientes.Text = " Gestao Clientes";
            this.iconGestaoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconGestaoClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconGestaoClientes.UseVisualStyleBackColor = true;
            this.iconGestaoClientes.Click += new System.EventHandler(this.iconGestaoClientes_Click);
            // 
            // iconLogo
            // 
            this.iconLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogo.IconSize = 72;
            this.iconLogo.Location = new System.Drawing.Point(26, 12);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Size = new System.Drawing.Size(135, 72);
            this.iconLogo.TabIndex = 0;
            this.iconLogo.TabStop = false;
            this.iconLogo.Click += new System.EventHandler(this.iconLogo_Click);
            // 
            // Form_Func_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 598);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelMenus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Func_Caixa";
            this.ShowIcon = false;
            this.Text = "Form_Func_Caixa";
            this.Load += new System.EventHandler(this.Form_Func_Caixa_Load);
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelMenus.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconGestaoClientes;
        private FontAwesome.Sharp.IconButton iconGestaoVeiculos;
        private FontAwesome.Sharp.IconButton iconGestaoVagas;
        private FontAwesome.Sharp.IconButton iconPagamentos;
        private System.Windows.Forms.Panel panelMenus;
        private FontAwesome.Sharp.IconButton iconDefinicoes;
        private System.Windows.Forms.Label labelHome;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconLogo;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label labelTime;
    }
}