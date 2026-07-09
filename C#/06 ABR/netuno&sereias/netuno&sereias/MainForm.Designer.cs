/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 06/04/2026
 * Hora: 20:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace netuno_sereias
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbValorFim = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pbBotao = new System.Windows.Forms.PictureBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.txtLargura = new System.Windows.Forms.TextBox();
			this.txtComprimento = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBotao)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1175, 650);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1172, 68);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(353, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(454, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Orçamento de Limpeza";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(370, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Informe o tamanho da piscina em \"metros\":";
			// 
			// lbValorFim
			// 
			this.lbValorFim.AutoSize = true;
			this.lbValorFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValorFim.Location = new System.Drawing.Point(607, 207);
			this.lbValorFim.Name = "lbValorFim";
			this.lbValorFim.Size = new System.Drawing.Size(104, 44);
			this.lbValorFim.TabIndex = 3;
			this.lbValorFim.Text = "2000";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(607, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(236, 35);
			this.label4.TabIndex = 4;
			this.label4.Text = "Valor final";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pbBotao
			// 
			this.pbBotao.Image = ((System.Drawing.Image)(resources.GetObject("pbBotao.Image")));
			this.pbBotao.Location = new System.Drawing.Point(224, 158);
			this.pbBotao.Name = "pbBotao";
			this.pbBotao.Size = new System.Drawing.Size(255, 200);
			this.pbBotao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBotao.TabIndex = 5;
			this.pbBotao.TabStop = false;
			this.pbBotao.Click += new System.EventHandler(this.PbBotaoClick);
			// 
			// txtAltura
			// 
			this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAltura.Location = new System.Drawing.Point(10, 176);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(143, 28);
			this.txtAltura.TabIndex = 6;
			this.txtAltura.Text = "8";
			// 
			// txtLargura
			// 
			this.txtLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLargura.Location = new System.Drawing.Point(12, 254);
			this.txtLargura.Name = "txtLargura";
			this.txtLargura.Size = new System.Drawing.Size(141, 28);
			this.txtLargura.TabIndex = 7;
			this.txtLargura.Text = "5";
			// 
			// txtComprimento
			// 
			this.txtComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComprimento.Location = new System.Drawing.Point(13, 330);
			this.txtComprimento.Name = "txtComprimento";
			this.txtComprimento.Size = new System.Drawing.Size(140, 28);
			this.txtComprimento.TabIndex = 8;
			this.txtComprimento.Text = "3";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "Altura";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(11, 230);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 21);
			this.label6.TabIndex = 10;
			this.label6.Text = "Largura";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 306);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 21);
			this.label7.TabIndex = 11;
			this.label7.Text = "Comprimento";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1167, 646);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtComprimento);
			this.Controls.Add(this.txtLargura);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.pbBotao);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbValorFim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Netuno & Sereias";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBotao)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtComprimento;
		private System.Windows.Forms.TextBox txtLargura;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.PictureBox pbBotao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbValorFim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
