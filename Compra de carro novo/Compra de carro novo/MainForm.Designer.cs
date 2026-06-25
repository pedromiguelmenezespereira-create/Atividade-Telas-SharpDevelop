/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 25/06/2026
 * Time: 08:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Compra_de_carro_novo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtdinheiro;
		private System.Windows.Forms.Button btnverificar;
		private System.Windows.Forms.Label lblresultado;
		private System.Windows.Forms.TextBox txtdesejocarro;
		
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
			this.txtdesejocarro = new System.Windows.Forms.TextBox();
			this.txtdinheiro = new System.Windows.Forms.TextBox();
			this.btnverificar = new System.Windows.Forms.Button();
			this.lblresultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "deseja comprar um carro:(sim/não)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "tem dinheiro?";
			// 
			// txtdesejocarro
			// 
			this.txtdesejocarro.Location = new System.Drawing.Point(52, 73);
			this.txtdesejocarro.Name = "txtdesejocarro";
			this.txtdesejocarro.Size = new System.Drawing.Size(217, 20);
			this.txtdesejocarro.TabIndex = 2;
			// 
			// txtdinheiro
			// 
			this.txtdinheiro.Location = new System.Drawing.Point(52, 156);
			this.txtdinheiro.Name = "txtdinheiro";
			this.txtdinheiro.Size = new System.Drawing.Size(217, 20);
			this.txtdinheiro.TabIndex = 3;
			// 
			// btnverificar
			// 
			this.btnverificar.Location = new System.Drawing.Point(143, 199);
			this.btnverificar.Name = "btnverificar";
			this.btnverificar.Size = new System.Drawing.Size(75, 23);
			this.btnverificar.TabIndex = 4;
			this.btnverificar.Text = "verificar...";
			this.btnverificar.UseVisualStyleBackColor = true;
			this.btnverificar.Click += new System.EventHandler(this.BtnverificarClick);
			// 
			// lblresultado
			// 
			this.lblresultado.AutoSize = true;
			this.lblresultado.Location = new System.Drawing.Point(124, 244);
			this.lblresultado.Name = "lblresultado";
			this.lblresultado.Size = new System.Drawing.Size(130, 13);
			this.lblresultado.TabIndex = 5;
			this.lblresultado.Text = ".........................................";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 288);
			this.Controls.Add(this.lblresultado);
			this.Controls.Add(this.btnverificar);
			this.Controls.Add(this.txtdinheiro);
			this.Controls.Add(this.txtdesejocarro);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Compra de carro novo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
