using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propuesto01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Propuesto01"].ConnectionString);

		public void ListaClientes()
		{
			using (SqlDataAdapter df = new SqlDataAdapter("S01_Propuesto01", cn))
			{
				df.SelectCommand.CommandType = CommandType.StoredProcedure;
				df.SelectCommand.Parameters.Add("@busquedaNombre", SqlDbType.VarChar).Value = tbBusqueda.Text;
				using (DataSet ds = new DataSet())
				{
					df.Fill(ds, "Clientes");
					dgClientes.DataSource = ds.Tables["Clientes"];
					lblCantidad.Text = ds.Tables["Clientes"].Rows.Count.ToString();
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ListaClientes();
		}

		private void TbBusqueda_TextChanged(object sender, EventArgs e)
		{
			ListaClientes();
		}
	}
}
