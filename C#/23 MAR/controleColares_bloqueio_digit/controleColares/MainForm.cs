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
			double colar1 = 4.65;
			double colar2 = 5.40;
			double colar3 = 7.65;
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			//Variáveis
			
			double preço1= 0, preço2= 0, preço3= 0;
			int inicial1= 0, inicial2= 0, inicial3= 0;
			int final1= 0, final2= 0, final3= 0;
			
			//Conversão
			
			double.TryParse(preçobox1.Text, out preço1);
			double.TryParse(preçobox2.Text, out preço2);
			double.TryParse(preçobox3.Text, out preço3);
			
			int.TryParse(quantidadebox1.Text, out inicial1);
			int.TryParse(quantidadebox2.Text, out inicial2);
			int.TryParse(quantidadebox3.Text, out inicial3);
			
			int.TryParse(qtdfinalbox1.Text, out final1);
			int.TryParse(qtdfinalbox2.Text, out final2);
			int.TryParse(qtdfinalbox3.Text, out final3);
			
			//Cálculos
			
			int quantidadevendida1 = inicial1 - final1;
			int quantidadevendida2 = inicial2 - final2;
			int quantidadevendida3 = inicial3 - final3;
			
			double arrecadação1 = quantidadevendida1 * preço1;
			double arrecadação2 = quantidadevendida2 * preço2;
			double arrecadação3 = quantidadevendida3 * preço3;
			
			double custo1 = (preço1 - colar1) * quantidadevendida1;
		    double custo2 = (preço2 - colar2) * quantidadevendida2;
		    double custo3 = (preço3 - colar3) * quantidadevendida3;
		    
		    double lucro1 = arrecadação1 - custo1;
		    double lucro2 = arrecadação2 - custo2;
		    double lucro3 = arrecadação3 - custo3;
		    
		    double arrecadaçãototal = arrecadação1 +arrecadação2 + arrecadação3;
		    double custototal = custo1 + custo2 + custo3;
		    double lucrototal = lucro1 + lucro2 + lucro3;
		    
		    //Saídas
		    
		    quantidadebox1.Text = quantidadevendida1.ToString();
		    quantidadebox2.Text = quantidadevendida2.ToString();
		    quantidadebox3.Text = quantidadevendida3.ToString();
		    
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
		
		void Preçobox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')  {
				e.Handled = true;
			}
			if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(",")) {
				e.Handled = true;
			}
			
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',') {
				e.Handled = true;
			}
			if (e.KeyChar == ',' && (sender as TextBox).Text.Contains (",")) {
				e.Handled = true;
			}
		}
	}
}
