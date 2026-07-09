/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 21/05/2026
 * Hora: 21:19
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicio1_tabuada
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
				MessageBox.Show("Preencha os campos");
			
			else
			{
				listBox1.Items.Clear();
				
				double numero = double.Parse(textBox1.Text);
				
				for (double i = 1; i <= 10; i++)
				{
					double resultado = numero * i;
					
					string mensagem = numero + " x " + i + " = " + resultado;
					
					listBox1.Items.Add(mensagem);
				}
			}
			
			textBox1.Text = "";
		}
	}
}
