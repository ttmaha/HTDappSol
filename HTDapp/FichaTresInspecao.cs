using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTDapp
{
    public partial class FichaTresInspecao : Form
    {
        public string NomePaciente { get; set; }
        public string TelefonePaciente { get; set; }

        private int numeroColunasEsperado = 78;
        private string caminhoArquivo = "C:/dados/clientes.csv";

        private bool dadosCarregados = false;

        public FichaTresInspecao()
        {
            InitializeComponent();

            // Adicione aqui a lógica para verificar se o arquivo CSV existe
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo CSV não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Adicione lógica adicional conforme necessário (pode ser criar o arquivo, informar ao usuário, etc.)
            }
        }

        private void FichaTresInspecao_Load(object sender, EventArgs e)
        {
            labelNomePaciente.Text = NomePaciente;
            labelTelefonePaciente.Text = TelefonePaciente;
            
            
        }

        private void AtualizarDadosNoCSV()
        {
            // Adapte a lógica conforme necessário
            LerECriarColunasDoCSV();
            dadosCarregados = true; // Indica que os dados foram carregados

        }

        private void LerECriarColunasDoCSV()
        {
            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    MessageBox.Show("Arquivo CSV não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<string> linhas = new List<string>(File.ReadAllLines(caminhoArquivo));
                bool clienteEncontrado = false;

                for (int i = 0; i < linhas.Count; i++)
                {
                    string[] colunas = linhas[i].Split(';');

                    // Verifica se encontrou o cliente na linha
                    if (colunas.Length > 7 && colunas[0].Trim().ToLower() == NomePaciente.Trim().ToLower() &&
                    colunas[7].Trim().ToLower() == TelefonePaciente.Trim().ToLower())
                    {
                        clienteEncontrado = true;

                        // Garante que há colunas suficientes antes de acessá-las
                        if (GarantirColunasSuficientes(ref colunas))
                        {
                            // Atualiza as informações nas colunas desejadas
                            AtualizarValoresEmColunas(colunas);

                            // Atualiza a linha no array de linhas
                            linhas[i] = string.Join(";", colunas);

                            // Adicione mensagens de debug para verificar os valores após a atualização
                           
                           

                            break; // Sai do loop após encontrar e atualizar o cliente
                        }
                        else
                        {
                            MessageBox.Show("Erro: O arquivo CSV não possui colunas suficientes. (LER E CRIAR)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Adicionado para sair do método em caso de erro
                        }
                    }
                }

                if (!clienteEncontrado)
                {
                    MessageBox.Show("Cliente não encontrado no arquivo CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Escreve as alterações de volta no arquivo
                File.WriteAllLines(caminhoArquivo, linhas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar informações do arquivo CSV: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GarantirColunasSuficientes(ref string[] colunas)
        {
            // Se o número de colunas for menor que o esperado, adicione as colunas ausentes
            if (colunas.Length < numeroColunasEsperado)
            {
                // Crie um novo array com o tamanho esperado e copie os valores existentes
                string[] novasColunas = new string[numeroColunasEsperado];
                Array.Copy(colunas, novasColunas, colunas.Length);

                // Adicione valores padrão ou vazios às colunas ausentes a partir da posição 32
                for (int j = colunas.Length; j < numeroColunasEsperado; j++)
                {
                    // Verifica se a coluna está vazia e preenche com string vazia se necessário
                    novasColunas[j] = string.Empty;
                }

                // Atualize os valores do array original com os valores do novo array
                colunas = novasColunas;

                return true;
            }

            return colunas.Length == numeroColunasEsperado;
        }

        private void AtualizarValoresEmColunas(string[] colunas)
        {
            // Certifique-se de que o array de colunas tenha pelo menos 78 elementos
            if (GarantirColunasSuficientes(ref colunas))
            {
                // Adicione as demais atualizações de acordo com o índice da coluna
                colunas[32] = checkBoxNormalCervical.Checked.ToString();
                colunas[33] = checkBoxCervicalHiperlordose.Checked.ToString();
                colunas[34] = checkBoxCervicalRetificacao.Checked.ToString();
                colunas[35] = checkBoxCervicalInversao.Checked.ToString();
                colunas[36] = checkBoxNormalTorarica.Checked.ToString();
                colunas[37] = checkBoxToracicHipercifose.Checked.ToString();
                colunas[38] = checkBoxToraricaRetificacao.Checked.ToString();
                colunas[39] = checkBoxToracicaInversao.Checked.ToString();
                colunas[40] = checkBoxNormalLombar.Checked.ToString();
                colunas[41] = checkBoxLombarHiperLordose.Checked.ToString();
                colunas[42] = checkBoxLombarRetificacao.Checked.ToString();
                colunas[43] = checkBoxLombarInversao.Checked.ToString();
                colunas[44] = checkBoxTorcaoAntD.Checked.ToString();
                colunas[45] = checkBoxTorcaoAntE.Checked.ToString();
                colunas[46] = checkBoxElevacaoD.Checked.ToString();
                colunas[47] = checkBoxRetroversao.Checked.ToString();
                colunas[48] = checkBoxAnteversao.Checked.ToString();
                colunas[49] = checkBoxElevaoE.Checked.ToString();
                colunas[50] = textBoxPeDireitoDesc.Text;
                colunas[51] = textBoxPeEsquerdoDesc.Text;
                colunas[52] = checkBoxPeDireitoVaro.Checked.ToString();
                colunas[53] = checkBoxPeEsquerdoVaro.Checked.ToString();
                colunas[54] = checkBoxPeDireitoValgo.Checked.ToString();
                colunas[55] = checkBoxPeEsquerdoValgo.Checked.ToString();
                colunas[56] = checkBoxPeDireitoPlano.Checked.ToString();
                colunas[57] = checkBoxPeEsquerdoPlano.Checked.ToString();
                colunas[58] = checkBoxPeDireitoCavo.Checked.ToString();
                colunas[59] = checkBoxPeEsquerdoCavo.Checked.ToString();
                colunas[60] = checkBoxClasse1.Checked.ToString();
                colunas[61] = checkBoxClasse2.Checked.ToString();
                colunas[62] = checkBoxATMAberta.Checked.ToString();
                colunas[63] = checkBoxATMProfunda.Checked.ToString();
                colunas[64] = checkBoxClasse3.Checked.ToString();
                colunas[65] = checkBoxMordidaCruzadaE.Checked.ToString();
                colunas[66] = checkBoxMordidaCruzadaD.Checked.ToString();
                colunas[67] = checkBoxMordidaCruzadaBilateral.Checked.ToString();
                colunas[68] = textBoxAusenciaDentes.Text;
                colunas[69] = checkBoxEstrabismoConvergenteD.Checked.ToString();
                colunas[70] = checkBoxEstrabismoConvegenteE.Checked.ToString();
                colunas[71] = checkBoxEstrabismoDivergenteE.Checked.ToString();
                colunas[72] = checkBoxEstrabismoDivergenteD.Checked.ToString();
                colunas[73] = checkBoxHipoConvergenciaD.Checked.ToString();
                colunas[74] = checkBoxHipoConvergenciaE.Checked.ToString();
                colunas[75] = checkBoxHipoConvergenciaBilateral.Checked.ToString();
                colunas[76] = textBoxCicatrizes.Text;
                colunas[77] = textBoxOutrasInfos.Text;

                // Adicione as colunas adicionais e atualizações conforme necessário
            }
            else
            {
                MessageBox.Show("Erro: O arquivo CSV não possui colunas suficientes (ATUALIZAR VALORES).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarDadosDoCSVParaFormulario(string[] colunas)
        {
            try
            {
                // Certifique-se de adaptar isso para seus controles específicos e índices de coluna
                bool valorBool;

                if (GarantirColunasSuficientes(ref colunas))
                {
                    // Itera pelos índices de 32 a 77
                    for (int i = 32; i <= 77; i++)
                    {
                        if (colunas.Length > i)
                        {
                            // Verifica se o valor é null e atribui uma string vazia se for o caso
                            colunas[i] = colunas[i] ?? string.Empty;

                            // Trata os TextBox e CheckBox de acordo com o índice
                            switch (i)
                            {
                                case 32:
                                    checkBoxNormalCervical.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 33:
                                    checkBoxCervicalHiperlordose.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 34:
                                    checkBoxCervicalRetificacao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 35:
                                    checkBoxCervicalInversao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 36:
                                    checkBoxNormalTorarica.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 37:
                                    checkBoxToracicHipercifose.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 38:
                                    checkBoxToraricaRetificacao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 39:
                                    checkBoxToracicaInversao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 40:
                                    checkBoxNormalLombar.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 41:
                                    checkBoxLombarHiperLordose.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 42:
                                    checkBoxLombarRetificacao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 43:
                                    checkBoxLombarInversao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 44:
                                    checkBoxTorcaoAntD.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 45:
                                    checkBoxTorcaoAntE.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 46:
                                    checkBoxElevacaoD.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 47:
                                    checkBoxRetroversao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 48:
                                    checkBoxAnteversao.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 49:
                                    checkBoxElevaoE.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 50:
                                    textBoxPeDireitoDesc.Text = colunas[i];
                                    break;
                                case 51:
                                    textBoxPeEsquerdoDesc.Text = colunas[i];
                                    break;
                                case 52:
                                    checkBoxPeDireitoVaro.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 53:
                                    checkBoxPeEsquerdoVaro.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 54:
                                    checkBoxPeDireitoValgo.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 55:
                                    checkBoxPeEsquerdoValgo.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 56:
                                    checkBoxPeDireitoPlano.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 57:
                                    checkBoxPeEsquerdoPlano.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 58:
                                    checkBoxPeDireitoCavo.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 59:
                                    checkBoxPeEsquerdoCavo.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 60:
                                    checkBoxClasse1.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 61:
                                    checkBoxClasse2.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 62:
                                    checkBoxATMAberta.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 63:
                                    checkBoxATMProfunda.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 64:
                                    checkBoxClasse3.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 65:
                                    checkBoxMordidaCruzadaE.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 66:
                                    checkBoxMordidaCruzadaD.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 67:
                                    checkBoxMordidaCruzadaBilateral.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 68:
                                    textBoxAusenciaDentes.Text = colunas[i];
                                    break;
                                case 69:
                                    checkBoxEstrabismoConvergenteD.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 70:
                                    checkBoxEstrabismoConvegenteE.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 71:
                                    checkBoxEstrabismoDivergenteE.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 72:
                                    checkBoxEstrabismoDivergenteD.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 73:
                                    checkBoxHipoConvergenciaD.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 74:
                                    checkBoxHipoConvergenciaE.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 75:
                                    checkBoxHipoConvergenciaBilateral.Checked = bool.TryParse(colunas[i], out valorBool) ? valorBool : false;
                                    break;
                                case 76:
                                    textBoxCicatrizes.Text = colunas[i];
                                    break;
                                case 77:
                                    textBoxOutrasInfos.Text = colunas[i];
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    // ...
                }
                else
                {
                    MessageBox.Show("Erro: O arquivo CSV não possui colunas suficientes. (CARREGAR DADOS)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do arquivo CSV para o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSalvarFechar_Click(object sender, EventArgs e)
        {
            AtualizarDadosNoCSV(); // Chamada para atualizar dados antes de fechar
            MessageBox.Show("Os dados foram salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            
        }

        private void FichaTresInspecao_Shown(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                // Se o arquivo CSV existe, carrega os dados para o formulário
                List<string> linhas = new List<string>(File.ReadAllLines(caminhoArquivo));

                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(';');

                    // Verifica se encontrou o cliente na linha
                    if (colunas.Length > 7 && colunas[0].Trim().ToLower() == NomePaciente.Trim().ToLower() &&
                        colunas[7].Trim().ToLower() == TelefonePaciente.Trim().ToLower())
                    {
                        CarregarDadosDoCSVParaFormulario(colunas);
                        break;
                    }
                }
            }
        }

        private void buttonVoltarSalvar_Click(object sender, EventArgs e)
        {
           
            
            AtualizarDadosNoCSV(); // Chamada para atualizar dados antes de fechar
            MessageBox.Show("Os dados foram salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FichaDoisAvaliacao fichaDois = new FichaDoisAvaliacao();
            fichaDois.NomePaciente = labelNomePaciente.Text;
            fichaDois.TelefonePaciente = labelTelefonePaciente.Text;

            this.Close();

           

           
            fichaDois.Show();



        }
    }
}