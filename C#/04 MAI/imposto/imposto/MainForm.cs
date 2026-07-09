/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 04/05/2026
 * Hora: 20:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imposto
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BtCalcularClick(object sender, EventArgs e)
		{
			double bruto = double.Parse(txtBruto.Text);
			double liquido = 0;
			double desconto = 0;
			double valor;
			
			if(bruto <= 3500)
			{
				liquido = bruto;
				
				txtLiquido.Text = liquido.ToString("c");
				txtDesconto.Text = desconto.ToString("c");
			}
			
			else if(bruto > 3500 && bruto <= 7000)
			{
				valor = bruto - (bruto * 0.10);
				desconto = bruto - valor;
				liquido = bruto - desconto;
				
				txtLiquido.Text = liquido.ToString("c");
				txtDesconto.Text = desconto.ToString("c");
			}
			
			else if(bruto > 7000 && bruto <= 12000)
			{
				valor = bruto - (bruto * 0.15);
				desconto = bruto - valor;
				liquido = bruto - desconto;
				
				txtLiquido.Text = liquido.ToString("c");
				txtDesconto.Text = desconto.ToString("c");
			}
			
			else if(bruto > 12000 && bruto <= 20000)
			{
				valor = bruto - (bruto * 0.20);
				desconto = bruto - valor;
				liquido = bruto - desconto;
				
				txtLiquido.Text = liquido.ToString("c");
				txtDesconto.Text = desconto.ToString("c");
			}
			
			else if(bruto > 20000)
			{
				valor = bruto - (bruto * 0.25);
				desconto = bruto - valor;
				liquido = bruto - desconto;
				
				txtLiquido.Text = liquido.ToString("c");
				txtDesconto.Text = desconto.ToString("c");
			}
			
			else
			{
				MessageBox.Show("Você digitou valores inválidos");
			}
			
		}
	}
}
