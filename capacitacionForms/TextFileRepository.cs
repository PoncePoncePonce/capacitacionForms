using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capacitacionForms
{
    public class TextFileRepository
    {
        string path = "D:\\ejemplo\\clientes.txt";


        public void Agregar(Cliente cliente)
        {
            using (StreamWriter strWriter = new StreamWriter(path, true))
            {

                strWriter.WriteLine(cliente.ToString());
                strWriter.Close();
            }
        }
        public List<Cliente> GetClientes()
        {
            if (!System.IO.File.Exists(path))
            {
                return new List<Cliente>();
            }

            using (StreamReader strReader = new StreamReader(path))
            {

                List<Cliente> cliente = new List<Cliente>();
                string ln = string.Empty;

                while ((ln = strReader.ReadLine()) != null)
                {
                    string[] campos = ln.Split(',');

                    Cliente clientes = new Cliente()
                    {
                        //Id = campos[0],
                        Nombre = campos[0],
                        Apellido = campos[1],
                        NumeroDeTelefono = campos[2]

                    };
                    cliente.Add(clientes);
                }

                return cliente;
            }
        }
    }
}
