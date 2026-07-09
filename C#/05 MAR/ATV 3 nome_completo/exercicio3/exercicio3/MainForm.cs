
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicio3
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		
				
		
		void Button1Click(object sender, EventArgs e)
		{
			string nome, sobrenome;
			
			nome = textBox1.Text;
			sobrenome = textBox2.Text;
			textBox3.Text = nome + " " + sobrenome;
				
		}
	}
}
