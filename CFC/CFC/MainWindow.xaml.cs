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

        private void clickHook(object sender, RoutedEventArgs e)
        {
            /*PQ SEnder as Control? 
             
             é o msm que ((Control)sender).Name
             
             sender é o objeto que chamou o evento.Como vários objetos estao utilizando,entao o sender vai ser diferente
             entao vc tem que saber quem ta chamando o evento.Se for o menu sair,entao faz uma coisa...
             a gente sabe que só os menus estao usando esse evento,e os menus são do tipo Control
             entoa a gente da um cast no sender pra ver qual menu chamou e ve qual o nome dele*/
            switch((sender as Control).Name)
            {
                case "Sair":
                    var response = MessageBox.Show("sair?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (response == MessageBoxResult.Yes)
                        Environment.Exit(0);
                    break;

                case "contas_a_pagar":
                    var at = new ContasAPagar();
                    at.ShowDialog();
                    break;
            }
        }

        private void contas_a_pagar_Click(object sender, RoutedEventArgs e)
        {
            ContasAPagar at = new ContasAPagar();
            at.Owner = this;
            at.Show();
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Tem certeza que seseja sair?", "Sair",
                                 MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        private void Sobre_Click(object sender, RoutedEventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Owner = this;
            sobre.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       
        }

        private Connection conn;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn = new Connection(@"Data Source=(localdb)\Projects;Initial Catalog=cfcdb1;Integrated Security=True;Encrypt=False;TrustServerCertificate=False");

            if (conn.Connect()) {
                Structs.Item[] items = conn.GetItems();

                foreach(Structs.Item item in items)
                {
                    Views.ListBoxItemEX lb = new Views.ListBoxItemEX();

                    lb.ItemName = item.Conta;
                    lb.ItemPrice = item.Valor.ToString();

                    itens2.Children.Add(lb);
                }
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }


    }
}
