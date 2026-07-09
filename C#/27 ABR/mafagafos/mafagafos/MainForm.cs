/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 27/04/2026
 * Hora: 19:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mafagafos
{

	public partial class MainForm : Form
	{
		List<NumericUpDown> grupo1 = new List<NumericUpDown>();
		
		public MainForm()
		{

			InitializeComponent();
			
			grupo1.AddRange(new[] {txtGravido, txtAdulto, txtFilhote});
	            
			                
            foreach (var txt in grupo1)
            {
            	txt.ValueChanged += Calcular;
            }
            
		}
			
		void Calcular(object sender, EventArgs e)
		{
			
			//-----------DADOS-----------//
			
			//Coleta
			int qtdFilhote = (int)txtFilhote.Value;
			int qtdAdulto = (int)txtAdulto.Value;
			int qtdGravido = (int)txtGravido.Value;
			
			int totalMafagafos = qtdFilhote + qtdAdulto + qtdGravido;
			
			//Valores
			double vlFilhote = 1000 * qtdFilhote;
			double vlAdulto = 1000 * qtdAdulto;
			double vlGravido = 1000 * qtdGravido;
			
			double vlRaiz = vlFilhote + vlAdulto + vlGravido;
			
			//Desconto
			double desconto = 0.07;
			double totalDesconto = 0;
			
			//-----------CÁLCULOS-----------//
			if (qtdFilhote >= 7)
			{
				double valorDescontado = vlFilhote * desconto;
				vlFilhote = vlFilhote - (vlFilhote * desconto);
				totalDesconto = valorDescontado + totalDesconto;
			}
			
			if (qtdAdulto >= 14)
			{
				double valorDescontado = vlAdulto * desconto;
				vlFilhote = vlFilhote - (vlAdulto * desconto);
				totalDesconto = valorDescontado + totalDesconto;
			}
			
			if (qtdGravido >= 1)
			{
				vlGravido = vlGravido + (vlGravido/2);
			}
			
			double totalFinal = vlFilhote + vlAdulto + vlGravido;
			
			//-----------SAÍDAS-----------//
			
			//Relatório
			lbValorFinal.Text = totalFinal.ToString("c");
			lbTotalMaf.Text = totalMafagafos.ToString();
			lbValorTotal.Text = vlRaiz.ToString("c");
			lbDesconto.Text = totalDesconto.ToString("c");
			
		}
		
		void btCalcularClick(object sender, EventArgs e)
		{
			//-----------DADOS-----------//
			
			//Coleta
			int qtdFilhote = (int)txtFilhote.Value;
			int qtdAdulto = (int)txtAdulto.Value;
			int qtdGravido = (int)txtGravido.Value;
			
			//Estoque
			int estFilhote = int.Parse(lbEstFilhote.Text);
			int estAdulto = int.Parse(lbEstAdulto.Text);
			int estGravido = int.Parse(lbEstGravido.Text);
			
			//-----------CÁLCULOS-----------//
			
			//Comprado Estoque
			int saidaEstFilhote = estFilhote - qtdFilhote;
			int saidaEstAdulto = estAdulto - qtdAdulto;
			int saidaEstGravido = estGravido - qtdGravido;
			
			//-----------SAÍDAS-----------//
			
			//Valores
			lbEstFilhote.Text = saidaEstFilhote.ToString();
			lbEstAdulto.Text = saidaEstAdulto.ToString();
			lbEstGravido.Text = saidaEstGravido.ToString();
			
			//Zerar
			txtFilhote.Value = 0;
			txtAdulto.Value = 0;
			txtGravido.Value = 0;
			
			MessageBox.Show("Compra realizada com sucesso!");
			
		}
		
	}
}
