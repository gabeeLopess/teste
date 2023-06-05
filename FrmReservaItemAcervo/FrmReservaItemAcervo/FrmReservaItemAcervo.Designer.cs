namespace FrmReservaItemAcervo
{
	partial class FrmReservaItemAcervo
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservaItemAcervo));
			this.gridLayout = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTipoMovimento = new System.Windows.Forms.Label();
			this.lblSituacao = new System.Windows.Forms.Label();
			this.lblCodigoItem = new System.Windows.Forms.Label();
			this.txtCodigoItem = new System.Windows.Forms.TextBox();
			this.cbxSituacao = new System.Windows.Forms.ComboBox();
			this.cbxTipoMovimento = new System.Windows.Forms.ComboBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtNomeItem = new System.Windows.Forms.TextBox();
			this.btnSelecionarItemAcervo = new System.Windows.Forms.Button();
			this.txtTipoItem = new System.Windows.Forms.TextBox();
			this.lblTipoItem = new System.Windows.Forms.Label();
			this.lblNomeLeitor = new System.Windows.Forms.Label();
			this.lblCodLeitor = new System.Windows.Forms.Label();
			this.txtCodLeitor = new System.Windows.Forms.TextBox();
			this.txtLocalizacao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSelecionarLeitor = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpPrazoReserva = new System.Windows.Forms.DateTimePicker();
			this.lblNumExemplar = new System.Windows.Forms.Label();
			this.txtNumExemplar = new System.Windows.Forms.TextBox();
			this.lblSelecionarLeitor = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblSelecionarItemAcervo = new System.Windows.Forms.Label();
			this.txtNomeLeitor = new System.Windows.Forms.TextBox();
			this.colCodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNomeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSitucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDataRetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnLimpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridLayout
			// 
			this.gridLayout.AllowUserToAddRows = false;
			this.gridLayout.AllowUserToDeleteRows = false;
			this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridLayout.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridLayout.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodItem,
            this.colNomeItem,
            this.colSitucao,
            this.colLeitor,
            this.colDataReserva,
            this.colDataRetorno});
			this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gridLayout.Location = new System.Drawing.Point(6, 283);
			this.gridLayout.Margin = new System.Windows.Forms.Padding(4);
			this.gridLayout.Name = "gridLayout";
			this.gridLayout.ReadOnly = true;
			this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gridLayout.RowHeadersWidth = 51;
			this.gridLayout.Size = new System.Drawing.Size(1017, 351);
			this.gridLayout.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.Controls.Add(this.lblTipoMovimento);
			this.groupBox1.Controls.Add(this.lblSituacao);
			this.groupBox1.Controls.Add(this.lblCodigoItem);
			this.groupBox1.Controls.Add(this.txtCodigoItem);
			this.groupBox1.Controls.Add(this.cbxSituacao);
			this.groupBox1.Controls.Add(this.cbxTipoMovimento);
			this.groupBox1.Location = new System.Drawing.Point(6, 1);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(1017, 71);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// lblTipoMovimento
			// 
			this.lblTipoMovimento.AutoSize = true;
			this.lblTipoMovimento.Location = new System.Drawing.Point(632, 32);
			this.lblTipoMovimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTipoMovimento.Name = "lblTipoMovimento";
			this.lblTipoMovimento.Size = new System.Drawing.Size(104, 16);
			this.lblTipoMovimento.TabIndex = 2;
			this.lblTipoMovimento.Text = "Tipo Movimento";
			// 
			// lblSituacao
			// 
			this.lblSituacao.AutoSize = true;
			this.lblSituacao.Location = new System.Drawing.Point(295, 28);
			this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(60, 16);
			this.lblSituacao.TabIndex = 3;
			this.lblSituacao.Text = "Situação";
			// 
			// lblCodigoItem
			// 
			this.lblCodigoItem.AutoSize = true;
			this.lblCodigoItem.Location = new System.Drawing.Point(-4, 32);
			this.lblCodigoItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigoItem.Name = "lblCodigoItem";
			this.lblCodigoItem.Size = new System.Drawing.Size(79, 16);
			this.lblCodigoItem.TabIndex = 0;
			this.lblCodigoItem.Text = "Código Item";
			// 
			// txtCodigoItem
			// 
			this.txtCodigoItem.Location = new System.Drawing.Point(81, 28);
			this.txtCodigoItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigoItem.Multiline = true;
			this.txtCodigoItem.Name = "txtCodigoItem";
			this.txtCodigoItem.Size = new System.Drawing.Size(160, 25);
			this.txtCodigoItem.TabIndex = 1;
			this.txtCodigoItem.TextChanged += new System.EventHandler(this.txtCodigoItem_TextChanged);
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.Items.AddRange(new object[] {
            "Reservar",
            "Devolver"});
			this.cbxSituacao.Location = new System.Drawing.Point(387, 28);
			this.cbxSituacao.Margin = new System.Windows.Forms.Padding(4);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(228, 24);
			this.cbxSituacao.TabIndex = 1;
			this.cbxSituacao.SelectedIndexChanged += new System.EventHandler(this.cbxSituacao_SelectedIndexChanged);
			// 
			// cbxTipoMovimento
			// 
			this.cbxTipoMovimento.FormattingEnabled = true;
			this.cbxTipoMovimento.Items.AddRange(new object[] {
            "Reservar",
            "Devolver"});
			this.cbxTipoMovimento.Location = new System.Drawing.Point(788, 28);
			this.cbxTipoMovimento.Margin = new System.Windows.Forms.Padding(4);
			this.cbxTipoMovimento.Name = "cbxTipoMovimento";
			this.cbxTipoMovimento.Size = new System.Drawing.Size(228, 24);
			this.cbxTipoMovimento.TabIndex = 0;
			this.cbxTipoMovimento.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMovimento_SelectedIndexChanged);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(-3, 19);
			this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(72, 16);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome Item";
			// 
			// txtNomeItem
			// 
			this.txtNomeItem.Location = new System.Drawing.Point(81, 16);
			this.txtNomeItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtNomeItem.Multiline = true;
			this.txtNomeItem.Name = "txtNomeItem";
			this.txtNomeItem.Size = new System.Drawing.Size(533, 22);
			this.txtNomeItem.TabIndex = 3;
			// 
			// btnSelecionarItemAcervo
			// 
			this.btnSelecionarItemAcervo.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarItemAcervo.Image")));
			this.btnSelecionarItemAcervo.Location = new System.Drawing.Point(942, 119);
			this.btnSelecionarItemAcervo.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarItemAcervo.Name = "btnSelecionarItemAcervo";
			this.btnSelecionarItemAcervo.Size = new System.Drawing.Size(52, 23);
			this.btnSelecionarItemAcervo.TabIndex = 4;
			this.btnSelecionarItemAcervo.UseVisualStyleBackColor = true;
			this.btnSelecionarItemAcervo.Click += new System.EventHandler(this.btnSelecionarItemAcervo_Click);
			// 
			// txtTipoItem
			// 
			this.txtTipoItem.Location = new System.Drawing.Point(778, 16);
			this.txtTipoItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtTipoItem.Multiline = true;
			this.txtTipoItem.Name = "txtTipoItem";
			this.txtTipoItem.Size = new System.Drawing.Size(238, 22);
			this.txtTipoItem.TabIndex = 5;
			// 
			// lblTipoItem
			// 
			this.lblTipoItem.AutoSize = true;
			this.lblTipoItem.Location = new System.Drawing.Point(649, 22);
			this.lblTipoItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTipoItem.Name = "lblTipoItem";
			this.lblTipoItem.Size = new System.Drawing.Size(63, 16);
			this.lblTipoItem.TabIndex = 6;
			this.lblTipoItem.Text = "Tipo Item";
			// 
			// lblNomeLeitor
			// 
			this.lblNomeLeitor.AutoSize = true;
			this.lblNomeLeitor.Location = new System.Drawing.Point(-3, 92);
			this.lblNomeLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNomeLeitor.Name = "lblNomeLeitor";
			this.lblNomeLeitor.Size = new System.Drawing.Size(80, 16);
			this.lblNomeLeitor.TabIndex = 8;
			this.lblNomeLeitor.Text = "Nome Leitor";
			// 
			// lblCodLeitor
			// 
			this.lblCodLeitor.AutoSize = true;
			this.lblCodLeitor.Location = new System.Drawing.Point(649, 92);
			this.lblCodLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodLeitor.Name = "lblCodLeitor";
			this.lblCodLeitor.Size = new System.Drawing.Size(87, 16);
			this.lblCodLeitor.TabIndex = 11;
			this.lblCodLeitor.Text = "Código Leitor";
			// 
			// txtCodLeitor
			// 
			this.txtCodLeitor.Location = new System.Drawing.Point(778, 89);
			this.txtCodLeitor.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodLeitor.Multiline = true;
			this.txtCodLeitor.Name = "txtCodLeitor";
			this.txtCodLeitor.Size = new System.Drawing.Size(238, 22);
			this.txtCodLeitor.TabIndex = 12;
			// 
			// txtLocalizacao
			// 
			this.txtLocalizacao.Location = new System.Drawing.Point(81, 55);
			this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(4);
			this.txtLocalizacao.Multiline = true;
			this.txtLocalizacao.Name = "txtLocalizacao";
			this.txtLocalizacao.Size = new System.Drawing.Size(533, 22);
			this.txtLocalizacao.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-3, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Localização";
			// 
			// btnSelecionarLeitor
			// 
			this.btnSelecionarLeitor.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarLeitor.Image")));
			this.btnSelecionarLeitor.Location = new System.Drawing.Point(942, 150);
			this.btnSelecionarLeitor.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelecionarLeitor.Name = "btnSelecionarLeitor";
			this.btnSelecionarLeitor.Size = new System.Drawing.Size(52, 23);
			this.btnSelecionarLeitor.TabIndex = 16;
			this.btnSelecionarLeitor.UseVisualStyleBackColor = true;
			this.btnSelecionarLeitor.Click += new System.EventHandler(this.btnSelecionarLeitor_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(702, 181);
			this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(145, 25);
			this.btnSalvar.TabIndex = 21;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.dtpDataReserva);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.dtpPrazoReserva);
			this.groupBox3.Location = new System.Drawing.Point(81, 116);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(595, 100);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 25);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Data Reseva";
			// 
			// dtpDataReserva
			// 
			this.dtpDataReserva.Location = new System.Drawing.Point(164, 23);
			this.dtpDataReserva.Margin = new System.Windows.Forms.Padding(4);
			this.dtpDataReserva.Name = "dtpDataReserva";
			this.dtpDataReserva.Size = new System.Drawing.Size(317, 22);
			this.dtpDataReserva.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 63);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "Prazo Reserva";
			// 
			// dtpPrazoReserva
			// 
			this.dtpPrazoReserva.Location = new System.Drawing.Point(164, 63);
			this.dtpPrazoReserva.Margin = new System.Windows.Forms.Padding(4);
			this.dtpPrazoReserva.Name = "dtpPrazoReserva";
			this.dtpPrazoReserva.Size = new System.Drawing.Size(317, 22);
			this.dtpPrazoReserva.TabIndex = 20;
			// 
			// lblNumExemplar
			// 
			this.lblNumExemplar.AutoSize = true;
			this.lblNumExemplar.Location = new System.Drawing.Point(649, 53);
			this.lblNumExemplar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNumExemplar.Name = "lblNumExemplar";
			this.lblNumExemplar.Size = new System.Drawing.Size(95, 16);
			this.lblNumExemplar.TabIndex = 22;
			this.lblNumExemplar.Text = "Num Exemplar";
			// 
			// txtNumExemplar
			// 
			this.txtNumExemplar.Location = new System.Drawing.Point(778, 50);
			this.txtNumExemplar.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumExemplar.Multiline = true;
			this.txtNumExemplar.Name = "txtNumExemplar";
			this.txtNumExemplar.Size = new System.Drawing.Size(239, 22);
			this.txtNumExemplar.TabIndex = 23;
			// 
			// lblSelecionarLeitor
			// 
			this.lblSelecionarLeitor.AutoSize = true;
			this.lblSelecionarLeitor.Location = new System.Drawing.Point(804, 150);
			this.lblSelecionarLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelecionarLeitor.Name = "lblSelecionarLeitor";
			this.lblSelecionarLeitor.Size = new System.Drawing.Size(108, 16);
			this.lblSelecionarLeitor.TabIndex = 24;
			this.lblSelecionarLeitor.Text = "Selecionar Leitor";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.Controls.Add(this.btnLimpar);
			this.groupBox2.Controls.Add(this.lblSelecionarItemAcervo);
			this.groupBox2.Controls.Add(this.lblSelecionarLeitor);
			this.groupBox2.Controls.Add(this.txtNumExemplar);
			this.groupBox2.Controls.Add(this.lblNumExemplar);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.btnSalvar);
			this.groupBox2.Controls.Add(this.btnSelecionarLeitor);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtLocalizacao);
			this.groupBox2.Controls.Add(this.txtCodLeitor);
			this.groupBox2.Controls.Add(this.lblCodLeitor);
			this.groupBox2.Controls.Add(this.txtNomeLeitor);
			this.groupBox2.Controls.Add(this.lblNomeLeitor);
			this.groupBox2.Controls.Add(this.lblTipoItem);
			this.groupBox2.Controls.Add(this.txtTipoItem);
			this.groupBox2.Controls.Add(this.btnSelecionarItemAcervo);
			this.groupBox2.Controls.Add(this.txtNomeItem);
			this.groupBox2.Controls.Add(this.lblNome);
			this.groupBox2.Location = new System.Drawing.Point(6, 64);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1017, 224);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			// 
			// lblSelecionarItemAcervo
			// 
			this.lblSelecionarItemAcervo.AutoSize = true;
			this.lblSelecionarItemAcervo.Location = new System.Drawing.Point(804, 126);
			this.lblSelecionarItemAcervo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelecionarItemAcervo.Name = "lblSelecionarItemAcervo";
			this.lblSelecionarItemAcervo.Size = new System.Drawing.Size(100, 16);
			this.lblSelecionarItemAcervo.TabIndex = 25;
			this.lblSelecionarItemAcervo.Text = "Selecionar Item";
			this.lblSelecionarItemAcervo.Click += new System.EventHandler(this.lblSelecionarItemAcervo_Click);
			// 
			// txtNomeLeitor
			// 
			this.txtNomeLeitor.Location = new System.Drawing.Point(81, 90);
			this.txtNomeLeitor.Margin = new System.Windows.Forms.Padding(4);
			this.txtNomeLeitor.Multiline = true;
			this.txtNomeLeitor.Name = "txtNomeLeitor";
			this.txtNomeLeitor.Size = new System.Drawing.Size(533, 22);
			this.txtNomeLeitor.TabIndex = 9;
			// 
			// colCodItem
			// 
			this.colCodItem.HeaderText = "Id Item";
			this.colCodItem.MinimumWidth = 6;
			this.colCodItem.Name = "colCodItem";
			this.colCodItem.ReadOnly = true;
			// 
			// colNomeItem
			// 
			this.colNomeItem.HeaderText = "Item da Biblioteca";
			this.colNomeItem.MinimumWidth = 6;
			this.colNomeItem.Name = "colNomeItem";
			this.colNomeItem.ReadOnly = true;
			// 
			// colSitucao
			// 
			this.colSitucao.HeaderText = "Situação";
			this.colSitucao.MinimumWidth = 6;
			this.colSitucao.Name = "colSitucao";
			this.colSitucao.ReadOnly = true;
			// 
			// colLeitor
			// 
			this.colLeitor.HeaderText = "Leitor";
			this.colLeitor.MinimumWidth = 6;
			this.colLeitor.Name = "colLeitor";
			this.colLeitor.ReadOnly = true;
			// 
			// colDataReserva
			// 
			this.colDataReserva.HeaderText = "Data Reserva";
			this.colDataReserva.MinimumWidth = 6;
			this.colDataReserva.Name = "colDataReserva";
			this.colDataReserva.ReadOnly = true;
			// 
			// colDataRetorno
			// 
			this.colDataRetorno.HeaderText = "Data Retorno";
			this.colDataRetorno.MinimumWidth = 6;
			this.colDataRetorno.Name = "colDataRetorno";
			this.colDataRetorno.ReadOnly = true;
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(872, 181);
			this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(145, 25);
			this.btnLimpar.TabIndex = 26;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// FrmReservaItemAcervo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 635);
			this.Controls.Add(this.gridLayout);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmReservaItemAcervo";
			this.Text = "Reserva Item Acervo";
			this.Load += new System.EventHandler(this.FrmReservaItemAcervo_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView gridLayout;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblTipoMovimento;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.Label lblCodigoItem;
		private System.Windows.Forms.TextBox txtCodigoItem;
		private System.Windows.Forms.ComboBox cbxSituacao;
		private System.Windows.Forms.ComboBox cbxTipoMovimento;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtNomeItem;
		private System.Windows.Forms.Button btnSelecionarItemAcervo;
		private System.Windows.Forms.TextBox txtTipoItem;
		private System.Windows.Forms.Label lblTipoItem;
		private System.Windows.Forms.Label lblNomeLeitor;
		private System.Windows.Forms.Label lblCodLeitor;
		private System.Windows.Forms.TextBox txtCodLeitor;
		private System.Windows.Forms.TextBox txtLocalizacao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelecionarLeitor;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpDataReserva;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtpPrazoReserva;
		private System.Windows.Forms.Label lblNumExemplar;
		private System.Windows.Forms.TextBox txtNumExemplar;
		private System.Windows.Forms.Label lblSelecionarLeitor;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblSelecionarItemAcervo;
		private System.Windows.Forms.TextBox txtNomeLeitor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSitucao;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLeitor;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataReserva;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDataRetorno;
		private System.Windows.Forms.Button btnLimpar;
	}
}

