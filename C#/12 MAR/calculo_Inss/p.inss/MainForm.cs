/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 12/03/2026
 * Hora: 19:32
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace p.inss
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double sal, fal;
			double descfal, saliquid, inss;
			if (textBox1.Text == "" || textBox2.Text == "")
			{
				MessageBox.Show("Preencha todos os campos");
			}
			else
			{
				sal = double.Parse(textBox1.Text);
				fal = double.Parse(textBox2.Text);
				
				inss = (sal * 0.12);
				descfal = (sal/30)*fal;
				saliquid = sal-descfal-inss;
				
				textBox3.Text = inss.ToString();
				textBox4.Text = descfal.ToString();
				textBox5.Text = saliquid.ToString();
			}
			
			//
			
//			float sal, fal;
//			float descfal, saliquid, inss;
//			sal = float.Parse(textBox1.Text);
//			fal = float.Parse(textBox2.Text);
//			
//			inss = (sal * 0.12f);
//			descfal = (sal/30)*fal;
//			saliquid = sal-descfal-inss;
//			
//			textBox3.Text = inss.ToString();
//			textBox4.Text = descfal.ToString();
//			textBox5.Text = saliquid.ToString();
			
			
		}
	}
}
