using CFC.Views.Acesso;
using CFC.Views.Ajuda;
using CFC.Views.Arquivo;
using CFC.Views.Cadastro;
using CFC.Views.Cursos;
using CFC.Views.Financeiro;
using CFC.Views.Impressos;
using CFC.Views.Relatorios;
using CFC.Views.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CFC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowEx(Connection conn)
        {
            this.conn = conn;
            this.Show();
        }

        private void clickHook(object sender, RoutedEventArgs e)
        {
            /*Pq Sender as Control? 
             é o msm que ((Control)sender).Name
             
             sender é o objeto que chamou o evento.Como vários objetos estao utilizando,entao o sender vai ser diferente
             entao vc tem que saber quem ta chamando o evento.Se for o menu sair,entao faz uma coisa...
             a gente sabe que só os menus estao usando esse evento,e os menus são do tipo Control
             entoa a gente da um cast no sender pra ver qual menu chamou e ve qual o nome dele*/
            switch ((sender as Control).Name)
            {
                /* MENU ARQUIVO */
                case "contas_a_pagar":
                    var conpa = new Arquivo_Contas_A_Pagar();
                    conpa.ShowDialog();
                    break;

                case "atualizar_base_dados":
                    var atbsda = new Arquivo_Atualizar_Base_De_Dados();
                    atbsda.ShowDialog();
                    break;

                case "apagar_banco_dados":
                    var apbada = new Arquivo_Apagar_Banco_De_Dados();
                    apbada.ShowDialog();
                    break;

                case "configurar_rede":
                    var core = new Arquivo_Configurar_Rede();
                    core.ShowDialog();
                    break;

                case "Sair":
                    var response = MessageBox.Show("Realmente deseja sair da aplicação?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (response == MessageBoxResult.Yes)
                        Environment.Exit(0);
                    break;
                /* FIM MENU ARQUIVO */

                /* MENU CADASTRO*/
                case "cadastro_alunos":
                    var caal = new Cadastro_Funcionario();
                    caal.ShowDialog();
                    break;

                case "cadastro_funcionarios":
                    var cafu = new Cadastro_Funcionario();
                    cafu.ShowDialog();
                    break;

                case "cadastro_bancos":
                    var caba = new Cadastro_Banco();
                    caba.ShowDialog();
                    break;

                case "cadastro_colaboradores":
                    var caco = new Cadastro_Colaborador();
                    caco.ShowDialog();
                    break;

                case "cadastro_contratos":
                    var cacon = new Cadastro_Contrato();
                    cacon.ShowDialog();
                    break;

                case "cadastro_empresas":
                    var caem = new Cadastro_Empresa();
                    caem.ShowDialog();
                    break;

                case "cadastro_tbl_precos":
                    var catbpe = new Cadastro_Tabela_de_Precos();
                    catbpe.ShowDialog();
                    break;

                case "cadastro_veiculos":
                    var cave = new Cadastro_Veiculo();
                    cave.ShowDialog();
                    break;
                /* FIM MENU CADASTRO*/

                /* MENU CURSOS */
                case "configurar_cursos":
                    var cocu = new Cursos_Configurar_Cursos();
                    cocu.ShowDialog();
                    break;

                case "turmas_teoricas":
                    var tute = new Cursos_Turmas_Teoricas();
                    tute.ShowDialog();
                    break;

                case "lista_de_exames":
                    var liex = new Cursos_Lista_De_Exames();
                    liex.ShowDialog();
                    break;

                case "agendamento_de_aulas":
                    var agau = new Cursos_Agendamento_De_Aulas();
                    agau.ShowDialog();
                    break;

                case "marcar_frequencia":
                    var mafr = new Cursos_Marcar_Frequencia();
                    mafr.ShowDialog();
                    break;
                /* FIM MENU CURSOS*/

                /* MENU FINANCEIROS*/
                case "caixa":
                    var ca = new Financeiro_Caixa();
                    ca.ShowDialog();
                    break;
                case "listagem_de_pagamentos":
                    var lidepa = new Financeiro_Listagem_De_Pagamentos();
                    lidepa.ShowDialog();
                    break;
                case "receber_pagamento_numero":
                    var repaponu = new Financeiro_Receber_Pagamento_Por_Numero();
                    repaponu.ShowDialog();
                    break;
                /* FIM MENU FINANCEIROS*/

                /* MENU IMPRESSOS*/
                case "contrato":
                    var co = new Impressos_Contrato();
                    co.ShowDialog();
                    break;
                case "ficha_cadastral_aluno":
                    var ficaal = new Impressos_Ficha_Cadastral_Do_Aluno();
                    ficaal.ShowDialog();
                    break;
                case "carne_pagamentos":
                    var capa = new Impressos_Carne_De_Pagamentos();
                    capa.ShowDialog();
                    break;
                /* FIM MENU IMPRESSOS*/

                /* MENU RELATÓRIOS*/
                case "rel_alunos":
                    var real = new Relatorios_Alunos();
                    real.ShowEx(conn);
                    break;
                case "aniversariantes":
                    var an = new Relatorios_Aniversariantes();
                    an.ShowDialog();
                    break;
                case "agenda_de_aula":
                    var agdeau = new Relatorios_Agenda_De_Aulas();
                    agdeau.ShowDialog();
                    break;
                case "exames":
                    var ex = new Relatorios_Exames();
                    ex.ShowDialog();
                    break;
                case "grade_aulas_instrutor":
                    var grauin = new Relatorios_Grade_De_Aula_Do_Instrutor();
                    grauin.ShowDialog();
                    break;
                case "veiculos":
                    var ve = new Relatorios_Veiculos();
                    ve.ShowDialog();
                    break;
                case "extrato_financeiro_aluno":
                    var exfial = new Relatorios_Extrato_Financeiro_Do_Aluno();
                    exfial.ShowDialog();
                    break;
                case "devedores":
                    var de = new Relatorios_Devedores();
                    de.ShowDialog();
                    break;
                case "graficos":
                    var gr = new Relatorios_Graficos();
                    gr.ShowDialog();
                    break;
                /* FIM MENU RELATÓRIOS*/

                /* MENU UTILITÁRIOS*/
                case "configuracoes":
                    var conf = new Utilitarios_Configuracoes();
                    conf.ShowDialog();
                    break;
                case "bkp_restauracao":
                    var bkpre = new Utilitarios_Backup_Restauracao();
                    bkpre.ShowDialog();
                    break;
                case "bkp_rapido":
                    var bkpra = new Utilitarios_Backup_Rapido();
                    bkpra.ShowDialog();
                    break;
                case "manutencao_banco_dados":
                    var mabada = new Utilitarios_Manutencao_De_Banco_De_Dados();
                    mabada.ShowDialog();
                    break;
                /* FIM MENU UTILITÁRIOS*/

                /* MENU ACESSO*/
                case "alterar_usuario":
                    var alus = new Acesso_Alterar_Usuario();
                    alus.ShowDialog();
                    break;
                case "alterar_senha":
                    var alse = new Acesso_Alterar_Senha();
                    alse.ShowDialog();
                    break;
                case "acesso_configuracoes":
                    var acco = new Acesso_Configuracoes();
                    acco.ShowDialog();
                    break;
                case "acesso_banco_dados":
                    var acbada = new Acesso_Banco_Dados();
                    acbada.ShowDialog();
                    break;
                /* FIM MENU ACESSO*/

                /* MENU AJUDA*/
                case "como_utilizar":
                    var cout = new Ajuda_Como_Utilizar();
                    cout.ShowDialog();
                    break;
                case "manual":
                    var ma = new Ajuda_Manual_Do_Programa();
                    ma.ShowDialog();
                    break;
                case "sobre_programa":
                    var sopr = new Ajuda_Sobre_o_Programa();
                    sopr.ShowDialog();
                    break;
                case "sobre_kagencia":
                    var soka = new Ajuda_Sobre_a_Kagencia();
                    soka.ShowDialog();
                    break;
                case "contrato_licenca":
                    var coli = new Ajuda_Contrato_Licenca_de_Uso();
                    coli.ShowDialog();
                    break;
                case "revalidar":
                    var reva = new Ajuda_Revalidar_Liberacao();
                    reva.ShowDialog();
                    break;
                /* FIM MENU AJUDA*/


            }
        }


        private Connection conn;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        conn = new Connection(@"Data Source=(localdb)\Projects;Initial Catalog=cfcdb1;Integrated Security=True;Encrypt=False;TrustServerCertificate=False");

            if (conn.Connect()) {
                /*Contas a Pagar Resumo*/
                Structs.conta_a_pagar[] conta_a_pagar = conn.GetContasaPagar();

                foreach(Structs.conta_a_pagar item in conta_a_pagar)
                {
                    Views.ListBoxItemEX lb = new Views.ListBoxItemEX();
                    lb.ItemName = item.Conta;
                    lb.ItemPrice = item.Valor.ToString();

                    resumo_contas_a_pagar_lb.Children.Add(lb);
                }

                /*Contas a Receber Resumo*/
                Structs.conta_a_receber[] conta_a_receber = conn.GetContasaReceber();

                foreach (Structs.conta_a_receber item in conta_a_receber)
                {
                    Views.ListBoxItemEX lb = new Views.ListBoxItemEX();

                    lb.ItemName = item.Conta;
                    lb.ItemPrice = item.Valor.ToString();

                    resumo_contas_a_receber_lb.Children.Add(lb);
                }

                /*Faturas Resumo*/
                Structs.conta_a_receber[] faturas = conn.GetContasaReceber();
                float total = 0;

                foreach (Structs.conta_a_receber item in faturas)
                {
                    Views.ListBoxItemEX lb = new Views.ListBoxItemEX();
                    total += item.Valor;
                    lb.ItemName = item.Conta;
                    lb.ItemPrice = item.Valor.ToString();

                    resumo_faturas_lb.Children.Add(lb);
                    /*
                    Select max(sum(preco))
                    from Contas_a_Receber
                    */
                }

                Views.ListBoxItemEX lbTotal = new Views.ListBoxItemEX();
                lbTotal.IsTotal = true;
                lbTotal.ItemName = "Total";
                lbTotal.ItemPrice = total.ToString();

                if (Convert.ToSingle(lbTotal.ItemPrice) < 0)
                {
                    lbTotal.Background = Brushes.Red;
                }
                else
                {
                    lbTotal.Background = Brushes.Green;
                }

                resumo_faturas_lb.Children.Add(lbTotal);

            }
            else
            {
                MessageBox.Show("Connection Failed!");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            clickHook(Sair, null);
        }


    }
}
