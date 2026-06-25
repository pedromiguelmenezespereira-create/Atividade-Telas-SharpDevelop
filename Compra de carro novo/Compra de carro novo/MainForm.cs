/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 08:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Compra_de_carro_novo
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		
	
		}
		void BtnverificarClick(object sender, EventArgs e)
		{
	
    string deseja = txtdesejocarro.Text.ToLower();
    string dinheiro = txtdinheiro.Text.ToLower();

    if (deseja == "sim" && dinheiro == "sim")
    {
        lblresultado.Text =
            "Parabéns, você pode comprar um carro novo!";
    }
    else
    {
        lblresultado.Text =
            "Ainda não é possível realizar a compra.";
    }

		}
		
		
		
		
		
		
		
	}
}
