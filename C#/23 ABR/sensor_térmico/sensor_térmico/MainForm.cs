/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 23/04/2026
 * Hora: 19:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sensor_térmico
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			float temp = float.Parse(txtTemp.Text);
			
			if (temp <= 0)
			{
				pbImagem.Load("congelante.png");
				this.BackColor = Color.DarkBlue;
				
				panel1.BackColor = Color.Blue;
				btMedir.BackColor = Color.CornflowerBlue;
				lbTexto.BackColor = Color.CornflowerBlue;
				
				lbTexto.Text = "...tA mUiTo FrIo...";
			}
			else if (temp >0 && temp <=10)
			{
				pbImagem.Load("muitoFrio.png");
				this.BackColor = Color.DodgerBlue;
				
				panel1.BackColor = Color.DeepSkyBlue;
				btMedir.BackColor = Color.DarkTurquoise;
				lbTexto.BackColor = Color.DarkTurquoise;
				
				lbTexto.Text = "Ta frio visse!";
			}
			else if (temp >10 && temp <=18)
			{
				pbImagem.Load("frio.png");
				this.BackColor = Color.LightSkyBlue;
				
				panel1.BackColor = Color.LightBlue;
				btMedir.BackColor = Color.LightCyan;
				lbTexto.BackColor = Color.LightCyan;
				btMedir.ForeColor = Color.Black;
				lbTexto.ForeColor = Color.Black;
				
				lbTexto.Text = "Ta um friozinho";
			}
			else if (temp >18 && temp <=24)
			{
				pbImagem.Load("normal.png");
				this.BackColor = Color.LightSeaGreen;
				
				panel1.BackColor = Color.LightGreen;
				btMedir.BackColor = Color.MediumAquamarine;
				lbTexto.BackColor = Color.MediumAquamarine;
				btMedir.ForeColor = Color.Black;
				lbTexto.ForeColor = Color.Black;
				
				lbTexto.Text = "Tempo bom";
			}
			else if (temp >24 && temp <=32)
			{
				pbImagem.Load("calor.png");
				this.BackColor = Color.LightSalmon;
				
				panel1.BackColor = Color.OrangeRed;
				btMedir.BackColor = Color.Orange;
				lbTexto.BackColor = Color.Orange;
				btMedir.ForeColor = Color.Black;
				lbTexto.ForeColor = Color.Black;
				
				lbTexto.Text = "Tá fazendo calor hoje";
			}
			else if (temp >32 && temp <=38)
			{
				pbImagem.Load("muitoQuente.png");
				this.BackColor = Color.Red;
				
				panel1.BackColor = Color.Crimson;
				btMedir.BackColor = Color.Coral;
				lbTexto.BackColor = Color.Coral;
				btMedir.ForeColor = Color.Black;
				lbTexto.ForeColor = Color.Black;
				
				lbTexto.Text = "O sol tá fritando!";
			}
			else
			{
				pbImagem.Load("fogo.png");
				this.BackColor = Color.DarkRed;
				
				panel1.BackColor = Color.Brown;
				btMedir.BackColor = Color.Firebrick;
				lbTexto.BackColor = Color.Firebrick;
				
				lbTexto.Text = "AAAAAAHHHH!!!!";
			}
			
			//ligar o timer
			timer1.Enabled = true;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
				pbImagem.Load("imgInicial.png");
				this.BackColor = Color.Silver;
				
				panel1.BackColor = Color.Gray;
				btMedir.BackColor = Color.DimGray;
				lbTexto.BackColor = Color.DimGray;
				
				lbTexto.Text = "Qual é a temperatura hoje?";
				
				//desligar o timer
				timer1.Enabled = false;
		}
		
		void BtLimparClick(object sender, EventArgs e)
		{
			txtTemp.Text = "";
		}
	}
}
