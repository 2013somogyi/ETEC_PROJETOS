/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 30/03/2026
 * Hora: 19:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lux_lumine
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}	
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "") {
				MessageBox.Show("Preencha o campo solicitado");
			}
			
			else {
			
				//Nomes
				string nome1 = "Pedro";
				string nome2 = "Karina";
				string nome3 = "Tanaka";
				string nome4 = "Luiz";
				string nome5 = "Silmara";
				
				//Salários
				double salario1 = 2080.41;
				double salario2 = 1821.10;
				double salario3 = 1980.84;
				double salario4 = 1600.00;
				double salario5 = 2500.00;
				
				//Cálculos
				double reajuste = double.Parse(textBox1.Text);
				
				double resultado1 = (salario1/100) * reajuste + salario1;
				double resultado2 = (salario2/100) * reajuste + salario2;
				double resultado3 = (salario3/100) * reajuste + salario3;
				double resultado4 = (salario4/100) * reajuste + salario4;
				double resultado5 = (salario5/100) * reajuste + salario5;
				
				//Saídas
				label20.Text = resultado1.ToString("c");
				label19.Text = resultado2.ToString("c");
				label18.Text = resultado3.ToString("c");
				label17.Text = resultado4.ToString("c");
				label16.Text = resultado5.ToString("c");
				
				//Para cumprir oque foi solicitado
				label26.Text = nome1;
				label25.Text = nome2;
				label24.Text = nome3;
				label23.Text = nome4;
				label22.Text = nome5;
			}
		}
	}
}
