/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 08:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROVADO_OU_REPROVADO
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCalcularMedia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.TextBox txtnota1;
		private System.Windows.Forms.TextBox txtnota2;
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
			this.btnCalcularMedia = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.txtnota1 = new System.Windows.Forms.TextBox();
			this.txtnota2 = new System.Windows.Forms.TextBox();
			this.txtnota3 = new System.Windows.Forms.TextBox();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalcularMedia
			// 
			this.btnCalcularMedia.Location = new System.Drawing.Point(299, 326);
			this.btnCalcularMedia.Name = "btnCalcularMedia";
			this.btnCalcularMedia.Size = new System.Drawing.Size(75, 23);
			this.btnCalcularMedia.TabIndex = 0;
			this.btnCalcularMedia.Text = "verificar";
			this.btnCalcularMedia.UseVisualStyleBackColor = true;
			this.btnCalcularMedia.Click += new System.EventHandler(this.BtnCalcularMediaClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(98, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "NOME";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(182, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "NOTA:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(182, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "NOTA:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(182, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "NOTA:";
			// 
			// txtnome
			// 
			this.txtnome.Location = new System.Drawing.Point(284, 41);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(291, 20);
			this.txtnome.TabIndex = 5;
			// 
			// txtnota1
			// 
			this.txtnota1.Location = new System.Drawing.Point(299, 87);
			this.txtnota1.Name = "txtnota1";
			this.txtnota1.Size = new System.Drawing.Size(201, 20);
			this.txtnota1.TabIndex = 6;
			// 
			// txtnota2
			// 
			this.txtnota2.Location = new System.Drawing.Point(299, 149);
			this.txtnota2.Name = "txtnota2";
			this.txtnota2.Size = new System.Drawing.Size(201, 20);
			this.txtnota2.TabIndex = 7;
			// 
			// txtnota3
			// 
			this.txtnota3.Location = new System.Drawing.Point(299, 203);
			this.txtnota3.Name = "txtnota3";
			this.txtnota3.Size = new System.Drawing.Size(201, 20);
			this.txtnota3.TabIndex = 8;
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Location = new System.Drawing.Point(291, 270);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(0, 13);
			this.lblresultado.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 379);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.txtnota3);
			this.Controls.Add(this.txtnota2);
			this.Controls.Add(this.txtnota1);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalcularMedia);
			this.Name = "MainForm";
			this.Text = "PROVADO OU REPROVADO";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
