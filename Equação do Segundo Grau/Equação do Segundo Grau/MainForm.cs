
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Equação_do_Segundo_Grau
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		





			
	
		
	
		}
		void BtncalcularClick(object sender, EventArgs e)
		{
	   double a, b, c;

    if (double.TryParse(txtvalorA.Text, out a) &&
        double.TryParse(txtvalorB.Text, out b) &&
        double.TryParse(txtvalorC.Text, out c))
    {
        if (a == 0)
        {
            lblresultado.Text = "Não é uma equação do 2º grau.";
            return;
        }

        double delta = (b * b) - (4 * a * c);

        if (delta < 0)
        {
            lblresultado.Text = "Não existem raízes reais.";
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);

            lblresultado.Text =
                "Delta = 0\nRaiz única = " +
                x.ToString("F2");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            lblresultado.Text =
                "X1 = " + x1.ToString("F2") +
                "\nX2 = " + x2.ToString("F2");
        }
    }
    else
    {
        lblresultado.Text = "Digite valores válidos.";
    }

		}		}
	}