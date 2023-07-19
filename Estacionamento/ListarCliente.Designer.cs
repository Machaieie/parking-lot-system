
namespace Estacionamento
{
    partial class ListarCliente
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
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.l = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.Label();
            this.q = new System.Windows.Forms.Label();
            this.btnatualizar = new FontAwesome.Sharp.IconButton();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApagar = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new Estacionamento.Controlers.DarkXTextBox();
            this.darkXTextBox5 = new Estacionamento.Controlers.DarkXTextBox();
            this.txtBi = new Estacionamento.Controlers.DarkXTextBox();
            this.txtApelido = new Estacionamento.Controlers.DarkXTextBox();
            this.txtNome = new Estacionamento.Controlers.DarkXTextBox();
            this.txtCodigo = new Estacionamento.Controlers.DarkXTextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToOrderColumns = true;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(29, 35);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.Size = new System.Drawing.Size(680, 313);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.LightPink;
            this.l.Location = new System.Drawing.Point(806, 82);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(120, 19);
            this.l.TabIndex = 2;
            this.l.Text = "Codigo do Cliente";
            this.l.Click += new System.EventHandler(this.label1_Click);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.Color.LightPink;
            this.c.Location = new System.Drawing.Point(806, 152);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(47, 19);
            this.c.TabIndex = 2;
            this.c.Text = "Nome";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.LightPink;
            this.x.Location = new System.Drawing.Point(806, 235);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(57, 19);
            this.x.TabIndex = 2;
            this.x.Text = "Apelido";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.LightPink;
            this.g.Location = new System.Drawing.Point(806, 315);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(28, 19);
            this.g.TabIndex = 2;
            this.g.Text = "B.I";
            // 
            // txtTel
            // 
            this.txtTel.AutoSize = true;
            this.txtTel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.LightPink;
            this.txtTel.Location = new System.Drawing.Point(803, 380);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(60, 19);
            this.txtTel.TabIndex = 2;
            this.txtTel.Text = "Telefone";
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.ForeColor = System.Drawing.Color.LightPink;
            this.q.Location = new System.Drawing.Point(811, 524);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(42, 19);
            this.q.TabIndex = 2;
            this.q.Text = "Email";
            // 
            // btnatualizar
            // 
            this.btnatualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnatualizar.FlatAppearance.BorderSize = 0;
            this.btnatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatualizar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnatualizar.IconColor = System.Drawing.Color.Black;
            this.btnatualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnatualizar.Location = new System.Drawing.Point(29, 367);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(142, 47);
            this.btnatualizar.TabIndex = 3;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = false;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(960, 445);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(200, 20);
            this.txtData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(803, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data de Nascimento";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnApagar.IconColor = System.Drawing.Color.Black;
            this.btnApagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApagar.Location = new System.Drawing.Point(254, 369);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(163, 46);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.txtEmail.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(960, 512);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 31);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // darkXTextBox5
            // 
            this.darkXTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.darkXTextBox5.BorderColor = System.Drawing.Color.DarkOrchid;
            this.darkXTextBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.darkXTextBox5.BorderSize = 2;
            this.darkXTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkXTextBox5.ForeColor = System.Drawing.Color.White;
            this.darkXTextBox5.Location = new System.Drawing.Point(963, 368);
            this.darkXTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.darkXTextBox5.Multiline = false;
            this.darkXTextBox5.Name = "darkXTextBox5";
            this.darkXTextBox5.Padding = new System.Windows.Forms.Padding(7);
            this.darkXTextBox5.PasswordChar = false;
            this.darkXTextBox5.Size = new System.Drawing.Size(250, 31);
            this.darkXTextBox5.TabIndex = 1;
            this.darkXTextBox5.Texts = "";
            this.darkXTextBox5.UnderlinedStyle = false;
            // 
            // txtBi
            // 
            this.txtBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.txtBi.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtBi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBi.BorderSize = 2;
            this.txtBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBi.ForeColor = System.Drawing.Color.White;
            this.txtBi.Location = new System.Drawing.Point(963, 303);
            this.txtBi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBi.Multiline = false;
            this.txtBi.Name = "txtBi";
            this.txtBi.Padding = new System.Windows.Forms.Padding(7);
            this.txtBi.PasswordChar = false;
            this.txtBi.Size = new System.Drawing.Size(250, 31);
            this.txtBi.TabIndex = 1;
            this.txtBi.Texts = "";
            this.txtBi.UnderlinedStyle = false;
            // 
            // txtApelido
            // 
            this.txtApelido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.txtApelido.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtApelido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApelido.BorderSize = 2;
            this.txtApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApelido.ForeColor = System.Drawing.Color.White;
            this.txtApelido.Location = new System.Drawing.Point(963, 223);
            this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApelido.Multiline = false;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApelido.PasswordChar = false;
            this.txtApelido.Size = new System.Drawing.Size(250, 31);
            this.txtApelido.TabIndex = 1;
            this.txtApelido.Texts = "";
            this.txtApelido.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.txtNome.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(963, 140);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(250, 31);
            this.txtNome.TabIndex = 1;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.txtCodigo.BorderColor = System.Drawing.Color.DarkOrchid;
            this.txtCodigo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCodigo.BorderSize = 2;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(963, 70);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodigo.PasswordChar = false;
            this.txtCodigo.Size = new System.Drawing.Size(250, 31);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Texts = "";
            this.txtCodigo.UnderlinedStyle = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(497, 369);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 45);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1240, 545);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.q);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.g);
            this.Controls.Add(this.x);
            this.Controls.Add(this.c);
            this.Controls.Add(this.l);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.darkXTextBox5);
            this.Controls.Add(this.txtBi);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dataGridViewDados);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.Load += new System.EventHandler(this.ListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDados;
        private Controlers.DarkXTextBox txtCodigo;
        private Controlers.DarkXTextBox txtNome;
        private Controlers.DarkXTextBox txtApelido;
        private Controlers.DarkXTextBox txtBi;
        private Controlers.DarkXTextBox darkXTextBox5;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label txtTel;
        private Controlers.DarkXTextBox txtEmail;
        private System.Windows.Forms.Label q;
        private FontAwesome.Sharp.IconButton btnatualizar;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnApagar;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}