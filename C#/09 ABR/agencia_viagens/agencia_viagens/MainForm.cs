/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 09/04/2026
 * Hora: 19:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace agencia_viagens
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			
				//-------------------Locais-------------------//
				//Origem
				cboxOrigem.Items.Add("São Paulo");
				cboxOrigem.Items.Add("Rio de Janeiro");
				cboxOrigem.Items.Add("Salvador");
				cboxOrigem.Items.Add("Campo Grande");
				cboxOrigem.Items.Add("Manaus");
				
				//Destino
				cboxDestino.Items.Add("João Pessoa");
				cboxDestino.Items.Add("Curitiba");
				cboxDestino.Items.Add("Brasília");
				cboxDestino.Items.Add("Belo Horizonte");
				cboxDestino.Items.Add("Vitória");
				
				//-------------------Horários-------------------//
				
				cboxHorario.Items.Add("08:00hrs");
				cboxHorario.Items.Add("10:00hrs");
				cboxHorario.Items.Add("12:00hrs");
				cboxHorario.Items.Add("18:00hrs");
				cboxHorario.Items.Add("20:00hrs");
		}		
				//-------------------ValoresHotéis-------------------//
				
				//Hotel João Pessoa
				double vlJoaoPessoa1 = 200.00;
				double vlJoaoPessoa2 = 300.00;
				double vlJoaoPessoa3 = 400.00;
				
				//Hotel Curitiba
				double vlCuritiba1 = 250.00;
				double vlCuritiba2 = 350.00;
				double vlCuritiba3 = 450.00;
				
				//Hotel Brasília
				double vlBrasilia1 = 300.00;
				double vlBrasilia2 = 400.00;
				double vlBrasilia3 = 500.00;
				
				//Hotel Belo Horizonte
				double vlBeloHorizonte1 = 350.00;
				double vlBeloHorizonte2 = 450.00;
				double vlBeloHorizonte3 = 550.00;
				
				//Hotel Vitória
				double vlVitoria1 = 400.00;
				double vlVitoria2 = 500.00;
				double vlVitoria3 = 600.00;
				
				//-------------------ValoresViagem-------------------//
				//João Pessoa
				double busJoaoPessoa = 2000.00;
				double aviaoJoaoPessoa = 3000.00;
				
				//Curitiba
				double busCuritiba = 2500.00;
				double aviaoCuritiba = 3500.00;
				
				//Brasília
				double busBrasilia = 3000.00;
				double aviaoBrasilia = 4000.00;
				
				//Belo Horizonte
				double busBeloHorizonte = 3500.00;
				double aviaoBeloHorizonte = 4500.00;
				
				//Vitória
				double busVitoria = 4000.00;
				double aviaoVitoria = 5000.00;
				
				//-------------------LógicaComboBox-------------------//
				
		void CboxDestinoSelectedIndexChanged(object sender, EventArgs e)
		{		
			if (cboxDestino.SelectedItem.ToString() == "João Pessoa") {
				cboxHospedagem.Items.Clear();
				cboxHospedagem.Items.Add("Hotel Bom Preço");
				cboxHospedagem.Items.Add("Hotel Eddy's");			
				cboxHospedagem.Items.Add("Hotel Feira");
			}
			else if (cboxDestino.SelectedItem.ToString() == "Curitiba") {
				cboxHospedagem.Items.Clear();
				cboxHospedagem.Items.Add("Hotel Cruz das Armas");
				cboxHospedagem.Items.Add("Hotel Bancários");			
				cboxHospedagem.Items.Add("Hotel Trincheiras");
			}
			else if (cboxDestino.SelectedItem.ToString() == "Brasília") {
				cboxHospedagem.Items.Clear();
				cboxHospedagem.Items.Add("Hotel Campina Grande");
				cboxHospedagem.Items.Add("Hotel Paulistano");
				cboxHospedagem.Items.Add("Hotel Liberdade");
			}
			else if (cboxDestino.SelectedItem.ToString() == "Belo Horizonte") {
				cboxHospedagem.Items.Clear();
				cboxHospedagem.Items.Add("Hotel Malvinas");
				cboxHospedagem.Items.Add("Hotel Sítio Lucas");
				cboxHospedagem.Items.Add("Hotel Prata");
			}
			else {
				cboxHospedagem.Items.Clear();
				cboxHospedagem.Items.Add("Hotel Centenário");
				cboxHospedagem.Items.Add("Hotel Esperança");
				cboxHospedagem.Items.Add("Hotel Torre");
			}
		}
				
				//-------------------LógicaBotão-------------------//
		void BtCalcularClick(object sender, EventArgs e)
		{
				int nmrDias = (int)boxNmrDias.Value;
				
				
				//-------------------João Pessoa-------------------//
				
				
				//Ônibus JP1
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Bom Preço" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelJP1 = nmrDias * vlJoaoPessoa1;
				double rstd_JP1 = rstd_HotelJP1 + busJoaoPessoa;
				
				txtTransporte.Text = busJoaoPessoa.ToString("C");
				txtHospedagem.Text = rstd_HotelJP1.ToString("C");
				lbTotal.Text = rstd_JP1.ToString("C");
				
			}   //Aviao JP1
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Bom Preço" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelJP1 = nmrDias * vlJoaoPessoa1;
				double rstd_JP1 = rstd_HotelJP1 + aviaoJoaoPessoa;
				
				txtTransporte.Text = aviaoJoaoPessoa.ToString("C");
				txtHospedagem.Text = rstd_HotelJP1.ToString("C");
				lbTotal.Text = rstd_JP1.ToString("C");
				
			}
				//Ônibus JP2
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Eddy's" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelJP2 = nmrDias * vlJoaoPessoa2;
				double rstd_JP2 = rstd_HotelJP2 + busJoaoPessoa;
				
				txtTransporte.Text = busJoaoPessoa.ToString("C");
				txtHospedagem.Text = rstd_HotelJP2.ToString("C");
				lbTotal.Text = rstd_JP2.ToString("C");
				
			}   //Aviao JP2
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Eddy's" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelJP2 = nmrDias * vlJoaoPessoa2;
				double rstd_JP2 = rstd_HotelJP2 + aviaoJoaoPessoa;
				
				txtTransporte.Text = aviaoJoaoPessoa.ToString("C");
				txtHospedagem.Text = rstd_HotelJP2.ToString("C");
				lbTotal.Text = rstd_JP2.ToString("C");
				
			}
				//Ônibus JP3
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Feira" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelJP3 = nmrDias * vlJoaoPessoa3;
				double rstd_JP3 = rstd_HotelJP3 + busJoaoPessoa;
				
				txtTransporte.Text = busJoaoPessoa.ToString("C");
				txtHospedagem.Text = rstd_HotelJP3.ToString("C");
				lbTotal.Text = rstd_JP3.ToString("C");
				
			}   //Aviao JP3
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Feira" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelJP3 = nmrDias * vlJoaoPessoa3;
				double rstd_JP3 = rstd_HotelJP3 + aviaoJoaoPessoa;
				
				txtTransporte.Text = aviaoJoaoPessoa.ToString("C");
				txtHospedagem.Text = rstd_HotelJP3.ToString("C");
				lbTotal.Text = rstd_JP3.ToString("C");
				
			}
				
				
				//-------------------Curitiba-------------------//
				
				
				//Ônibus CTB1
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Cruz das Armas" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelCTB1 = nmrDias * vlCuritiba1;
				double rstd_CTB1 = rstd_HotelCTB1 + busCuritiba;
				
				txtTransporte.Text = busCuritiba.ToString("C");
				txtHospedagem.Text = rstd_HotelCTB1.ToString("C");
				lbTotal.Text = rstd_CTB1.ToString("C");
				
			}   //Aviao CTB1
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Cruz das Armas" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelCTB1 = nmrDias * vlCuritiba1;
				double rstd_CTB1 = rstd_HotelCTB1  + aviaoCuritiba;
				
				txtTransporte.Text = aviaoCuritiba.ToString("C");
				txtHospedagem.Text = rstd_HotelCTB1.ToString("C");
				lbTotal.Text = rstd_CTB1.ToString("C");
				
			}
				//Ônibus CTB2
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Bancários" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelCTB2 = nmrDias * vlCuritiba2;
				double rstd_CTB2 = rstd_HotelCTB2 + busCuritiba;
				
				txtTransporte.Text = busCuritiba.ToString("C");
				txtHospedagem.Text = rstd_HotelCTB2.ToString("C");
				lbTotal.Text = rstd_CTB2.ToString("C");
				
			}   //Aviao CTB2
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Bancários" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelCTB2 = nmrDias * vlCuritiba2;
				double rstd_CTB2 = rstd_HotelCTB2  + aviaoCuritiba;
				
				txtTransporte.Text = aviaoCuritiba.ToString("C");
				txtHospedagem.Text = rstd_HotelCTB2.ToString("C");
				lbTotal.Text = rstd_CTB2.ToString("C");
				
			}
				//Ônibus CTB3
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Trincheiras" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelCTB3 = nmrDias * vlCuritiba3;
				double rstd_CTB3 = rstd_HotelCTB3 + busCuritiba;
				
				txtTransporte.Text = busCuritiba.ToString("C");
				txtHospedagem.Text = rstd_HotelCTB3.ToString("C");
				lbTotal.Text = rstd_CTB3.ToString("C");
				
			}   //Aviao CTB3
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Trincheiras" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelCTB3 = nmrDias * vlCuritiba3;
				double rstd_CTB3 = rstd_HotelCTB3 + aviaoCuritiba;
				
				txtTransporte.Text = aviaoCuritiba.ToString("C");
				txtHospedagem.Text = rstd_HotelCTB3.ToString("C");
				lbTotal.Text = rstd_CTB3.ToString("C");
				
			}
				
				
				//-------------------Brasília-------------------//
				
				
				//Ônibus BSL1
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Campina Grande" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBSL1 = nmrDias * vlBrasilia1;
				double rstd_BSL1 = rstd_HotelBSL1 + busBrasilia;
				
				txtTransporte.Text = busBrasilia.ToString("C");
				txtHospedagem.Text = rstd_HotelBSL1.ToString("C");
				lbTotal.Text = rstd_BSL1.ToString("C");
				
			}   //Aviao BSL1
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Campina Grande" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBSL1 = nmrDias * vlBrasilia1;
				double rstd_BSL1 = rstd_HotelBSL1  + aviaoBrasilia;
				
				txtTransporte.Text = aviaoBrasilia.ToString("C");
				txtHospedagem.Text = rstd_HotelBSL1.ToString("C");
				lbTotal.Text = rstd_BSL1.ToString("C");
				
			}
				//Ônibus BSL2
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Paulistano" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBSL2 = nmrDias * vlBrasilia2;
				double rstd_BSL2 = rstd_HotelBSL2 + busBrasilia;
				
				txtTransporte.Text = busBrasilia.ToString("C");
				txtHospedagem.Text = rstd_HotelBSL2.ToString("C");
				lbTotal.Text = rstd_BSL2.ToString("C");
				
			}   //Aviao BSL2
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Paulistano" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBSL2 = nmrDias * vlBrasilia2;
				double rstd_BSL2 = rstd_HotelBSL2  + aviaoBrasilia;
				
				txtTransporte.Text = aviaoBrasilia.ToString("C");
				txtHospedagem.Text = rstd_HotelBSL2.ToString("C");
				lbTotal.Text = rstd_BSL2.ToString("C");
				
			}
				//Ônibus BSL3
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Liberdade" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBSL3 = nmrDias * vlBrasilia3;
				double rstd_BSL3 = rstd_HotelBSL3 + busBrasilia;
				
				txtTransporte.Text = busBrasilia.ToString("C");
				txtHospedagem.Text = rstd_HotelBSL3.ToString("C");
				lbTotal.Text = rstd_BSL3.ToString("C");
				
			}   //Aviao BSL3
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Liberdade" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBSL3 = nmrDias * vlBrasilia3;
				double rstd_BSL3 = rstd_HotelBSL3  + aviaoBrasilia;
				
				txtTransporte.Text = aviaoBrasilia.ToString("C");
				txtHospedagem.Text = rstd_HotelBSL3.ToString("C");
				lbTotal.Text = rstd_BSL3.ToString("C");
				
			}
				
				
				//-------------------Belo Horizonte-------------------//
				
				
				//Ônibus BH1
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Malvinas" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBH1 = nmrDias * vlBeloHorizonte1;
				double rstd_BH1 = rstd_HotelBH1 + busBeloHorizonte;
				
				txtTransporte.Text = busBeloHorizonte.ToString("C");
				txtHospedagem.Text = rstd_HotelBH1.ToString("C");
				lbTotal.Text = rstd_BH1.ToString("C");
				
			}   //Aviao BH1
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Malvinas" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBH1 = nmrDias * vlBeloHorizonte1;
				double rstd_BH1 = rstd_HotelBH1  + aviaoBeloHorizonte;
				
				txtTransporte.Text = aviaoBeloHorizonte.ToString("C");
				txtHospedagem.Text = rstd_HotelBH1.ToString("C");
				lbTotal.Text = rstd_BH1.ToString("C");
				
			}
				//Ônibus BH2
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Sítio Lucas" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBH2 = nmrDias * vlBeloHorizonte2;
				double rstd_BH2 = rstd_HotelBH2 + busBeloHorizonte;
				
				txtTransporte.Text = busBeloHorizonte.ToString("C");
				txtHospedagem.Text = rstd_HotelBH2.ToString("C");
				lbTotal.Text = rstd_BH2.ToString("C");
				
			}   //Aviao BH2
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Sítio Lucas" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBH2 = nmrDias * vlBeloHorizonte2;
				double rstd_BH2 = rstd_HotelBH2  + aviaoBeloHorizonte;
				
				txtTransporte.Text = aviaoBeloHorizonte.ToString("C");
				txtHospedagem.Text = rstd_HotelBH2.ToString("C");
				lbTotal.Text = rstd_BH2.ToString("C");
				
			}
				//Ônibus BH3
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Prata" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBH3 = nmrDias * vlBeloHorizonte3;
				double rstd_BH3 = rstd_HotelBH3 + busBeloHorizonte;
				
				txtTransporte.Text = busBeloHorizonte.ToString("C");
				txtHospedagem.Text = rstd_HotelBH3.ToString("C");
				lbTotal.Text = rstd_BH3.ToString("C");
				
			}   //Aviao BH3
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Prata" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelBH3 = nmrDias * vlBeloHorizonte3;
				double rstd_BH3 = rstd_HotelBH3  + aviaoBeloHorizonte;
				
				txtTransporte.Text = aviaoBeloHorizonte.ToString("C");
				txtHospedagem.Text = rstd_HotelBH3.ToString("C");
				lbTotal.Text = rstd_BH3.ToString("C");
				
			}
				
				
				//-------------------Vitória-------------------//
				
				
				//Ônibus VTR1
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Centenário" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelVTR1 = nmrDias * vlVitoria1;
				double rstd_VTR1 = rstd_HotelVTR1 + busVitoria;
				
				txtTransporte.Text = busVitoria.ToString("C");
				txtHospedagem.Text = rstd_HotelVTR1.ToString("C");
				lbTotal.Text = rstd_VTR1.ToString("C");
				
			}   //Aviao VTR1
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Centenário" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelVTR1 = nmrDias * vlVitoria1;
				double rstd_VTR1 = rstd_HotelVTR1  + aviaoVitoria;
				
				txtTransporte.Text = aviaoVitoria.ToString("C");
				txtHospedagem.Text = rstd_HotelVTR1.ToString("C");
				lbTotal.Text = rstd_VTR1.ToString("C");
				
			}
				//Ônibus VTR2
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Esperança" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelVTR2 = nmrDias * vlVitoria2;
				double rstd_VTR2 = rstd_HotelVTR2 + busVitoria;
				
				txtTransporte.Text = busVitoria.ToString("C");
				txtHospedagem.Text = rstd_HotelVTR2.ToString("C");
				lbTotal.Text = rstd_VTR2.ToString("C");
				
			}   //Aviao VTR2
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Esperança" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelVTR2 = nmrDias * vlVitoria2;
				double rstd_VTR2 = rstd_HotelVTR2  + aviaoVitoria;
				
				txtTransporte.Text = aviaoVitoria.ToString("C");
				txtHospedagem.Text = rstd_HotelVTR2.ToString("C");
				lbTotal.Text = rstd_VTR2.ToString("C");
				
			}
				//Ônibus VTR3
			if (cboxHospedagem.SelectedItem.ToString() == "Hotel Torre" && rbOnibus.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelVTR3 = nmrDias * vlVitoria3;
				double rstd_VTR3 = rstd_HotelVTR3 + busVitoria;
				
				txtTransporte.Text = busVitoria.ToString("C");
				txtHospedagem.Text = rstd_HotelVTR3.ToString("C");
				lbTotal.Text = rstd_VTR3.ToString("C");
				
			}   //Aviao VTR3
				else if (cboxHospedagem.SelectedItem.ToString() == "Hotel Torre" && rbAviao.Checked) {
				txtTransporte.Clear();
				
				
				double rstd_HotelVTR3 = nmrDias * vlVitoria3;
				double rstd_VTR3 = rstd_HotelVTR3 + aviaoVitoria;
				
				txtTransporte.Text = aviaoVitoria.ToString("C");
				txtHospedagem.Text = rstd_HotelVTR3.ToString("C");
				lbTotal.Text = rstd_VTR3.ToString("C");
				
			}
				
		}
										
	}	
	
}	