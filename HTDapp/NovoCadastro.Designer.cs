namespace HTDapp
{
    partial class NovoCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEndereço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProfissao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEncaminhadoPor = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownFilhos = new System.Windows.Forms.NumericUpDown();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPrimeiraConsulta = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilhos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxNome.Location = new System.Drawing.Point(71, 18);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(279, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // textBoxEndereço
            // 
            this.textBoxEndereço.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEndereço.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBoxEndereço.Location = new System.Drawing.Point(99, 142);
            this.textBoxEndereço.Name = "textBoxEndereço";
            this.textBoxEndereço.Size = new System.Drawing.Size(680, 20);
            this.textBoxEndereço.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço/Rua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nascimento:";
            // 
            // textBoxProfissao
            // 
            this.textBoxProfissao.AutoCompleteCustomSource.AddRange(new string[] {
            "Médico",
            "Enfermeiro",
            "Advogado",
            "Professor",
            "Engenheiro",
            "Dentista",
            "Policial",
            "Bombeiro",
            "Farmacêutico",
            "Arquiteto",
            "Psicólogo",
            "Contador",
            "Jornalista",
            "Programador",
            "Designer",
            "Eletricista",
            "Mecânico",
            "Pedreiro",
            "Motorista",
            "Agricultor",
            "Cientista",
            "Biólogo",
            "Químico",
            "Fisioterapeuta",
            "Nutricionista",
            "Veterinário",
            "Economista",
            "Geólogo",
            "Astrônomo",
            "Pintor",
            "Cozinheiro",
            "Garçom",
            "Músico",
            "Ator",
            "Diretor de cinema",
            "Produtor de TV",
            "Fotógrafo",
            "Cabeleireiro",
            "Maquiador",
            "Esteticista",
            "Massagista",
            "Consultor financeiro",
            "Analista de sistemas",
            "Gerente de projetos",
            "Consultor de marketing",
            "Analista de RH",
            "Piloto",
            "Marinheiro",
            "Técnico em informática",
            "Técnico em enfermagem",
            "Técnico em segurança do trabalho",
            "Técnico em eletrônica",
            "Técnico em radiologia",
            "Técnico em química",
            "Técnico em edificações",
            "Técnico agrícola",
            "Técnico em nutrição",
            "Técnico em estética",
            "Técnico em laboratório",
            "Técnico em contabilidade",
            "Técnico em logística",
            "Técnico em design de interiores",
            "Técnico em saneamento",
            "Técnico em telecomunicações",
            "Técnico em meio ambiente",
            "Técnico em geoprocessamento",
            "Técnico em mineração",
            "Técnico em meteorologia",
            "Técnico em patologia",
            "Técnico em agropecuária",
            "Técnico em climatização",
            "Técnico em manutenção",
            "Técnico em redes",
            "Técnico em radiologia industrial",
            "Técnico em eletromecânica"});
            this.textBoxProfissao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxProfissao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxProfissao.Location = new System.Drawing.Point(71, 58);
            this.textBoxProfissao.Name = "textBoxProfissao";
            this.textBoxProfissao.Size = new System.Drawing.Size(279, 20);
            this.textBoxProfissao.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profissão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado cívil:";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxTelefone.Location = new System.Drawing.Point(446, 101);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(333, 20);
            this.textBoxTelefone.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data da Primeira Consulta:";
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viuvo(a)",
            "Divorciado(a)"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(446, 58);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(81, 21);
            this.comboBoxEstadoCivil.TabIndex = 5;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxBairro.Location = new System.Drawing.Point(71, 101);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(279, 20);
            this.textBoxBairro.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Encaminhado por:";
            // 
            // textBoxEncaminhadoPor
            // 
            this.textBoxEncaminhadoPor.Location = new System.Drawing.Point(632, 61);
            this.textBoxEncaminhadoPor.Name = "textBoxEncaminhadoPor";
            this.textBoxEncaminhadoPor.Size = new System.Drawing.Size(147, 20);
            this.textBoxEncaminhadoPor.TabIndex = 6;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(446, 19);
            this.textBoxCPF.Mask = "000,000,000-00";
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(194, 20);
            this.textBoxCPF.TabIndex = 2;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(150, 181);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(86, 20);
            this.dateTimePickerNascimento.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(686, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Filhos:";
            // 
            // numericUpDownFilhos
            // 
            this.numericUpDownFilhos.Location = new System.Drawing.Point(729, 18);
            this.numericUpDownFilhos.Name = "numericUpDownFilhos";
            this.numericUpDownFilhos.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownFilhos.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(536, 328);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(159, 64);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Nacionalidade:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "@gmail.com",
            "@hotmail.com",
            "@outlook.com",
            "@yahoo.com.br"});
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEmail.Location = new System.Drawing.Point(378, 177);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(401, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Email:";
            // 
            // textBoxPrimeiraConsulta
            // 
            this.textBoxPrimeiraConsulta.Location = new System.Drawing.Point(150, 252);
            this.textBoxPrimeiraConsulta.Name = "textBoxPrimeiraConsulta";
            this.textBoxPrimeiraConsulta.Size = new System.Drawing.Size(279, 20);
            this.textBoxPrimeiraConsulta.TabIndex = 13;
            // 
            // textBoxNacionalidade
            // 
            this.textBoxNacionalidade.Location = new System.Drawing.Point(150, 214);
            this.textBoxNacionalidade.Name = "textBoxNacionalidade";
            this.textBoxNacionalidade.Size = new System.Drawing.Size(144, 20);
            this.textBoxNacionalidade.TabIndex = 12;
            this.textBoxNacionalidade.Tag = "";
            this.textBoxNacionalidade.Text = "Brasileiro";
            // 
            // NovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.textBoxNacionalidade);
            this.Controls.Add(this.textBoxPrimeiraConsulta);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.numericUpDownFilhos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxEncaminhadoPor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxEstadoCivil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxProfissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEndereço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "NovoCadastro";
            this.Text = "NovoCadastro";
            this.Load += new System.EventHandler(this.NovoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndereço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProfissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEncaminhadoPor;
        private System.Windows.Forms.MaskedTextBox textBoxCPF;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownFilhos;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPrimeiraConsulta;
        private System.Windows.Forms.TextBox textBoxNacionalidade;
    }
}