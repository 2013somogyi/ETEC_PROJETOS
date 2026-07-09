/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 01/06/2026
 * Hora: 21:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace forca_simples
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		int erros = 0;
		
		void BtOKClick(object sender, EventArgs e)
		{
			//RECEBE E OCULTA A PALAVRA SECRETA
			btOK.Visible = false;
			textBox1.Visible = false;
			
			textBox3.Enabled = true;
			textBox4.Enabled = true;
			btVerificar.Enabled = true;
			btSuaResposta.Enabled = true;
			label2.Visible = true;
			label2.Text = "A palavra tem " + textBox1.Text.Length + " letras \n" +
				"Digite apenas letras maiúsculas";
		}
		
		void BtVerificarClick(object sender, EventArgs e)
		{
			
			//LOOP DE VERIFICAÇÃO
			string palavra = textBox1.Text.ToUpper();
			char letra = textBox3.Text[0];
			
			int i = 0, cont = 0;
			while (i < palavra.Length) {
				
				if (letra == palavra[i])
				{
					cont++;
				}
				i++;
			}
			
			//INFORMA O RESULTADO DA VERIFICAÇÃO
			if (cont ==0)
			{
				erros++;
				listBox1.Items.Add(letra + ": não aparece. Erros: " + erros);
			}
			
			else
			{
				listBox1.Items.Add(letra + ": aparece " + cont + " vezes");
			}
			
			//VERIFICANDO LIMITE DE ERROS
			
			if (erros == 6)
			{
				MessageBox.Show("Atenção!!!\n" +
				                "Ultrapassou o limite de chutes errados \n" +
				                "Você deve agora informar a palavra");
				
				btVerificar.Enabled = false;
				textBox3.Enabled = false;
			}
			
			textBox3.Clear();
			textBox3.Focus();
		}
		void BtSuaRespostaClick(object sender, EventArgs e)
		{
			string resposta = textBox4.Text;
			
			if (resposta.ToUpper() == textBox1.Text.ToUpper())
			{
				label1.ForeColor = Color.Green;
				label1.Text = "Resultado: Acertou";
			}
			else
			{
				label1.ForeColor = Color.Red;
				label1.Text = "Resultado: Errou";
			}
			btSuaResposta.Enabled = false;
			
		}
		void BtReiniciarClick(object sender, EventArgs e)
		{
			//DESABILITANDO E HABILITANDO	
			btSuaResposta.Enabled = false;
			btVerificar.Enabled = false;
			textBox3.Enabled = false;
			textBox4.Enabled = false;
			
			textBox1.Visible = true;
			btOK.Visible = true;
			label2.Visible = true;
			
			//LIMPEZA
			textBox1.Clear();
			textBox3.Clear();
			textBox4.Clear();
			listBox1.Items.Clear();
			
			erros = 0;
		}
		
	}
}
