/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 09:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Qualificação_para_vaga
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Button btnverificar;
		private System.Windows.Forms.TextBox txtdiploma;
		private System.Windows.Forms.TextBox txtidade;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.lblresultado = new System.Windows.Forms.Label();
			this.btnverificar = new System.Windows.Forms.Button();
			this.txtdiploma = new System.Windows.Forms.TextBox();
			this.txtidade = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "diploma";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(104, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "idade";
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Location = new System.Drawing.Point(210, 274);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(106, 13);
			this.lblresultado.TabIndex = 3;
			this.lblresultado.Text = ".................................";
			// 
			// btnverificar
			// 
			this.btnverificar.Location = new System.Drawing.Point(229, 217);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 23);
			this.btnverificar.TabIndex = 4;
			this.btnverificar.Text = "verificar";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// txtdiploma
			// 
			this.txtdiploma.Location = new System.Drawing.Point(210, 61);
			this.txtdiploma.Name = "txtdiploma";
			this.txtdiploma.Size = new System.Drawing.Size(123, 20);
			this.txtdiploma.TabIndex = 5;
			// 
			// txtidade
			// 
			this.txtidade.Location = new System.Drawing.Point(210, 119);
			this.txtidade.Name = "txtidade";
			this.txtidade.Size = new System.Drawing.Size(123, 20);
			this.txtidade.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 365);
			this.Controls.Add(this.txtidade);
			this.Controls.Add(this.txtdiploma);
			this.Controls.Add(this.btnverificar);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Qualificação para vaga";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
