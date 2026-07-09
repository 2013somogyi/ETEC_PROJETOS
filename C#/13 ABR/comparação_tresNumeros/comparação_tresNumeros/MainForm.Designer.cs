/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 13/04/2026
 * Hora: 20:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace comparação_tresNumeros
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
			this.txtNmr1 = new System.Windows.Forms.TextBox();
			this.txtNmr2 = new System.Windows.Forms.TextBox();
			this.txtNmr3 = new System.Windows.Forms.TextBox();
			this.btComparar = new System.Windows.Forms.Button();
			this.lbResultado = new System.Windows.Forms.Label();
			this.btLimpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-52, -6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(889, 598);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtNmr1
			// 
			this.txtNmr1.BackColor = System.Drawing.Color.DimGray;
			this.txtNmr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNmr1.ForeColor = System.Drawing.Color.White;
			this.txtNmr1.Location = new System.Drawing.Point(152, 178);
			this.txtNmr1.Name = "txtNmr1";
			this.txtNmr1.Size = new System.Drawing.Size(236, 38);
			this.txtNmr1.TabIndex = 1;
			// 
			// txtNmr2
			// 
			this.txtNmr2.BackColor = System.Drawing.Color.DimGray;
			this.txtNmr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNmr2.ForeColor = System.Drawing.Color.White;
			this.txtNmr2.Location = new System.Drawing.Point(152, 286);
			this.txtNmr2.Name = "txtNmr2";
			this.txtNmr2.Size = new System.Drawing.Size(236, 38);
			this.txtNmr2.TabIndex = 2;
			// 
			// txtNmr3
			// 
			this.txtNmr3.BackColor = System.Drawing.Color.DimGray;
			this.txtNmr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNmr3.ForeColor = System.Drawing.Color.White;
			this.txtNmr3.Location = new System.Drawing.Point(152, 392);
			this.txtNmr3.Name = "txtNmr3";
			this.txtNmr3.Size = new System.Drawing.Size(236, 38);
			this.txtNmr3.TabIndex = 3;
			// 
			// btComparar
			// 
			this.btComparar.BackColor = System.Drawing.Color.DarkOrange;
			this.btComparar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btComparar.Location = new System.Drawing.Point(413, 179);
			this.btComparar.Name = "btComparar";
			this.btComparar.Size = new System.Drawing.Size(227, 61);
			this.btComparar.TabIndex = 4;
			this.btComparar.Text = "Comparar";
			this.btComparar.UseVisualStyleBackColor = false;
			this.btComparar.Click += new System.EventHandler(this.BtCompararClick);
			// 
			// lbResultado
			// 
			this.lbResultado.BackColor = System.Drawing.Color.White;
			this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbResultado.Location = new System.Drawing.Point(428, 326);
			this.lbResultado.Name = "lbResultado";
			this.lbResultado.Size = new System.Drawing.Size(199, 120);
			this.lbResultado.TabIndex = 5;
			this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btLimpar
			// 
			this.btLimpar.AutoSize = true;
			this.btLimpar.BackColor = System.Drawing.Color.Crimson;
			this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLimpar.Location = new System.Drawing.Point(542, 273);
			this.btLimpar.Name = "btLimpar";
			this.btLimpar.Size = new System.Drawing.Size(85, 35);
			this.btLimpar.TabIndex = 6;
			this.btLimpar.Text = "Limpar";
			this.btLimpar.UseVisualStyleBackColor = false;
			this.btLimpar.Click += new System.EventHandler(this.BtLimparClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btComparar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(835, 526);
			this.Controls.Add(this.btLimpar);
			this.Controls.Add(this.lbResultado);
			this.Controls.Add(this.btComparar);
			this.Controls.Add(this.txtNmr3);
			this.Controls.Add(this.txtNmr2);
			this.Controls.Add(this.txtNmr1);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "comparação_tresNumeros";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.Label lbResultado;
		private System.Windows.Forms.Button btComparar;
		private System.Windows.Forms.TextBox txtNmr3;
		private System.Windows.Forms.TextBox txtNmr2;
		private System.Windows.Forms.TextBox txtNmr1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
