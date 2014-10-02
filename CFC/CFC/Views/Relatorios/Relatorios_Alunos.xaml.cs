using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace CFC.Views.Relatorios
{
    /// <summary>
    /// Interaction logic for Relatorios_Alunos.xaml
    /// </summary>
    public partial class Relatorios_Alunos : Window
    {
        public Relatorios_Alunos()
        {
            InitializeComponent();
        }
        Connection conn;


        public void ShowEx(Connection conn)
        {
            this.conn = conn;
            this.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn.preencherDataGridAlunos(dg_relatorio_alunos);
        }

        private void btn_Alterar_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void btn_Salvar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void dg_relatorio_alunos_PreviewKeyDown(object sender, KeyEventArgs e)
        {
      
        }
    }
}
