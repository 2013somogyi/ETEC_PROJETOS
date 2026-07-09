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
			this.lbValorTotal = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pbBotao = new System.Windows.Forms.PictureBox();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.txtLargura = new System.Windows.Forms.TextBox();
			this.txtComprimento = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtImposto = new System.Windows.Forms.TextBox();
			this.txtValor_semImposto = new System.Windows.Forms.TextBox();
			this.txtTaxaFixa = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtAdicional = new System.Windows.Forms.TextBox();
			this.txt_semAdicional = new System.Windows.Forms.TextBox();
			this.txtVolume = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBotao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(964, 650);
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
			this.label1.Location = new System.Drawing.Point(225, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(452, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cálculos de orçamento";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(370, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Informe o tamanho da piscina em \"metros\":";
			// 
			// lbValorTotal
			// 
			this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValorTotal.Location = new System.Drawing.Point(69, 398);
			this.lbValorTotal.Name = "lbValorTotal";
			this.lbValorTotal.Size = new System.Drawing.Size(300, 44);
			this.lbValorTotal.TabIndex = 3;
			this.lbValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(96, 341);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(236, 35);
			this.label4.TabIndex = 4;
			this.label4.Text = "Valor final";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pbBotao
			// 
			this.pbBotao.Image = ((System.Drawing.Image)(resources.GetObject("pbBotao.Image")));
			this.pbBotao.Location = new System.Drawing.Point(36, 399);
			this.pbBotao.Name = "pbBotao";
			this.pbBotao.Size = new System.Drawing.Size(415, 194);
			this.pbBotao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBotao.TabIndex = 5;
			this.pbBotao.TabStop = false;
			this.pbBotao.Click += new System.EventHandler(this.PbBotaoClick);
			// 
			// txtAltura
			// 
			this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAltura.Location = new System.Drawing.Point(6, 82);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(143, 28);
			this.txtAltura.TabIndex = 6;
			this.txtAltura.Text = "8";
			// 
			// txtLargura
			// 
			this.txtLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLargura.Location = new System.Drawing.Point(6, 154);
			this.txtLargura.Name = "txtLargura";
			this.txtLargura.Size = new System.Drawing.Size(141, 28);
			this.txtLargura.TabIndex = 7;
			this.txtLargura.Text = "5";
			// 
			// txtComprimento
			// 
			this.txtComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComprimento.Location = new System.Drawing.Point(5, 225);
			this.txtComprimento.Name = "txtComprimento";
			this.txtComprimento.Size = new System.Drawing.Size(140, 28);
			this.txtComprimento.TabIndex = 8;
			this.txtComprimento.Text = "3";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(7, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 21);
			this.label5.TabIndex = 9;
			this.label5.Text = "Altura";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(5, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 21);
			this.label6.TabIndex = 10;
			this.label6.Text = "Largura";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(5, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 21);
			this.label7.TabIndex = 11;
			this.label7.Text = "Comprimento";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(175, 59);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(227, 204);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Turquoise;
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtComprimento);
			this.panel2.Controls.Add(this.txtLargura);
			this.panel2.Controls.Add(this.txtAltura);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(36, 90);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(415, 289);
			this.panel2.TabIndex = 13;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Turquoise;
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.lbValorTotal);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.txtImposto);
			this.panel3.Controls.Add(this.txtValor_semImposto);
			this.panel3.Controls.Add(this.txtTaxaFixa);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.txtAdicional);
			this.panel3.Controls.Add(this.txt_semAdicional);
			this.panel3.Controls.Add(this.txtVolume);
			this.panel3.Location = new System.Drawing.Point(471, 90);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(440, 503);
			this.panel3.TabIndex = 14;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(42, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(343, 52);
			this.label13.TabIndex = 1;
			this.label13.Text = "Orçamento";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(243, 261);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(135, 20);
			this.label10.TabIndex = 23;
			this.label10.Text = "Valor do imposto";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(243, 190);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(140, 20);
			this.label11.TabIndex = 22;
			this.label11.Text = "Valor s/ Impostos";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(245, 118);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(81, 20);
			this.label12.TabIndex = 21;
			this.label12.Text = "Taxa Fixa";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtImposto
			// 
			this.txtImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImposto.Location = new System.Drawing.Point(243, 285);
			this.txtImposto.Name = "txtImposto";
			this.txtImposto.Size = new System.Drawing.Size(140, 28);
			this.txtImposto.TabIndex = 20;
			// 
			// txtValor_semImposto
			// 
			this.txtValor_semImposto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValor_semImposto.Location = new System.Drawing.Point(244, 214);
			this.txtValor_semImposto.Name = "txtValor_semImposto";
			this.txtValor_semImposto.Size = new System.Drawing.Size(141, 28);
			this.txtValor_semImposto.TabIndex = 19;
			// 
			// txtTaxaFixa
			// 
			this.txtTaxaFixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTaxaFixa.Location = new System.Drawing.Point(244, 142);
			this.txtTaxaFixa.Name = "txtTaxaFixa";
			this.txtTaxaFixa.Size = new System.Drawing.Size(143, 28);
			this.txtTaxaFixa.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(57, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 20);
			this.label3.TabIndex = 17;
			this.label3.Text = "Valor do Adicional";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(57, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(149, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "Valor s/ Adicionais";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(59, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "Volume";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAdicional
			// 
			this.txtAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdicional.Location = new System.Drawing.Point(57, 285);
			this.txtAdicional.Name = "txtAdicional";
			this.txtAdicional.Size = new System.Drawing.Size(140, 28);
			this.txtAdicional.TabIndex = 14;
			// 
			// txt_semAdicional
			// 
			this.txt_semAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_semAdicional.Location = new System.Drawing.Point(58, 214);
			this.txt_semAdicional.Name = "txt_semAdicional";
			this.txt_semAdicional.Size = new System.Drawing.Size(141, 28);
			this.txt_semAdicional.TabIndex = 13;
			// 
			// txtVolume
			// 
			this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVolume.Location = new System.Drawing.Point(58, 142);
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.Size = new System.Drawing.Size(143, 28);
			this.txtVolume.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(929, 646);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pbBotao);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Netuno & Sereias";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBotao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtVolume;
		private System.Windows.Forms.TextBox txt_semAdicional;
		private System.Windows.Forms.TextBox txtAdicional;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTaxaFixa;
		private System.Windows.Forms.TextBox txtValor_semImposto;
		private System.Windows.Forms.TextBox txtImposto;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtComprimento;
		private System.Windows.Forms.TextBox txtLargura;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.PictureBox pbBotao;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbValorTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
