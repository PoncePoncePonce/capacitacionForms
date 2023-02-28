using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capacitacionForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cliente> clienteList = new List<Cliente>();
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Cliente cliente= new Cliente()
            {
                Nombre = txt_nombre.Text,
                Apellido= txt_apellido.Text,
                NumeroDeTelefono = txt_numeroDeTelefono.Text,
            };
            TextFileRepository repository= new TextFileRepository();
            repository.Agregar(cliente);
            dtg_clientes.DataSource= repository.GetClientes();
            dtg_clientes.Refresh();
        }
    }
}
