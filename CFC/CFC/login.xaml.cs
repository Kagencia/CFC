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

            var response = MessageBox.Show("sair?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (response == MessageBoxResult.Yes)
                Environment.Exit(0);
        }

        private void callClose(int token)
        {
            CLOSE_TOKEN = token;
            this.Close();
            CLOSE_TOKEN = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(tblogin.Text == String.Empty || tbsenha.Text == String.Empty)
            {
                MessageBox.Show("campo vazio");
                return;
            }
            
            switch(conn.login(tblogin.Text, tbsenha.Text))
            {
                case Connection.loginReturn.INVALID_USER:
                    MessageBox.Show("usuario nao encontrado");
                    break;

                case Connection.loginReturn.WRONG_PASS:
                    MessageBox.Show("senha incorreta");
                    break;

                case Connection.loginReturn.SUCCESS:
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowEx(conn);
                    callClose(0);
                    break;
            }

        }
    }
}
