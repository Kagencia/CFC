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

namespace CFC.Views.Ajuda
{
    /// <summary>
    /// Interaction logic for Ajuda_Sobre_a_Kagencia.xaml
    /// </summary>
    public partial class Ajuda_Sobre_a_Kagencia : Window
    {
        public Ajuda_Sobre_a_Kagencia()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }
    }
}
