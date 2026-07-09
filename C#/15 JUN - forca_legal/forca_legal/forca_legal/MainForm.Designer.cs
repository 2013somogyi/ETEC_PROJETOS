/*
 * Criado por SharpDevelop.
 * Usuário: lucas
 * Data: 15/06/2026
 * Hora: 19:38
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace forca_legal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPalavra;
		private System.Windows.Forms.PictureBox pbForca;
		private System.Windows.Forms.Button btA;
		private System.Windows.Forms.Button btB;
		private System.Windows.Forms.Button btC;
		private System.Windows.Forms.Button btD;
		private System.Windows.Forms.Button btE;
		private System.Windows.Forms.Button btF;
		private System.Windows.Forms.Button btG;
		private System.Windows.Forms.Button btH;
		private System.Windows.Forms.Button btJ;
		private System.Windows.Forms.Button btI;
		private System.Windows.Forms.Button btT;
		private System.Windows.Forms.Button btS;
		private System.Windows.Forms.Button btR;
		private System.Windows.Forms.Button btQ;
		private System.Windows.Forms.Button btP;
		private System.Windows.Forms.Button btO;
		private System.Windows.Forms.Button btN;
		private System.Windows.Forms.Button btM;
		private System.Windows.Forms.Button btL;
		private System.Windows.Forms.Button btK;
		private System.Windows.Forms.Button btZ;
		private System.Windows.Forms.Button btY;
		private System.Windows.Forms.Button btX;
		private System.Windows.Forms.Button btW;
		private System.Windows.Forms.Button btV;
		private System.Windows.Forms.Button btU;
		private System.Windows.Forms.Panel pnTeclado;
		private System.Windows.Forms.Button btEsconder;
		private System.Windows.Forms.Panel pnEsconder;
		private System.Windows.Forms.Label lbPalavra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.Button btIniciar;
		private System.Windows.Forms.Button btSair;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtPalavra = new System.Windows.Forms.TextBox();
			this.pbForca = new System.Windows.Forms.PictureBox();
			this.btA = new System.Windows.Forms.Button();
			this.btB = new System.Windows.Forms.Button();
			this.btC = new System.Windows.Forms.Button();
			this.btD = new System.Windows.Forms.Button();
			this.btE = new System.Windows.Forms.Button();
			this.btF = new System.Windows.Forms.Button();
			this.btG = new System.Windows.Forms.Button();
			this.btH = new System.Windows.Forms.Button();
			this.btJ = new System.Windows.Forms.Button();
			this.btI = new System.Windows.Forms.Button();
			this.btT = new System.Windows.Forms.Button();
			this.btS = new System.Windows.Forms.Button();
			this.btR = new System.Windows.Forms.Button();
			this.btQ = new System.Windows.Forms.Button();
			this.btP = new System.Windows.Forms.Button();
			this.btO = new System.Windows.Forms.Button();
			this.btN = new System.Windows.Forms.Button();
			this.btM = new System.Windows.Forms.Button();
			this.btL = new System.Windows.Forms.Button();
			this.btK = new System.Windows.Forms.Button();
			this.btZ = new System.Windows.Forms.Button();
			this.btY = new System.Windows.Forms.Button();
			this.btX = new System.Windows.Forms.Button();
			this.btW = new System.Windows.Forms.Button();
			this.btV = new System.Windows.Forms.Button();
			this.btU = new System.Windows.Forms.Button();
			this.pnTeclado = new System.Windows.Forms.Panel();
			this.btLimpar = new System.Windows.Forms.Button();
			this.btEsconder = new System.Windows.Forms.Button();
			this.pnEsconder = new System.Windows.Forms.Panel();
			this.lbPalavra = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btIniciar = new System.Windows.Forms.Button();
			this.btSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
			this.pnTeclado.SuspendLayout();
			this.pnEsconder.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtPalavra
			// 
			this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPalavra.Location = new System.Drawing.Point(82, 20);
			this.txtPalavra.Name = "txtPalavra";
			this.txtPalavra.ReadOnly = true;
			this.txtPalavra.Size = new System.Drawing.Size(228, 39);
			this.txtPalavra.TabIndex = 0;
			// 
			// pbForca
			// 
			this.pbForca.BackColor = System.Drawing.Color.Transparent;
			this.pbForca.Location = new System.Drawing.Point(39, 134);
			this.pbForca.Name = "pbForca";
			this.pbForca.Size = new System.Drawing.Size(410, 492);
			this.pbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbForca.TabIndex = 1;
			this.pbForca.TabStop = false;
			// 
			// btA
			// 
			this.btA.AutoSize = true;
			this.btA.BackColor = System.Drawing.Color.Honeydew;
			this.btA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btA.Location = new System.Drawing.Point(30, 22);
			this.btA.Name = "btA";
			this.btA.Size = new System.Drawing.Size(67, 39);
			this.btA.TabIndex = 15;
			this.btA.Text = "A";
			this.btA.UseVisualStyleBackColor = false;
			this.btA.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btB
			// 
			this.btB.AutoSize = true;
			this.btB.BackColor = System.Drawing.Color.Honeydew;
			this.btB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btB.Location = new System.Drawing.Point(103, 22);
			this.btB.Name = "btB";
			this.btB.Size = new System.Drawing.Size(67, 39);
			this.btB.TabIndex = 16;
			this.btB.Text = "B";
			this.btB.UseVisualStyleBackColor = false;
			this.btB.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btC
			// 
			this.btC.AutoSize = true;
			this.btC.BackColor = System.Drawing.Color.Honeydew;
			this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btC.Location = new System.Drawing.Point(176, 22);
			this.btC.Name = "btC";
			this.btC.Size = new System.Drawing.Size(67, 39);
			this.btC.TabIndex = 17;
			this.btC.Text = "C";
			this.btC.UseVisualStyleBackColor = false;
			this.btC.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btD
			// 
			this.btD.AutoSize = true;
			this.btD.BackColor = System.Drawing.Color.Honeydew;
			this.btD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btD.Location = new System.Drawing.Point(249, 22);
			this.btD.Name = "btD";
			this.btD.Size = new System.Drawing.Size(67, 39);
			this.btD.TabIndex = 18;
			this.btD.Text = "D";
			this.btD.UseVisualStyleBackColor = false;
			this.btD.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btE
			// 
			this.btE.AutoSize = true;
			this.btE.BackColor = System.Drawing.Color.Honeydew;
			this.btE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btE.Location = new System.Drawing.Point(322, 22);
			this.btE.Name = "btE";
			this.btE.Size = new System.Drawing.Size(67, 39);
			this.btE.TabIndex = 19;
			this.btE.Text = "E";
			this.btE.UseVisualStyleBackColor = false;
			this.btE.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btF
			// 
			this.btF.AutoSize = true;
			this.btF.BackColor = System.Drawing.Color.Honeydew;
			this.btF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btF.Location = new System.Drawing.Point(395, 22);
			this.btF.Name = "btF";
			this.btF.Size = new System.Drawing.Size(67, 39);
			this.btF.TabIndex = 20;
			this.btF.Text = "F";
			this.btF.UseVisualStyleBackColor = false;
			this.btF.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btG
			// 
			this.btG.AutoSize = true;
			this.btG.BackColor = System.Drawing.Color.Honeydew;
			this.btG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btG.Location = new System.Drawing.Point(468, 22);
			this.btG.Name = "btG";
			this.btG.Size = new System.Drawing.Size(67, 39);
			this.btG.TabIndex = 21;
			this.btG.Text = "G";
			this.btG.UseVisualStyleBackColor = false;
			this.btG.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btH
			// 
			this.btH.AutoSize = true;
			this.btH.BackColor = System.Drawing.Color.Honeydew;
			this.btH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btH.Location = new System.Drawing.Point(541, 22);
			this.btH.Name = "btH";
			this.btH.Size = new System.Drawing.Size(67, 39);
			this.btH.TabIndex = 22;
			this.btH.Text = "H";
			this.btH.UseVisualStyleBackColor = false;
			this.btH.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btJ
			// 
			this.btJ.AutoSize = true;
			this.btJ.BackColor = System.Drawing.Color.Honeydew;
			this.btJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btJ.Location = new System.Drawing.Point(688, 22);
			this.btJ.Name = "btJ";
			this.btJ.Size = new System.Drawing.Size(67, 39);
			this.btJ.TabIndex = 24;
			this.btJ.Text = "J";
			this.btJ.UseVisualStyleBackColor = false;
			this.btJ.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btI
			// 
			this.btI.AutoSize = true;
			this.btI.BackColor = System.Drawing.Color.Honeydew;
			this.btI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btI.Location = new System.Drawing.Point(615, 22);
			this.btI.Name = "btI";
			this.btI.Size = new System.Drawing.Size(67, 39);
			this.btI.TabIndex = 23;
			this.btI.Text = "I";
			this.btI.UseVisualStyleBackColor = false;
			this.btI.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btT
			// 
			this.btT.AutoSize = true;
			this.btT.BackColor = System.Drawing.Color.Honeydew;
			this.btT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btT.Location = new System.Drawing.Point(688, 87);
			this.btT.Name = "btT";
			this.btT.Size = new System.Drawing.Size(67, 39);
			this.btT.TabIndex = 34;
			this.btT.Text = "T";
			this.btT.UseVisualStyleBackColor = false;
			this.btT.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btS
			// 
			this.btS.AutoSize = true;
			this.btS.BackColor = System.Drawing.Color.Honeydew;
			this.btS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btS.Location = new System.Drawing.Point(615, 87);
			this.btS.Name = "btS";
			this.btS.Size = new System.Drawing.Size(67, 39);
			this.btS.TabIndex = 33;
			this.btS.Text = "S";
			this.btS.UseVisualStyleBackColor = false;
			this.btS.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btR
			// 
			this.btR.AutoSize = true;
			this.btR.BackColor = System.Drawing.Color.Honeydew;
			this.btR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btR.Location = new System.Drawing.Point(541, 87);
			this.btR.Name = "btR";
			this.btR.Size = new System.Drawing.Size(67, 39);
			this.btR.TabIndex = 32;
			this.btR.Text = "R";
			this.btR.UseVisualStyleBackColor = false;
			this.btR.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btQ
			// 
			this.btQ.AutoSize = true;
			this.btQ.BackColor = System.Drawing.Color.Honeydew;
			this.btQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btQ.Location = new System.Drawing.Point(468, 87);
			this.btQ.Name = "btQ";
			this.btQ.Size = new System.Drawing.Size(67, 39);
			this.btQ.TabIndex = 31;
			this.btQ.Text = "Q";
			this.btQ.UseVisualStyleBackColor = false;
			this.btQ.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btP
			// 
			this.btP.AutoSize = true;
			this.btP.BackColor = System.Drawing.Color.Honeydew;
			this.btP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btP.Location = new System.Drawing.Point(395, 87);
			this.btP.Name = "btP";
			this.btP.Size = new System.Drawing.Size(67, 39);
			this.btP.TabIndex = 30;
			this.btP.Text = "P";
			this.btP.UseVisualStyleBackColor = false;
			this.btP.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btO
			// 
			this.btO.AutoSize = true;
			this.btO.BackColor = System.Drawing.Color.Honeydew;
			this.btO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btO.Location = new System.Drawing.Point(322, 87);
			this.btO.Name = "btO";
			this.btO.Size = new System.Drawing.Size(67, 39);
			this.btO.TabIndex = 29;
			this.btO.Text = "O";
			this.btO.UseVisualStyleBackColor = false;
			this.btO.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btN
			// 
			this.btN.AutoSize = true;
			this.btN.BackColor = System.Drawing.Color.Honeydew;
			this.btN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btN.Location = new System.Drawing.Point(249, 87);
			this.btN.Name = "btN";
			this.btN.Size = new System.Drawing.Size(67, 39);
			this.btN.TabIndex = 28;
			this.btN.Text = "N";
			this.btN.UseVisualStyleBackColor = false;
			this.btN.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btM
			// 
			this.btM.AutoSize = true;
			this.btM.BackColor = System.Drawing.Color.Honeydew;
			this.btM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btM.Location = new System.Drawing.Point(176, 87);
			this.btM.Name = "btM";
			this.btM.Size = new System.Drawing.Size(67, 39);
			this.btM.TabIndex = 27;
			this.btM.Text = "M";
			this.btM.UseVisualStyleBackColor = false;
			this.btM.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btL
			// 
			this.btL.AutoSize = true;
			this.btL.BackColor = System.Drawing.Color.Honeydew;
			this.btL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btL.Location = new System.Drawing.Point(103, 87);
			this.btL.Name = "btL";
			this.btL.Size = new System.Drawing.Size(67, 39);
			this.btL.TabIndex = 26;
			this.btL.Text = "L";
			this.btL.UseVisualStyleBackColor = false;
			this.btL.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btK
			// 
			this.btK.AutoSize = true;
			this.btK.BackColor = System.Drawing.Color.Honeydew;
			this.btK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btK.Location = new System.Drawing.Point(30, 87);
			this.btK.Name = "btK";
			this.btK.Size = new System.Drawing.Size(67, 39);
			this.btK.TabIndex = 25;
			this.btK.Text = "K";
			this.btK.UseVisualStyleBackColor = false;
			this.btK.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btZ
			// 
			this.btZ.AutoSize = true;
			this.btZ.BackColor = System.Drawing.Color.Honeydew;
			this.btZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btZ.Location = new System.Drawing.Point(541, 149);
			this.btZ.Name = "btZ";
			this.btZ.Size = new System.Drawing.Size(67, 39);
			this.btZ.TabIndex = 40;
			this.btZ.Text = "Z";
			this.btZ.UseVisualStyleBackColor = false;
			this.btZ.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btY
			// 
			this.btY.AutoSize = true;
			this.btY.BackColor = System.Drawing.Color.Honeydew;
			this.btY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btY.Location = new System.Drawing.Point(468, 149);
			this.btY.Name = "btY";
			this.btY.Size = new System.Drawing.Size(67, 39);
			this.btY.TabIndex = 39;
			this.btY.Text = "Y";
			this.btY.UseVisualStyleBackColor = false;
			this.btY.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btX
			// 
			this.btX.AutoSize = true;
			this.btX.BackColor = System.Drawing.Color.Honeydew;
			this.btX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btX.Location = new System.Drawing.Point(395, 149);
			this.btX.Name = "btX";
			this.btX.Size = new System.Drawing.Size(67, 39);
			this.btX.TabIndex = 38;
			this.btX.Text = "X";
			this.btX.UseVisualStyleBackColor = false;
			this.btX.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btW
			// 
			this.btW.AutoSize = true;
			this.btW.BackColor = System.Drawing.Color.Honeydew;
			this.btW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btW.Location = new System.Drawing.Point(322, 149);
			this.btW.Name = "btW";
			this.btW.Size = new System.Drawing.Size(67, 39);
			this.btW.TabIndex = 37;
			this.btW.Text = "W";
			this.btW.UseVisualStyleBackColor = false;
			this.btW.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btV
			// 
			this.btV.AutoSize = true;
			this.btV.BackColor = System.Drawing.Color.Honeydew;
			this.btV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btV.Location = new System.Drawing.Point(249, 149);
			this.btV.Name = "btV";
			this.btV.Size = new System.Drawing.Size(67, 39);
			this.btV.TabIndex = 36;
			this.btV.Text = "V";
			this.btV.UseVisualStyleBackColor = false;
			this.btV.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// btU
			// 
			this.btU.AutoSize = true;
			this.btU.BackColor = System.Drawing.Color.Honeydew;
			this.btU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btU.Location = new System.Drawing.Point(176, 149);
			this.btU.Name = "btU";
			this.btU.Size = new System.Drawing.Size(67, 39);
			this.btU.TabIndex = 35;
			this.btU.Text = "U";
			this.btU.UseVisualStyleBackColor = false;
			this.btU.Click += new System.EventHandler(this.Botao_clicado);
			// 
			// pnTeclado
			// 
			this.pnTeclado.BackColor = System.Drawing.Color.Transparent;
			this.pnTeclado.Controls.Add(this.btLimpar);
			this.pnTeclado.Controls.Add(this.btZ);
			this.pnTeclado.Controls.Add(this.btY);
			this.pnTeclado.Controls.Add(this.btX);
			this.pnTeclado.Controls.Add(this.btW);
			this.pnTeclado.Controls.Add(this.btV);
			this.pnTeclado.Controls.Add(this.btU);
			this.pnTeclado.Controls.Add(this.btT);
			this.pnTeclado.Controls.Add(this.btS);
			this.pnTeclado.Controls.Add(this.btR);
			this.pnTeclado.Controls.Add(this.btQ);
			this.pnTeclado.Controls.Add(this.btP);
			this.pnTeclado.Controls.Add(this.btO);
			this.pnTeclado.Controls.Add(this.btN);
			this.pnTeclado.Controls.Add(this.btM);
			this.pnTeclado.Controls.Add(this.btL);
			this.pnTeclado.Controls.Add(this.btK);
			this.pnTeclado.Controls.Add(this.btJ);
			this.pnTeclado.Controls.Add(this.btI);
			this.pnTeclado.Controls.Add(this.btH);
			this.pnTeclado.Controls.Add(this.btG);
			this.pnTeclado.Controls.Add(this.btF);
			this.pnTeclado.Controls.Add(this.btE);
			this.pnTeclado.Controls.Add(this.btD);
			this.pnTeclado.Controls.Add(this.btC);
			this.pnTeclado.Controls.Add(this.btB);
			this.pnTeclado.Controls.Add(this.btA);
			this.pnTeclado.Location = new System.Drawing.Point(499, 407);
			this.pnTeclado.Name = "pnTeclado";
			this.pnTeclado.Size = new System.Drawing.Size(786, 219);
			this.pnTeclado.TabIndex = 41;
			// 
			// btLimpar
			// 
			this.btLimpar.AutoSize = true;
			this.btLimpar.BackColor = System.Drawing.Color.Honeydew;
			this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLimpar.Location = new System.Drawing.Point(13, 166);
			this.btLimpar.Name = "btLimpar";
			this.btLimpar.Size = new System.Drawing.Size(105, 39);
			this.btLimpar.TabIndex = 42;
			this.btLimpar.Text = "Limpar";
			this.btLimpar.UseVisualStyleBackColor = false;
			this.btLimpar.Click += new System.EventHandler(this.BtLimparClick);
			// 
			// btEsconder
			// 
			this.btEsconder.AutoSize = true;
			this.btEsconder.BackColor = System.Drawing.Color.Honeydew;
			this.btEsconder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btEsconder.Location = new System.Drawing.Point(82, 79);
			this.btEsconder.Name = "btEsconder";
			this.btEsconder.Size = new System.Drawing.Size(228, 39);
			this.btEsconder.TabIndex = 41;
			this.btEsconder.Text = "Esconder Palavra";
			this.btEsconder.UseVisualStyleBackColor = false;
			this.btEsconder.Click += new System.EventHandler(this.BtEsconderClick);
			// 
			// pnEsconder
			// 
			this.pnEsconder.BackColor = System.Drawing.Color.Transparent;
			this.pnEsconder.Controls.Add(this.btEsconder);
			this.pnEsconder.Controls.Add(this.txtPalavra);
			this.pnEsconder.Controls.Add(this.lbPalavra);
			this.pnEsconder.Location = new System.Drawing.Point(688, 207);
			this.pnEsconder.Name = "pnEsconder";
			this.pnEsconder.Size = new System.Drawing.Size(392, 145);
			this.pnEsconder.TabIndex = 42;
			// 
			// lbPalavra
			// 
			this.lbPalavra.AutoSize = true;
			this.lbPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPalavra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbPalavra.Location = new System.Drawing.Point(82, 20);
			this.lbPalavra.Name = "lbPalavra";
			this.lbPalavra.Size = new System.Drawing.Size(35, 37);
			this.lbPalavra.TabIndex = 42;
			this.lbPalavra.Text = "?";
			this.lbPalavra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Sylfaen", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Orange;
			this.label1.Location = new System.Drawing.Point(258, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(814, 126);
			this.label1.TabIndex = 43;
			this.label1.Text = "JOGO DA FORCA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btIniciar
			// 
			this.btIniciar.BackColor = System.Drawing.Color.Gold;
			this.btIniciar.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btIniciar.Location = new System.Drawing.Point(464, 309);
			this.btIniciar.Name = "btIniciar";
			this.btIniciar.Size = new System.Drawing.Size(386, 148);
			this.btIniciar.TabIndex = 44;
			this.btIniciar.Text = "INICIAR";
			this.btIniciar.UseVisualStyleBackColor = false;
			this.btIniciar.Click += new System.EventHandler(this.BtIniciarClick);
			// 
			// btSair
			// 
			this.btSair.BackColor = System.Drawing.Color.Gold;
			this.btSair.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSair.Location = new System.Drawing.Point(39, 35);
			this.btSair.Name = "btSair";
			this.btSair.Size = new System.Drawing.Size(128, 49);
			this.btSair.TabIndex = 46;
			this.btSair.Text = "SAIR";
			this.btSair.UseVisualStyleBackColor = false;
			this.btSair.Click += new System.EventHandler(this.BtSairClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1344, 657);
			this.Controls.Add(this.btSair);
			this.Controls.Add(this.btIniciar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnEsconder);
			this.Controls.Add(this.pnTeclado);
			this.Controls.Add(this.pbForca);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "forca_legal";
			((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
			this.pnTeclado.ResumeLayout(false);
			this.pnTeclado.PerformLayout();
			this.pnEsconder.ResumeLayout(false);
			this.pnEsconder.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
