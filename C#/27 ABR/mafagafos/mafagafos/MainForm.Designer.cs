/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 27/04/2026
 * Hora: 19:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace mafagafos
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
			this.txtFilhote = new System.Windows.Forms.NumericUpDown();
			this.txtGravido = new System.Windows.Forms.NumericUpDown();
			this.txtAdulto = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbEstGravido = new System.Windows.Forms.Label();
			this.lbEstAdulto = new System.Windows.Forms.Label();
			this.lbEstFilhote = new System.Windows.Forms.Label();
			this.lbQtd = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbValorFinal = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbDesconto = new System.Windows.Forms.Label();
			this.lbValorTotal = new System.Windows.Forms.Label();
			this.lbTotalMaf = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btCalcular = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtFilhote)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGravido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdulto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFilhote
			// 
			this.txtFilhote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilhote.Location = new System.Drawing.Point(125, 70);
			this.txtFilhote.Name = "txtFilhote";
			this.txtFilhote.Size = new System.Drawing.Size(68, 34);
			this.txtFilhote.TabIndex = 2;
			this.txtFilhote.ValueChanged += new System.EventHandler(this.Calcular);
			// 
			// txtGravido
			// 
			this.txtGravido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGravido.Location = new System.Drawing.Point(125, 213);
			this.txtGravido.Name = "txtGravido";
			this.txtGravido.Size = new System.Drawing.Size(68, 34);
			this.txtGravido.TabIndex = 3;
			this.txtGravido.ValueChanged += new System.EventHandler(this.Calcular);
			// 
			// txtAdulto
			// 
			this.txtAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdulto.Location = new System.Drawing.Point(125, 141);
			this.txtAdulto.Name = "txtAdulto";
			this.txtAdulto.Size = new System.Drawing.Size(68, 34);
			this.txtAdulto.TabIndex = 4;
			this.txtAdulto.ValueChanged += new System.EventHandler(this.Calcular);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Filhote";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "Adulto";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Grávido";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(25, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(370, 179);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SkyBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(6, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 521);
			this.panel1.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.PowderBlue;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.lbEstGravido);
			this.panel3.Controls.Add(this.lbEstAdulto);
			this.panel3.Controls.Add(this.lbEstFilhote);
			this.panel3.Controls.Add(this.lbQtd);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txtAdulto);
			this.panel3.Controls.Add(this.txtGravido);
			this.panel3.Controls.Add(this.txtFilhote);
			this.panel3.Location = new System.Drawing.Point(16, 236);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(379, 272);
			this.panel3.TabIndex = 10;
			// 
			// lbEstGravido
			// 
			this.lbEstGravido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEstGravido.Location = new System.Drawing.Point(224, 214);
			this.lbEstGravido.Name = "lbEstGravido";
			this.lbEstGravido.Size = new System.Drawing.Size(152, 32);
			this.lbEstGravido.TabIndex = 11;
			this.lbEstGravido.Text = "700";
			this.lbEstGravido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbEstAdulto
			// 
			this.lbEstAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEstAdulto.Location = new System.Drawing.Point(224, 140);
			this.lbEstAdulto.Name = "lbEstAdulto";
			this.lbEstAdulto.Size = new System.Drawing.Size(152, 32);
			this.lbEstAdulto.TabIndex = 10;
			this.lbEstAdulto.Text = "20300";
			this.lbEstAdulto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbEstFilhote
			// 
			this.lbEstFilhote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEstFilhote.Location = new System.Drawing.Point(224, 69);
			this.lbEstFilhote.Name = "lbEstFilhote";
			this.lbEstFilhote.Size = new System.Drawing.Size(152, 32);
			this.lbEstFilhote.TabIndex = 9;
			this.lbEstFilhote.Text = "7000";
			this.lbEstFilhote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbQtd
			// 
			this.lbQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbQtd.Location = new System.Drawing.Point(224, 38);
			this.lbQtd.Name = "lbQtd";
			this.lbQtd.Size = new System.Drawing.Size(152, 32);
			this.lbQtd.TabIndex = 8;
			this.lbQtd.Text = "Estoque";
			this.lbQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(329, 46);
			this.label5.TabIndex = 8;
			this.label5.Text = "Selecione a quantidade:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.PowderBlue;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(19, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(368, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "COMPRA DE MAFAGAFOS";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SkyBlue;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.lbValorFinal);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.btCalcular);
			this.panel2.Location = new System.Drawing.Point(703, 9);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(378, 522);
			this.panel2.TabIndex = 10;
			// 
			// lbValorFinal
			// 
			this.lbValorFinal.BackColor = System.Drawing.Color.SkyBlue;
			this.lbValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValorFinal.Location = new System.Drawing.Point(27, 285);
			this.lbValorFinal.Name = "lbValorFinal";
			this.lbValorFinal.Size = new System.Drawing.Size(316, 97);
			this.lbValorFinal.TabIndex = 4;
			this.lbValorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.lbDesconto);
			this.panel4.Controls.Add(this.lbValorTotal);
			this.panel4.Controls.Add(this.lbTotalMaf);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(3, 70);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(365, 334);
			this.panel4.TabIndex = 5;
			// 
			// lbDesconto
			// 
			this.lbDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDesconto.Location = new System.Drawing.Point(203, 95);
			this.lbDesconto.Name = "lbDesconto";
			this.lbDesconto.Size = new System.Drawing.Size(159, 25);
			this.lbDesconto.TabIndex = 7;
			// 
			// lbValorTotal
			// 
			this.lbValorTotal.BackColor = System.Drawing.Color.SkyBlue;
			this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbValorTotal.Location = new System.Drawing.Point(205, 59);
			this.lbValorTotal.Name = "lbValorTotal";
			this.lbValorTotal.Size = new System.Drawing.Size(157, 25);
			this.lbValorTotal.TabIndex = 6;
			// 
			// lbTotalMaf
			// 
			this.lbTotalMaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalMaf.Location = new System.Drawing.Point(205, 21);
			this.lbTotalMaf.Name = "lbTotalMaf";
			this.lbTotalMaf.Size = new System.Drawing.Size(157, 25);
			this.lbTotalMaf.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 21);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(185, 25);
			this.label9.TabIndex = 4;
			this.label9.Text = "Total de mafagafos:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(105, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(152, 32);
			this.label8.TabIndex = 3;
			this.label8.Text = "Valor Final";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(179, 25);
			this.label7.TabIndex = 2;
			this.label7.Text = "Desconto aplicado:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Valor Total:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.PowderBlue;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(75, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(232, 32);
			this.label10.TabIndex = 11;
			this.label10.Text = "MEU CARRINHO";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btCalcular
			// 
			this.btCalcular.BackColor = System.Drawing.Color.LimeGreen;
			this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCalcular.ForeColor = System.Drawing.Color.White;
			this.btCalcular.Location = new System.Drawing.Point(30, 421);
			this.btCalcular.Name = "btCalcular";
			this.btCalcular.Size = new System.Drawing.Size(318, 76);
			this.btCalcular.TabIndex = 0;
			this.btCalcular.Text = "Comprar";
			this.btCalcular.UseVisualStyleBackColor = false;
			this.btCalcular.Click += new System.EventHandler(this.btCalcularClick);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.SkyBlue;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.label12);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.label14);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Location = new System.Drawing.Point(428, 8);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(272, 521);
			this.panel5.TabIndex = 11;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(34, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(185, 25);
			this.label12.TabIndex = 15;
			this.label12.Text = "Total de mafagafos:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(34, 263);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(179, 25);
			this.label13.TabIndex = 14;
			this.label13.Text = "Desconto aplicado:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(34, 190);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(113, 25);
			this.label14.TabIndex = 13;
			this.label14.Text = "Valor Total:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.PowderBlue;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(34, 17);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(208, 64);
			this.label11.TabIndex = 12;
			this.label11.Text = "VALOR\r\nPOR UNIDADE";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btCalcular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1093, 535);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mafagafos_Rumpelstilskin";
			((System.ComponentModel.ISupportInitialize)(this.txtFilhote)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGravido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAdulto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lbEstFilhote;
		private System.Windows.Forms.Label lbEstAdulto;
		private System.Windows.Forms.Label lbEstGravido;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbTotalMaf;
		private System.Windows.Forms.Label lbValorTotal;
		private System.Windows.Forms.Label lbDesconto;
		private System.Windows.Forms.Label lbQtd;
		private System.Windows.Forms.Button btCalcular;
		private System.Windows.Forms.Label lbValorFinal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown txtAdulto;
		private System.Windows.Forms.NumericUpDown txtGravido;
		private System.Windows.Forms.NumericUpDown txtFilhote;
	}
}
