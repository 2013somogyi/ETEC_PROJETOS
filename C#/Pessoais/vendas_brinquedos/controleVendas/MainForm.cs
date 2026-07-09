/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 21/03/2026
 * Time: 23:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace controleVendas
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Label7Click(object sender, EventArgs e)
		{
			//Brinquedo 1
			string nome1 = textBox1.Text;
			double preço1 = double.Parse(textBox2.Text);
			int inicio1 = int.Parse(textBox3.Text);
			int final1 = int.Parse(textBox4.Text);
			//Brinquedo 2
			string nome2 = textBox13.Text;
			double preço2 = double.Parse(textBox14.Text);
			int inicio2 = int.Parse(textBox15.Text);
			int final2 = int.Parse(textBox16.Text);
			//Brinquedo 3
			string nome3 = textBox12.Text;
			double preço3 = double.Parse(textBox11.Text);
			int inicio3 = int.Parse(textBox10.Text);
			int final3 = int.Parse(textBox9.Text);
			//Brinquedo 4
			string nome4 = textBox24.Text;
			double preço4 = double.Parse(textBox23.Text);
			int inicio4 = int.Parse(textBox22.Text);
			int final4 = int.Parse(textBox21.Text);
			//Brinquedo 5
			string nome5 = textBox30.Text;
			double preço5 = double.Parse(textBox29.Text);
			int inicio5 = int.Parse(textBox28.Text);
			int final5 = int.Parse(textBox27.Text);
			//Brinquedo 6
			string nome6 = textBox36.Text;
			double preço6 = double.Parse(textBox35.Text);
			int inicio6 = int.Parse(textBox34.Text);
			int final6 = int.Parse(textBox33.Text);
			
			//Calculos
			
			//Brinquedo1
			int quantidade1 = inicio1 - final1;
			double vendas1 = quantidade1 * preço1;
			//Brinquedo2
			int quantidade2 = inicio2 - final2;
			double vendas2 = quantidade2 * preço2;
			//Brinquedo3
			int quantidade3 = inicio3 - final3;
			double vendas3 = quantidade3 * preço3;
			//Brinquedo4
			int quantidade4 = inicio4 - final4;
			double vendas4 = quantidade4 * preço4;
			//Brinquedo5
			int quantidade5 = inicio5 - final5;
			double vendas5 = quantidade5 * preço5;
			//Brinquedo6
			int quantidade6 = inicio6 - final6;
			double vendas6 = quantidade6 * preço6;
			//Valor total
			double lucro = vendas1 + vendas2 + vendas3 + vendas4 + vendas5 + vendas6;
			
			//Saídas
			
			//Brinquedo1
			textBox5.Text = quantidade1.ToString();
			//Brinquedo2
			textBox17.Text = quantidade2.ToString();
			//Brinquedo3
			textBox8.Text = quantidade3.ToString();
			//Brinquedo4
			textBox20.Text = quantidade4.ToString();
			//Brinquedo5
			textBox26.Text = quantidade5.ToString();
			//Brinquedo6
			textBox32.Text = quantidade6.ToString();
			//Vendas Total
			textBox37.Text	= lucro.ToString("c");
			
		}
	}
}
