/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 19/03/2026
 * Hora: 19:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace programa_brinque_comigo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			//Entrada
			
			//Brinquedo1
			string nome1 = textBox1.Text;
			float preço1 = float.Parse(textBox7.Text);
			int inicio1 = int.Parse(textBox13.Text);
			int final1 = int.Parse(textBox19.Text);
			//Brinquedo2
			string nome2 = textBox2.Text;
			float preço2 = float.Parse(textBox8.Text);
			int inicio2 = int.Parse(textBox14.Text);
			int final2 = int.Parse(textBox20.Text);
			//Brinquedo3
			string nome3 = textBox3.Text;
			float preço3 = float.Parse(textBox9.Text);
			int inicio3 = int.Parse(textBox15.Text);
			int final3 = int.Parse(textBox21.Text);
			//Brinquedo4
			string nome4 = textBox4.Text;
			float preço4 = float.Parse(textBox10.Text);
			int inicio4 = int.Parse(textBox16.Text);
			int final4 = int.Parse(textBox22.Text);
			//Brinquedo5
			string nome5 = textBox5.Text;
			float preço5 = float.Parse(textBox11.Text);
			int inicio5 = int.Parse(textBox17.Text);
			int final5 = int.Parse(textBox23.Text);
			//Brinquedo6
			string nome6 = textBox6.Text;
			float preço6 = float.Parse(textBox12.Text);
			int inicio6 = int.Parse(textBox18.Text);
			int final6 = int.Parse(textBox24.Text);
			
			//Cálculo
			
			//Brinquedo1
			float quantidade1 = inicio1 - final1;
			float vendas1 = preço1 * quantidade1;
			//Brinquedo2
			float quantidade2 = inicio2 - final2;
			float vendas2 = preço2 * quantidade2;
			//Brinquedo3
			float quantidade3 = inicio3 - final3;
			float vendas3 = preço3 * quantidade3;
			//Brinquedo4
			float quantidade4 = inicio4 - final4;
			float vendas4 = preço4 * quantidade4;
			//Brinquedo5
			float quantidade5 = inicio5 - final5;
			float vendas5 = preço5 * quantidade5;
			//Brinquedo6
			float quantidade6 = inicio6 - final6;
			float vendas6 = preço6 * quantidade6;
			
			//Saída
			
			//Brinquedo1
			textBox36.Text = quantidade1.ToString();
			textBox30.Text = vendas1.ToString("c");
			//Brinquedo2
			textBox35.Text = quantidade2.ToString();
			textBox29.Text = vendas2.ToString("c");
			//Brinquedo3
			textBox34.Text = quantidade3.ToString();
			textBox28.Text = vendas3.ToString("c");
			//Brinquedo4
			textBox33.Text = quantidade4.ToString();
			textBox27.Text = vendas4.ToString("c");
			//Brinquedo5
			textBox32.Text = quantidade5.ToString();
			textBox26.Text = vendas5.ToString("c");
			//Brinquedo6
			textBox31.Text = quantidade6.ToString();
			textBox25.Text = vendas6.ToString("c");
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Text= "";
			textBox2.Text= "";
			textBox3.Text= "";
			textBox4.Text= "";
			textBox5.Text= "";
			textBox6.Text= "";
			textBox7.Text= "";
			textBox8.Text= "";
			textBox9.Text= "";
			textBox10.Text= "";
			textBox11.Text= "";
			textBox12.Text= "";
			textBox13.Text= "";
			textBox14.Text= "";
			textBox15.Text= "";
			textBox16.Text= "";
			textBox17.Text= "";
			textBox18.Text= "";
			textBox19.Text= "";
			textBox20.Text= "";
			textBox21.Text= "";
			textBox22.Text= "";
			textBox23.Text= "";
			textBox24.Text= "";
			textBox25.Text= "";
			textBox26.Text= "";
			textBox27.Text= "";
			textBox28.Text= "";
			textBox29.Text= "";
			textBox30.Text= "";
			textBox31.Text= "";
			textBox32.Text= "";
			textBox33.Text= "";
			textBox34.Text= "";
			textBox35.Text= "";
			textBox36.Text= "";
		}
	}
}
