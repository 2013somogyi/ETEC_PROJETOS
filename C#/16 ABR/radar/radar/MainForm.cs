/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 16/04/2026
 * Hora: 20:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace radar
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			label3.Parent = pictureBox1;
			pictureBox2.Parent = pictureBox1;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//VARIÁVEIS
			int vel_1 = int.Parse(textBox1.Text);
			int vel_2 = int.Parse(textBox2.Text);
			int tempo = int.Parse(textBox3.Text);
			
			//PROCESSAMENTO
			int vel_media = (vel_2 - vel_1)/tempo;
			
			if (vel_media > 80)
			{
					pictureBox2.Load("policialMau.png");
					
					label3.Text = vel_media.ToString() + "Km";
					
					MessageBox.Show("Multado!");
				
			}
			else
			{
				pictureBox2.Load("policialBom.png");
				
				label3.Text = vel_media.ToString() + "Km";
				
				MessageBox.Show("Ta andando certinho! Parabéns");
			
			}
			
		}
}
}
