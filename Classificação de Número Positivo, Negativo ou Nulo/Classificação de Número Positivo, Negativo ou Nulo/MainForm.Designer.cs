/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Classificação_de_Número_Positivo__Negativo_ou_Nulo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnumero;
		private System.Windows.Forms.Button btnvrerificar;
		private System.Windows.Forms.Label lblresultado;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtnumero = new System.Windows.Forms.TextBox();
			this.btnvrerificar = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "escreva um numero:";
			// 
			// txtnumero
			// 
			this.txtnumero.Location = new System.Drawing.Point(248, 73);
			this.txtnumero.Name = "txtnumero";
			this.txtnumero.Size = new System.Drawing.Size(186, 20);
			this.txtnumero.TabIndex = 1;
			// 
			// btnvrerificar
			// 
			this.btnvrerificar.Location = new System.Drawing.Point(234, 168);
			this.btnvrerificar.Name = "btnvrerificar";
			this.btnvrerificar.Size = new System.Drawing.Size(75, 23);
			this.btnvrerificar.TabIndex = 2;
			this.btnvrerificar.Text = "verificar:";
			this.btnvrerificar.UseVisualStyleBackColor = true;
			this.btnvrerificar.Click += new System.EventHandler(this.BtnvrerificarClick);
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(378, 234);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(0, 20);
			this.lblresultado.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 382);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btnvrerificar);
			this.Controls.Add(this.txtnumero);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Classificação de Número Positivo, Negativo ou Nulo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
