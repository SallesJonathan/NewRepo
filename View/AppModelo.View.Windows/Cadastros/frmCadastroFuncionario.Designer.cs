namespace AppModelo.View.Windows.Cadastros
{
    partial class frmCadastroFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnderecoLogradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnderecoNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnderecoComplemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnderecoBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnderecoMunicipio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEnderecoUf = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbNaturalidade = new System.Windows.Forms.ComboBox();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEnderecoCep = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(17, 133);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(69, 27);
            this.txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(107, 133);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 27);
            this.txtNome.TabIndex = 4;
            this.txtNome.Tag = "Obrigatorio";
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Nascimento*";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(625, 133);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(130, 27);
            this.txtCpf.TabIndex = 8;
            this.txtCpf.Tag = "Obrigatorio";
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(344, 133);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(127, 27);
            this.txtDataNascimento.TabIndex = 9;
            this.txtDataNascimento.Tag = "Obrigatorio";
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome completo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "E-mail";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(254, 283);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(130, 27);
            this.txtTelefone.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cep";
            // 
            // txtEnderecoLogradouro
            // 
            this.txtEnderecoLogradouro.Enabled = false;
            this.txtEnderecoLogradouro.Location = new System.Drawing.Point(17, 416);
            this.txtEnderecoLogradouro.Name = "txtEnderecoLogradouro";
            this.txtEnderecoLogradouro.Size = new System.Drawing.Size(318, 27);
            this.txtEnderecoLogradouro.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Logradouro";
            // 
            // txtEnderecoNumero
            // 
            this.txtEnderecoNumero.Location = new System.Drawing.Point(362, 416);
            this.txtEnderecoNumero.Name = "txtEnderecoNumero";
            this.txtEnderecoNumero.Size = new System.Drawing.Size(109, 27);
            this.txtEnderecoNumero.TabIndex = 19;
            this.txtEnderecoNumero.Tag = "Obrigatorio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Numero";
            // 
            // txtEnderecoComplemento
            // 
            this.txtEnderecoComplemento.Location = new System.Drawing.Point(491, 416);
            this.txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            this.txtEnderecoComplemento.Size = new System.Drawing.Size(234, 27);
            this.txtEnderecoComplemento.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Complemento (opcional)";
            // 
            // txtEnderecoBairro
            // 
            this.txtEnderecoBairro.Enabled = false;
            this.txtEnderecoBairro.Location = new System.Drawing.Point(17, 472);
            this.txtEnderecoBairro.Name = "txtEnderecoBairro";
            this.txtEnderecoBairro.Size = new System.Drawing.Size(217, 27);
            this.txtEnderecoBairro.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bairro";
            // 
            // txtEnderecoMunicipio
            // 
            this.txtEnderecoMunicipio.Enabled = false;
            this.txtEnderecoMunicipio.Location = new System.Drawing.Point(254, 472);
            this.txtEnderecoMunicipio.Name = "txtEnderecoMunicipio";
            this.txtEnderecoMunicipio.Size = new System.Drawing.Size(217, 27);
            this.txtEnderecoMunicipio.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(250, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Municipio";
            // 
            // txtEnderecoUf
            // 
            this.txtEnderecoUf.Enabled = false;
            this.txtEnderecoUf.Location = new System.Drawing.Point(491, 472);
            this.txtEnderecoUf.Name = "txtEnderecoUf";
            this.txtEnderecoUf.Size = new System.Drawing.Size(109, 27);
            this.txtEnderecoUf.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 449);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "UF";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(506, 151);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 24);
            this.rbMasculino.TabIndex = 28;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(506, 129);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(87, 24);
            this.rbFeminino.TabIndex = 29;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(502, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Sexo";
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.AccessibleDescription = "";
            this.cmbNacionalidade.AccessibleName = "";
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Location = new System.Drawing.Point(17, 204);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(156, 28);
            this.cmbNacionalidade.TabIndex = 31;
            this.cmbNacionalidade.Tag = "Obrigatorio";
            this.cmbNacionalidade.Click += new System.EventHandler(this.cmbNacionalidade_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Nacionalidade*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(190, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 20);
            this.label18.TabIndex = 34;
            this.label18.Text = "Naturalidade";
            // 
            // cmbNaturalidade
            // 
            this.cmbNaturalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaturalidade.FormattingEnabled = true;
            this.cmbNaturalidade.Location = new System.Drawing.Point(194, 204);
            this.cmbNaturalidade.Name = "cmbNaturalidade";
            this.cmbNaturalidade.Size = new System.Drawing.Size(130, 28);
            this.cmbNaturalidade.TabIndex = 33;
            this.cmbNaturalidade.Click += new System.EventHandler(this.cmbNaturalidade_Click);
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.Location = new System.Drawing.Point(413, 283);
            this.txtTelefoneContato.Mask = "(##) #####-####";
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(130, 27);
            this.txtTelefoneContato.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(409, 260);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "Telefone contato";
            // 
            // txtEnderecoCep
            // 
            this.txtEnderecoCep.Location = new System.Drawing.Point(17, 360);
            this.txtEnderecoCep.Mask = "#####-###";
            this.txtEnderecoCep.Name = "txtEnderecoCep";
            this.txtEnderecoCep.Size = new System.Drawing.Size(130, 27);
            this.txtEnderecoCep.TabIndex = 37;
            this.txtEnderecoCep.Tag = "Obrigatorio";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.Location = new System.Drawing.Point(153, 360);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(92, 27);
            this.btnPesquisarCep.TabIndex = 38;
            this.btnPesquisarCep.Text = "Pesquisar";
            this.btnPesquisarCep.UseVisualStyleBackColor = true;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(640, 475);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 36);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "Salvar";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 523);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.btnPesquisarCep);
            this.Controls.Add(this.txtEnderecoCep);
            this.Controls.Add(this.txtTelefoneContato);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbNaturalidade);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbNacionalidade);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.txtEnderecoUf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEnderecoMunicipio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEnderecoBairro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEnderecoComplemento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEnderecoNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEnderecoLogradouro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroFuncionario";
            this.Tag = "";
            this.Text = "frmCadastroFuncionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnderecoLogradouro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEnderecoNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEnderecoComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnderecoBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnderecoMunicipio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEnderecoUf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbNaturalidade;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txtEnderecoCep;
        private System.Windows.Forms.Button btnPesquisarCep;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button SaveButton;
    }
}