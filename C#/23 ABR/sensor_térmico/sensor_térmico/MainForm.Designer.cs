/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 23/04/2026
 * Hora: 19:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace sensor_térmico
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbTexto = new System.Windows.Forms.Label();
			this.txtTemp = new System.Windows.Forms.TextBox();
			this.btMedir = new System.Windows.Forms.Button();
			this.pbImagem = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btLimpar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.lbTexto);
			this.panel1.Controls.Add(this.txtTemp);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(429, 172);
			this.panel1.TabIndex = 0;
			// 
			// lbTexto
			// 
			this.lbTexto.BackColor = System.Drawing.Color.DimGray;
			this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTexto.ForeColor = System.Drawing.Color.White;
			this.lbTexto.Location = new System.Drawing.Point(22, 11);
			this.lbTexto.Name = "lbTexto";
			this.lbTexto.Size = new System.Drawing.Size(385, 42);
			this.lbTexto.TabIndex = 1;
			this.lbTexto.Text = "Qual a temperatura hoje?";
			this.lbTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtTemp
			// 
			this.txtTemp.BackColor = System.Drawing.Color.Gainsboro;
			this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTemp.Location = new System.Drawing.Point(37, 62);
			this.txtTemp.Name = "txtTemp";
			this.txtTemp.Size = new System.Drawing.Size(348, 98);
			this.txtTemp.TabIndex = 0;
			this.txtTemp.Text = "36";
			this.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btMedir
			// 
			this.btMedir.BackColor = System.Drawing.Color.DimGray;
			this.btMedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMedir.ForeColor = System.Drawing.Color.White;
			this.btMedir.Location = new System.Drawing.Point(12, 192);
			this.btMedir.Name = "btMedir";
			this.btMedir.Size = new System.Drawing.Size(428, 45);
			this.btMedir.TabIndex = 1;
			this.btMedir.Text = "Medir";
			this.btMedir.UseVisualStyleBackColor = false;
			this.btMedir.Click += new System.EventHandler(this.Button1Click);
			// 
			// pbImagem
			// 
			this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
			this.pbImagem.Location = new System.Drawing.Point(12, 265);
			this.pbImagem.Name = "pbImagem";
			this.pbImagem.Size = new System.Drawing.Size(427, 353);
			this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImagem.TabIndex = 2;
			this.pbImagem.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 2000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// btLimpar
			// 
			this.btLimpar.BackColor = System.Drawing.Color.Firebrick;
			this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLimpar.ForeColor = System.Drawing.Color.White;
			this.btLimpar.Location = new System.Drawing.Point(13, 634);
			this.btLimpar.Name = "btLimpar";
			this.btLimpar.Size = new System.Drawing.Size(428, 45);
			this.btLimpar.TabIndex = 3;
			this.btLimpar.Text = "Limpar";
			this.btLimpar.UseVisualStyleBackColor = false;
			this.btLimpar.Click += new System.EventHandler(this.BtLimparClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btMedir;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(461, 691);
			this.Controls.Add(this.btLimpar);
			this.Controls.Add(this.pbImagem);
			this.Controls.Add(this.btMedir);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ronaldinho_térmico";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pbImagem;
		private System.Windows.Forms.Button btMedir;
		private System.Windows.Forms.TextBox txtTemp;
		private System.Windows.Forms.Label lbTexto;
		private System.Windows.Forms.Panel panel1;
	}
}
