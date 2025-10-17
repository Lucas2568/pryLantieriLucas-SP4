using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace pryLantieriLucas_SP4
{
    internal class clsConexionBD
    {
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Escritorio\\BaseDeDatos\\control_transporte.accdb";
        OleDbConnection coneccionBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD(System.Windows.Forms.ToolStripStatusLabel label)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.DataSource;

                coneccionBaseDatos.Open();

                label.Text = "Base de datos conectada";
                label.BackColor = System.Drawing.Color.LightGreen;
            }
            catch (Exception error)
            {
                label.Text = "No se pudo conectar con la base de datos";
                label.BackColor = System.Drawing.Color.LightCyan;
            }

        }
    }
}
