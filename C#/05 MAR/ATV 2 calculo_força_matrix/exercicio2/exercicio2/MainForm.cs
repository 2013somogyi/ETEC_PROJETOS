
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicio2
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			label1.Parent = pictureBox1;
			label2.Parent = pictureBox1;
			label3.Parent = pictureBox1;
			label4.Parent = pictureBox1;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox2.Text == "" || textBox1.Text =="")
			{
				MessageBox.Show("Preencha todos os campos");
			}
			else
			{
				float força, aceleração, massa;
				massa = float.Parse(textBox1.Text);
				aceleração = float.Parse(textBox2.Text);
				força = aceleração * massa;
				
				textBox3.Text = força.ToString();
			}
		}
	}
}
