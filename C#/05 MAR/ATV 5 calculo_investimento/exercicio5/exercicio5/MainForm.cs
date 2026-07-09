
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicio5
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			double juros, valor, r;
			juros = double.Parse(textBox1.Text);
			valor = double.Parse(textBox2.Text);
			r = (juros/100) * valor;
			textBox3.Text = r.ToString();
		}
	}
}
