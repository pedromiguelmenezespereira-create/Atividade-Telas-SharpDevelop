
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Categoria_de_Nadador
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
		void BtnClassificarClick(object sender, EventArgs e)
		{
	    int idade;

    if (int.TryParse(txtidade.Text, out idade))
    {
        if (idade >= 5 && idade <= 7)
        {
            lblresultado.Text = "Infantil A";
        }
        else if (idade >= 8 && idade <= 10)
        {
            lblresultado.Text = "Infantil B";
        }
        else if (idade >= 11 && idade <= 13)
        {
            lblresultado.Text = "Juvenil A";
        }
        else if (idade >= 14 && idade <= 17)
        {
            lblresultado.Text = "Juvenil B";
        }
        else if (idade >= 18)
        {
            lblresultado.Text = "Sênior";
        }
        else
        {
            lblresultado.Text = "Idade fora das categorias.";
        }
    }
    else
    {
        lblresultado.Text = "Digite uma idade válida!";
    }

		}
		
		
		
		
	}
}
