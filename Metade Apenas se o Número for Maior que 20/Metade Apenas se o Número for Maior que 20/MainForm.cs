
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Metade_Apenas_se_o_Número_for_Maior_que_20
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
		void BtnverificarClick(object sender, EventArgs e)
		{
	   double numero;

    if(double.TryParse(txtnumero.Text, out numero))
    {
        if(numero > 20)
        {
            lblresultado.Text = "Metade = " + (numero / 2);
        }
      else
        {
            lblresultado.Text = "O número não é maior que 20.";
        }
    }
    else
    {
        lblresultado.Text =
            "Digite um número válido!";
      }
    }

		
		
		}
		
		 
		
		
	}
