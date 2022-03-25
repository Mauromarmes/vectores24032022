using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24032022_vectores
{
    public partial class formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnvector_Click(object sender, EventArgs e)
        {
            int tamano;
                double sum = 0;
            string aux = "";
            tamano = Convert.ToInt32(txttamano.Text);
            double[] vector = new double[tamano];
            //colocar con tab dos veces
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Numeros Enteros y Decimales"));
                aux = aux + "," + vector[i];
                lblelementos.Text = aux;
                sum = sum + vector[i];
                lblsumatoria.Text = System.Convert.ToString(sum);
            }
        }
    }
}