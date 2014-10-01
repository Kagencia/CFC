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
        SqlConnection conn;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=cfcdb1;Integrated Security=True;Encrypt=False;TrustServerCertificate=False");
            conn.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM Alunos", conn);
            using(SqlDataAdapter da = new SqlDataAdapter(query))
            {
                DataSet Alunos = new DataSet();
                da.Fill(Alunos, "Alunos");
                dg_relatorio_alunos.DataContext = Alunos;
            }
        }
    }
}
