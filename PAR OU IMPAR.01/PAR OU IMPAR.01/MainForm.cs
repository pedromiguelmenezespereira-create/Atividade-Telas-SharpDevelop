/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 08:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PAR_OU_IMPAR._1
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
			    int numero;

    if (int.TryParse(txtnumero.Text, out numero))
    {
        if (numero % 2 == 0)
        {
            lblresultado.Text = "O número é PAR";
        }
        else
        {
            lblresultado.Text = "O número é ÍMPAR";
        }
    }
    else
    {
        lblresultado.Text = "Digite um número válido!";
    }

			
			
			
			
	
		}
		
		
		
		
		
		
		
		
	}
}
