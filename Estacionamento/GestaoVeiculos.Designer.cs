
namespace Estacionamento
{
    partial class GestaoVeiculos
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconVeiculo = new FontAwesome.Sharp.IconPictureBox();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.btnListarv = new FontAwesome.Sharp.IconButton();
            this.btnProcurarv = new FontAwesome.Sharp.IconButton();
            this.btnAlterarv = new FontAwesome.Sharp.IconButton();
            this.btnRemoverv = new FontAwesome.Sharp.IconButton();
            this.btnInserirv = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelMenu.Controls.Add(this.btnListarv);
            this.panelMenu.Controls.Add(this.btnProcurarv);
            this.panelMenu.Controls.Add(this.btnAlterarv);
            this.panelMenu.Controls.Add(this.btnRemoverv);
            this.panelMenu.Controls.Add(this.btnInserirv);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(156, 605);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelTitle.Controls.Add(this.iconVeiculo);
            this.panelTitle.Controls.Add(this.iconHome);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(156, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(772, 66);
            this.panelTitle.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(156, 66);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(772, 539);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconVeiculo
            // 
            this.iconVeiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconVeiculo.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconVeiculo.IconColor = System.Drawing.Color.White;
            this.iconVeiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVeiculo.IconSize = 58;
            this.iconVeiculo.Location = new System.Drawing.Point(697, 8);
            this.iconVeiculo.Name = "iconVeiculo";
            this.iconVeiculo.Size = new System.Drawing.Size(63, 58);
            this.iconVeiculo.TabIndex = 1;
            this.iconVeiculo.TabStop = false;
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconHome.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 45;
            this.iconHome.Location = new System.Drawing.Point(6, 18);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(45, 45);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            // 
            // btnListarv
            // 
            this.btnListarv.FlatAppearance.BorderSize = 0;
            this.btnListarv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarv.ForeColor = System.Drawing.Color.White;
            this.btnListarv.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnListarv.IconColor = System.Drawing.Color.White;
            this.btnListarv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarv.Location = new System.Drawing.Point(3, 521);
            this.btnListarv.Name = "btnListarv";
            this.btnListarv.Size = new System.Drawing.Size(153, 60);
            this.btnListarv.TabIndex = 4;
            this.btnListarv.Text = "Listar";
            this.btnListarv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarv.UseVisualStyleBackColor = true;
            this.btnListarv.Click += new System.EventHandler(this.btnListarv_Click);
            // 
            // btnProcurarv
            // 
            this.btnProcurarv.FlatAppearance.BorderSize = 0;
            this.btnProcurarv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarv.ForeColor = System.Drawing.Color.White;
            this.btnProcurarv.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnProcurarv.IconColor = System.Drawing.Color.White;
            this.btnProcurarv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProcurarv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurarv.Location = new System.Drawing.Point(3, 434);
            this.btnProcurarv.Name = "btnProcurarv";
            this.btnProcurarv.Size = new System.Drawing.Size(150, 60);
            this.btnProcurarv.TabIndex = 3;
            this.btnProcurarv.Text = "Procurar";
            this.btnProcurarv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurarv.UseVisualStyleBackColor = true;
            this.btnProcurarv.Click += new System.EventHandler(this.btnProcurarv_Click);
            // 
            // btnAlterarv
            // 
            this.btnAlterarv.FlatAppearance.BorderSize = 0;
            this.btnAlterarv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarv.ForeColor = System.Drawing.Color.White;
            this.btnAlterarv.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnAlterarv.IconColor = System.Drawing.Color.White;
            this.btnAlterarv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterarv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarv.Location = new System.Drawing.Point(3, 345);
            this.btnAlterarv.Name = "btnAlterarv";
            this.btnAlterarv.Size = new System.Drawing.Size(150, 60);
            this.btnAlterarv.TabIndex = 2;
            this.btnAlterarv.Text = "Alterar";
            this.btnAlterarv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarv.UseVisualStyleBackColor = true;
            this.btnAlterarv.Click += new System.EventHandler(this.btnAlterarv_Click);
            // 
            // btnRemoverv
            // 
            this.btnRemoverv.FlatAppearance.BorderSize = 0;
            this.btnRemoverv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverv.ForeColor = System.Drawing.Color.White;
            this.btnRemoverv.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemoverv.IconColor = System.Drawing.Color.White;
            this.btnRemoverv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoverv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverv.Location = new System.Drawing.Point(3, 245);
            this.btnRemoverv.Name = "btnRemoverv";
            this.btnRemoverv.Size = new System.Drawing.Size(150, 60);
            this.btnRemoverv.TabIndex = 1;
            this.btnRemoverv.Text = "Remover";
            this.btnRemoverv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoverv.UseVisualStyleBackColor = true;
            this.btnRemoverv.Click += new System.EventHandler(this.btnRemoverv_Click);
            // 
            // btnInserirv
            // 
            this.btnInserirv.FlatAppearance.BorderSize = 0;
            this.btnInserirv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirv.ForeColor = System.Drawing.Color.White;
            this.btnInserirv.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnInserirv.IconColor = System.Drawing.Color.White;
            this.btnInserirv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInserirv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirv.Location = new System.Drawing.Point(3, 143);
            this.btnInserirv.Name = "btnInserirv";
            this.btnInserirv.Size = new System.Drawing.Size(153, 60);
            this.btnInserirv.TabIndex = 0;
            this.btnInserirv.Text = "Inserir";
            this.btnInserirv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserirv.UseVisualStyleBackColor = true;
            this.btnInserirv.Click += new System.EventHandler(this.btnInserirv_Click);
            // 
            // GestaoVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 605);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "GestaoVeiculos";
            this.Text = "GestaoVeiculos";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnListarv;
        private FontAwesome.Sharp.IconButton btnProcurarv;
        private FontAwesome.Sharp.IconButton btnAlterarv;
        private FontAwesome.Sharp.IconButton btnRemoverv;
        private FontAwesome.Sharp.IconButton btnInserirv;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconVeiculo;
    }
}