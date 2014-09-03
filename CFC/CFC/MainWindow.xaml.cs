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

        private void atualizar_resumo_Click(object sender, RoutedEventArgs e)
        {
            AtualizarResumo at = new AtualizarResumo();
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


    }
}
