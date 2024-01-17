using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTDapp
{
    public partial class FichaDoisAvaliacao : Form
    {
        public string NomePaciente { get; set; }
        public string TelefonePaciente { get; set; }

        public FichaDoisAvaliacao()
        {
            InitializeComponent();
            
        }

        private void buttonAvancarSalvar_Click(object sender, EventArgs e)
        {
            AtualizarInformacoesNoCSV();

           

            FichaTresInspecao fichaTres = new FichaTresInspecao();
            fichaTres.NomePaciente = labelNomePaciente.Text;
            fichaTres.TelefonePaciente = labelTelefonePaciente.Text;
           
            this.Close();





            fichaTres.Show();



        }

        private void AtualizarInformacoesNoCSV()
        {
            string caminhoArquivo = "C:/dados/clientes.csv";

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] colunas = linhas[i].Split(';');

                    if (colunas.Length >= 8 && colunas[0].Trim().ToLower() == NomePaciente.Trim().ToLower() &&
                        colunas[7].Trim().ToLower() == TelefonePaciente.Trim().ToLower())
                    {
                        // Verifica se há colunas suficientes e preenche com string vazia se necessário
                        for (int j = colunas.Length; j <= 31; j++)
                        {
                            colunas = colunas.Append(string.Empty).ToArray();
                        }

                        // Atualiza as informações nas colunas desejadas
                        colunas[22] = textBoxQuestoesViscerais.Text;
                        colunas[23] = textBoxNomeMedicacao.Text;
                        colunas[24] = textBoxParaQueMedicacao.Text;
                        colunas[25] = textBoxDosagemMedicacao.Text;
                        colunas[26] = textBoxDesdeQuandoMedicacao.Text;
                        colunas[27] = textBoxAlimentacao.Text;
                        colunas[28] = textBoxEmocionalTrabalho.Text;
                        colunas[29] = textBoxSonoQualidade.Text;
                        colunas[30] = textBoxAtividadeFisica.Text;
                        colunas[31] = textBoxTrabalho.Text;

                        // Atualiza a linha no array de linhas
                        linhas[i] = string.Join(";", colunas);

                        // Escreve as alterações de volta no arquivo
                        File.WriteAllLines(caminhoArquivo, linhas);

                        MessageBox.Show("Informações atualizadas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Sai do método após encontrar e atualizar o cliente
                    }
                }

                MessageBox.Show("Cliente não encontrado no arquivo CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonVoltarSalvar_Click(object sender, EventArgs e)
        {
            // Adicione aqui o código para voltar ou realizar outras ações necessárias ao clicar no botão Voltar
        }

        private void FichaDoisAvaliacao_Load(object sender, EventArgs e)
        {

            CarregarInformacoesDoCSV();


            labelNomePaciente.Text = NomePaciente;
            labelTelefonePaciente.Text = TelefonePaciente;


        }




        private void CarregarInformacoesDoCSV()
        {
            string caminhoArquivo = "C:/dados/clientes.csv";

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(';');

                    if (colunas.Length >= 8 && colunas[0].Trim().ToLower() == NomePaciente.Trim().ToLower() &&
                        colunas[7].Trim().ToLower() == TelefonePaciente.Trim().ToLower())
                    {
                        // Verifica se as colunas específicas existem antes de preenchê-las
                        if (colunas.Length >= 32)
                        {
                            textBoxQuestoesViscerais.Text = colunas[22];
                            textBoxNomeMedicacao.Text = colunas[23];
                            textBoxParaQueMedicacao.Text = colunas[24];
                            textBoxDosagemMedicacao.Text = colunas[25];
                            textBoxDesdeQuandoMedicacao.Text = colunas[26];
                            textBoxAlimentacao.Text = colunas[27];
                            textBoxEmocionalTrabalho.Text = colunas[28];
                            textBoxSonoQualidade.Text = colunas[29];
                            textBoxAtividadeFisica.Text = colunas[30];
                            textBoxTrabalho.Text = colunas[31];
                        }

                        return; // Sai do método após carregar as informações
                    }
                }

                MessageBox.Show("Cliente não encontrado no arquivo CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar informações do arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVoltarSalvar_Click_1(object sender, EventArgs e)
        {
            AtualizarInformacoesNoCSV();

            

            this.Close();
        }
    }
}
