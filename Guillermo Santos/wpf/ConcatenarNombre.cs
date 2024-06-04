using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ConcatenarNombre : INotifyPropertyChanged
    {
        private string _nombre;
        private string _apellido;
        private string _nombrecompleto;
        public string NombreCompleto { get { _nombrecompleto = Nombre + " " + Apellido; return _nombrecompleto; } set { } }
        public string Apellido { get { return _apellido; } set { _apellido = value; OnPropertyChanged("NombreCompleto"); } }
        public string Nombre { get { return _nombre; } set { _nombre = value; OnPropertyChanged("NombreCompleto"); } }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
