
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Três_Números_em_Ordem_Decrescente
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
    int n1, n2, n3, n4;

    if (int.TryParse(txtnumero1.Text, out n1) &&
        int.TryParse(txtnumero2.Text, out n2) &&
        int.TryParse(txtnumero3.Text, out n3)&&
        int.TryParse(txtnumero4.Text, out n4))
    {
        int[] numeros = { n1, n2, n3 , n4};

        Array.Sort(numeros);
        Array.Reverse(numeros);

        lblresultado.Text =
            numeros[0] + " - " +
            numeros[1] + " - " +
            numeros[2] + " - " +
        	numeros[3];
    }
		

		
    else
    {
        lblresultado.Text = "Digite valores válidos!";
    }

			}
	}
}