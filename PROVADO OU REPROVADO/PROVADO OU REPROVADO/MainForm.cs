/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 08:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROVADO_OU_REPROVADO
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
	
		}
		void BtnCalcularMediaClick(object sender, EventArgs e)
		{
			
			    double n1, n2, n3;

    if(double.TryParse(txtnota1.Text, out n1) &&
       double.TryParse(txtnota2.Text, out n2) &&
       double.TryParse(txtnota3.Text, out n3))
    {
        double media = (n1 + n2 + n3) / 3;

        if(media >= 7)
        {
            lblresultado.Text = "sua media é de:" + media +" - APROVADO";
        }
        else
        {
            lblresultado.Text = txtnome.Text +
                " - Média: " + media +
                " - REPROVADO";
        }
    }
    else
    {
        lblresultado.Text = "Digite notas válidas!";
    }

        
    }		
	
	
	
	
		}		
	}

