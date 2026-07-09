/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 11/05/2026
 * Hora: 19:50
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace caixa_eletronico
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			// Define o estado inicial: esconde todos e mostra apenas o que você quer
		    pnSaque.Visible = false;
		    pnSaldo.Visible = false;
		    
		    // O painel que você deseja que apareça ao abrir
		    pnEntrada.Visible = true;
		}
		//CALCULOS DE SAQUE
		void BtCalcularClick(object sender, EventArgs e)
		{
			//SALDO
			double vlSaldo = double.Parse(lbSaldo.Text);
			lbSaldo.Text = vlSaldo.ToString();
			
			//SAQUE
			double vlSaque = double.Parse(txtSaque.Text);
			
			if (vlSaque % 50 == 0)
			{
				if (vlSaque < 1500)
				{
					if (vlSaque < vlSaldo)
					{
						vlSaldo = vlSaldo - vlSaque;
						MessageBox.Show("Seu saque foi realizado com sucesso!");
					}
					if (vlSaque > vlSaldo)
					{
						MessageBox.Show("Saldo insuficiente!");
					}
				}
				else
				{MessageBox.Show("R$1500 é o valor máximo para saque");}
			}
			else
			{MessageBox.Show("Escolha um valor múltiplo de 50!");}
			
			lbSaldo.Text = vlSaldo.ToString();
			lbTelaSaldo.Text = "R$ " + lbSaldo.Text;
		}
		
		// BOTÕES DE SAQUE
		void Lb50Click(object sender, EventArgs e)
		{
			txtSaque.Text = "50";
		}
		
		void Lb100Click(object sender, EventArgs e)
		{
			txtSaque.Text = "100";
		}
		
		void Lb500Click(object sender, EventArgs e)
		{
			txtSaque.Text = "500";
		}
		
		void Lb1000Click(object sender, EventArgs e)
		{
			txtSaque.Text = "1000";
		}
		
		private void TrocarTela(Panel panelParaMostrar)
		{
		    // Lista de todos os painéis que você usa
		    Panel[] panels = { pnSaque, pnSaldo, pnEntrada };
		
		    // Esconde todos
		    foreach (Panel p in panels)
		    {
		        p.Visible = false;
		    }
		
		    // Mostra apenas o que foi passado como parâmetro
		    panelParaMostrar.Visible = true;
		}

		//BOTÕES VOLTAR
		void BtVoltar2Click(object sender, EventArgs e)
		{
			TrocarTela(pnEntrada);			
		}
		

		void BtVoltarClick(object sender, EventArgs e)
		{
			TrocarTela(pnEntrada);
		}
		
		//BOTÕES TELAS
		void BtSaldoClick(object sender, EventArgs e)
		{
			TrocarTela(pnSaldo);			
		}
		
		void BtSacarClick(object sender, EventArgs e)
		{
			TrocarTela(pnSaque);			
		}
	}
}
