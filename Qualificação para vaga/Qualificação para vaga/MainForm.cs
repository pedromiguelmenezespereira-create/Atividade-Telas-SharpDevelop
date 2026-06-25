/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 09:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Qualificação_para_vaga
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
	   string diploma = txtdiploma.Text.ToLower();
    int idade;

    if (int.TryParse(txtidade.Text, out idade))
    {
        if (diploma == "sim" && idade > 21)
        {
            lblresultado.Text =
                "Parabéns, você está qualificado para a vaga!";
        }
        else
        {
            lblresultado.Text =
                "Você não atende aos requisitos.";
        }
    }
    else
    {
        lblresultado.Text = "Digite uma idade válida.";
    }

		}
	
	}
}