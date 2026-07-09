/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 22/02/2026
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
		List<TextBox> grupo1 = new List<TextBox>();
		List<TextBox> grupo2 = new List<TextBox>();
		List<TextBox> grupo3 = new List<TextBox>();
		
		bool processando = false;
		
		public MainForm()
		{
			
			InitializeComponent();
			
			grupo1.AddRange(new[] {preçobox1, quantidadebox1, qtdfinalbox1});
        	grupo2.AddRange(new[] {preçobox2, quantidadebox2, qtdfinalbox2});
        	grupo3.AddRange(new[] {preçobox3, quantidadebox3, qtdfinalbox3});
        	
        	foreach (var txt in grupo1) {
        		txt.TextChanged += Cálculos1;
        	}
        	foreach (var txt in grupo2) {
        		txt.TextChanged += Cálculos2;
        	}
        	 foreach (var txt in grupo3) {
        	 	txt.TextChanged += Cálculos3;
        	 } 	
		}
		
			double colar1 = 4.65;
			double colar2 = 5.40;
			double colar3 = 7.65;
		
		void Cálculos1(object sender, EventArgs e)
		{
			if (processando) return;
				processando = true;
			
			try {

			//Variáveis
			
			double preço1= 0;
			int inicial1= 0;
			int final1= 0;
			
			//Conversão
			
			double.TryParse(preçobox1.Text, out preço1);
			
			
			int.TryParse(quantidadebox1.Text, out inicial1);
			
			
			int.TryParse(qtdfinalbox1.Text, out final1);
			
			
			//Cálculos
			
			int quantidadevendida1 = inicial1 - final1;
			
			
			double arrecadação1 = quantidadevendida1 * preço1;
			
			
			double custo1 = (preço1 - colar1) * quantidadevendida1;
		   
		    
		    double lucro1 = arrecadação1 - custo1;
		    
		    
		    //Saídas
		    
		    quantidadebox1.Text = quantidadevendida1.ToString();
		    
		    
		    arrecadacaobox1.Text = arrecadação1.ToString("c");
		    
		    
		    custobox1.Text = custo1.ToString("c");
		   
		    
		    lucrobox1.Text = lucro1.ToString("c");
			}
			finally{
				processando= false;
			}
	
		}
		
		void Cálculos2(object sender, EventArgs e)
		{
			if (processando) return;
				processando = true;
			
			try {

			//Variáveis
			
			double preço2= 0;
			int inicial2= 0;
			int final2= 0;
			
			//Conversão
			
			double.TryParse(preçobox2.Text, out preço2);
			
			
			int.TryParse(quantidadebox2.Text, out inicial2);
			
			
			int.TryParse(qtdfinalbox2.Text, out final2);
			
			
			//Cálculos
			
			int quantidadevendida2 = inicial2 - final2;
			
			
			double arrecadação2 = quantidadevendida2 * preço2;
			
			
			double custo2 = (preço2 - colar2) * quantidadevendida2;
		   
		    
		    double lucro2 = arrecadação2 - custo2;
		    
		    
		    //Saídas
		    
		    quantidadebox2.Text = quantidadevendida2.ToString();
		    
		    
		    arrecadacaobox2.Text = arrecadação2.ToString("c");
		    
		    
		    custobox2.Text = custo2.ToString("c");
		   
		    
		    lucrobox2.Text = lucro2.ToString("c");
			}
			finally{
				processando= false;
			}
	
		}
		void Cálculos3(object sender, EventArgs e)
		{
			if (processando) return;
				processando = true;
			
			try {

			//Variáveis
			
			double preço3= 0;
			int inicial3= 0;
			int final3= 0;
			
			//Conversão
			
			double.TryParse(preçobox3.Text, out preço3);
			
			
			int.TryParse(quantidadebox3.Text, out inicial3);
			
			
			int.TryParse(qtdfinalbox3.Text, out final3);
			
			
			//Cálculos
			
			int quantidadevendida3 = inicial3 - final3;
			
			
			double arrecadação3 = quantidadevendida3 * preço3;
			
			
			double custo3 = (preço3 - colar3) * quantidadevendida3;
		   
		    
		    double lucro3 = arrecadação3 - custo3;
		    
		    
		    //Saídas
		    
		    quantidadebox3.Text = quantidadevendida3.ToString();
		    
		    
		    arrecadacaobox3.Text = arrecadação3.ToString("c");
		    
		    
		    custobox3.Text = custo3.ToString("c");
		   
		    
		    lucrobox3.Text = lucro3.ToString("c");
			}
			finally{
				processando= false;
			}
	
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

	
