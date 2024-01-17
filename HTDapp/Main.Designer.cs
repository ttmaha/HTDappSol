namespace HTDapp
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.labelHorario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAbrirAvaliacao = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditarCadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Location = new System.Drawing.Point(611, 376);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(179, 79);
            this.btnNovoCadastro.TabIndex = 1;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Abril Fatface", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorario.Location = new System.Drawing.Point(473, 12);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(70, 22);
            this.labelHorario.TabIndex = 2;
            this.labelHorario.Text = "Horário";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Telefone});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(430, 472);
            this.dataGridView1.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Tel";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // buttonAbrirAvaliacao
            // 
            this.buttonAbrirAvaliacao.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonAbrirAvaliacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAbrirAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirAvaliacao.Location = new System.Drawing.Point(463, 377);
            this.buttonAbrirAvaliacao.Name = "buttonAbrirAvaliacao";
            this.buttonAbrirAvaliacao.Size = new System.Drawing.Size(142, 36);
            this.buttonAbrirAvaliacao.TabIndex = 6;
            this.buttonAbrirAvaliacao.Text = "Abrir Avaliação";
            this.buttonAbrirAvaliacao.UseVisualStyleBackColor = false;
            this.buttonAbrirAvaliacao.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.LightPink;
            this.buttonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Location = new System.Drawing.Point(463, 461);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonEditarCadastro
            // 
            this.buttonEditarCadastro.BackColor = System.Drawing.Color.Wheat;
            this.buttonEditarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCadastro.Location = new System.Drawing.Point(463, 419);
            this.buttonEditarCadastro.Name = "buttonEditarCadastro";
            this.buttonEditarCadastro.Size = new System.Drawing.Size(141, 36);
            this.buttonEditarCadastro.TabIndex = 8;
            this.buttonEditarCadastro.Text = "Editar Cadastro";
            this.buttonEditarCadastro.UseVisualStyleBackColor = false;
            this.buttonEditarCadastro.Click += new System.EventHandler(this.buttonEditarCadastro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HTDapp.Properties.Resources._52B32A58_71B3_4EBE_89C0_07EC90B65679_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(463, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AcceptButton = this.buttonAbrirAvaliacao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEditarCadastro);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAbrirAvaliacao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.btnNovoCadastro);
            this.Name = "Main";
            this.Text = "HTD Software";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button buttonAbrirAvaliacao;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditarCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

