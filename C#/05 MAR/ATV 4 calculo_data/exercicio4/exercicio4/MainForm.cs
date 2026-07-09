/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 06/03/2026
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicio4
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			string dia, mes, ano;
				dia = (textBox1.Text);
				mes = (textBox2.Text);
				ano = (textBox3.Text);
				textBox4.Text = dia + "/" + mes + "/" + ano;
		}
		
	}
}
