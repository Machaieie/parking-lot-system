
namespace Estacionamento
{
    partial class GestaoClientes
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
            this.panelLista = new System.Windows.Forms.Panel();
            this.btnListar = new FontAwesome.Sharp.IconButton();
            this.btnProcurar = new FontAwesome.Sharp.IconButton();
            this.iconInserir = new FontAwesome.Sharp.IconButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.iconCliente = new FontAwesome.Sharp.IconPictureBox();
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLista.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLista
            // 
            this.panelLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelLista.Controls.Add(this.btnListar);
            this.panelLista.Controls.Add(this.btnProcurar);
            this.panelLista.Controls.Add(this.iconInserir);
            this.panelLista.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLista.Location = new System.Drawing.Point(0, 0);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(185, 607);
            this.panelLista.TabIndex = 0;
            this.panelLista.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLista_Paint);
            // 
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnListar.IconColor = System.Drawing.Color.White;
            this.btnListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListar.Location = new System.Drawing.Point(3, 316);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 50);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar ";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.FlatAppearance.BorderSize = 0;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnProcurar.IconColor = System.Drawing.Color.White;
            this.btnProcurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProcurar.Location = new System.Drawing.Point(8, 229);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(171, 50);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar ";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // iconInserir
            // 
            this.iconInserir.FlatAppearance.BorderSize = 0;
            this.iconInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconInserir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconInserir.ForeColor = System.Drawing.Color.White;
            this.iconInserir.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconInserir.IconColor = System.Drawing.Color.White;
            this.iconInserir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInserir.Location = new System.Drawing.Point(12, 139);
            this.iconInserir.Name = "iconInserir";
            this.iconInserir.Size = new System.Drawing.Size(164, 50);
            this.iconInserir.TabIndex = 1;
            this.iconInserir.Text = "Inserir";
            this.iconInserir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconInserir.UseVisualStyleBackColor = true;
            this.iconInserir.Click += new System.EventHandler(this.iconInserir_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelTitle.Controls.Add(this.iconCliente);
            this.panelTitle.Controls.Add(this.labelInicio);
            this.panelTitle.Controls.Add(this.labelHome);
            this.panelTitle.Controls.Add(this.iconHome);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(185, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(744, 61);
            this.panelTitle.TabIndex = 1;
            // 
            // iconCliente
            // 
            this.iconCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconCliente.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconCliente.IconColor = System.Drawing.Color.White;
            this.iconCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCliente.IconSize = 61;
            this.iconCliente.Location = new System.Drawing.Point(680, 0);
            this.iconCliente.Name = "iconCliente";
            this.iconCliente.Size = new System.Drawing.Size(64, 61);
            this.iconCliente.TabIndex = 3;
            this.iconCliente.TabStop = false;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(105, 30);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(10, 13);
            this.labelInicio.TabIndex = 2;
            this.labelInicio.Text = " ";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(40, 39);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(0, 19);
            this.labelHome.TabIndex = 1;
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconHome.IconColor = System.Drawing.Color.White;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 47;
            this.iconHome.Location = new System.Drawing.Point(6, 8);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(48, 47);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(185, 61);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(744, 546);
            this.panelDesktop.TabIndex = 2;
            // 
            // GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 607);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelLista);
            this.Name = "GestaoClientes";
            this.Text = "GestaoClientes";
            this.panelLista.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLista;
        private FontAwesome.Sharp.IconButton btnProcurar;
        private FontAwesome.Sharp.IconButton iconInserir;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelHome;
        private FontAwesome.Sharp.IconButton btnListar;
        private FontAwesome.Sharp.IconPictureBox iconCliente;
    }
}