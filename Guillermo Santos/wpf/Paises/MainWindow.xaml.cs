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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Ciudades> ComboCiudades = new List<Ciudades>();
            ComboCiudades.Add(new Ciudades() { Nombre = "Montevideo" });
            ComboCiudades.Add(new Ciudades() { Nombre = "Paris" });
            ComboCiudades.Add(new Ciudades() { Nombre = "Roma" });
            ComboCiudades.Add(new Ciudades() { Nombre = "Valencia" });
            ComboCiudades.Add(new Ciudades() { Nombre = "Mendoza" });

            ComboBoxCiudades.ItemsSource = ComboCiudades;
            ComboBoxCiudades.SelectedIndex = 0;

            if (TodosCheck.IsChecked == true) 
            { 
            /*Deberes*/
            }
        }
    }
}
