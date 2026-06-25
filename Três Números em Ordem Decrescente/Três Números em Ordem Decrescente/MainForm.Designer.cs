/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Três_Números_em_Ordem_Decrescente
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtnumero1;
		private System.Windows.Forms.TextBox txtnumero2;
		private System.Windows.Forms.TextBox txtnumero3;
		private System.Windows.Forms.Button btnverificar;
		private System.Windows.Forms.TextBox txtnumero4;
		
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
			this.lblresultado = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtnumero1 = new System.Windows.Forms.TextBox();
			this.txtnumero4 = new System.Windows.Forms.TextBox();
			this.txtnumero2 = new System.Windows.Forms.TextBox();
			this.txtnumero3 = new System.Windows.Forms.TextBox();
			this.btnverificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(525, 297);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(0, 20);
			this.lblresultado.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(64, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "numero";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "numero";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(64, 97);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "numero";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(64, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "numero";
			// 
			// txtnumero1
			// 
			this.txtnumero1.Location = new System.Drawing.Point(132, 41);
			this.txtnumero1.Name = "txtnumero1";
			this.txtnumero1.Size = new System.Drawing.Size(243, 20);
			this.txtnumero1.TabIndex = 6;
			// 
			// txtnumero4
			// 
			this.txtnumero4.Location = new System.Drawing.Point(132, 187);
			this.txtnumero4.Name = "txtnumero4";
			this.txtnumero4.Size = new System.Drawing.Size(243, 20);
			this.txtnumero4.TabIndex = 7;
			// 
			// txtnumero2
			// 
			this.txtnumero2.Location = new System.Drawing.Point(132, 100);
			this.txtnumero2.Name = "txtnumero2";
			this.txtnumero2.Size = new System.Drawing.Size(243, 20);
			this.txtnumero2.TabIndex = 8;
			// 
			// txtnumero3
			// 
			this.txtnumero3.Location = new System.Drawing.Point(132, 144);
			this.txtnumero3.Name = "txtnumero3";
			this.txtnumero3.Size = new System.Drawing.Size(243, 20);
			this.txtnumero3.TabIndex = 9;
			// 
			// btnverificar
			// 
			this.btnverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnverificar.Location = new System.Drawing.Point(312, 253);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 23);
			this.btnverificar.TabIndex = 10;
			this.btnverificar.Text = "verificar...";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(689, 392);
			this.Controls.Add(this.btnverificar);
			this.Controls.Add(this.txtnumero3);
			this.Controls.Add(this.txtnumero2);
			this.Controls.Add(this.txtnumero4);
			this.Controls.Add(this.txtnumero1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblresultado);
			this.Name = "MainForm";
			this.Text = "Três Números em Ordem Decrescente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
