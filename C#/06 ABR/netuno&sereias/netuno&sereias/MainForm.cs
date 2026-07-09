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
			label2.Parent = pictureBox1;
			label5.Parent = pictureBox1;
			label6.Parent = pictureBox1;
			label7.Parent = pictureBox1;
			
		}
		
		
		void PbBotaoClick(object sender, EventArgs e)
		{
			//------------Declaração de Constantes-----------
			
			const double precoMetro = 49.99;
			const double precoDespesas = 450.00;
			
			//-----------Coleta de Dados--------------
			
			double altura = double.Parse(txtAltura.Text);
			double largura = double.Parse(txtLargura.Text);
			double comprimento = double.Parse(txtComprimento.Text);
			
			//------------Cálculos--------------------
			
			double tamanho = altura * largura * comprimento;
			double orcamento = tamanho * precoMetro + precoDespesas;
			
			//---------------Exibição---------------
			
			lbValorFim.Text = orcamento.ToString("c");
			
		}
	}
}
