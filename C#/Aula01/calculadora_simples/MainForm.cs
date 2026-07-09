/*
 * Criado por SharpDevelop.
 * Usuário: Lucas
 * Data: 26/02/2026
 * Hora: 19:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic; //Bibliotecas
using System.Drawing;
using System.Windows.Forms;

// TODO:Cada espaço entre chaves é uma estrutura, estruturas não levam ";", mas os comandos sim

namespace Aula01 //Nome do projeto
{
	public partial class MainForm : Form //Classe
	{
		public MainForm() //Método construtor, método sempre vai ter parênteses "()"
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e) //Método do click do button1
													  //As fómulas são sempre assim: Quem.Propriedade, lembre-se da corcova de camelo nessa situação. As variáveis sempre começam com letra minúscula 
		{
			//SOMA
			float caixa1, caixa2, resultado; //Criação de variáveis
			caixa1 = float.Parse(textBox1.Text); //Atribuindo valor à variável
			caixa2 = float.Parse(textBox2.Text);
			
			resultado = caixa1 + caixa2; //Realizando o cálculo
			
			textBox3.Text = resultado.ToString(); //Convertendo para "String"(texto), e exibindo em TextBox3
			
		 	textBox3.BackColor = Color.Orange;
		 	MessageBox.Show("Somou!");
			
			//textBox3.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();                                               
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//SUBTRAÇÃO
			float caixa1, caixa2, resultado;
			caixa1 = float.Parse(textBox1.Text);
			caixa2 = float.Parse(textBox2.Text);
			
			resultado = caixa1 - caixa2;
			
			textBox3.Text = resultado.ToString();
			
			textBox3.BackColor = Color.Orange;
			MessageBox.Show("Subtraiu!");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			//MULTIPLICAÇÃO
			float caixa1, caixa2, resultado;
			caixa1 = float.Parse(textBox1.Text);
			caixa2 = float.Parse(textBox2.Text);
			
			resultado = caixa1 * caixa2;
	
			textBox3.Text = resultado.ToString();
			
			textBox3.BackColor = Color.Orange;
			MessageBox.Show("Multiplicou!");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			//DIVISÃO
			float caixa1, caixa2, resultado;
			caixa1 = float.Parse(textBox1.Text);
			caixa2 = float.Parse(textBox2.Text);
			
			resultado = caixa1 / caixa2;
			
			textBox3.Text = resultado.ToString();
			
			textBox3.BackColor = Color.Orange;
			MessageBox.Show("Dividiu!");
		}
	}
}
