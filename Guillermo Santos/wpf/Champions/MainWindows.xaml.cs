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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Equipos> ListaEquipos = new List<Equipos>();

            ListaEquipos.Add(new Equipos() { Equipo1 = "Real Madrid", Equipo2 = "Bayern", CampeonatosEuropa1 = "16", CampeonatosEuropa2 = "6", Diferencia = "10" });
            ListaEquipos.Add(new Equipos() { Equipo1 = "PSG", Equipo2 = "Manchester City", CampeonatosEuropa1 = "0", CampeonatosEuropa2 = "1", Diferencia = "1" });
            ListaEquipos.Add(new Equipos() { Equipo1 = "Arsenal", Equipo2 = "Juventus", CampeonatosEuropa1 = "0", CampeonatosEuropa2 = "2", Diferencia = "2" });
            ListaEquipos.Add(new Equipos() { Equipo1 = "ACMilan", Equipo2 = "Barcelona", CampeonatosEuropa1 = "7", CampeonatosEuropa2 = "5", Diferencia = "2" });

            ListBoxEquipos.ItemsSource = ListaEquipos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxEquipos.SelectedItem != null)
            {
            MessageBox.Show(
            (ListBoxEquipos.SelectedItem as Equipos).Equipo1 + " " + (ListBoxEquipos.SelectedItem as Equipos).CampeonatosEuropa1 + " " + (ListBoxEquipos.SelectedItem as Equipos).Equipo2 + " " + (ListBoxEquipos.SelectedItem as Equipos).CampeonatosEuropa2);
            }
            else
            {
                MessageBox.Show("Usted debe seleccionar una fila");
            
            }
        }
    }

    public class Equipos
    {
        public string Equipo1 { get; set; }
        public string Equipo2 { get; set; }
        public string CampeonatosEuropa1 { get; set; }
        public string CampeonatosEuropa2 { get; set; }
        public string Diferencia { get; set; }
    }
}
