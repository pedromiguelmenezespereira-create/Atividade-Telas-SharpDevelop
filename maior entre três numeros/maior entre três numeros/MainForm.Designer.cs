/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 24/06/2026
 * Time: 10:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace maior_entre_três_numeros
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnverificar;
		private System.Windows.Forms.TextBox txtnumero1;
		private System.Windows.Forms.Label lblnumero;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.Label lblnumero2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtnumero2;
		private System.Windows.Forms.TextBox txtnumero3;
		
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
			this.txtnumero1 = new System.Windows.Forms.TextBox();
			this.lblnumero = new System.Windows.Forms.Label();
			this.lblresultado = new System.Windows.Forms.Label();
			this.lblnumero2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtnumero2 = new System.Windows.Forms.TextBox();
			this.txtnumero3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnverificar
			// 
			this.btnverificar.AutoSize = true;
			this.btnverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnverificar.Location = new System.Drawing.Point(80, 233);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 26);
			this.btnverificar.TabIndex = 0;
			this.btnverificar.Text = "verificar:";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// txtnumero1
			// 
			this.txtnumero1.Location = new System.Drawing.Point(232, 28);
			this.txtnumero1.Name = "txtnumero1";
			this.txtnumero1.Size = new System.Drawing.Size(100, 20);
			this.txtnumero1.TabIndex = 1;
			// 
			// lblnumero
			// 
			this.lblnumero.AutoSize = true;
			this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnumero.Location = new System.Drawing.Point(71, 28);
			this.lblnumero.Name = "lblnumero";
			this.lblnumero.Size = new System.Drawing.Size(84, 20);
			this.lblnumero.TabIndex = 2;
			this.lblnumero.Text = "numero1:";
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(232, 233);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(0, 20);
			this.lblresultado.TabIndex = 3;
			// 
			// lblnumero2
			// 
			this.lblnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblnumero2.Location = new System.Drawing.Point(71, 88);
			this.lblnumero2.Name = "lblnumero2";
			this.lblnumero2.Size = new System.Drawing.Size(100, 23);
			this.lblnumero2.TabIndex = 5;
			this.lblnumero2.Text = "numero2";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(71, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "numero3";
			// 
			// txtnumero2
			// 
			this.txtnumero2.Location = new System.Drawing.Point(232, 90);
			this.txtnumero2.Name = "txtnumero2";
			this.txtnumero2.Size = new System.Drawing.Size(100, 20);
			this.txtnumero2.TabIndex = 7;
			// 
			// txtnumero3
			// 
			this.txtnumero3.Location = new System.Drawing.Point(232, 144);
			this.txtnumero3.Name = "txtnumero3";
			this.txtnumero3.Size = new System.Drawing.Size(100, 20);
			this.txtnumero3.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 366);
			this.Controls.Add(this.txtnumero3);
			this.Controls.Add(this.txtnumero2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblnumero2);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.lblnumero);
			this.Controls.Add(this.txtnumero1);
			this.Controls.Add(this.btnverificar);
			this.Name = "MainForm";
			this.Text = "maior entre três numeros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
