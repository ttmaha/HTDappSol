using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTDapp
{
    public partial class NovoCadastro : Form
    {
        public NovoCadastro()
        {
            InitializeComponent();
            
        }


      


        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se há informações nos campos Nome e Telefone
            if (!string.IsNullOrWhiteSpace(textBoxNome.Text) && !string.IsNullOrWhiteSpace(textBoxTelefone.Text))
            {
                // Ambos os campos estão preenchidos, pode prosseguir com o salvamento
                SalvarClientCsv();
                LimparForm();

                // Obtém uma referência para o Main (assumindo que Main é o tipo do seu formulário principal)
                Main main = Application.OpenForms.OfType<Main>().FirstOrDefault();

                // Atualiza o DataGridView no Main
                main?.AtualizarDataGridView();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Os dados foram salvos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha o formulário atual
                this.Close();
            }
            else
            {
                // Exibe uma mensagem de aviso se os campos Nome ou Telefone estiverem vazios
                MessageBox.Show("Preencha os campos Nome e Telefone antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparForm()
        {
                        textBoxNome.Text = "";
                        textBoxCPF.Text = "";
                        textBoxProfissao.Text = "";
                        numericUpDownFilhos.Value = 0;
                        comboBoxEstadoCivil.SelectedIndex = -1;
                        textBoxEncaminhadoPor.Text = "";
                        textBoxBairro.Text = "";
                        textBoxTelefone.Text = "";
                        textBoxEndereço.Text = "";
                        dateTimePickerNascimento.Text = "";
                        textBoxNacionalidade.Text = "";
                        textBoxPrimeiraConsulta.Text = "";
                        textBoxEmail.Text = "";
                        textBoxNome.Focus();
        }

        private void SalvarClientCsv()
        {
            string caminhoArquivo = @"c:\dados\clientes.csv";
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            bool clienteExistente = false;

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] colunas = linhas[i].Split(';');

                if (colunas.Length >= 8 && colunas[0].Trim().ToLower() == textBoxNome.Text.Trim().ToLower() && colunas[7].Trim().ToLower() == textBoxTelefone.Text.Trim().ToLower())
                {
                    // Cliente encontrado, mantenha as informações a partir do índice 13 e atualize as outras colunas
                    string colunasPosteriores = string.Join(";", colunas.Skip(13));
                    linhas[i] = MontarLinhaCSV() + ";" + colunasPosteriores;
                    clienteExistente = true;
                    break;
                }
            }

            if (!clienteExistente)
            {
                // Se o cliente não foi encontrado, adicione uma nova linha
                string novaLinha = MontarLinhaCSV();
                Array.Resize(ref linhas, linhas.Length + 1);
                linhas[linhas.Length - 1] = novaLinha;
            }

            // Reescreva o arquivo com as modificações
            File.WriteAllLines(caminhoArquivo, linhas);
        }



        private string MontarLinhaCSV()
        {
            return $"{textBoxNome.Text.Trim()};" +
                $"{textBoxCPF.Text.Trim()};" +
                $"{numericUpDownFilhos.Value.ToString()};" +
                $"{textBoxProfissao.Text.Trim()};" +
                $"{comboBoxEstadoCivil.SelectedIndex};" +
                $"{textBoxEncaminhadoPor.Text.Trim()};" +
                $"{textBoxBairro.Text.Trim()};" +
                $"{textBoxTelefone.Text.Trim()};" +
                $"{textBoxEndereço.Text.Trim()};" +
                $"{dateTimePickerNascimento.Text.Trim()};" +
                $"{textBoxNacionalidade.Text.Trim()};" +
                $"{textBoxEmail.Text.Trim()};" +
                $"{textBoxPrimeiraConsulta.Text.Trim()}";
        }

        private void NovoCadastro_Load(object sender, EventArgs e)
        {

        }


        public void SetDadosCliente(string[] dadosCliente)
        {
            if (dadosCliente.Length >= 8)
            {
                textBoxNome.Text = dadosCliente[0].Trim();
                textBoxTelefone.Text = dadosCliente[7].Trim();
                textBoxProfissao.Text = dadosCliente[3].Trim();
                textBoxCPF.Text = dadosCliente[1].Trim();
                textBoxEncaminhadoPor.Text = dadosCliente[5].Trim();
                textBoxBairro.Text = dadosCliente[6].Trim();
                textBoxEndereço.Text = dadosCliente[8].Trim();
                dateTimePickerNascimento.Text = dadosCliente[9].Trim();
                textBoxNacionalidade.Text = dadosCliente[10].Trim();

   
                textBoxEmail.Text = dadosCliente[11].Trim();
                textBoxPrimeiraConsulta.Text = dadosCliente[12].Trim();

                if (int.TryParse(dadosCliente[2].Trim(), out int numeroFilhos))
                {
                    numericUpDownFilhos.Value = numeroFilhos;
                }

                // Preencha os outros campos conforme necessário

                if (int.TryParse(dadosCliente[4].Trim(), out int indiceEstadoCivil))
                {
                    // Verifique se o índice está dentro do intervalo válido do ComboBox
                    if (indiceEstadoCivil >= 0 && indiceEstadoCivil < comboBoxEstadoCivil.Items.Count)
                    {
                        comboBoxEstadoCivil.SelectedIndex = indiceEstadoCivil;
                    }
                    else
                    {
                        // Lida com o caso em que o índice não é válido
                    }
                }
                else
                {
                    // Caso a conversão falhe, você pode lidar com isso conforme necessário
                    MessageBox.Show("Valor do estado civil inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

       
    }
}
