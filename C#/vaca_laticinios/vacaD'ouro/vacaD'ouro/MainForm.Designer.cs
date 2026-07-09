/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 04/06/2026
 * Hora: 18:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace vacaD_ouro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnConsultar;
		private System.Windows.Forms.Panel pnAdicionarCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btBuscar;
		private System.Windows.Forms.TextBox txtPosicaoConsulta;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btAdicionar;
		private System.Windows.Forms.TextBox txtPosicao;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbExibirEndereco;
		private System.Windows.Forms.Label lbExibirNome;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.Button btAdicionarCliente;
		private System.Windows.Forms.Button btConsultar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel pnListBox;
		private System.Windows.Forms.Button btVoltarConsultar;
		private System.Windows.Forms.Button btVoltarAdicionar;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnListBox = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox = new System.Windows.Forms.ListBox();
			this.pnConsultar = new System.Windows.Forms.Panel();
			this.btVoltarConsultar = new System.Windows.Forms.Button();
			this.lbExibirEndereco = new System.Windows.Forms.Label();
			this.lbExibirNome = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btBuscar = new System.Windows.Forms.Button();
			this.txtPosicaoConsulta = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pnMenu = new System.Windows.Forms.Panel();
			this.btAdicionarCliente = new System.Windows.Forms.Button();
			this.btConsultar = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.pnAdicionarCliente = new System.Windows.Forms.Panel();
			this.btVoltarAdicionar = new System.Windows.Forms.Button();
			this.btAdicionar = new System.Windows.Forms.Button();
			this.txtPosicao = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.pnListBox.SuspendLayout();
			this.pnConsultar.SuspendLayout();
			this.pnMenu.SuspendLayout();
			this.pnAdicionarCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.pnListBox);
			this.panel1.Controls.Add(this.pnConsultar);
			this.panel1.Controls.Add(this.pnMenu);
			this.panel1.Controls.Add(this.pnAdicionarCliente);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1096, 515);
			this.panel1.TabIndex = 0;
			// 
			// pnListBox
			// 
			this.pnListBox.Controls.Add(this.label2);
			this.pnListBox.Controls.Add(this.listBox);
			this.pnListBox.Location = new System.Drawing.Point(667, 88);
			this.pnListBox.Name = "pnListBox";
			this.pnListBox.Size = new System.Drawing.Size(413, 420);
			this.pnListBox.TabIndex = 4;
			this.pnListBox.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(110, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lista de Clientes";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox
			// 
			this.listBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 20;
			this.listBox.Location = new System.Drawing.Point(25, 63);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(368, 344);
			this.listBox.TabIndex = 2;
			// 
			// pnConsultar
			// 
			this.pnConsultar.BackColor = System.Drawing.Color.Khaki;
			this.pnConsultar.Controls.Add(this.btVoltarConsultar);
			this.pnConsultar.Controls.Add(this.lbExibirEndereco);
			this.pnConsultar.Controls.Add(this.lbExibirNome);
			this.pnConsultar.Controls.Add(this.label11);
			this.pnConsultar.Controls.Add(this.label10);
			this.pnConsultar.Controls.Add(this.btBuscar);
			this.pnConsultar.Controls.Add(this.txtPosicaoConsulta);
			this.pnConsultar.Controls.Add(this.label8);
			this.pnConsultar.Controls.Add(this.label4);
			this.pnConsultar.Location = new System.Drawing.Point(55, 146);
			this.pnConsultar.Name = "pnConsultar";
			this.pnConsultar.Size = new System.Drawing.Size(352, 353);
			this.pnConsultar.TabIndex = 5;
			this.pnConsultar.Visible = false;
			// 
			// btVoltarConsultar
			// 
			this.btVoltarConsultar.AutoSize = true;
			this.btVoltarConsultar.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btVoltarConsultar.Location = new System.Drawing.Point(5, 9);
			this.btVoltarConsultar.Name = "btVoltarConsultar";
			this.btVoltarConsultar.Size = new System.Drawing.Size(61, 30);
			this.btVoltarConsultar.TabIndex = 3;
			this.btVoltarConsultar.Text = "Voltar";
			this.btVoltarConsultar.UseVisualStyleBackColor = false;
			this.btVoltarConsultar.Click += new System.EventHandler(this.BtVoltarConsultarClick);
			// 
			// lbExibirEndereco
			// 
			this.lbExibirEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbExibirEndereco.Location = new System.Drawing.Point(111, 313);
			this.lbExibirEndereco.Name = "lbExibirEndereco";
			this.lbExibirEndereco.Size = new System.Drawing.Size(227, 27);
			this.lbExibirEndereco.TabIndex = 12;
			this.lbExibirEndereco.Visible = false;
			// 
			// lbExibirNome
			// 
			this.lbExibirNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbExibirNome.Location = new System.Drawing.Point(111, 270);
			this.lbExibirNome.Name = "lbExibirNome";
			this.lbExibirNome.Size = new System.Drawing.Size(227, 27);
			this.lbExibirNome.TabIndex = 11;
			this.lbExibirNome.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(5, 313);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(91, 20);
			this.label11.TabIndex = 10;
			this.label11.Text = "Endereço:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(5, 270);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 20);
			this.label10.TabIndex = 9;
			this.label10.Text = "Nome:";
			// 
			// btBuscar
			// 
			this.btBuscar.BackColor = System.Drawing.Color.OliveDrab;
			this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBuscar.ForeColor = System.Drawing.Color.White;
			this.btBuscar.Location = new System.Drawing.Point(96, 152);
			this.btBuscar.Name = "btBuscar";
			this.btBuscar.Size = new System.Drawing.Size(149, 43);
			this.btBuscar.TabIndex = 8;
			this.btBuscar.Text = "Buscar";
			this.btBuscar.UseVisualStyleBackColor = false;
			this.btBuscar.Click += new System.EventHandler(this.BtBuscarClick);
			// 
			// txtPosicaoConsulta
			// 
			this.txtPosicaoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPosicaoConsulta.Location = new System.Drawing.Point(153, 111);
			this.txtPosicaoConsulta.Name = "txtPosicaoConsulta";
			this.txtPosicaoConsulta.Size = new System.Drawing.Size(48, 35);
			this.txtPosicaoConsulta.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(96, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(164, 25);
			this.label8.TabIndex = 5;
			this.label8.Text = "Insira a posição";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(78, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(206, 29);
			this.label4.TabIndex = 1;
			this.label4.Text = "Consultar Dados";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pnMenu.Controls.Add(this.btAdicionarCliente);
			this.pnMenu.Controls.Add(this.btConsultar);
			this.pnMenu.Controls.Add(this.label9);
			this.pnMenu.Location = new System.Drawing.Point(185, 160);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(724, 306);
			this.pnMenu.TabIndex = 2;
			// 
			// btAdicionarCliente
			// 
			this.btAdicionarCliente.AutoSize = true;
			this.btAdicionarCliente.BackColor = System.Drawing.Color.Khaki;
			this.btAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAdicionarCliente.Location = new System.Drawing.Point(399, 148);
			this.btAdicionarCliente.Name = "btAdicionarCliente";
			this.btAdicionarCliente.Size = new System.Drawing.Size(259, 88);
			this.btAdicionarCliente.TabIndex = 4;
			this.btAdicionarCliente.Text = "Adicionar\r\nCliente";
			this.btAdicionarCliente.UseVisualStyleBackColor = false;
			this.btAdicionarCliente.Click += new System.EventHandler(this.BtAdicionarClienteClick);
			// 
			// btConsultar
			// 
			this.btConsultar.AutoSize = true;
			this.btConsultar.BackColor = System.Drawing.Color.Khaki;
			this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btConsultar.Location = new System.Drawing.Point(56, 148);
			this.btConsultar.Name = "btConsultar";
			this.btConsultar.Size = new System.Drawing.Size(282, 88);
			this.btConsultar.TabIndex = 3;
			this.btConsultar.Text = "Consultar\r\nDados";
			this.btConsultar.UseVisualStyleBackColor = false;
			this.btConsultar.Click += new System.EventHandler(this.BtConsultarClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(282, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(167, 60);
			this.label9.TabIndex = 2;
			this.label9.Text = "MENU";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnAdicionarCliente
			// 
			this.pnAdicionarCliente.BackColor = System.Drawing.Color.Khaki;
			this.pnAdicionarCliente.Controls.Add(this.btVoltarAdicionar);
			this.pnAdicionarCliente.Controls.Add(this.btAdicionar);
			this.pnAdicionarCliente.Controls.Add(this.txtPosicao);
			this.pnAdicionarCliente.Controls.Add(this.txtEndereco);
			this.pnAdicionarCliente.Controls.Add(this.txtNome);
			this.pnAdicionarCliente.Controls.Add(this.label7);
			this.pnAdicionarCliente.Controls.Add(this.label6);
			this.pnAdicionarCliente.Controls.Add(this.label5);
			this.pnAdicionarCliente.Controls.Add(this.label3);
			this.pnAdicionarCliente.Location = new System.Drawing.Point(77, 134);
			this.pnAdicionarCliente.Name = "pnAdicionarCliente";
			this.pnAdicionarCliente.Size = new System.Drawing.Size(330, 352);
			this.pnAdicionarCliente.TabIndex = 4;
			this.pnAdicionarCliente.Visible = false;
			// 
			// btVoltarAdicionar
			// 
			this.btVoltarAdicionar.AutoSize = true;
			this.btVoltarAdicionar.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btVoltarAdicionar.Location = new System.Drawing.Point(6, 309);
			this.btVoltarAdicionar.Name = "btVoltarAdicionar";
			this.btVoltarAdicionar.Size = new System.Drawing.Size(61, 30);
			this.btVoltarAdicionar.TabIndex = 13;
			this.btVoltarAdicionar.Text = "Voltar";
			this.btVoltarAdicionar.UseVisualStyleBackColor = false;
			this.btVoltarAdicionar.Click += new System.EventHandler(this.BtVoltarAdicionarClick);
			// 
			// btAdicionar
			// 
			this.btAdicionar.BackColor = System.Drawing.Color.OliveDrab;
			this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAdicionar.ForeColor = System.Drawing.Color.White;
			this.btAdicionar.Location = new System.Drawing.Point(168, 296);
			this.btAdicionar.Name = "btAdicionar";
			this.btAdicionar.Size = new System.Drawing.Size(149, 43);
			this.btAdicionar.TabIndex = 7;
			this.btAdicionar.Text = "Adicionar";
			this.btAdicionar.UseVisualStyleBackColor = false;
			this.btAdicionar.Click += new System.EventHandler(this.BtAdicionarClick);
			// 
			// txtPosicao
			// 
			this.txtPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPosicao.Location = new System.Drawing.Point(19, 237);
			this.txtPosicao.Name = "txtPosicao";
			this.txtPosicao.Size = new System.Drawing.Size(57, 35);
			this.txtPosicao.TabIndex = 6;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(19, 163);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(287, 35);
			this.txtEndereco.TabIndex = 5;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(18, 93);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(288, 35);
			this.txtNome.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 209);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(164, 25);
			this.label7.TabIndex = 3;
			this.label7.Text = "Insira a posição";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(181, 25);
			this.label6.TabIndex = 2;
			this.label6.Text = "Insira o Endereço";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "Insira o nome";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(213, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Adicionar Cliente";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(240, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(659, 71);
			this.label1.TabIndex = 1;
			this.label1.Text = "CONTROLE DE DADOS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(231, 125);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 513);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VACA D\'OURO LATICÍNIOS";
			this.panel1.ResumeLayout(false);
			this.pnListBox.ResumeLayout(false);
			this.pnListBox.PerformLayout();
			this.pnConsultar.ResumeLayout(false);
			this.pnConsultar.PerformLayout();
			this.pnMenu.ResumeLayout(false);
			this.pnMenu.PerformLayout();
			this.pnAdicionarCliente.ResumeLayout(false);
			this.pnAdicionarCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
