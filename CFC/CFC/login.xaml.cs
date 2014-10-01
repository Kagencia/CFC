using System;
using System.Collections.Generic;
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

namespace CFC
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private Connection conn;

        private int CLOSE_TOKEN = 1;

        public void ShowEx(Connection conn)
        {
            this.conn = conn;
            this.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CLOSE_TOKEN != 1)
                return;

            e.Cancel = true;

            var response = MessageBox.Show("Deseja Sair?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (response == MessageBoxResult.Yes)
                Environment.Exit(0);
        }

        private void callClose(int token)
        {
            CLOSE_TOKEN = token;
            this.Close();
            CLOSE_TOKEN = 1;
        }

        public void login_Click(object sender, RoutedEventArgs e)
        {

            if(tblogin.Text == String.Empty || tbsenha.Text == String.Empty)
            {
                MessageBox.Show("Preencha os Campos Corretamente!");
                return;
            }
            
            switch(conn.login(tblogin.Text, tbsenha.Text))
            {
                case Connection.loginReturn.INVALID_USER:
                    MessageBox.Show("Usuário Não Encontrado");
                    break;

                case Connection.loginReturn.WRONG_PASS:
                    MessageBox.Show("Senha Incorreta!");
                    break;

                case Connection.loginReturn.SUCCESS:
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowEx(conn);
                    callClose(0);
                    break;
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                return;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblogin.Focusable = true;
            Keyboard.Focus(tblogin);
        }
    }
}
