/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 12/03/2026
 * Hora: 20:36
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace distancia_cidades
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == ""|| textBox2.Text == ""|| textBox4.Text == "")
			{
				MessageBox.Show("Preencha direito");
			}
			else
			{
			//variáveis
			string city1 = textBox1.Text;	
			string city2 = textBox2.Text;
			int distancia = int.Parse (textBox4.Text);
			
			//cálculos
			int resultado = distancia/4;
			int p1 = resultado;
			int p2 = p1 + resultado;
			int p3 = p2 + resultado;
			
			//exibição
			label1.Text = city1;
			label02.Text = city2;
			label8.Text = p1.ToString() + "km";
			label7.Text = p2.ToString() + "km";
			label6.Text = p3.ToString() + "km";
			}
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
			
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
