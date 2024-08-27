using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatosLayer;



namespace CapaConexion
{
    public partial class Form1 : Form
    {
        CustomerRepository customersRepository = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var Customer = customersRepository.ObtenerTodos();
            dataGrid.DataSource = Customer;                   
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //var filtro = Customers.FindAll(X => X.CompanyName.StartsWith(txtFiltro.Text));
            //dataGrid.DataSource = filtro;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
            //DatosLayer.DataBase.ConnetionTimeout = 30;

            //string cadenaconexion = DatosLayer.DataBase.ConnectionString;
            //var conn = DatosLayer.DataBase.GetSqlConnection();
        }
    }
}
