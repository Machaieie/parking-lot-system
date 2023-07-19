
namespace Estacionamento
{
    partial class GestaoVagas
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
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.iconVagas = new FontAwesome.Sharp.IconPictureBox();
            this.btnRemoverR = new FontAwesome.Sharp.IconButton();
            this.btnAlterarR = new FontAwesome.Sharp.IconButton();
            this.btnPesquisaR = new FontAwesome.Sharp.IconButton();
            this.btnRegVeiculo = new FontAwesome.Sharp.IconButton();
            this.btnVagaOc_Disp = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelMenu.Controls.Add(this.btnRemoverR);
            this.panelMenu.Controls.Add(this.btnAlterarR);
            this.panelMenu.Controls.Add(this.btnPesquisaR);
            this.panelMenu.Controls.Add(this.btnRegVeiculo);
            this.panelMenu.Controls.Add(this.btnVagaOc_Disp);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 607);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelTitle.Controls.Add(this.iconHome);
            this.panelTitle.Controls.Add(this.iconVagas);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(179, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(750, 73);
            this.panelTitle.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(179, 73);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(750, 534);
            this.panelDesktop.TabIndex = 2;
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconHome.IconColor = System.Drawing.Color.White;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 52;
            this.iconHome.Location = new System.Drawing.Point(6, 18);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(54, 52);
            this.iconHome.TabIndex = 1;
            this.iconHome.TabStop = false;
            // 
            // iconVagas
            // 
            this.iconVagas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.iconVagas.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.iconVagas.IconColor = System.Drawing.Color.White;
            this.iconVagas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVagas.IconSize = 61;
            this.iconVagas.Location = new System.Drawing.Point(684, 12);
            this.iconVagas.Name = "iconVagas";
            this.iconVagas.Size = new System.Drawing.Size(64, 61);
            this.iconVagas.TabIndex = 0;
            this.iconVagas.TabStop = false;
            // 
            // btnRemoverR
            // 
            this.btnRemoverR.FlatAppearance.BorderSize = 0;
            this.btnRemoverR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverR.ForeColor = System.Drawing.Color.White;
            this.btnRemoverR.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemoverR.IconColor = System.Drawing.Color.White;
            this.btnRemoverR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoverR.Location = new System.Drawing.Point(0, 453);
            this.btnRemoverR.Name = "btnRemoverR";
            this.btnRemoverR.Size = new System.Drawing.Size(179, 60);
            this.btnRemoverR.TabIndex = 2;
            this.btnRemoverR.Text = "Remover Registro";
            this.btnRemoverR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoverR.UseVisualStyleBackColor = true;
            this.btnRemoverR.Click += new System.EventHandler(this.btnRemoverR_Click);
            // 
            // btnAlterarR
            // 
            this.btnAlterarR.FlatAppearance.BorderSize = 0;
            this.btnAlterarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarR.ForeColor = System.Drawing.Color.White;
            this.btnAlterarR.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.btnAlterarR.IconColor = System.Drawing.Color.White;
            this.btnAlterarR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterarR.Location = new System.Drawing.Point(0, 366);
            this.btnAlterarR.Name = "btnAlterarR";
            this.btnAlterarR.Size = new System.Drawing.Size(179, 62);
            this.btnAlterarR.TabIndex = 2;
            this.btnAlterarR.Text = "Alterar Registro";
            this.btnAlterarR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarR.UseVisualStyleBackColor = true;
            this.btnAlterarR.Click += new System.EventHandler(this.btnAlterarR_Click);
            // 
            // btnPesquisaR
            // 
            this.btnPesquisaR.FlatAppearance.BorderSize = 0;
            this.btnPesquisaR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaR.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaR.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPesquisaR.IconColor = System.Drawing.Color.White;
            this.btnPesquisaR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisaR.Location = new System.Drawing.Point(0, 290);
            this.btnPesquisaR.Name = "btnPesquisaR";
            this.btnPesquisaR.Size = new System.Drawing.Size(179, 60);
            this.btnPesquisaR.TabIndex = 2;
            this.btnPesquisaR.Text = "Pesquisar Registro";
            this.btnPesquisaR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisaR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisaR.UseVisualStyleBackColor = true;
            this.btnPesquisaR.Click += new System.EventHandler(this.btnPesquisaR_Click);
            // 
            // btnRegVeiculo
            // 
            this.btnRegVeiculo.FlatAppearance.BorderSize = 0;
            this.btnRegVeiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegVeiculo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnRegVeiculo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnRegVeiculo.IconColor = System.Drawing.Color.White;
            this.btnRegVeiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegVeiculo.Location = new System.Drawing.Point(0, 204);
            this.btnRegVeiculo.Name = "btnRegVeiculo";
            this.btnRegVeiculo.Size = new System.Drawing.Size(179, 60);
            this.btnRegVeiculo.TabIndex = 1;
            this.btnRegVeiculo.Text = "Registar Parqueamento";
            this.btnRegVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegVeiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegVeiculo.UseVisualStyleBackColor = true;
            this.btnRegVeiculo.Click += new System.EventHandler(this.btnRegVeiculo_Click);
            // 
            // btnVagaOc_Disp
            // 
            this.btnVagaOc_Disp.FlatAppearance.BorderSize = 0;
            this.btnVagaOc_Disp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVagaOc_Disp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVagaOc_Disp.ForeColor = System.Drawing.Color.White;
            this.btnVagaOc_Disp.IconChar = FontAwesome.Sharp.IconChar.TrafficLight;
            this.btnVagaOc_Disp.IconColor = System.Drawing.Color.White;
            this.btnVagaOc_Disp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVagaOc_Disp.Location = new System.Drawing.Point(0, 116);
            this.btnVagaOc_Disp.Name = "btnVagaOc_Disp";
            this.btnVagaOc_Disp.Size = new System.Drawing.Size(179, 60);
            this.btnVagaOc_Disp.TabIndex = 0;
            this.btnVagaOc_Disp.Text = "Vagas";
            this.btnVagaOc_Disp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVagaOc_Disp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVagaOc_Disp.UseVisualStyleBackColor = true;
            this.btnVagaOc_Disp.Click += new System.EventHandler(this.btnVagaOc_Disp_Click);
            // 
            // GestaoVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 607);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "GestaoVagas";
            this.Text = "GestaoVagas";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVagas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnRemoverR;
        private FontAwesome.Sharp.IconButton btnAlterarR;
        private FontAwesome.Sharp.IconButton btnPesquisaR;
        private FontAwesome.Sharp.IconButton btnRegVeiculo;
        private FontAwesome.Sharp.IconButton btnVagaOc_Disp;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private FontAwesome.Sharp.IconPictureBox iconVagas;
        private System.Windows.Forms.Panel panelDesktop;
    }
}