/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 08:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Equação_do_Segundo_Grau
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtvalorB;
		private System.Windows.Forms.TextBox txtvalorC;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.TextBox txtvalorA;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtvalorB = new System.Windows.Forms.TextBox();
			this.txtvalorC = new System.Windows.Forms.TextBox();
			this.txtvalorA = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "A:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(86, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "B:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(86, 232);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "C:";
			// 
			// txtvalorB
			// 
			this.txtvalorB.Location = new System.Drawing.Point(127, 178);
			this.txtvalorB.Name = "txtvalorB";
			this.txtvalorB.Size = new System.Drawing.Size(100, 20);
			this.txtvalorB.TabIndex = 3;
			// 
			// txtvalorC
			// 
			this.txtvalorC.Location = new System.Drawing.Point(127, 232);
			this.txtvalorC.Name = "txtvalorC";
			this.txtvalorC.Size = new System.Drawing.Size(100, 20);
			this.txtvalorC.TabIndex = 4;
			// 
			// txtvalorA
			// 
			this.txtvalorA.Location = new System.Drawing.Point(127, 124);
			this.txtvalorA.Name = "txtvalorA";
			this.txtvalorA.Size = new System.Drawing.Size(100, 20);
			this.txtvalorA.TabIndex = 5;
			// 
			// btncalcular
			// 
			this.btncalcular.AutoSize = true;
			this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncalcular.Location = new System.Drawing.Point(127, 277);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(347, 53);
			this.btncalcular.TabIndex = 6;
			this.btncalcular.Text = "Ver equaçao do segundo grau";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblresultado.Location = new System.Drawing.Point(384, 103);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(105, 20);
			this.lblresultado.TabIndex = 7;
			this.lblresultado.Text = "----------------";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 353);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtvalorA);
			this.Controls.Add(this.txtvalorC);
			this.Controls.Add(this.txtvalorB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Equação do Segundo Grau";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
