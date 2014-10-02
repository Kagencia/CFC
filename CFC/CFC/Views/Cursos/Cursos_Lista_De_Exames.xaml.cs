using GrupoAlfacentauro.WPF.Agenda.UI;
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

namespace CFC.Views.Cursos
{
    /// <summary>
    /// Interaction logic for Cursos_Lista_De_Exames.xaml
    /// </summary>
    public partial class Cursos_Lista_De_Exames : Window
    {
        public Cursos_Lista_De_Exames()
        {
            InitializeComponent();

            ComponenteAgenda agendaExames = new ComponenteAgenda()
            {
                StrConexao_Host = @"KLAUS\KLAUSSERVER",
                StrConexao_Usuario = "Klaus",
                StrConexao_Senha = "49005120"
            };

            GradeAgenda.Children.Add(agendaExames);

        }
    }
}
