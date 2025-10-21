using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLantieriLucas_SP4
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.ConectarBD(toolStripStatusLabel1Conexion);
            clsConexionBD.cargarChart(chartCamiones, "Kilómetros por camión", cbxTipoGrafico.Text);
        }
        private void btnKilometrosCamion_Click_1(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.cargarChart(chartCamiones, "Kilómetros por camión", cbxTipoGrafico.Text);
        }
        private void btnGastosPorCamion_Click_1(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.cargarChart(chartCamiones, "Gastos por camión", cbxTipoGrafico.Text);
        }

        private void btnKilogramosPorCamion_Click_1(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.cargarChart(chartCamiones, "Kilogramos por camión", cbxTipoGrafico.Text);
        }

        private void btnGastosViaticosPorCamion_Click_1(object sender, EventArgs e)
        {
            clsConexionBD clsConexionBD = new clsConexionBD();
            clsConexionBD.cargarChart(chartCamiones, "Gastos/Viáticos por camión", cbxTipoGrafico.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
