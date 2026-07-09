/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 15/06/2026
 * Hora: 19:38
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace forca_legal
{
	public partial class MainForm : Form
	{
		//==++==++==++==++==++VARIÁVEIS GLOBAIS++==++==++==++==++==\\
		
		Button letra_escolhida;
		int erros = 0;
		char letra;
		string palavra, palavra_escondida;
		bool jogo_iniciado = false;
		
		public MainForm()
		{	
			InitializeComponent();
			menu();
		}
		//==++==++==++==++==++FUNÇÕES AUXILIARES++==++==++==++==++==\\
		
		//-----------LIMPAR TXTBOX-----------\\
		void limpar_txt()
		{
			txtPalavra.Text = "";
		}
		
		//-----------LIMPAR TECLADO-----------\\
		void BtLimparClick(object sender, EventArgs e)
		{
			limpar_txt();
		}
		
		//-----------PARAR JOGO-----------\\
		void parar_jogo()
		{
			if (palavra_escondida == palavra)
			{
				MessageBox.Show("Parabéns, você ganhou o jogo!!!");
				jogo_iniciado = false;
				reiniciar();
			}
			
			else if (erros == 7)
			{
				MessageBox.Show("Perdeu bobalhão, tente novamente mais tarde...");
				jogo_iniciado = false;
				reiniciar();
			}
		}
		
		//-----------REINICIAR-----------\\
		void reiniciar()
		{
			Application.Restart();
		}
		
		//-----------TECLADO-----------\\
		private void Botao_clicado(object sender, EventArgs e)
		{
			letra_escolhida = sender as Button;
			
			if (letra_escolhida != null)
				letra = char.Parse(letra_escolhida.Text);
			
			if (jogo_iniciado == true)
				verificar();
			
			else
				txtPalavra.Text += letra;
			
		}
		
		//-----------MENU-----------\\
		void menu()
		{
			//VOLTA ELEMENTOS
			pnTeclado.Visible = false;
			pnEsconder.Visible = false;
			pbForca.Visible = false;
			btSair.Visible = false;
			
			label1.Visible = true;
			btIniciar.Visible = true;
			
			
			//ZERA VARIÁVEIS
			erros = 0;
			letra = '\0';
			palavra = "";
			palavra_escondida = "";
			jogo_iniciado = false;
		}
		
		//-----------INICIAR-----------\\
		void BtIniciarClick(object sender, EventArgs e)
		{
			pnTeclado.Visible = true;
			pnEsconder.Visible = true;
			pbForca.Visible = true;
			btSair.Visible = true;
			
			label1.Visible = false;
			btIniciar.Visible = false;
		}
		
		//-----------SAIR-----------\\
		void BtSairClick(object sender, EventArgs e)
		{
			menu();
		}
		
		
		
		
		//==++==++==++==++==++FUNÇÕES PRINCIPAIS++==++==++==++==++==\\
		
		void verificar()
		{
			letra_escolhida.Enabled = false;
			
			string teste = "";
			
			//---VERIFICAÇÃO---\\
			int x = 0, cont = 0;
			while (x < palavra.Length)
			{
				//MONTAGEM DA PALAVRA COM OS ASTERISCOS
				if (letra == palavra[x])
					teste += letra;
				
				else
				{
					teste += palavra_escondida[x];
					cont++;
				}
				
				x++;
			}
			
			//ATUALIZAÇÃO DO TXTBOX
			palavra_escondida = teste;
			lbPalavra.Text = palavra_escondida;
			
			
			//COLORAÇÃO DO BOTÃO
			if (cont == palavra.Length)
			{
				letra_escolhida.BackColor = Color.Red;
				erros++;
			}
			
			else
				letra_escolhida.BackColor = Color.Green;
			
			
			//CARREGAMENTO DO BONECO
			if (erros == 1) pbForca.Load("forca1.png");
			
			else if (erros == 2) pbForca.Load("forca2.png");
			
			else if (erros == 3) pbForca.Load("forca3.png");
			
			else if (erros == 4) pbForca.Load("forca4.png");

			else if (erros == 5) pbForca.Load("forca5.png");
			
			else if (erros == 6) pbForca.Load("forca6.png");

			parar_jogo();
		}
		
		
		//-----------ESCONDE PALAVRA-----------\\
		void BtEsconderClick(object sender, EventArgs e)
		{
			palavra = txtPalavra.Text;
			txtPalavra.Visible = false;
			
			for (int i = 0; i < palavra.Length; i++)
			{
				palavra_escondida += "*";
			}
			
			//FORMATAÇÃO FINAL
			lbPalavra.Text = palavra_escondida;
			btEsconder.Visible = false;
			btLimpar.Visible = false;
			jogo_iniciado = true;
			pbForca.Load("forca.png");
			
		}
		
		
		
		
	}
}
