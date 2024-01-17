using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlTypes;

namespace HTDapp
{
    public partial class FichaDeAvaliacao : Form
    {
        public string NomePaciente { get; set; }
        public string TelefonePaciente { get; set; }

        public FichaDeAvaliacao()
        {
            InitializeComponent();
            Load += FichaDeAvaliacao_Load;
        }

        private void FichaDeAvaliacao_Load(object sender, EventArgs e)
        {
            labelNomePaciente.Text = NomePaciente;
            labelTelefonePaciente.Text = TelefonePaciente;
            CarregarDadosDoCSV();
        }

        // Restante do código...

        private void AtualizarClienteNoCSV(string nome, string telefone,
            string novaInformacao14, string novaInformacao15,
            string novaInformacao16, string novaInformacao17,
            string novaInformacao18, string novaInformacao19,
            string novaInformacao20, string novaInformacao21,
            string novaInformacao22)
        {
            string caminhoArquivo = @"c:\dados\clientes.csv";

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                bool clienteEncontrado = false;

                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] colunas = linhas[i].Split(';');

                    if (colunas.Length >= 8 && colunas[0].Trim().ToLower() == nome.Trim().ToLower() && colunas[7].Trim().ToLower() == telefone.Trim().ToLower())
                    {
                        clienteEncontrado = true;

                        if (colunas.Length > 13)
                        {
                            colunas[13] = novaInformacao14;
                        }
                        else
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao14);
                            colunas = colunasAtualizadas.ToArray();
                        }

                        if (colunas.Length > 14 && !string.IsNullOrWhiteSpace(novaInformacao15))
                        {
                            colunas[14] = novaInformacao15;
                        }
                        else if (!string.IsNullOrWhiteSpace(novaInformacao15))
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao15);
                            colunas = colunasAtualizadas.ToArray();
                        }

                        if (colunas.Length > 15 && !string.IsNullOrWhiteSpace(novaInformacao16))
                        {
                            colunas[15] = novaInformacao16;
                        }
                        else if (!string.IsNullOrWhiteSpace(novaInformacao16))
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao16);
                            colunas = colunasAtualizadas.ToArray();
                        }

                        if (colunas.Length > 16 && !string.IsNullOrWhiteSpace(novaInformacao17))
                        {
                            colunas[16] = novaInformacao17;
                        }
                        else if (!string.IsNullOrWhiteSpace(novaInformacao17))
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao17);
                            colunas = colunasAtualizadas.ToArray();
                        }

                        if (colunas.Length > 17 && !string.IsNullOrWhiteSpace(novaInformacao18))
                        {
                            colunas[17] = novaInformacao18;
                        }
                        else if (!string.IsNullOrWhiteSpace(novaInformacao18))
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao18);
                            colunas = colunasAtualizadas.ToArray();
                        }

                        if (colunas.Length > 18)
                        {
                            colunas[18] = novaInformacao19;
                        }
                        else
                        {
                            // Adicione colunas vazias para garantir que novaInformacao19 vá para a coluna 19
                            for (int j = colunas.Length; j <= 18; j++)
                            {
                                colunas = colunas.Append(string.Empty).ToArray();
                            }

                            colunas[18] = novaInformacao19;
                        }


                        if (colunas.Length > 19 && !string.IsNullOrWhiteSpace(novaInformacao20))
                        {
                            colunas[19] = novaInformacao20;
                        }
                        else if (!string.IsNullOrWhiteSpace(novaInformacao20))
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao20);
                            colunas = colunasAtualizadas.ToArray();
                        }

                        if (colunas.Length > 20 && !string.IsNullOrWhiteSpace(novaInformacao21))
                        {
                            colunas[20] = novaInformacao21;
                        }
                        else if (!string.IsNullOrWhiteSpace(novaInformacao21))
                        {
                            List<string> colunasAtualizadas = colunas.ToList();
                            colunasAtualizadas.Add(novaInformacao21);
                            colunas = colunasAtualizadas.ToArray();
                        }

                       


                        if (colunas.Length > 21)
                        {
                            colunas[21] = novaInformacao22;
                        }
                        else
                        {
                            // Adicione colunas vazias para garantir que novaInformacao19 vá para a coluna 19
                            for (int j = colunas.Length; j <= 21; j++)
                            {
                                colunas = colunas.Append(string.Empty).ToArray();
                            }

                            colunas[21] = novaInformacao22;
                        }





                        linhas[i] = string.Join(";", colunas);
                        File.WriteAllLines(caminhoArquivo, linhas);

                        MessageBox.Show("Informações atualizadas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    }
                }

                if (!clienteEncontrado)
                {
                    MessageBox.Show("Cliente não encontrado no arquivo CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o arquivo CSV: " + ex.Message + "\n" + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     


        private void buttonSalvarVoltar_Click(object sender, EventArgs e)
        {
            string novaInformacao14 = textBoxPrincipalQueixa.Text;
            string novaInformacao15 = textBoxHistoricoQueixa.Text;
            string novaInformacao16 = textBoxCaracteristicaDor.Text;
            string novaInformacao17 = textBoxOqueMelhora.Text;
            string novaInformacao18 = textBoxOquePiora.Text;

           

            
            string novaInformacao19 = textBoxHoraDor.Text;

          

            string novaInformacao20 = textBoxTratamentosRealizados.Text;
            string novaInformacao21 = textBoxTraumas.Text;
            string novaInformacao22 = textBoxDores.Text;

            AtualizarClienteNoCSV(NomePaciente, TelefonePaciente, novaInformacao14, novaInformacao15, novaInformacao16,
                novaInformacao17, novaInformacao18, novaInformacao19, novaInformacao20, novaInformacao21, novaInformacao22);
            CarregarDadosDoCSV();
            this.Close();
        }





        private void CarregarDadosDoCSV()
        {
            string caminhoArquivo = @"c:\dados\clientes.csv";
            bool fichaExistente = false; // Adicione uma variável para verificar se a ficha já existe

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(';');

                    if (colunas.Length >= 8 && colunas[0].Trim().ToLower() == NomePaciente.Trim().ToLower() &&
                        colunas[7].Trim().ToLower() == TelefonePaciente.Trim().ToLower())
                    {
                        fichaExistente = true; // A ficha existe no CSV

                        if (colunas.Length > 13)
                        {
                            textBoxPrincipalQueixa.Text = colunas[13].Trim();
                        }

                        if (colunas.Length > 14)
                        {
                            textBoxHistoricoQueixa.Text = colunas[14].Trim();
                        }

                        if (colunas.Length > 15)
                        {
                            textBoxCaracteristicaDor.Text = colunas[15].Trim();
                        }

                        if (colunas.Length > 16)
                        {
                            textBoxOqueMelhora.Text = colunas[16].Trim();
                        }

                        if (colunas.Length > 17)
                        {
                            textBoxOquePiora.Text = colunas[17].Trim();
                        }

                        if (colunas.Length > 18)
                        {
                            textBoxHoraDor.Text = colunas[18].Trim();
                        }

                        if (colunas.Length > 19)
                        {
                            textBoxTratamentosRealizados.Text = colunas[19].Trim();
                        }

                        if (colunas.Length > 20)
                        {
                            textBoxTraumas.Text = colunas[20].Trim();
                        }

                        if (colunas.Length > 21)
                        {
                            textBoxDores.Text = colunas[21].Trim();
                        }

                        break;
                    }
                }

                if (!fichaExistente)
                {
                    MessageBox.Show("Ficha Nova.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSalvarProximo_Click(object sender, EventArgs e)
        {

            string novaInformacao14 = textBoxPrincipalQueixa.Text;
            string novaInformacao15 = textBoxHistoricoQueixa.Text;
            string novaInformacao16 = textBoxCaracteristicaDor.Text;
            string novaInformacao17 = textBoxOqueMelhora.Text;
            string novaInformacao18 = textBoxOquePiora.Text;


            string novaInformacao19 = textBoxHoraDor.Text;



            string novaInformacao20 = textBoxTratamentosRealizados.Text;
            string novaInformacao21 = textBoxTraumas.Text;
            string novaInformacao22 = textBoxDores.Text;

            AtualizarClienteNoCSV(NomePaciente, TelefonePaciente, novaInformacao14, novaInformacao15, novaInformacao16,
                novaInformacao17, novaInformacao18, novaInformacao19, novaInformacao20, novaInformacao21, novaInformacao22);
            CarregarDadosDoCSV();

            this.Close();


            FichaDoisAvaliacao fichaDois = new FichaDoisAvaliacao();
            fichaDois.NomePaciente = labelNomePaciente.Text;
            fichaDois.TelefonePaciente = labelTelefonePaciente.Text;

            await Task.Delay(500);
            fichaDois.Show();



        }


    }
}
