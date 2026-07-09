/*
 * Created by SharpDevelop.
 * User: lucas
 * Date: 07/03/2026
 * Time: 17:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace calculadora_top
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Button0Click(object sender, EventArgs e)
		{
			button0 = (Button)sender;
			if(visor.Text == "0")
				visor.Text = button0.Text;
			else
				visor.Text += button0.Text;
		}
		void Button1Click(object sender, EventArgs e)
		{
			button1 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button1.Text;
			else
				visor.Text += button1.Text;
		}
		void Button2Click(object sender, EventArgs e)
		{
			button2 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button2.Text;
			else
				visor.Text += button2.Text;
		}
		void Button3Click(object sender, EventArgs e)
		{
			button3 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button3.Text;
			else
				visor.Text += button3.Text;
		}
		void Button4Click(object sender, EventArgs e)
		{
			button4 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button4.Text;
			else
				visor.Text += button4.Text;
		}
		void Button5Click(object sender, EventArgs e)
		{
			button5 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button5.Text;
			else
				visor.Text += button5.Text;
		}
		void Button6Click(object sender, EventArgs e)
		{
			button6 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button6.Text;
			else
				visor.Text += button6.Text;
		}
		void Button7Click(object sender, EventArgs e)
		{
			button7 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button7.Text;
			else
				visor.Text += button7.Text;
		}
		void Button8Click(object sender, EventArgs e)
		{
			button8 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button8.Text;
			else
				visor.Text += button8.Text;
		}
		void Button9Click(object sender, EventArgs e)
		{
			button9 = (Button)sender;
			if (visor.Text == "0")
				visor.Text = button9.Text;
			else
				visor.Text += button9.Text;
		}
		void Button11Click(object sender, EventArgs e)
		{
			string[] partes = visor.Text.Split('+', '-', 'x', '/');
			string ultimo = partes[partes.Length -1];
			
			if (!ultimo.Contains("."));
			{
				visor.Text += ".";
			}
		}
		void Button12Click(object sender, EventArgs e)
		{	
			if ((visor.Text.Length > 0))
		    {
		    	char ultimo = visor.Text[visor.Text.Length - 1];
            if (ultimo =='+' || ultimo =='-' || ultimo =='×' || ultimo =='÷')
            {
            	visor.Text = visor.Text.Substring(0, visor.Text.Length -1);
            }
            visor.Text +="+";
			}
		}
		void Button13Click(object sender, EventArgs e)
		{
			if ((visor.Text.Length > 0))
		    {
		    	char ultimo = visor.Text[visor.Text.Length - 1];
            if (ultimo =='+' || ultimo =='-' || ultimo =='×' || ultimo =='÷')
            {
            	visor.Text = visor.Text.Substring(0, visor.Text.Length -1);
            }
            visor.Text +="-";
			}
		}
		void Button14Click(object sender, EventArgs e)
		{
			if (visor.Text.Length > 0)
		    {
		    	char ultimo = visor.Text[visor.Text.Length - 1];
            if (ultimo =='+' || ultimo =='-' || ultimo =='×' || ultimo =='÷')
            {
            	visor.Text = visor.Text.Substring(0, visor.Text.Length -1);
            }
            visor.Text +="×";
			}
		}
		void Button_divClick(object sender, EventArgs e)
		{
			if ((visor.Text.Length > 0))
		    {
		    	char ultimo = visor.Text[visor.Text.Length - 1];
            if (ultimo =='+' || ultimo =='-' || ultimo =='×' || ultimo =='÷')
            {
            	visor.Text = visor.Text.Substring(0, visor.Text.Length -1);
            }
            visor.Text +="÷";
			}
		}
		void Button10Click(object sender, EventArgs e)
		{
			try
			{
				string expressão = visor.Text.Replace('×', '*').Replace(',', '.').Replace('÷', '/');
				
				DataTable table = new DataTable();
				var resultado = table.Compute(expressão, string.Empty);
				visor.Text = resultado.ToString();
			}
			
			catch (Exception)
			{
				MessageBox.Show("Expressão inválida");
				visor.Text = "0";
			}
		}
		void Button_clearClick(object sender, EventArgs e)
		{
			visor.Text = "0";
		}
		void Button_deleteClick(object sender, EventArgs e)
		{
			if (visor.Text.Length >0 && visor.Text !="0")
			{
				visor.Text = visor.Text.Substring(0, visor.Text.Length -1);
			}
			if ( visor.Text == "")
			{
				visor.Text ="0";
			}
		}
		
	}
}
