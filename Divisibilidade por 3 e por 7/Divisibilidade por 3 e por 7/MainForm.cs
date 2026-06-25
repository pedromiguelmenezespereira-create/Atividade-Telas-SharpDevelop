
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Divisibilidade_por_3_e_por_7
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
	
		}
		void BtnverificarClick(object sender, EventArgs e)
		{
	     int numero;

       if (int.TryParse(txtnumero.Text, out numero))
    {
        if (numero % 3 == 0 && numero % 7 == 0)
        {
            lblresultado.Text = "O número é divisível por 3 e por 7.";
        }
        else
        {
            lblresultado.Text = "O número NÃO é divisível por 3 e por 7 ao mesmo tempo.";
        }
    }
    else
    {
        lblresultado.Text = "Digite um número válido!";
     }
    }

			
			
			
			
			
			
			
			
			
		}
		
		
		
		
		
		
		
		
		
	}