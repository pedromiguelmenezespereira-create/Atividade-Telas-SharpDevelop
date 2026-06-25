
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Classificação_de_Número_Positivo__Negativo_ou_Nulo
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
		}
		void BtnvrerificarClick(object sender, EventArgs e)
		{
	    double numero;

    if(double.TryParse(txtnumero.Text, out numero))
    {
        if(numero > 0)
        {
            lblresultado.Text = "Positivo";
        }
        else if(numero < 0)
        {
            lblresultado.Text = "Negativo";
        }
        else
        {
            lblresultado.Text = "Nulo";
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