namespace pryLantieriLucas_SP4
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.chartCamiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1Conexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTipoGrafico = new System.Windows.Forms.Label();
            this.cbxTipoGrafico = new System.Windows.Forms.ComboBox();
            this.btnKilometrosCamion = new System.Windows.Forms.Button();
            this.btnGastosPorCamion = new System.Windows.Forms.Button();
            this.btnKilogramosPorCamion = new System.Windows.Forms.Button();
            this.btnGastosViaticosPorCamion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCamiones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartCamiones
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCamiones.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCamiones.Legends.Add(legend1);
            this.chartCamiones.Location = new System.Drawing.Point(222, 101);
            this.chartCamiones.Name = "chartCamiones";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCamiones.Series.Add(series1);
            this.chartCamiones.Size = new System.Drawing.Size(550, 353);
            this.chartCamiones.TabIndex = 0;
            this.chartCamiones.Text = "chart1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1Conexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(813, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1Conexion
            // 
            this.toolStripStatusLabel1Conexion.Name = "toolStripStatusLabel1Conexion";
            this.toolStripStatusLabel1Conexion.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1Conexion.Text = "toolStripStatusLabel1";
            // 
            // lblTipoGrafico
            // 
            this.lblTipoGrafico.AutoSize = true;
            this.lblTipoGrafico.Location = new System.Drawing.Point(33, 13);
            this.lblTipoGrafico.Name = "lblTipoGrafico";
            this.lblTipoGrafico.Size = new System.Drawing.Size(80, 13);
            this.lblTipoGrafico.TabIndex = 2;
            this.lblTipoGrafico.Text = "Tipo de Gráfico";
            // 
            // cbxTipoGrafico
            // 
            this.cbxTipoGrafico.FormattingEnabled = true;
            this.cbxTipoGrafico.Items.AddRange(new object[] {
            "Gráfico de columna ",
            "Gráfico de línea",
            "Gráfico de barra",
            "Otra opción a su elección"});
            this.cbxTipoGrafico.Location = new System.Drawing.Point(36, 43);
            this.cbxTipoGrafico.Name = "cbxTipoGrafico";
            this.cbxTipoGrafico.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoGrafico.TabIndex = 3;
            // 
            // btnKilometrosCamion
            // 
            this.btnKilometrosCamion.Location = new System.Drawing.Point(36, 101);
            this.btnKilometrosCamion.Name = "btnKilometrosCamion";
            this.btnKilometrosCamion.Size = new System.Drawing.Size(121, 46);
            this.btnKilometrosCamion.TabIndex = 4;
            this.btnKilometrosCamion.Text = "Kilómetros por Camión";
            this.btnKilometrosCamion.UseVisualStyleBackColor = true;
            // 
            // btnGastosPorCamion
            // 
            this.btnGastosPorCamion.Location = new System.Drawing.Point(36, 169);
            this.btnGastosPorCamion.Name = "btnGastosPorCamion";
            this.btnGastosPorCamion.Size = new System.Drawing.Size(121, 46);
            this.btnGastosPorCamion.TabIndex = 5;
            this.btnGastosPorCamion.Text = "Gastos por Camión";
            this.btnGastosPorCamion.UseVisualStyleBackColor = true;
            // 
            // btnKilogramosPorCamion
            // 
            this.btnKilogramosPorCamion.Location = new System.Drawing.Point(36, 239);
            this.btnKilogramosPorCamion.Name = "btnKilogramosPorCamion";
            this.btnKilogramosPorCamion.Size = new System.Drawing.Size(121, 51);
            this.btnKilogramosPorCamion.TabIndex = 6;
            this.btnKilogramosPorCamion.Text = "Kilogramos por Camión";
            this.btnKilogramosPorCamion.UseVisualStyleBackColor = true;
            // 
            // btnGastosViaticosPorCamion
            // 
            this.btnGastosViaticosPorCamion.Location = new System.Drawing.Point(36, 316);
            this.btnGastosViaticosPorCamion.Name = "btnGastosViaticosPorCamion";
            this.btnGastosViaticosPorCamion.Size = new System.Drawing.Size(121, 68);
            this.btnGastosViaticosPorCamion.TabIndex = 7;
            this.btnGastosViaticosPorCamion.Text = "Gastos/Viáticos por Camión";
            this.btnGastosViaticosPorCamion.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(217, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(459, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Estadísticas de Kilómetros recorridos por Camión";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 534);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGastosViaticosPorCamion);
            this.Controls.Add(this.btnKilogramosPorCamion);
            this.Controls.Add(this.btnGastosPorCamion);
            this.Controls.Add(this.btnKilometrosCamion);
            this.Controls.Add(this.cbxTipoGrafico);
            this.Controls.Add(this.lblTipoGrafico);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chartCamiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCamiones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCamiones;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1Conexion;
        private System.Windows.Forms.Label lblTipoGrafico;
        private System.Windows.Forms.ComboBox cbxTipoGrafico;
        private System.Windows.Forms.Button btnKilometrosCamion;
        private System.Windows.Forms.Button btnGastosPorCamion;
        private System.Windows.Forms.Button btnKilogramosPorCamion;
        private System.Windows.Forms.Button btnGastosViaticosPorCamion;
        private System.Windows.Forms.Label lblTitulo;
    }
}