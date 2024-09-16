using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Publicaciones.Views.Reportes
{
    public partial class ReportesUsuario : Form
    {
        public ReportesUsuario()
        {
            InitializeComponent();
            CargarDatosUsuarios();
        }

        private void ReportesUsuario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void CargarDatosUsuarios()
        {
            string connectionString = "Server=DORIAN;Database=pubs;User Id=sa;Password=12345;";
            string query = "SELECT ID, nombre_usuario, password, roles FROM usuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                ReportDataSource rds = new ReportDataSource("DataSet2", dataTable);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\LEGION\\Desktop\\PROYECTOS IMPORTADOS\\Tarea-08-SEPT-06Publicaciones\\Views\\Reportes\\ReporteUsuarios.rdlc";
                reportViewer1.RefreshReport();
            }
        }


    }
}
