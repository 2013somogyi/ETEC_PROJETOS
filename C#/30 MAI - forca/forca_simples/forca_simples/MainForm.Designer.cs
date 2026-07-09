/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 01/06/2026
 * Hora: 21:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace forca_simples
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btVerificar;
		private System.Windows.Forms.Button btSuaResposta;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btReiniciar;
		
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
			this.btOK = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btVerificar = new System.Windows.Forms.Button();
			this.btSuaResposta = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btReiniciar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btOK
			// 
			this.btOK.AutoSize = true;
			this.btOK.Location = new System.Drawing.Point(277, 56);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(69, 30);
			this.btOK.TabIndex = 0;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.BtOKClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(55, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(198, 26);
			this.textBox1.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(65, 204);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(315, 304);
			this.listBox1.TabIndex = 2;
			// 
			// btVerificar
			// 
			this.btVerificar.AutoSize = true;
			this.btVerificar.Enabled = false;
			this.btVerificar.Location = new System.Drawing.Point(145, 128);
			this.btVerificar.Name = "btVerificar";
			this.btVerificar.Size = new System.Drawing.Size(187, 30);
			this.btVerificar.TabIndex = 3;
			this.btVerificar.Text = "Verificar";
			this.btVerificar.UseVisualStyleBackColor = true;
			this.btVerificar.Click += new System.EventHandler(this.BtVerificarClick);
			// 
			// btSuaResposta
			// 
			this.btSuaResposta.AutoSize = true;
			this.btSuaResposta.Enabled = false;
			this.btSuaResposta.Location = new System.Drawing.Point(463, 160);
			this.btSuaResposta.Name = "btSuaResposta";
			this.btSuaResposta.Size = new System.Drawing.Size(198, 30);
			this.btSuaResposta.TabIndex = 4;
			this.btSuaResposta.Text = "Sua resposta";
			this.btSuaResposta.UseVisualStyleBackColor = true;
			this.btSuaResposta.Click += new System.EventHandler(this.BtSuaRespostaClick);
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(55, 128);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(62, 26);
			this.textBox3.TabIndex = 5;
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(463, 128);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(198, 26);
			this.textBox4.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(460, 242);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 39);
			this.label1.TabIndex = 7;
			this.label1.Text = "Resultado:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(55, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(220, 26);
			this.label2.TabIndex = 8;
			this.label2.Visible = false;
			// 
			// btReiniciar
			// 
			this.btReiniciar.Location = new System.Drawing.Point(445, 471);
			this.btReiniciar.Name = "btReiniciar";
			this.btReiniciar.Size = new System.Drawing.Size(202, 36);
			this.btReiniciar.TabIndex = 9;
			this.btReiniciar.Text = "Reiniciar";
			this.btReiniciar.UseVisualStyleBackColor = true;
			this.btReiniciar.Click += new System.EventHandler(this.BtReiniciarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 588);
			this.Controls.Add(this.btReiniciar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.btSuaResposta);
			this.Controls.Add(this.btVerificar);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.label2);
			this.Name = "MainForm";
			this.Text = "forca_simples";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
