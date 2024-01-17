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
using static HTDapp.Main;
using static System.Windows.Forms.LinkLabel;

namespace HTDapp
{
    public partial class Main : Form
    {
        Timer timer; // Declare um temporizador 
        public Main()
        {
            InitializeComponent();
            CarregarDadosNoDataGridView();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Inicialize o temporizador
            timer = new Timer();
            timer.Interval = 1000; // Configura o intervalo para 1 segundo (1000 milissegundos)
            timer.Tick += Timer_Tick; // Adiciona o manipulador de eventos
            timer.Start(); // Inicia o temporizador
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Método chamado a cada segundo pelo temporizador
            AtualizarLabelHorario();
        }

   

        private void AtualizarLabelHorario()
        {
            DateTime agora = DateTime.Now;
            labelHorario.Text = agora.ToString("dd/MM/yyyy HH:mm:ss");

        }




        private void button1_Click(object sender, EventArgs e)
        {
            NovoCadastro cadastroNovo = new NovoCadastro();

            cadastroNovo.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?","Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
            {
                e.Cancel = true;            
            }
        }

        private void Informar(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool Confirmar(string pergunta)
        {
            return MessageBox.Show(pergunta, "Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            // Verifique se há pelo menos uma linha selecionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

                // Obtém o valor da célula na primeira coluna (índice 0) da linha selecionada
                string nome = dataGridView1.Rows[indiceLinhaSelecionada].Cells[0].Value?.ToString();
                string telefone = dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value?.ToString();

                // Verifica se o nome não é vazio
                if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(telefone))
                {
                    // Cria uma instância do formulário FichaDeAvaliacao
                    FichaDeAvaliacao fichaForm = new FichaDeAvaliacao();

                    // Define as propriedades NomePaciente e TelefonePaciente
                    fichaForm.NomePaciente = nome;
                    fichaForm.TelefonePaciente = telefone;

                    // Exibe o formulário FichaDeAvaliacao
                    fichaForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("O nome ou telefone na linha selecionada está vazio. Não é possível abrir a ficha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para abrir a ficha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void CarregarDadosNoDataGridView()
        {
            // Especifique o caminho do seu arquivo CSV
            string caminhoArquivo = @"c:\dados\clientes.csv";

            List<string> linhasLidas = LerTodasPrimeirasLinhasCSV(caminhoArquivo);

            // Limpe o DataGridView antes de adicionar novos dados
            dataGridView1.Rows.Clear();

            // Adicionar Dados ao DataGridView
            AdicionarDadosAoDataGrid(linhasLidas);
        }




        private List<string> LerTodasPrimeirasLinhasCSV(string caminhoArquivo)
        {
            List<string> linhasLidas = new List<string>();

            try
            {
                using (StreamReader arquivo = new StreamReader(caminhoArquivo))
                {
                    // Continue lendo até atingir o final do arquivo
                    while (!arquivo.EndOfStream)
                    {
                        string linha = arquivo.ReadLine();
                        linhasLidas.Add(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return linhasLidas;
        }

        private void AdicionarDadosAoDataGrid(List<string> linhas)
        {
            // Adicione linhas ao DataGridView com os dados do CSV
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(';');

                // Certifique-se de que há pelo menos dois elementos no array antes de acessar a segunda coluna
                if (dados.Length >= 8)
                {
                    try
                    {
                        // Tente converter os dados para garantir que são válidos
                        string nome = dados[0];
                        string telefone = dados[7];

                        // Adicione as primeiras duas colunas (nome e telefone) ao DataGridView
                        dataGridView1.Rows.Add(nome, telefone);
                    }
                    catch (Exception ex)
                    {
                        // Se ocorrer um erro ao converter os dados, exiba uma mensagem de erro detalhada
                        MessageBox.Show($"Erro ao processar a linha do arquivo CSV: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    
                }
            }
        }





        public void AtualizarDataGridView()
        {
            // Chame a função que carrega os dados no DataGridView
            CarregarDadosNoDataGridView();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            // Verifique se há pelo menos uma linha selecionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int indiceLinhaSelecionada = dataGridView1.SelectedRows[0].Index;

                // Obtém o valor da célula na primeira coluna (índice 0) da linha selecionada
                string nome = dataGridView1.Rows[indiceLinhaSelecionada].Cells[0].Value?.ToString();
                string telefone = dataGridView1.Rows[indiceLinhaSelecionada].Cells[1].Value?.ToString();

                // Verifica se o nome não é vazio
                if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(telefone))
                {
                    // Mostra uma caixa de mensagem de confirmação
                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Se o usuário clicar em "Sim" na caixa de mensagem de confirmação
                    if (resultado == DialogResult.Yes)
                    {
                        // Remove a linha do DataGridView
                        dataGridView1.Rows.RemoveAt(indiceLinhaSelecionada);

                        // Atualiza o arquivo CSV removendo a linha correspondente
                        AtualizarArquivoCSV(nome, telefone);
                    }
                }
                else
                {
                    MessageBox.Show("O nome ou telefone na linha selecionada está vazio. Não é possível excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void AtualizarArquivoCSV(string nome, string telefone)
        {
            // Especifique o caminho do seu arquivo CSV
            string caminhoArquivo = @"c:\dados\clientes.csv";

            try
            {
                // Obtenha todas as linhas do arquivo CSV
                List<string> linhas = File.ReadAllLines(caminhoArquivo).ToList();

                // Mantenha apenas as linhas que não correspondem ao cliente selecionado
                linhas = linhas.Where(linha =>
                {
                    string[] colunas = linha.Split(';');
                    return colunas.Length >= 8 &&
                           colunas[0].Trim().ToLower() != nome.Trim().ToLower() &&
                           colunas[1].Trim().ToLower() != telefone.Trim().ToLower();
                })
                .ToList();

                // Salve as linhas atualizadas no arquivo CSV
                File.WriteAllLines(caminhoArquivo, linhas);

                MessageBox.Show("Linha excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o arquivo CSV: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEditarCadastro_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nomeSelecionado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string telefoneSelecionado = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                string caminhoArquivo = "C:/dados/clientes.csv";
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                string[] dadosCliente = null;

                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(';');

                    if (colunas.Length >= 8 &&
                        colunas[0].Trim().ToLower() == nomeSelecionado.ToLower() &&
                        colunas[7].Trim().ToLower() == telefoneSelecionado.ToLower())
                    {
                        // Encontrou a linha correspondente, armazene os dados
                        dadosCliente = colunas;
                        break;
                    }
                }

                if (dadosCliente != null)
                {
                    NovoCadastro novoCadastroForm = new NovoCadastro();
                    novoCadastroForm.SetDadosCliente(dadosCliente);
                    novoCadastroForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado no arquivo CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha no DataGridView para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
    }
}
