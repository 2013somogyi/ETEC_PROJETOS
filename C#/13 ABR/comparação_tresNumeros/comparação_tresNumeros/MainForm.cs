/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 13/04/2026
 * Hora: 20:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace comparação_tresNumeros
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtCompararClick(object sender, EventArgs e)
		{
			//Coleta
			double txt1 = double.Parse(txtNmr1.Text);
			double txt2 = double.Parse(txtNmr2.Text);
			double txt3 = double.Parse(txtNmr3.Text);
			
			//Comparações
			if (txt1 > txt2)
			{
				lbResultado.Text = "O 1° é o maior!";
			}
			else if (txt1 > txt3)
			{
				lbResultado.Text = "O 1° é o maior!";
			}
			else if (txt2 > txt3)
			{
				lbResultado.Text = "O 2° é o maior!";
			}
			else
			{
				lbResultado.Text = "O 3° é o maior!";
			}
		}
		
		void BtLimparClick(object sender, EventArgs e)
		{
			lbResultado.Text = "";
			txtNmr1.Text = "";
			txtNmr2.Text = "";
			txtNmr3.Text = "";
		}
	}
}
