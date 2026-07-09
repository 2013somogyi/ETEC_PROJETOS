/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 11/05/2026
 * Hora: 19:50
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace caixa_eletronico
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
			this.lbSaldo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnSaque = new System.Windows.Forms.Panel();
			this.btVoltar2 = new System.Windows.Forms.Label();
			this.btCalcular = new System.Windows.Forms.Button();
			this.txtSaque = new System.Windows.Forms.TextBox();
			this.lb1000 = new System.Windows.Forms.Label();
			this.lb100 = new System.Windows.Forms.Label();
			this.lb500 = new System.Windows.Forms.Label();
			this.lb50 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pnSaldo = new System.Windows.Forms.Panel();
			this.btVoltar = new System.Windows.Forms.Label();
			this.lbTelaSaldo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pnEntrada = new System.Windows.Forms.Panel();
			this.btSaldo = new System.Windows.Forms.Label();
			this.btSacar = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnSaque.SuspendLayout();
			this.pnSaldo.SuspendLayout();
			this.pnEntrada.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(698, 766);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lbSaldo
			// 
			this.lbSaldo.AutoSize = true;
			this.lbSaldo.BackColor = System.Drawing.Color.White;
			this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSaldo.Location = new System.Drawing.Point(425, 213);
			this.lbSaldo.Name = "lbSaldo";
			this.lbSaldo.Size = new System.Drawing.Size(50, 24);
			this.lbSaldo.TabIndex = 1;
			this.lbSaldo.Text = "3000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(321, 213);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Saldo: R$";
			// 
			// pnSaque
			// 
			this.pnSaque.Controls.Add(this.btVoltar2);
			this.pnSaque.Controls.Add(this.btCalcular);
			this.pnSaque.Controls.Add(this.txtSaque);
			this.pnSaque.Controls.Add(this.lb1000);
			this.pnSaque.Controls.Add(this.lb100);
			this.pnSaque.Controls.Add(this.lb500);
			this.pnSaque.Controls.Add(this.lb50);
			this.pnSaque.Controls.Add(this.label3);
			this.pnSaque.Controls.Add(this.label1);
			this.pnSaque.Location = new System.Drawing.Point(160, 250);
			this.pnSaque.Name = "pnSaque";
			this.pnSaque.Size = new System.Drawing.Size(377, 165);
			this.pnSaque.TabIndex = 3;
			// 
			// btVoltar2
			// 
			this.btVoltar2.AutoSize = true;
			this.btVoltar2.BackColor = System.Drawing.Color.MidnightBlue;
			this.btVoltar2.ForeColor = System.Drawing.Color.White;
			this.btVoltar2.Location = new System.Drawing.Point(7, 9);
			this.btVoltar2.Name = "btVoltar2";
			this.btVoltar2.Size = new System.Drawing.Size(45, 17);
			this.btVoltar2.TabIndex = 8;
			this.btVoltar2.Text = "Voltar";
			this.btVoltar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btVoltar2.Click += new System.EventHandler(this.BtVoltar2Click);
			// 
			// btCalcular
			// 
			this.btCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCalcular.Location = new System.Drawing.Point(21, 94);
			this.btCalcular.Name = "btCalcular";
			this.btCalcular.Size = new System.Drawing.Size(131, 34);
			this.btCalcular.TabIndex = 7;
			this.btCalcular.Text = "Sacar";
			this.btCalcular.UseVisualStyleBackColor = false;
			this.btCalcular.Click += new System.EventHandler(this.BtCalcularClick);
			// 
			// txtSaque
			// 
			this.txtSaque.Location = new System.Drawing.Point(21, 61);
			this.txtSaque.Name = "txtSaque";
			this.txtSaque.Size = new System.Drawing.Size(131, 22);
			this.txtSaque.TabIndex = 5;
			// 
			// lb1000
			// 
			this.lb1000.BackColor = System.Drawing.Color.MidnightBlue;
			this.lb1000.ForeColor = System.Drawing.Color.White;
			this.lb1000.Location = new System.Drawing.Point(280, 108);
			this.lb1000.Name = "lb1000";
			this.lb1000.Size = new System.Drawing.Size(80, 47);
			this.lb1000.TabIndex = 4;
			this.lb1000.Text = "R$1.000";
			this.lb1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb1000.Click += new System.EventHandler(this.Lb1000Click);
			// 
			// lb100
			// 
			this.lb100.BackColor = System.Drawing.Color.MidnightBlue;
			this.lb100.ForeColor = System.Drawing.Color.White;
			this.lb100.Location = new System.Drawing.Point(280, 49);
			this.lb100.Name = "lb100";
			this.lb100.Size = new System.Drawing.Size(80, 47);
			this.lb100.TabIndex = 3;
			this.lb100.Text = "R$100";
			this.lb100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb100.Click += new System.EventHandler(this.Lb100Click);
			// 
			// lb500
			// 
			this.lb500.BackColor = System.Drawing.Color.MidnightBlue;
			this.lb500.ForeColor = System.Drawing.Color.White;
			this.lb500.Location = new System.Drawing.Point(183, 108);
			this.lb500.Name = "lb500";
			this.lb500.Size = new System.Drawing.Size(80, 47);
			this.lb500.TabIndex = 2;
			this.lb500.Text = "R$500";
			this.lb500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb500.Click += new System.EventHandler(this.Lb500Click);
			// 
			// lb50
			// 
			this.lb50.BackColor = System.Drawing.Color.MidnightBlue;
			this.lb50.ForeColor = System.Drawing.Color.White;
			this.lb50.Location = new System.Drawing.Point(183, 49);
			this.lb50.Name = "lb50";
			this.lb50.Size = new System.Drawing.Size(80, 47);
			this.lb50.TabIndex = 1;
			this.lb50.Text = "R$50";
			this.lb50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lb50.Click += new System.EventHandler(this.Lb50Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Notas disponíveis : R$ 50";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Selecione ou digite o valor:";
			// 
			// pnSaldo
			// 
			this.pnSaldo.Controls.Add(this.btVoltar);
			this.pnSaldo.Controls.Add(this.lbTelaSaldo);
			this.pnSaldo.Controls.Add(this.label4);
			this.pnSaldo.Location = new System.Drawing.Point(162, 248);
			this.pnSaldo.Name = "pnSaldo";
			this.pnSaldo.Size = new System.Drawing.Size(376, 165);
			this.pnSaldo.TabIndex = 4;
			// 
			// btVoltar
			// 
			this.btVoltar.AutoSize = true;
			this.btVoltar.BackColor = System.Drawing.Color.MidnightBlue;
			this.btVoltar.ForeColor = System.Drawing.Color.White;
			this.btVoltar.Location = new System.Drawing.Point(7, 8);
			this.btVoltar.Name = "btVoltar";
			this.btVoltar.Size = new System.Drawing.Size(45, 17);
			this.btVoltar.TabIndex = 9;
			this.btVoltar.Text = "Voltar";
			this.btVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btVoltar.Click += new System.EventHandler(this.BtVoltarClick);
			// 
			// lbTelaSaldo
			// 
			this.lbTelaSaldo.BackColor = System.Drawing.Color.MidnightBlue;
			this.lbTelaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTelaSaldo.ForeColor = System.Drawing.Color.White;
			this.lbTelaSaldo.Location = new System.Drawing.Point(18, 48);
			this.lbTelaSaldo.Name = "lbTelaSaldo";
			this.lbTelaSaldo.Size = new System.Drawing.Size(339, 91);
			this.lbTelaSaldo.TabIndex = 7;
			this.lbTelaSaldo.Text = "R$3000";
			this.lbTelaSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(134, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Saldo atual:";
			// 
			// pnEntrada
			// 
			this.pnEntrada.Controls.Add(this.btSaldo);
			this.pnEntrada.Controls.Add(this.btSacar);
			this.pnEntrada.Controls.Add(this.label7);
			this.pnEntrada.Controls.Add(this.label6);
			this.pnEntrada.Location = new System.Drawing.Point(162, 238);
			this.pnEntrada.Name = "pnEntrada";
			this.pnEntrada.Size = new System.Drawing.Size(369, 180);
			this.pnEntrada.TabIndex = 4;
			// 
			// btSaldo
			// 
			this.btSaldo.BackColor = System.Drawing.Color.MidnightBlue;
			this.btSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSaldo.ForeColor = System.Drawing.Color.White;
			this.btSaldo.Location = new System.Drawing.Point(15, 110);
			this.btSaldo.Name = "btSaldo";
			this.btSaldo.Size = new System.Drawing.Size(117, 47);
			this.btSaldo.TabIndex = 10;
			this.btSaldo.Text = "Ver Saldo";
			this.btSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btSaldo.Click += new System.EventHandler(this.BtSaldoClick);
			// 
			// btSacar
			// 
			this.btSacar.BackColor = System.Drawing.Color.MidnightBlue;
			this.btSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSacar.ForeColor = System.Drawing.Color.White;
			this.btSacar.Location = new System.Drawing.Point(237, 110);
			this.btSacar.Name = "btSacar";
			this.btSacar.Size = new System.Drawing.Size(117, 47);
			this.btSacar.TabIndex = 7;
			this.btSacar.Text = "Sacar";
			this.btSacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btSacar.Click += new System.EventHandler(this.BtSacarClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(101, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(180, 24);
			this.label7.TabIndex = 9;
			this.label7.Text = "Escolha um serviço:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.MidnightBlue;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(15, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(339, 46);
			this.label6.TabIndex = 8;
			this.label6.Text = "CAIXA 24HRS";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 762);
			this.Controls.Add(this.pnEntrada);
			this.Controls.Add(this.pnSaldo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbSaldo);
			this.Controls.Add(this.pnSaque);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "caixa_eletronico";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnSaque.ResumeLayout(false);
			this.pnSaque.PerformLayout();
			this.pnSaldo.ResumeLayout(false);
			this.pnSaldo.PerformLayout();
			this.pnEntrada.ResumeLayout(false);
			this.pnEntrada.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label btVoltar;
		private System.Windows.Forms.Label btVoltar2;
		private System.Windows.Forms.Button btCalcular;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label btSacar;
		private System.Windows.Forms.Label btSaldo;
		private System.Windows.Forms.Panel pnEntrada;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbTelaSaldo;
		private System.Windows.Forms.Panel pnSaldo;
		private System.Windows.Forms.Label lb100;
		private System.Windows.Forms.Label lb1000;
		private System.Windows.Forms.TextBox txtSaque;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnSaque;
		private System.Windows.Forms.Label lb500;
		private System.Windows.Forms.Label lb50;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbSaldo;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
