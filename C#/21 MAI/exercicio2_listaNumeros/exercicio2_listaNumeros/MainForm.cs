/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 21/05/2026
 * Hora: 21:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicio2_listaNumeros
{
	public partial class MainForm : Form
	{	
		public MainForm()
		{
			InitializeComponent();	
		}
		
		void BtCalcularClick(object sender, EventArgs e)
		{
			//LIMPEZA
			listBox1.Items.Clear();
			
			//VALIDAÇÃO
			
			
			if (textBox1.Text == "")
			{
				MessageBox.Show("Insira um número positivo!");
				return;
			}
			
			int num= int.Parse(textBox1.Text);
			
			if (num <= 0)
			{
				MessageBox.Show("Insira um número positivo!");
				return;
			}
			
			else
			{
				listBox1.Items.Add("Os primeiros " + num + " números são:");
				
				//REPETIÇÃO
				int total = 0;
				for (int i = 1; i <= num; i++)
				{
					total += i;
					listBox1.Items.Add(i);
				}
				listBox1.Items.Add("A soma dos " + num + " números é: " + total);
				
				//LIMPEZA
				textBox1.Text = "";
			}
		}
	}
}
