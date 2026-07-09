/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 04/05/2026
 * Hora: 20:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace imposto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btCalcular = new System.Windows.Forms.Button();
			this.txtBruto = new System.Windows.Forms.TextBox();
			this.txtLiquido = new System.Windows.Forms.TextBox();
			this.txtDesconto = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(808, 499);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btCalcular
			// 
			this.btCalcular.AutoSize = true;
			this.btCalcular.BackColor = System.Drawing.Color.SteelBlue;
			this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCalcular.ForeColor = System.Drawing.Color.White;
			this.btCalcular.Location = new System.Drawing.Point(357, 220);
			this.btCalcular.Name = "btCalcular";
			this.btCalcular.Size = new System.Drawing.Size(89, 35);
			this.btCalcular.TabIndex = 1;
			this.btCalcular.Text = "Calcular";
			this.btCalcular.UseVisualStyleBackColor = false;
			this.btCalcular.Click += new System.EventHandler(this.BtCalcularClick);
			// 
			// txtBruto
			// 
			this.txtBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBruto.Location = new System.Drawing.Point(205, 159);
			this.txtBruto.Name = "txtBruto";
			this.txtBruto.Size = new System.Drawing.Size(395, 27);
			this.txtBruto.TabIndex = 2;
			// 
			// txtLiquido
			// 
			this.txtLiquido.BackColor = System.Drawing.SystemColors.Control;
			this.txtLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLiquido.Location = new System.Drawing.Point(238, 321);
			this.txtLiquido.Name = "txtLiquido";
			this.txtLiquido.Size = new System.Drawing.Size(352, 27);
			this.txtLiquido.TabIndex = 3;
			// 
			// txtDesconto
			// 
			this.txtDesconto.BackColor = System.Drawing.SystemColors.Control;
			this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesconto.Location = new System.Drawing.Point(238, 383);
			this.txtDesconto.Name = "txtDesconto";
			this.txtDesconto.Size = new System.Drawing.Size(352, 27);
			this.txtDesconto.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btCalcular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(796, 450);
			this.Controls.Add(this.txtDesconto);
			this.Controls.Add(this.txtLiquido);
			this.Controls.Add(this.txtBruto);
			this.Controls.Add(this.btCalcular);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "imposto";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtDesconto;
		private System.Windows.Forms.TextBox txtLiquido;
		private System.Windows.Forms.TextBox txtBruto;
		private System.Windows.Forms.Button btCalcular;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
