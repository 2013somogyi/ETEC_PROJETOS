/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 23/03/2026
 * Hora: 19:18
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace controleColares
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			//Entrada
			double preço1 = double.Parse (preçobox1.Text);
			double preço2 = double.Parse (preçobox2.Text);
			double preço3 = double.Parse (preçobox3.Text);
			
			int quantidade1 = int.Parse (quantidadebox1.Text);
			int quantidade2 = int.Parse (quantidadebox2.Text);
			int quantidade3 = int.Parse (quantidadebox3.Text);
			
			int quantidadefinal1 = int.Parse (qtdfinalbox1.Text);
			int quantidadefinal2 = int.Parse (qtdfinalbox2.Text);
			int quantidadefinal3 = int.Parse (qtdfinalbox3.Text);
			
			//Cálculos
			
			int quantidadevendida1 = quantidade1 - quantidadefinal1;
			int quantidadevendida2 = quantidade2 - quantidadefinal2;
			int quantidadevendida3 = quantidade3 - quantidadefinal3;
			
			double arrecadação1 = quantidadevendida1 * preço1;
			double arrecadação2 = quantidadevendida2 * preço2;
			double arrecadação3 = quantidadevendida3 * preço3;
			
			double custo1 = (preço1 - 4.65) * quantidadevendida1;
			double custo2 = (preço2 - 5.40) * quantidadevendida2;
			double custo3 = (preço3 - 7.65) * quantidadevendida3;
			
			double lucro1 = arrecadação1 - custo1;
			double lucro2 = arrecadação2 - custo2;
			double lucro3 = arrecadação3 - custo3;
			
			double arrecadaçãototal = arrecadação1 + arrecadação2 + arrecadação3;
			double custototal = custo1 + custo2 + custo3;
			double lucrototal = lucro1 + lucro2 + lucro3;
			
			//Saídas
			
			qtdvendidabox1.Text = quantidadevendida1.ToString();
			qtdvendidabox2.Text = quantidadevendida2.ToString();
			qtdvendidabox3.Text = quantidadevendida3.ToString();
			
			arrecadacaobox1.Text = arrecadação1.ToString("c");
			arrecadacaobox2.Text = arrecadação2.ToString("c");
			arrecadacaobox3.Text = arrecadação3.ToString("c");
			
			custobox1.Text = custo1.ToString("c");
			custobox2.Text = custo2.ToString("c");
			custobox3.Text = custo3.ToString("c");
			
			lucrobox1.Text = lucro1.ToString("c");
			lucrobox2.Text = lucro2.ToString("c");
			lucrobox3.Text = lucro3.ToString("c");
			
			arrecadaçãoboxtotal.Text = arrecadaçãototal.ToString("c");
			custoboxtotal.Text = custototal.ToString("c");
			lucroboxtotal.Text = lucrototal.ToString("c");
		}
	}
}
