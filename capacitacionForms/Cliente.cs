using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capacitacionForms
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDeTelefono { get; set; }

        public Cliente(string nombre, string apellido, string numeroDeTelefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeTelefono= numeroDeTelefono;

        }
        public Cliente() 
        {
        }
        public override string ToString()
        {
            return $"{Nombre}, {Apellido}, {NumeroDeTelefono}";
        }
    }
}
