/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 09/04/2026
 * Hora: 19:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace agencia_viagens
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.cboxOrigem = new System.Windows.Forms.ComboBox();
			this.cboxDestino = new System.Windows.Forms.ComboBox();
			this.cboxHorario = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cboxHospedagem = new System.Windows.Forms.ComboBox();
			this.boxNmrDias = new System.Windows.Forms.NumericUpDown();
			this.txtTransporte = new System.Windows.Forms.TextBox();
			this.txtHospedagem = new System.Windows.Forms.TextBox();
			this.lbTotal = new System.Windows.Forms.Label();
			this.rbOnibus = new System.Windows.Forms.RadioButton();
			this.rbAviao = new System.Windows.Forms.RadioButton();
			this.btCalcular = new System.Windows.Forms.Button();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.boxNmrDias)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-17, -55);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1215, 671);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(44, 114);
			this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(403, 30);
			this.txtNome.TabIndex = 1;
			// 
			// cboxOrigem
			// 
			this.cboxOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxOrigem.FormattingEnabled = true;
			this.cboxOrigem.Location = new System.Drawing.Point(84, 227);
			this.cboxOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxOrigem.Name = "cboxOrigem";
			this.cboxOrigem.Size = new System.Drawing.Size(229, 28);
			this.cboxOrigem.TabIndex = 2;
			// 
			// cboxDestino
			// 
			this.cboxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxDestino.FormattingEnabled = true;
			this.cboxDestino.Location = new System.Drawing.Point(373, 226);
			this.cboxDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxDestino.Name = "cboxDestino";
			this.cboxDestino.Size = new System.Drawing.Size(232, 28);
			this.cboxDestino.TabIndex = 3;
			this.cboxDestino.SelectedIndexChanged += new System.EventHandler(this.CboxDestinoSelectedIndexChanged);
			// 
			// cboxHorario
			// 
			this.cboxHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxHorario.FormattingEnabled = true;
			this.cboxHorario.Location = new System.Drawing.Point(347, 309);
			this.cboxHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxHorario.Name = "cboxHorario";
			this.cboxHorario.Size = new System.Drawing.Size(221, 26);
			this.cboxHorario.TabIndex = 4;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(49, 311);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(263, 24);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// cboxHospedagem
			// 
			this.cboxHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboxHospedagem.FormattingEnabled = true;
			this.cboxHospedagem.Location = new System.Drawing.Point(49, 391);
			this.cboxHospedagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxHospedagem.Name = "cboxHospedagem";
			this.cboxHospedagem.Size = new System.Drawing.Size(263, 28);
			this.cboxHospedagem.TabIndex = 6;
			// 
			// boxNmrDias
			// 
			this.boxNmrDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boxNmrDias.Location = new System.Drawing.Point(51, 467);
			this.boxNmrDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.boxNmrDias.Name = "boxNmrDias";
			this.boxNmrDias.Size = new System.Drawing.Size(263, 30);
			this.boxNmrDias.TabIndex = 7;
			this.boxNmrDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtTransporte
			// 
			this.txtTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTransporte.Location = new System.Drawing.Point(721, 152);
			this.txtTransporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTransporte.Name = "txtTransporte";
			this.txtTransporte.ReadOnly = true;
			this.txtTransporte.Size = new System.Drawing.Size(407, 24);
			this.txtTransporte.TabIndex = 8;
			this.txtTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtHospedagem
			// 
			this.txtHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHospedagem.Location = new System.Drawing.Point(720, 247);
			this.txtHospedagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtHospedagem.Name = "txtHospedagem";
			this.txtHospedagem.ReadOnly = true;
			this.txtHospedagem.Size = new System.Drawing.Size(407, 24);
			this.txtHospedagem.TabIndex = 9;
			this.txtHospedagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbTotal
			// 
			this.lbTotal.BackColor = System.Drawing.Color.Transparent;
			this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotal.Location = new System.Drawing.Point(719, 351);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(408, 73);
			this.lbTotal.TabIndex = 10;
			this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbOnibus
			// 
			this.rbOnibus.BackColor = System.Drawing.Color.Transparent;
			this.rbOnibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbOnibus.ForeColor = System.Drawing.Color.Maroon;
			this.rbOnibus.Location = new System.Drawing.Point(361, 425);
			this.rbOnibus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbOnibus.Name = "rbOnibus";
			this.rbOnibus.Size = new System.Drawing.Size(125, 25);
			this.rbOnibus.TabIndex = 11;
			this.rbOnibus.TabStop = true;
			this.rbOnibus.Text = "Ônibus";
			this.rbOnibus.UseVisualStyleBackColor = false;
			// 
			// rbAviao
			// 
			this.rbAviao.BackColor = System.Drawing.Color.Transparent;
			this.rbAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbAviao.ForeColor = System.Drawing.Color.Maroon;
			this.rbAviao.Location = new System.Drawing.Point(361, 463);
			this.rbAviao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbAviao.Name = "rbAviao";
			this.rbAviao.Size = new System.Drawing.Size(125, 25);
			this.rbAviao.TabIndex = 12;
			this.rbAviao.TabStop = true;
			this.rbAviao.Text = "Avião";
			this.rbAviao.UseVisualStyleBackColor = false;
			// 
			// btCalcular
			// 
			this.btCalcular.BackColor = System.Drawing.Color.Firebrick;
			this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCalcular.ForeColor = System.Drawing.Color.White;
			this.btCalcular.Location = new System.Drawing.Point(464, 546);
			this.btCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btCalcular.Name = "btCalcular";
			this.btCalcular.Size = new System.Drawing.Size(249, 52);
			this.btCalcular.TabIndex = 13;
			this.btCalcular.Text = "Agendar Reserva";
			this.btCalcular.UseVisualStyleBackColor = false;
			this.btCalcular.Click += new System.EventHandler(this.BtCalcularClick);
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(95, 151);
			this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
			this.txtCPF.Mask = "000.000.000-00";
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(187, 30);
			this.txtCPF.TabIndex = 14;
			// 
			// MainForm
			// 
			this.AcceptButton = this.btCalcular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1181, 607);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.btCalcular);
			this.Controls.Add(this.rbAviao);
			this.Controls.Add(this.rbOnibus);
			this.Controls.Add(this.lbTotal);
			this.Controls.Add(this.txtHospedagem);
			this.Controls.Add(this.txtTransporte);
			this.Controls.Add(this.boxNmrDias);
			this.Controls.Add(this.cboxHospedagem);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cboxHorario);
			this.Controls.Add(this.cboxDestino);
			this.Controls.Add(this.cboxOrigem);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "agencia_viagens";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.boxNmrDias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox txtCPF;
		private System.Windows.Forms.Button btCalcular;
		private System.Windows.Forms.RadioButton rbAviao;
		private System.Windows.Forms.RadioButton rbOnibus;
		private System.Windows.Forms.Label lbTotal;
		private System.Windows.Forms.TextBox txtHospedagem;
		private System.Windows.Forms.TextBox txtTransporte;
		private System.Windows.Forms.NumericUpDown boxNmrDias;
		private System.Windows.Forms.ComboBox cboxHospedagem;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cboxHorario;
		private System.Windows.Forms.ComboBox cboxDestino;
		private System.Windows.Forms.ComboBox cboxOrigem;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
