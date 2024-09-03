namespace prjClinica
{
    partial class frmIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitulo = new Label();
            lbNome = new Label();
            txtNome = new TextBox();
            txtDataNasc = new TextBox();
            lbDataNasc = new Label();
            txtCPF = new TextBox();
            lbCPF = new Label();
            rbFeminino = new RadioButton();
            rbMasc = new RadioButton();
            rbOutro = new RadioButton();
            lbGenero = new Label();
            btOK = new Button();
            txtAltura = new TextBox();
            lbAltura = new Label();
            txtPeso = new TextBox();
            lbPeso = new Label();
            lbMensagem = new Label();
            txtMatricula = new TextBox();
            lbMatricula = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtRelatorio = new TextBox();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Sitka Banner", 25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTitulo.Location = new Point(213, 17);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(375, 98);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Clinica de Emagrecimento\r\n\r\n";
            lbTitulo.Click += lbTitulo_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNome.Location = new Point(12, 100);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(44, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(175, 23);
            txtNome.TabIndex = 2;
            // 
            // txtDataNasc
            // 
            txtDataNasc.Location = new Point(344, 245);
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.Size = new Size(100, 23);
            txtDataNasc.TabIndex = 4;
            // 
            // lbDataNasc
            // 
            lbDataNasc.AutoSize = true;
            lbDataNasc.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDataNasc.Location = new Point(213, 245);
            lbDataNasc.Name = "lbDataNasc";
            lbDataNasc.Size = new Size(125, 15);
            lbDataNasc.TabIndex = 3;
            lbDataNasc.Text = "Data de Nascimento: ";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(48, 203);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(189, 23);
            txtCPF.TabIndex = 6;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCPF.Location = new Point(12, 206);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(30, 15);
            lbCPF.TabIndex = 5;
            lbCPF.Text = "CPF:";
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(79, 246);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 7;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Location = new Point(79, 271);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(80, 19);
            rbMasc.TabIndex = 8;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            rbMasc.UseVisualStyleBackColor = true;
            rbMasc.CheckedChanged += rbMasc_CheckedChanged;
            // 
            // rbOutro
            // 
            rbOutro.AutoSize = true;
            rbOutro.Location = new Point(79, 296);
            rbOutro.Name = "rbOutro";
            rbOutro.Size = new Size(56, 19);
            rbOutro.TabIndex = 9;
            rbOutro.TabStop = true;
            rbOutro.Text = "Outro";
            rbOutro.UseVisualStyleBackColor = true;
            // 
            // lbGenero
            // 
            lbGenero.AutoSize = true;
            lbGenero.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbGenero.Location = new Point(12, 245);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(52, 15);
            lbGenero.TabIndex = 10;
            lbGenero.Text = "Genero:";
            // 
            // btOK
            // 
            btOK.Location = new Point(31, 404);
            btOK.Name = "btOK";
            btOK.Size = new Size(75, 23);
            btOK.TabIndex = 11;
            btOK.Text = "Ok";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(344, 97);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 13;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbAltura.Location = new Point(294, 100);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(44, 15);
            lbAltura.TabIndex = 12;
            lbAltura.Text = "Altura:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(344, 145);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 15;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPeso.Location = new Point(302, 148);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(36, 15);
            lbPeso.TabIndex = 14;
            lbPeso.Text = "Peso:";
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMensagem.ForeColor = Color.Red;
            lbMensagem.Location = new Point(262, 412);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 15);
            lbMensagem.TabIndex = 16;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(344, 206);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 18;
            // 
            // lbMatricula
            // 
            lbMatricula.AutoSize = true;
            lbMatricula.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatricula.Location = new Point(276, 209);
            lbMatricula.Name = "lbMatricula";
            lbMatricula.Size = new Size(62, 15);
            lbMatricula.TabIndex = 17;
            lbMatricula.Text = "Matricula:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 20;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Ebrima", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(9, 153);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(47, 15);
            lbEmail.TabIndex = 19;
            lbEmail.Text = "E-mail: ";
            // 
            // txtRelatorio
            // 
            txtRelatorio.Location = new Point(467, 88);
            txtRelatorio.Multiline = true;
            txtRelatorio.Name = "txtRelatorio";
            txtRelatorio.ReadOnly = true;
            txtRelatorio.ScrollBars = ScrollBars.Vertical;
            txtRelatorio.Size = new Size(321, 304);
            txtRelatorio.TabIndex = 21;
            // 
            // frmIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRelatorio);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMatricula);
            Controls.Add(lbMatricula);
            Controls.Add(lbMensagem);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            Controls.Add(txtAltura);
            Controls.Add(lbAltura);
            Controls.Add(btOK);
            Controls.Add(lbGenero);
            Controls.Add(rbOutro);
            Controls.Add(rbMasc);
            Controls.Add(rbFeminino);
            Controls.Add(txtCPF);
            Controls.Add(lbCPF);
            Controls.Add(txtDataNasc);
            Controls.Add(lbDataNasc);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(lbTitulo);
            Name = "frmIMC";
            Text = "Clinica IMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbNome;
        private TextBox txtNome;
        private TextBox txtDataNasc;
        private Label lbDataNasc;
        private TextBox txtCPF;
        private Label lbCPF;
        private RadioButton rbFeminino;
        private RadioButton rbMasc;
        private RadioButton rbOutro;
        private Label lbGenero;
        private Button btOK;
        private TextBox txtAltura;
        private Label lbAltura;
        private TextBox txtPeso;
        private Label lbPeso;
        private Label lbMensagem;
        private TextBox txtMatricula;
        private Label lbMatricula;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtRelatorio;
    }
}