/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 06/04/2026
 * Hora: 20:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace netuno_sereias
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void PbBotaoClick(object sender, EventArgs e)
		{
			//------------Declaração de Constantes-----------
			
			const double precoMetro = 57.99;
			const double precoFixo = 450;
			const double taxaImpostoPercentual = 0.22;
			
			//-----------Coleta de Dados--------------
			
			double altura = double.Parse(txtAltura.Text);
			double largura = double.Parse(txtLargura.Text);
			double comprimento = double.Parse(txtComprimento.Text);
			
			//------------Cálculos--------------------
			
			double vlVolume = altura * largura * comprimento;
			double vlPorMetro = vlVolume * precoMetro;
			double vlTotal = vlPorMetro + precoFixo;
			
			double vlSemAdicional = 0;
			double vlAdicional = 0;
			double vlImposto = 0.22;
			double vlSemImposto = 0;
			
			double percentAdicional = 0;
			if (vlVolume >= 50 && vlVolume <= 100)
			{
				percentAdicional = 0.20;
				
				vlAdicional = vlPorMetro + percentAdicional;
				vlSemAdicional = vlPorMetro + precoFixo;
				
				vlSemImposto = vlSemAdicional + vlAdicional;
				vlImposto = vlSemImposto * taxaImpostoPercentual;
				
				
				vlTotal = vlSemImposto + vlImposto;
			}
			
			if (vlVolume > 100 && vlVolume <= 250)
			{
				percentAdicional = 0.40;
				
				vlAdicional = vlPorMetro + percentAdicional;
				vlSemAdicional = vlPorMetro + precoFixo;
				
				vlSemImposto = vlSemAdicional + vlAdicional;
				vlImposto = vlSemImposto * taxaImpostoPercentual;
				
				
				vlTotal = vlSemImposto + vlImposto;
			}
			
			if (vlVolume > 250)
			{
				percentAdicional = 0.60;
				
				vlAdicional = vlPorMetro + percentAdicional;
				vlSemAdicional = vlPorMetro + precoFixo;
				
				vlSemImposto = vlSemAdicional + vlAdicional;
				vlImposto = vlSemImposto * taxaImpostoPercentual;
				
				
				vlTotal = vlSemImposto + vlImposto;
			}
			
			if (txtAltura.Text == "" | txtComprimento.Text == "" | txtLargura.Text =="")
			{
				MessageBox.Show("Complete todos os campos!");
			}
			
			//---------------Exibição---------------
			
			
			txtVolume.Text = vlVolume.ToString();
			txt_semAdicional.Text = vlSemAdicional.ToString("c");
			txtAdicional.Text = vlAdicional.ToString("c");
			txtTaxaFixa.Text = precoFixo.ToString("c");
			txtValor_semImposto.Text = vlSemImposto.ToString("c");
			txtImposto.Text = vlImposto.ToString("c");
			
			lbValorTotal.Text = vlTotal.ToString("c");
			
		}
	}
}
