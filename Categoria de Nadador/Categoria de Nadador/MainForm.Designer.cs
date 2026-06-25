/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 11:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Categoria_de_Nadador
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblidade;
		private System.Windows.Forms.TextBox txtidade;
		private System.Windows.Forms.Button BtnClassificar;
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
			this.lblidade = new System.Windows.Forms.Label();
			this.txtidade = new System.Windows.Forms.TextBox();
			this.lblresultado = new System.Windows.Forms.Label();
			this.BtnClassificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblidade
			// 
			this.lblidade.AutoSize = true;
			this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblidade.Location = new System.Drawing.Point(51, 64);
			this.lblidade.Name = "lblidade";
			this.lblidade.Size = new System.Drawing.Size(60, 20);
			this.lblidade.TabIndex = 0;
			this.lblidade.Text = "Idade:";
			// 
			// txtidade
			// 
			this.txtidade.Location = new System.Drawing.Point(117, 64);
			this.txtidade.Name = "txtidade";
			this.txtidade.Size = new System.Drawing.Size(168, 20);
			this.txtidade.TabIndex = 1;
			// 
			// lblresultado
			// 
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(70, 188);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(100, 23);
			this.lblresultado.TabIndex = 2;
			this.lblresultado.Text = "Resultado:";
			// 
			// BtnClassificar
			// 
			this.BtnClassificar.Location = new System.Drawing.Point(412, 64);
			this.BtnClassificar.Name = "BtnClassificar";
			this.BtnClassificar.Size = new System.Drawing.Size(75, 23);
			this.BtnClassificar.TabIndex = 3;
			this.BtnClassificar.Text = "Classificar...";
			this.BtnClassificar.UseVisualStyleBackColor = true;
			this.BtnClassificar.Click += new System.EventHandler(this.BtnClassificarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 343);
			this.Controls.Add(this.BtnClassificar);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.txtidade);
			this.Controls.Add(this.lblidade);
			this.Name = "MainForm";
			this.Text = "Categoria de Nadador";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
