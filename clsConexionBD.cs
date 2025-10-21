using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryLantieriLucas_SP4
{
    internal class clsConexionBD
    {
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Trabajos Lucas\\IES\\Segundo Año\\Primer Semestre\\Lab3\\SP4\\BaseDeDatos\\control_transporte.accdb";
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

        public void cargarChart(Chart chartCamiones, string filtro, string tipoGrafico)
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    string campoY = "";
                    string titulo = "";

                    // Determinamos qué columna graficar
                    switch (filtro)
                    {
                        case "Kilómetros por camión":
                            campoY = "Kilómetros";
                            titulo = "Kilómetros por camión";
                            break;
                        case "Gastos por camión":
                            campoY = "Precio"; // o Total, si ese representa los gastos
                            titulo = "Gastos por camión";
                            break;
                        case "Kilogramos por camión":
                            campoY = "kg";
                            titulo = "Kilogramos por camión";
                            break;
                        case "Gastos/Viáticos por camión":
                            campoY = "(Precio + Viáticos)";
                            titulo = "Gastos + Viáticos por camión";
                            break;
                    }

                    string sql = $"SELECT Camión, {campoY} AS Valor FROM transporte";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(sql, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Limpiamos el chart
                    chartCamiones.Series.Clear();
                    chartCamiones.ChartAreas.Clear();
                    chartCamiones.Titles.Clear();

                    chartCamiones.ChartAreas.Add("MainArea");

                    Series serie = new Series("Datos");
                    serie.XValueMember = "Camión";
                    serie.YValueMembers = "Valor";
                    serie.IsValueShownAsLabel = true;

                    // Tipo de gráfico
                    switch (tipoGrafico)
                    {
                        case "Gráfico de columna":
                            serie.ChartType = SeriesChartType.Column;
                            break;
                        case "Gráfico de línea":
                            serie.ChartType = SeriesChartType.Line;
                            break;
                        case "Gráfico de barra":
                            serie.ChartType = SeriesChartType.Bar;
                            break;
                        default:
                            serie.ChartType = SeriesChartType.Column;
                            break;
                    }

                    chartCamiones.Series.Add(serie);
                    chartCamiones.DataSource = tabla;
                    chartCamiones.Titles.Add(titulo);
                    chartCamiones.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message);
            }
        }

    }
}
