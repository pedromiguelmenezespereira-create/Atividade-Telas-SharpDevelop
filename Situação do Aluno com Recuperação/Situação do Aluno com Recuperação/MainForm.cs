
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Situação_do_Aluno_com_Recuperação
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
			
			
		
	
		}
		void BtnverificarClick(object sender, EventArgs e)
		{
			
			     double n1, n2, n3;
            
            if (double.TryParse(txtnota1.Text, out n1) &&
                double.TryParse(txtnota2.Text, out n2) &&
                double.TryParse(txtnota3.Text, out n3)) 
            {
                double media = (n1 + n2 + n3) / 3;
                                
                if (media >= 7)
                {
                    lblresultado.Text = txtnome.Text + " - media: " + media.ToString("F1") + " - APROVADO";
                }
                else if (media > 5 && media < 7)
                {
                    lblresultado.Text = txtnome.Text + " - media: " + media.ToString("F1") + " - RECUPERAÇÃO";
                }
                else
                {
                    lblresultado.Text = txtnome.Text + " - media: " + media.ToString("F1") + " - REPROVADO";
                }
                
            
        }
     }
  }

			
			
			
			
			
			
			
			
			
			
			
			
	
		}