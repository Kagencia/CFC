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

namespace CFC.Views.Cadastro
{
    /// <summary>
    /// Interaction logic for Cadastro_Aluno.xaml
    /// </summary>
    public partial class Cadastro_Aluno : Window
    {
        public Cadastro_Aluno()
        {
            InitializeComponent();
        }

        private void foto_aluno_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();



          

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                ImageSource imagem = new BitmapImage(new Uri(filename));
                foto_aluno.Source = imagem;
            }
        }
    }
}
