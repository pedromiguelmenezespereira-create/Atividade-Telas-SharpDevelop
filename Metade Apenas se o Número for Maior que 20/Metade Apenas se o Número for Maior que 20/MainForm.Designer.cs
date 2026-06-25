/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Metade_Apenas_se_o_Número_for_Maior_que_20
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtnumero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Button btnverificar;
		
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
			this.txtnumero = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblresultado = new System.Windows.Forms.Label();
			this.btnverificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtnumero
			// 
			this.txtnumero.Location = new System.Drawing.Point(348, 105);
			this.txtnumero.Name = "txtnumero";
			this.txtnumero.Size = new System.Drawing.Size(177, 20);
			this.txtnumero.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "escreva";
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(550, 227);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(0, 20);
			this.lblresultado.TabIndex = 3;
			// 
			// btnverificar
			// 
			this.btnverificar.AutoSize = true;
			this.btnverificar.Location = new System.Drawing.Point(339, 259);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 23);
			this.btnverificar.TabIndex = 4;
			this.btnverificar.Text = "verificar...";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 398);
			this.Controls.Add(this.btnverificar);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnumero);
			this.Name = "MainForm";
			this.Text = "Metade Apenas se o Número for Maior que 20";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
