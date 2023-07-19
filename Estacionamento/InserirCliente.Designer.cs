
namespace Estacionamento
{
    partial class InserirCliente
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnSubmeter = new FontAwesome.Sharp.IconButton();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBi = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtEmail = new Estacionamento.Controlers.DarkXTextBox();
            this.txtTelefone = new Estacionamento.Controlers.DarkXTextBox();
            this.txtBi = new Estacionamento.Controlers.DarkXTextBox();
            this.txtApelido = new Estacionamento.Controlers.DarkXTextBox();
            this.txtNome = new Estacionamento.Controlers.DarkXTextBox();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.panelDesktop.Controls.Add(this.btnSubmeter);
            this.panelDesktop.Controls.Add(this.dateNascimento);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.labelBi);
            this.panelDesktop.Controls.Add(this.labelNome);
            this.panelDesktop.Controls.Add(this.txtEmail);
            this.panelDesktop.Controls.Add(this.txtTelefone);
            this.panelDesktop.Controls.Add(this.txtBi);
            this.panelDesktop.Controls.Add(this.txtApelido);
            this.panelDesktop.Controls.Add(this.txtNome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1086, 547);
            this.panelDesktop.TabIndex = 0;
            // 
            // btnSubmeter
            // 
            this.btnSubmeter.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSubmeter.FlatAppearance.BorderSize = 0;
            this.btnSubmeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmeter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmeter.ForeColor = System.Drawing.Color.White;
            this.btnSubmeter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSubmeter.IconColor = System.Drawing.Color.Black;
            this.btnSubmeter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmeter.Location = new System.Drawing.Point(419, 462);
            this.btnSubmeter.Name = "btnSubmeter";
            this.btnSubmeter.Size = new System.Drawing.Size(187, 56);
            this.btnSubmeter.TabIndex = 4;
            this.btnSubmeter.Text = "Submeter";
            this.btnSubmeter.UseVisualStyleBackColor = false;
            this.btnSubmeter.Click += new System.EventHandler(this.btnSubmeter_Click);
            // 
            // dateNascimento
            // 
            this.dateNascimento.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNascimento.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dateNascimento.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dateNascimento.CalendarTitleForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dateNascimento.CalendarTrailingForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNascimento.Location = new System.Drawing.Point(579, 239);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(200, 20);
            this.dateNascimento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(593, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(575, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apelido";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(30, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // labelBi
            // 
            this.labelBi.AutoSize = true;
            this.labelBi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBi.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelBi.Location = new System.Drawing.Point(30, 240);
            this.labelBi.Name = "labelBi";
            this.labelBi.Size = new System.Drawing.Size(33, 21);
            this.labelBi.TabIndex = 2;
            this.labelBi.Text = "B.I";
            this.labelBi.Click += new System.EventHandler(this.labelBi_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelNome.Location = new System.Drawing.Point(30, 130);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(60, 21);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtEmail.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtEmail.Location = new System.Drawing.Point(748, 347);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 31);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtTelefone.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTelefone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefone.BorderSize = 3;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTelefone.Location = new System.Drawing.Point(136, 347);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Multiline = false;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefone.PasswordChar = false;
            this.txtTelefone.Size = new System.Drawing.Size(250, 31);
            this.txtTelefone.TabIndex = 0;
            this.txtTelefone.Texts = "";
            this.txtTelefone.UnderlinedStyle = true;
            // 
            // txtBi
            // 
            this.txtBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtBi.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBi.BorderSize = 3;
            this.txtBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBi.Location = new System.Drawing.Point(136, 228);
            this.txtBi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBi.Multiline = false;
            this.txtBi.Name = "txtBi";
            this.txtBi.Padding = new System.Windows.Forms.Padding(7);
            this.txtBi.PasswordChar = false;
            this.txtBi.Size = new System.Drawing.Size(250, 31);
            this.txtBi.TabIndex = 0;
            this.txtBi.Texts = "";
            this.txtBi.UnderlinedStyle = true;
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtApelido.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtApelido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApelido.BorderSize = 3;
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApelido.Location = new System.Drawing.Point(735, 120);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApelido.Multiline = false;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApelido.PasswordChar = false;
            this.txtApelido.Size = new System.Drawing.Size(250, 31);
            this.txtApelido.TabIndex = 0;
            this.txtApelido.Texts = "";
            this.txtApelido.UnderlinedStyle = true;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 3;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(136, 120);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(250, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = true;
            // 
            // InserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 547);
            this.Controls.Add(this.panelDesktop);
            this.Name = "InserirCliente";
            this.Text = "InserirCliente";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private Controlers.DarkXTextBox txtNome;
        private Controlers.DarkXTextBox txtEmail;
        private Controlers.DarkXTextBox txtTelefone;
        private Controlers.DarkXTextBox txtBi;
        private Controlers.DarkXTextBox txtApelido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBi;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private FontAwesome.Sharp.IconButton btnSubmeter;
    }
}