/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 22/06/2026
 * Hora: 19:51
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kiCar
{
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		//------------GLOBAIS------------\\
		string[] nome = new string[20];
		string[] setor = new string[20];
		string[] cargo = new string[20];
		double[] salario = new double[20];
		double[] totalVendido = new double[20];
		int[] registro = new int[20];
		
		int contRegistro = 0;
		double meta = 1200000;
		double bonus = 0.15;
		
		//____________________________FUNÇÕES_PRINCIPAIS____________________________\\
		
		//------------CALCULAR_BONUS------------\\
		void calcularBonus()
		{
			for (int i = 0; i < contRegistro; i++)
			{
				if (totalVendido[i] >= meta && cargo[i] == "Vendedor")
				{
					salario[i] += (salario[i] * bonus);
				}
			}
		}
		
		//------------COMBOBOX_ITENS------------\\
		void CbSetorSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbSetor.SelectedItem == "Recursos Humanos")
			{
				cbCargo.Items.Clear();
				cbCargo.Items.Add("Líder");
				cbCargo.Items.Add("Assistente");
				cbCargo.Items.Add("Aprendiz");
				cbCargo.Items.Add("Analista");
				cbCargo.Items.Add("Estagiário");
			}
			
			else if (cbSetor.SelectedItem == "Vendas")
			{
				cbCargo.Items.Clear();
				cbCargo.Items.Add("Supervisor");
				cbCargo.Items.Add("Vendedor");
				cbCargo.Items.Add("Aprendiz");
				cbCargo.Items.Add("Atendente de caixa");
			}
			
			else if (cbSetor.SelectedItem == "Administração")
			{
				cbCargo.Items.Clear();
				cbCargo.Items.Add("Diretor");
				cbCargo.Items.Add("Auditor");
				cbCargo.Items.Add("Gerente Geral");
				cbCargo.Items.Add("Assistente");
				cbCargo.Items.Add("Estagiário");
			}
		}
		
		//------------ADICIONAR_NOVO------------\\
		void PbNovoClick(object sender, EventArgs e)
		{
			Limpar();
			
			lbRegistro.Text = (contRegistro + 1).ToString();
		}
		
		//------------SALVAR------------\\
		void PbSalvarClick(object sender, EventArgs e)
		{
			nome[contRegistro] = txtNome.Text.ToUpper();
			setor[contRegistro] = cbSetor.Text;
			cargo[contRegistro] = cbCargo.Text;
			salario[contRegistro] = double.Parse(txtSalario.Text);
			totalVendido[contRegistro] = double.Parse(txtTotalVendido.Text);
			registro[contRegistro] = contRegistro;
			
			MessageBox.Show("Cadastrado com sucesso!!!");
			
			Limpar();
			contRegistro += 1;
			lbRegistro.Text = (contRegistro + 1).ToString();
		}
		
		//------------LISTAR_TODOS------------\\
		void PbListarTodosClick(object sender, EventArgs e)
		{
			Limpar();
			calcularBonus();
			
			for (int i = 0; i < contRegistro; i++)
			{
				listBox.Items.Add("Nome: " + nome[i] + "\n");
				listBox.Items.Add("Registro: " + registro[i] + "\n");
				listBox.Items.Add("Setor: " + setor[i]);
				listBox.Items.Add("Cargo: " + cargo[i]);
				listBox.Items.Add("Salário: " + salario[i]);
				listBox.Items.Add("");
				listBox.Items.Add("");
				
			}
			
		}
		
		//------------FILTRAR------------\\
		void PbFiltrarClick(object sender, EventArgs e)
		{
			Limpar();
			
			for (int i = 0; i < contRegistro; i++)
			{
				if (totalVendido[i] >= meta)
				{
					calcularBonus();
					listBox.Items.Add("Nome: " + nome[i] + "\n");
					listBox.Items.Add("Registro: " + registro[i] + "\n");
					listBox.Items.Add("Setor: " + setor[i]);
					listBox.Items.Add("Cargo: " + cargo[i]);
					listBox.Items.Add("Salário: " + salario[i]);
					listBox.Items.Add("");
					listBox.Items.Add("");
				}
				else
					listBox.Items.Add("Nenhum funcionário atingiu a meta");
				
			}
		}
		
		//------------CONSULTAR------------\\
		void PbConsultarClick(object sender, EventArgs e)
		{
			int numero = int.Parse(txtNumero.Text);
			
			for (int i = 0; i < contRegistro; i++)
			{
				if (registro[i] == numero)
				{
					Limpar();
					txtNome.Text = nome[i];
					cbSetor.SelectedItem = setor[i];
					cbCargo.SelectedItem = cargo[i];
					txtSalario.Text = salario[i].ToString();
					txtTotalVendido.Text = totalVendido[i].ToString();
					lbRegistro.Text = numero.ToString();
				}
			}
		}
	
		//____________________________FUNÇÕES_AUXILIARES____________________________\\
		
		//------------LIMPAR------------\\
		void Limpar()
		{
			txtNome.Text = "";
			cbSetor.SelectedItem = null;
			cbCargo.SelectedItem = null;
			txtSalario.Text = "";
			txtTotalVendido.Text = "";
			txtNumero.Text = "";
			lbRegistro.Text = "- - -";
			
			listBox.Items.Clear();
		}
		
		//------------LIMPAR_CLICK------------\\
		void PbLimparClick(object sender, EventArgs e)
		{
			Limpar();
		}
		
		//------------SAIR------------\\
		void PbSairClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
	}
}
