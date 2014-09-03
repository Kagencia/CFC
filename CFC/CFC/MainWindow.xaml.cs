﻿using System;
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
using Finisar.SQLite;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("teste");
            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "CREATE TABLE test (id integer primary key, text varchar(100));";

            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();

            // Lets insert something into our new table:
            sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (1, 'Test Text 1');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();

            // ...and inserting another line:
            sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (2, 'Test Text 2');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();

            // But how do we read something out of our table ?
            // First lets build a SQL-Query again:
            sqlite_cmd.CommandText = "SELECT * FROM test";

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                System.Console.WriteLine(sqlite_datareader["text"]);
            }

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
        }


    }
}
