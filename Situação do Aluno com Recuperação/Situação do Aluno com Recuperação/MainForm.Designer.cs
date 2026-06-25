/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 09:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Situação_do_Aluno_com_Recuperação
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnverificar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.TextBox txtnota1;
		private System.Windows.Forms.TextBox txtnota2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtnota3;
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.txtnota1 = new System.Windows.Forms.TextBox();
			this.txtnota2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnota3 = new System.Windows.Forms.TextBox();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnverificar
			// 
			this.btnverificar.Location = new System.Drawing.Point(239, 301);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 23);
			this.btnverificar.TabIndex = 0;
			this.btnverificar.Text = "verificar";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(124, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "nome:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(124, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "nota";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(124, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "nota";
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(249, 41);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(317, 20);
			this.txtnome.TabIndex = 4;
			// 
			// txtnota1
			// 
			this.txtnota1.Location = new System.Drawing.Point(249, 93);
			this.txtnota1.Name = "txtnota1";
			this.txtnota1.Size = new System.Drawing.Size(190, 20);
			this.txtnota1.TabIndex = 5;
			// 
			// txtnota2
			// 
			this.txtnota2.Location = new System.Drawing.Point(249, 158);
			this.txtnota2.Name = "txtnota2";
			this.txtnota2.Size = new System.Drawing.Size(190, 20);
			this.txtnota2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(124, 233);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "nota";
			// 
			// txtnota3
			// 
			this.txtnota3.Location = new System.Drawing.Point(249, 233);
			this.txtnota3.Name = "txtnota3";
			this.txtnota3.Size = new System.Drawing.Size(190, 20);
			this.txtnota3.TabIndex = 8;
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(438, 301);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(24, 20);
			this.lblresultado.TabIndex = 9;
			this.lblresultado.Text = "...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 374);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.txtnota3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtnota2);
			this.Controls.Add(this.txtnota1);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnverificar);
			this.Name = "MainForm";
			this.Text = "Situação do Aluno com Recuperação";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
