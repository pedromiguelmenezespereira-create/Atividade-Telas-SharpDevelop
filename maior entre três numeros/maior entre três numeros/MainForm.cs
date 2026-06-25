
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maior_entre_três_numeros
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
	    int n1, n2, n3;

    if (int.TryParse(txtnumero1.Text, out n1) &&
        int.TryParse(txtnumero2.Text, out n2) &&
        int.TryParse(txtnumero3.Text, out n3))
    {
        int maior = n1;

        if (n2 > maior)
            maior = n2;

        if (n3 > maior)
            maior = n3;

        lblresultado.Text = "Maior número: " + maior;
    }
    else
    {
        lblresultado.Text = "Digite valores válidos!";
    }

		}	
		
			
	}
}
