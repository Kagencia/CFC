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
using System.Windows.Shapes;
using CFC.Views;

namespace CFC
{
    /// <summary>
    /// Interaction logic for AtualizarResumo.xaml
    /// </summary>
    public partial class ContasAPagar : Window
    {
        public List<Client> Clients { get; set; }
        public ContasAPagar()
        {
            Clients = new List<Client>();
            Clients.Add(new Client(
                1, "Klaus Bernardo", "Ribeirão Pires", "São Paulo"));
            Clients.Add(new Client(
                2, "Bruno", "Ribeirão Pires", "São Paulo"));
            Clients.Add(new Client(
                3, "Weverton", "Mauá", "São Paulo"));
            Clients.Add(new Client(
                4, "Marcos", "Greenwich", "London"));
            InitializeComponent();
        }
    }
}
