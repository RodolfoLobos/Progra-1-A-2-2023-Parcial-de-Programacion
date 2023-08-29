using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_De_Programación_computacional_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            String[,] Area =  {
      {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectáreas" },
         };
            InitializeComponent();
        }

        private void btnConvertirArea_Click(object sender, EventArgs e)
        {
            int de, a, conversor;
            double cantidad, respuesta;

            de = cboDeArea.SelectedIndex;
            a = cboAarea.SelectedIndex;
            conversor = cboAarea.SelectedIndex;

            cantidad = double.Parse(txtCantidadArea.Text);
            //Pie Cuadrado, Vara Cuadrada, Yarda Cuadrada, Metro Cuadrado, Tareas, Manzana, Hectáreas, 
            double[][] Areas = {
                new double[] { 10.7639, 0.698896, 0.836127, 1 , 628.8, 6474.9702758, 10000},
            };

           respuesta= Areas[cboArea.SelectedIndex][de] / Areas[cboArea.SelectedIndex][a] * cantidad;
            lblRespuestaArea.Text = "Respuesta: " +  Math.Round(respuesta,6);
           
        }
    }
  
}
