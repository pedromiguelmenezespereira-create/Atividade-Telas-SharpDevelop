/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Divisibilidade_por_3_e_por_7
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnverificar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnumero;
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
			this.btnverificar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnumero = new System.Windows.Forms.TextBox();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnverificar
			// 
			this.btnverificar.Location = new System.Drawing.Point(473, 105);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 23);
			this.btnverificar.TabIndex = 0;
			this.btnverificar.Text = "verificar...";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "escreva um número:";
			// 
			// txtnumero
			// 
			this.txtnumero.Location = new System.Drawing.Point(215, 105);
			this.txtnumero.Name = "txtnumero";
			this.txtnumero.Size = new System.Drawing.Size(194, 20);
			this.txtnumero.TabIndex = 2;
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(78, 205);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(0, 20);
			this.lblresultado.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 282);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.txtnumero);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnverificar);
			this.Name = "MainForm";
			this.Text = "Divisibilidade por 3 e por 7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
