
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercício1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			double M1, M2, M3, M4, M5, M;
			M1 = double.Parse(Box1.Text);
			M2 = double.Parse(Box2.Text);
			M3 = double.Parse(Box3.Text);
			M4 = double.Parse(Box4.Text);
			M5 = double.Parse(Box5.Text);
			
			M = (M1 + M2 + M3 + M4 + M5) / 5;
			
			Box6.Text = M.ToString();
		}
	}
}
