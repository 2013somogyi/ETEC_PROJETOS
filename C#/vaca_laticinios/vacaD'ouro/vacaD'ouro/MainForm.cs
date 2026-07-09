/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 04/06/2026
 * Hora: 18:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vacaD_ouro
{
	public partial class MainForm : Form
	{
		string[] nomes =
		{
			"Antônio",
			"Abel",
			"Arnaldo",
			"Adalberto",
			"Alexandre",
			"Beto",
			"Bernardo",
			"Benjamin",
			"Baltazar",
			"Breno",
			"Carlos",
			"Caique",
			"Cesar",
			"Cícero",
			"Cosme",
			"Daniel",
			"Diogo",
			"Dennis",
			"Damião",
			"Darci",
		};
		
		string[] enderecos =
		{
			"Rua das Carpinteiras",
			"Rua das Jabiracas",
			"Rua das Cataratas",
			"Rua das Peneiras",
			"Rua das Armadas",
			"Rua das Remadas",
			"Rua das Queimadas",
			"Rua das Suzanas",
			"Rua das Sarradas",
			"Rua das Supinadas",
			"Rua das Pronadas",
			"Rua das Brincadeiras",
			"Rua das Zueiras",
			"Rua das Elevadas",
			"Rua das Cagadas",
			"Rua das Safadas",
			"Rua das Cantadas",
			"Rua das Jogadas",
			"Rua das Puladas",
			"Rua das Cozinhadas",
		};
		public MainForm()
		{
			InitializeComponent();
			atualizaListBox();
		}
		
		
		//----------------Funções de apoio----------------//
		
		void atualizaListBox()
		{
			label10.Visible = false;
			label11.Visible = false;
			
			for (int i = 0; i < nomes.Length; i++)
				{
					listBox.Items.Add("Nome: " + nomes[i] + "     " + "Endereço: " + enderecos[i]);
				}
		}
		
		void limpaListBox()
		{
			listBox.Items.Clear();
		}
		
		//----------------Funções dos botões----------------//
		
		void BtAdicionarClick(object sender, EventArgs e)
		{
			//Coleta
			string nome = txtNome.Text;
			string endereco = txtEndereco.Text;
			int posicao = int.Parse(txtPosicao.Text);
			
			//Validação
			if (nome == "" || endereco == "")
			{
				MessageBox.Show("Preencha devidamente os campos!!!");
				return;
			}
			
			//Lógica  +  Saídas
			listBox.Items.Add(nomes[posicao] = nome);
			listBox.Items.Add(enderecos[posicao] = endereco);
			
			MessageBox.Show("Cliente adicionado com sucesso!!! \n" +
			                "Verifique na lista de Clientes");
			
			txtNome.Text = "";
			txtEndereco.Text = "";
			txtPosicao.Text = "";
			
			limpaListBox();
			atualizaListBox();
		}
		
		void BtBuscarClick(object sender, EventArgs e)
		{
			//Coleta
			int posicao = int.Parse(txtPosicaoConsulta.Text);
			int nmrNomes = nomes.Length;
			
			if (posicao > nomes.Length)
			{
				txtPosicaoConsulta.Text = "";
				MessageBox.Show("Existem apenas " + nmrNomes + " clientes \n" +
				                "Escolha um número dentro do limite");
			}
			
			else
			{
				//Lógica e Saída
				label10.Visible = true;
				label11.Visible = true;
				lbExibirNome.Visible = true;
				lbExibirEndereco.Visible = true;
				
				lbExibirNome.Text = nomes[posicao];
				lbExibirEndereco.Text = enderecos[posicao];
				
				txtPosicaoConsulta.Text = "";
			}
		}
		
		//----------------Botões do Menu----------------//
		
		void BtConsultarClick(object sender, EventArgs e)
		{
			pnMenu.Visible = false;
			pnConsultar.Visible = true;
			pnListBox.Visible = true;
		}
		void BtAdicionarClienteClick(object sender, EventArgs e)
		{
			pnMenu.Visible = false;
			pnAdicionarCliente.Visible = true;
			pnListBox.Visible = true;
		}
		void BtVoltarConsultarClick(object sender, EventArgs e)
		{
			pnConsultar.Visible = false;
			pnListBox.Visible = false;
			pnMenu.Visible = true;
			
			label10.Visible = false;
			label11.Visible = false;
			lbExibirNome.Visible = false;
			lbExibirEndereco.Visible = false;
			
		}
		void BtVoltarAdicionarClick(object sender, EventArgs e)
		{
			pnAdicionarCliente.Visible = false;
			pnListBox.Visible = false;
			pnMenu.Visible = true;
		}
		
	}
}
