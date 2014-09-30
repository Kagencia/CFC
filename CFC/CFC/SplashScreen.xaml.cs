using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CFC
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        Thread thLoad;
        login _login;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            thLoad = new Thread(load);
            thLoad.SetApartmentState(ApartmentState.STA);

            _login = new login();

            thLoad.Start();
        }

        private void load()
        {
            int minSeconds = 2;

            Thread.Sleep(1000 * minSeconds);

            Connection conn = new Connection(@"Data Source=(localdb)\Projects;Initial Catalog=cfcdb1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");

            if(!conn.Connect())
            {
                MessageBox.Show("connection failed");
                Environment.Exit(1);
            }

            _login.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    _login.ShowEx(conn);
                }
            ));
            this.Dispatcher.Invoke(DispatcherPriority.Background, new Action(() => { this.Visibility = System.Windows.Visibility.Hidden; }));
        }
    }
}
