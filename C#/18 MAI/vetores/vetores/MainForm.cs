/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 18/05/2026
 * Hora: 20:33
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetores
{

	public partial class MainForm : Form
	{
		//global
		string[] nomes = {"Jéssica", "Victória", "Kelly", "Amanda", "Luíza", "Júlia", "Bianca", "Isabelle", "Karol"};
		
		public MainForm()
		{

			InitializeComponent();

		}
		
		int contador = 0;
		void Button1Click(object sender, EventArgs e)
		{
			if (contador >= nomes.Length)
			{
				MessageBox.Show("Todos os nomes foram listados");
				
				contador = 0;
			}
			else
			{
				listBox1.Items.Add(nomes[contador]);
				contador += 1;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Limpar();
			for (int i = 0; i < nomes.Length; i++)
			{
				listBox1.Items.Add(nomes[i]);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string n = textBox2.Text;
			
			listBox1.Items.Add(n);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Limpar();
			string nome = txtNome.Text;
			int posicao = int.Parse(txtPosicao.Text);
			
			if (posicao >= nomes.Length)
				MessageBox.Show("Posição inválida");
			else
			{
				nomes[posicao] = nome;
				
				MessageBox.Show("Item adicionado com sucesso");
				
				ListarTudo();
			}
		}
		
		void Limpar()
		{
			listBox1.Items.Clear();
		}
		
		void ListarTudo()
		{
			for (int i = 0; i < nomes.Length; i++)
			{
				listBox1.Items.Add(nomes[i]);
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Limpar();
		}
	}
}
