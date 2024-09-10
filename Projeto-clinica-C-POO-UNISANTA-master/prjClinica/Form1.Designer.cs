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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMC));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.imgZelda = new System.Windows.Forms.PictureBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.imgZelda2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgZelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZelda2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Sylfaen", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitulo.Location = new System.Drawing.Point(195, 14);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(382, 86);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Clinica de Emagrecimento\r\n\r\n";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNome.Location = new System.Drawing.Point(12, 100);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 15);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 23);
            this.txtNome.TabIndex = 2;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(137, 242);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(100, 23);
            this.txtDataNasc.TabIndex = 4;
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDataNasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDataNasc.Location = new System.Drawing.Point(9, 245);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(125, 15);
            this.lbDataNasc.TabIndex = 3;
            this.lbDataNasc.Text = "Data de Nascimento: ";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(62, 203);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(175, 23);
            this.txtCPF.TabIndex = 6;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.BackColor = System.Drawing.Color.Transparent;
            this.lbCPF.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCPF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCPF.Location = new System.Drawing.Point(12, 206);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 15);
            this.lbCPF.TabIndex = 5;
            this.lbCPF.Text = "CPF:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbFeminino.Location = new System.Drawing.Point(153, 290);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rbFeminino.TabIndex = 7;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbMasc.Location = new System.Drawing.Point(67, 290);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(80, 19);
            this.rbMasc.TabIndex = 8;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbOutro.Location = new System.Drawing.Point(234, 290);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(56, 19);
            this.rbOutro.TabIndex = 9;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.BackColor = System.Drawing.Color.Transparent;
            this.lbGenero.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbGenero.Location = new System.Drawing.Point(9, 292);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(52, 15);
            this.lbGenero.TabIndex = 10;
            this.lbGenero.Text = "Genero:";
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.SystemColors.GrayText;
            this.btOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btOK.FlatAppearance.BorderSize = 0;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOK.Font = new System.Drawing.Font("Swis721 BlkEx BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btOK.Location = new System.Drawing.Point(31, 404);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "Ok";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click_1);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(310, 97);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(129, 23);
            this.txtAltura.TabIndex = 13;
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAltura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAltura.Location = new System.Drawing.Point(260, 100);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(44, 15);
            this.lbAltura.TabIndex = 12;
            this.lbAltura.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(310, 145);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(129, 23);
            this.txtPeso.TabIndex = 15;
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPeso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPeso.Location = new System.Drawing.Point(268, 148);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(36, 15);
            this.lbPeso.TabIndex = 14;
            this.lbPeso.Text = "Peso:";
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMensagem.ForeColor = System.Drawing.Color.Brown;
            this.lbMensagem.Location = new System.Drawing.Point(262, 412);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 15);
            this.lbMensagem.TabIndex = 16;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(310, 206);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(129, 23);
            this.txtMatricula.TabIndex = 18;
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMatricula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbMatricula.Location = new System.Drawing.Point(242, 209);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(62, 15);
            this.lbMatricula.TabIndex = 17;
            this.lbMatricula.Text = "Matricula:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 23);
            this.txtEmail.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbEmail.Location = new System.Drawing.Point(9, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 15);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "E-mail: ";
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRelatorio.Location = new System.Drawing.Point(467, 88);
            this.txtRelatorio.Multiline = true;
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.ReadOnly = true;
            this.txtRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRelatorio.Size = new System.Drawing.Size(321, 221);
            this.txtRelatorio.TabIndex = 21;
            // 
            // imgZelda
            // 
            this.imgZelda.Image = global::prjClinica.Properties.Resources.a61a839aaf15d5bd141a1363b544920d;
            this.imgZelda.Location = new System.Drawing.Point(310, 263);
            this.imgZelda.Name = "imgZelda";
            this.imgZelda.Size = new System.Drawing.Size(129, 129);
            this.imgZelda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgZelda.TabIndex = 22;
            this.imgZelda.TabStop = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btLimpar.FlatAppearance.BorderSize = 0;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpar.Font = new System.Drawing.Font("Swis721 BlkEx BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpar.Location = new System.Drawing.Point(713, 408);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 23;
            this.btLimpar.Text = "RESET";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // imgZelda2
            // 
            this.imgZelda2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgZelda2.BackColor = System.Drawing.SystemColors.Desktop;
            this.imgZelda2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgZelda2.Image = global::prjClinica.Properties.Resources._8975129c3f9f091c97f4297aaea1f5d5;
            this.imgZelda2.Location = new System.Drawing.Point(467, 314);
            this.imgZelda2.Name = "imgZelda2";
            this.imgZelda2.Size = new System.Drawing.Size(321, 88);
            this.imgZelda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgZelda2.TabIndex = 24;
            this.imgZelda2.TabStop = false;
            this.imgZelda2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgZelda2);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.imgZelda);
            this.Controls.Add(this.txtRelatorio);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.rbOutro);
            this.Controls.Add(this.rbMasc);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.lbDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIMC";
            this.Text = "Clinica IMC ZELDA EDITION";
            ((System.ComponentModel.ISupportInitialize)(this.imgZelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgZelda2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox imgZelda;
        private Button btLimpar;
        private PictureBox imgZelda2;
    }
}