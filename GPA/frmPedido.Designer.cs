namespace Formularios
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            lbPedidos = new Label();
            txtNumeroPedido = new TextBox();
            txtEmpresa = new TextBox();
            txtNumPedExterno = new TextBox();
            lbNumeroPedido = new Label();
            labEmpresa = new Label();
            labNumPedExterno = new Label();
            lbDataSolicitacao = new Label();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            cmdUltVenda = new Button();
            cmdOcorrencias = new Button();
            cmdItensPedido = new Button();
            cmdCadCliente = new Button();
            txtxNatOperacao = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            labDescEndereco = new Label();
            labDescCEP = new Label();
            labDescNumero = new Label();
            labDescCNPJ = new Label();
            labDescUltCompra = new Label();
            label15 = new Label();
            labDescVlrUltCompra = new Label();
            txtObservacao = new TextBox();
            label17 = new Label();
            txtTotalItens = new TextBox();
            txtTotalFaturando = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            textBox10 = new TextBox();
            label21 = new Label();
            textBox11 = new TextBox();
            cmdExcluir = new Button();
            cmdNovo = new Button();
            cmdGravar = new Button();
            cmdSair = new Button();
            labVendedor = new Label();
            txtVendedor = new TextBox();
            chkConcluido = new CheckBox();
            txtDataConfirmacao = new MaskedTextBox();
            txtDataSolicitacao = new MaskedTextBox();
            cmdImprimir = new Button();
            txtValidadeProposta = new MaskedTextBox();
            labValidadeProp = new Label();
            labFatMinimo = new Label();
            txtFatMinimo = new TextBox();
            SuspendLayout();
            // 
            // lbPedidos
            // 
            lbPedidos.BorderStyle = BorderStyle.Fixed3D;
            lbPedidos.Cursor = Cursors.IBeam;
            lbPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbPedidos.ForeColor = Color.Black;
            lbPedidos.Location = new Point(12, 9);
            lbPedidos.Name = "lbPedidos";
            lbPedidos.Size = new Size(597, 30);
            lbPedidos.TabIndex = 2;
            lbPedidos.Text = "Pedido Saida";
            lbPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Location = new Point(12, 61);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(100, 23);
            txtNumeroPedido.TabIndex = 3;
            txtNumeroPedido.KeyDown += txtNumeroPedido_KeyDown;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(118, 61);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(549, 23);
            txtEmpresa.TabIndex = 4;
            txtEmpresa.KeyDown += txtEmpresa_KeyDown;
            // 
            // txtNumPedExterno
            // 
            txtNumPedExterno.Location = new Point(674, 61);
            txtNumPedExterno.Name = "txtNumPedExterno";
            txtNumPedExterno.Size = new Size(114, 23);
            txtNumPedExterno.TabIndex = 5;
            // 
            // lbNumeroPedido
            // 
            lbNumeroPedido.AutoSize = true;
            lbNumeroPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumeroPedido.Location = new Point(12, 43);
            lbNumeroPedido.Name = "lbNumeroPedido";
            lbNumeroPedido.Size = new Size(77, 15);
            lbNumeroPedido.TabIndex = 6;
            lbNumeroPedido.Text = "Numero - F1";
            // 
            // labEmpresa
            // 
            labEmpresa.AutoSize = true;
            labEmpresa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labEmpresa.Location = new Point(118, 43);
            labEmpresa.Name = "labEmpresa";
            labEmpresa.Size = new Size(78, 15);
            labEmpresa.TabIndex = 7;
            labEmpresa.Text = "Empresa - F1";
            // 
            // labNumPedExterno
            // 
            labNumPedExterno.AutoSize = true;
            labNumPedExterno.Location = new Point(688, 43);
            labNumPedExterno.Name = "labNumPedExterno";
            labNumPedExterno.Size = new Size(87, 15);
            labNumPedExterno.TabIndex = 8;
            labNumPedExterno.Text = "Pedido Externo";
            // 
            // lbDataSolicitacao
            // 
            lbDataSolicitacao.AutoSize = true;
            lbDataSolicitacao.Location = new Point(12, 157);
            lbDataSolicitacao.Name = "lbDataSolicitacao";
            lbDataSolicitacao.Size = new Size(91, 15);
            lbDataSolicitacao.TabIndex = 10;
            lbDataSolicitacao.Text = "Data Solicitação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 157);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 12;
            label1.Text = "Data Confirmação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(454, 96);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 13;
            label4.Text = "Data Ultima Compra: ";
            // 
            // button1
            // 
            button1.Location = new Point(659, 176);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmdUltVenda
            // 
            cmdUltVenda.Location = new Point(674, 96);
            cmdUltVenda.Name = "cmdUltVenda";
            cmdUltVenda.Size = new Size(114, 23);
            cmdUltVenda.TabIndex = 15;
            cmdUltVenda.Text = "Ultimas Compras";
            cmdUltVenda.UseVisualStyleBackColor = true;
            cmdUltVenda.Click += cmdUltVenda_Click;
            // 
            // cmdOcorrencias
            // 
            cmdOcorrencias.Location = new Point(674, 138);
            cmdOcorrencias.Name = "cmdOcorrencias";
            cmdOcorrencias.Size = new Size(114, 23);
            cmdOcorrencias.TabIndex = 16;
            cmdOcorrencias.Text = "Ocorrencias";
            cmdOcorrencias.UseVisualStyleBackColor = true;
            cmdOcorrencias.Click += cmdOcorrencias_Click;
            // 
            // cmdItensPedido
            // 
            cmdItensPedido.Location = new Point(673, 415);
            cmdItensPedido.Name = "cmdItensPedido";
            cmdItensPedido.Size = new Size(115, 23);
            cmdItensPedido.TabIndex = 17;
            cmdItensPedido.Text = "Itens Pedido";
            cmdItensPedido.UseVisualStyleBackColor = true;
            cmdItensPedido.Click += cmdItensPedido_Click;
            // 
            // cmdCadCliente
            // 
            cmdCadCliente.Location = new Point(674, 176);
            cmdCadCliente.Name = "cmdCadCliente";
            cmdCadCliente.Size = new Size(114, 23);
            cmdCadCliente.TabIndex = 18;
            cmdCadCliente.Text = "Dados Cliente";
            cmdCadCliente.UseVisualStyleBackColor = true;
            cmdCadCliente.Visible = false;
            // 
            // txtxNatOperacao
            // 
            txtxNatOperacao.Location = new Point(237, 175);
            txtxNatOperacao.Name = "txtxNatOperacao";
            txtxNatOperacao.Size = new Size(430, 23);
            txtxNatOperacao.TabIndex = 19;
            txtxNatOperacao.KeyDown += txtxNatOperacao_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 157);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 20;
            label5.Text = "Natureza da Operação - F1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(296, 96);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 21;
            label6.Text = "CNPJ/CPF: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 96);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 22;
            label7.Text = "Endereço: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 118);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 23;
            label8.Text = "CEP: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(118, 118);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 24;
            label9.Text = "Numero: ";
            // 
            // labDescEndereco
            // 
            labDescEndereco.AutoSize = true;
            labDescEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescEndereco.Location = new Point(83, 96);
            labDescEndereco.Name = "labDescEndereco";
            labDescEndereco.Size = new Size(203, 15);
            labDescEndereco.TabIndex = 25;
            labDescEndereco.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // labDescCEP
            // 
            labDescCEP.AutoSize = true;
            labDescCEP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescCEP.Location = new Point(44, 118);
            labDescCEP.Name = "labDescCEP";
            labDescCEP.Size = new Size(49, 15);
            labDescCEP.TabIndex = 26;
            labDescCEP.Text = "xxxxxx";
            // 
            // labDescNumero
            // 
            labDescNumero.AutoSize = true;
            labDescNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescNumero.Location = new Point(183, 118);
            labDescNumero.Name = "labDescNumero";
            labDescNumero.Size = new Size(49, 15);
            labDescNumero.TabIndex = 27;
            labDescNumero.Text = "xxxxxx";
            // 
            // labDescCNPJ
            // 
            labDescCNPJ.AutoSize = true;
            labDescCNPJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescCNPJ.Location = new Point(357, 96);
            labDescCNPJ.Name = "labDescCNPJ";
            labDescCNPJ.Size = new Size(91, 15);
            labDescCNPJ.TabIndex = 28;
            labDescCNPJ.Text = "xxxxxxxxxxxx";
            // 
            // labDescUltCompra
            // 
            labDescUltCompra.AutoSize = true;
            labDescUltCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescUltCompra.Location = new Point(585, 96);
            labDescUltCompra.Name = "labDescUltCompra";
            labDescUltCompra.Size = new Size(49, 15);
            labDescUltCompra.TabIndex = 29;
            labDescUltCompra.Text = "xxxxxx";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(454, 118);
            label15.Name = "label15";
            label15.Size = new Size(127, 15);
            label15.TabIndex = 30;
            label15.Text = "Valor Ultima Compra: ";
            // 
            // labDescVlrUltCompra
            // 
            labDescVlrUltCompra.AutoSize = true;
            labDescVlrUltCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labDescVlrUltCompra.Location = new Point(587, 118);
            labDescVlrUltCompra.Name = "labDescVlrUltCompra";
            labDescVlrUltCompra.Size = new Size(49, 15);
            labDescVlrUltCompra.TabIndex = 31;
            labDescVlrUltCompra.Text = "xxxxxx";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(12, 300);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(655, 184);
            txtObservacao.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(11, 280);
            label17.Name = "label17";
            label17.Size = new Size(78, 15);
            label17.TabIndex = 33;
            label17.Text = "Observações";
            // 
            // txtTotalItens
            // 
            txtTotalItens.Location = new Point(675, 254);
            txtTotalItens.Name = "txtTotalItens";
            txtTotalItens.ReadOnly = true;
            txtTotalItens.Size = new Size(113, 23);
            txtTotalItens.TabIndex = 34;
            // 
            // txtTotalFaturando
            // 
            txtTotalFaturando.Location = new Point(675, 298);
            txtTotalFaturando.Name = "txtTotalFaturando";
            txtTotalFaturando.ReadOnly = true;
            txtTotalFaturando.Size = new Size(113, 23);
            txtTotalFaturando.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(677, 236);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 36;
            label18.Text = "Total Itens";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(677, 280);
            label19.Name = "label19";
            label19.Size = new Size(63, 15);
            label19.TabIndex = 37;
            label19.Text = "Faturando";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(677, 321);
            label20.Name = "label20";
            label20.Size = new Size(58, 15);
            label20.TabIndex = 39;
            label20.Text = "Impostos";
            label20.Visible = false;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(675, 339);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(113, 23);
            textBox10.TabIndex = 38;
            textBox10.Visible = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(675, 368);
            label21.Name = "label21";
            label21.Size = new Size(58, 15);
            label21.TabIndex = 41;
            label21.Text = "Comissão";
            label21.Visible = false;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(673, 386);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(113, 23);
            textBox11.TabIndex = 40;
            textBox11.Visible = false;
            // 
            // cmdExcluir
            // 
            cmdExcluir.BackgroundImage = (Image)resources.GetObject("cmdExcluir.BackgroundImage");
            cmdExcluir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdExcluir.Location = new Point(650, 9);
            cmdExcluir.Name = "cmdExcluir";
            cmdExcluir.Size = new Size(30, 30);
            cmdExcluir.TabIndex = 45;
            cmdExcluir.UseVisualStyleBackColor = true;
            cmdExcluir.Click += cmdExcluir_Click;
            // 
            // cmdNovo
            // 
            cmdNovo.BackgroundImage = Properties.Resources.folder;
            cmdNovo.BackgroundImageLayout = ImageLayout.Zoom;
            cmdNovo.Location = new Point(686, 9);
            cmdNovo.Name = "cmdNovo";
            cmdNovo.Size = new Size(30, 30);
            cmdNovo.TabIndex = 44;
            cmdNovo.UseVisualStyleBackColor = true;
            cmdNovo.Click += cmdNovo_Click;
            // 
            // cmdGravar
            // 
            cmdGravar.BackgroundImage = Properties.Resources.save;
            cmdGravar.BackgroundImageLayout = ImageLayout.Zoom;
            cmdGravar.Location = new Point(722, 9);
            cmdGravar.Name = "cmdGravar";
            cmdGravar.Size = new Size(30, 30);
            cmdGravar.TabIndex = 43;
            cmdGravar.UseVisualStyleBackColor = true;
            cmdGravar.Click += cmdGravar_Click;
            // 
            // cmdSair
            // 
            cmdSair.BackgroundImage = Properties.Resources.logout;
            cmdSair.BackgroundImageLayout = ImageLayout.Zoom;
            cmdSair.Location = new Point(758, 9);
            cmdSair.Name = "cmdSair";
            cmdSair.Size = new Size(30, 30);
            cmdSair.TabIndex = 42;
            cmdSair.UseVisualStyleBackColor = true;
            cmdSair.Click += cmdSair_Click;
            // 
            // labVendedor
            // 
            labVendedor.AutoSize = true;
            labVendedor.Location = new Point(567, 206);
            labVendedor.Name = "labVendedor";
            labVendedor.Size = new Size(57, 15);
            labVendedor.TabIndex = 47;
            labVendedor.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Enabled = false;
            txtVendedor.Location = new Point(567, 225);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(100, 23);
            txtVendedor.TabIndex = 46;
            // 
            // chkConcluido
            // 
            chkConcluido.AutoSize = true;
            chkConcluido.Location = new Point(12, 254);
            chkConcluido.Name = "chkConcluido";
            chkConcluido.Size = new Size(71, 19);
            chkConcluido.TabIndex = 48;
            chkConcluido.Text = "Concluir";
            chkConcluido.UseVisualStyleBackColor = true;
            // 
            // txtDataConfirmacao
            // 
            txtDataConfirmacao.Location = new Point(121, 177);
            txtDataConfirmacao.Mask = "00/00/0000";
            txtDataConfirmacao.Name = "txtDataConfirmacao";
            txtDataConfirmacao.Size = new Size(100, 23);
            txtDataConfirmacao.TabIndex = 49;
            txtDataConfirmacao.ValidatingType = typeof(DateTime);
            txtDataConfirmacao.Leave += txtDataConfirmacao_Leave;
            // 
            // txtDataSolicitacao
            // 
            txtDataSolicitacao.Location = new Point(12, 176);
            txtDataSolicitacao.Mask = "00/00/0000";
            txtDataSolicitacao.Name = "txtDataSolicitacao";
            txtDataSolicitacao.Size = new Size(100, 23);
            txtDataSolicitacao.TabIndex = 50;
            txtDataSolicitacao.ValidatingType = typeof(DateTime);
            txtDataSolicitacao.Leave += txtDataSolicitacao_Leave;
            // 
            // cmdImprimir
            // 
            cmdImprimir.BackgroundImage = (Image)resources.GetObject("cmdImprimir.BackgroundImage");
            cmdImprimir.BackgroundImageLayout = ImageLayout.Zoom;
            cmdImprimir.Location = new Point(614, 9);
            cmdImprimir.Name = "cmdImprimir";
            cmdImprimir.Size = new Size(30, 30);
            cmdImprimir.TabIndex = 51;
            cmdImprimir.UseVisualStyleBackColor = true;
            cmdImprimir.Click += cmdImprimir_Click;
            // 
            // txtValidadeProposta
            // 
            txtValidadeProposta.Location = new Point(12, 225);
            txtValidadeProposta.Mask = "00/00/0000";
            txtValidadeProposta.Name = "txtValidadeProposta";
            txtValidadeProposta.Size = new Size(100, 23);
            txtValidadeProposta.TabIndex = 53;
            txtValidadeProposta.ValidatingType = typeof(DateTime);
            // 
            // labValidadeProp
            // 
            labValidadeProp.AutoSize = true;
            labValidadeProp.Location = new Point(12, 206);
            labValidadeProp.Name = "labValidadeProp";
            labValidadeProp.Size = new Size(101, 15);
            labValidadeProp.TabIndex = 52;
            labValidadeProp.Text = "Validade Proposta";
            // 
            // labFatMinimo
            // 
            labFatMinimo.AutoSize = true;
            labFatMinimo.Location = new Point(121, 210);
            labFatMinimo.Name = "labFatMinimo";
            labFatMinimo.Size = new Size(120, 15);
            labFatMinimo.TabIndex = 55;
            labFatMinimo.Text = "Faturamento Minimo";
            // 
            // txtFatMinimo
            // 
            txtFatMinimo.Location = new Point(121, 228);
            txtFatMinimo.Name = "txtFatMinimo";
            txtFatMinimo.Size = new Size(120, 23);
            txtFatMinimo.TabIndex = 54;
            txtFatMinimo.KeyPress += txtFatMinimo_KeyPress;
            txtFatMinimo.Leave += txtFatMinimo_Leave;
            // 
            // frmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            ControlBox = false;
            Controls.Add(labFatMinimo);
            Controls.Add(txtFatMinimo);
            Controls.Add(txtValidadeProposta);
            Controls.Add(labValidadeProp);
            Controls.Add(cmdImprimir);
            Controls.Add(txtDataSolicitacao);
            Controls.Add(txtDataConfirmacao);
            Controls.Add(chkConcluido);
            Controls.Add(labVendedor);
            Controls.Add(txtVendedor);
            Controls.Add(cmdExcluir);
            Controls.Add(cmdNovo);
            Controls.Add(cmdGravar);
            Controls.Add(cmdSair);
            Controls.Add(label21);
            Controls.Add(textBox11);
            Controls.Add(label20);
            Controls.Add(textBox10);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(txtTotalFaturando);
            Controls.Add(txtTotalItens);
            Controls.Add(label17);
            Controls.Add(txtObservacao);
            Controls.Add(labDescVlrUltCompra);
            Controls.Add(label15);
            Controls.Add(labDescUltCompra);
            Controls.Add(labDescCNPJ);
            Controls.Add(labDescNumero);
            Controls.Add(labDescCEP);
            Controls.Add(labDescEndereco);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtxNatOperacao);
            Controls.Add(cmdCadCliente);
            Controls.Add(cmdItensPedido);
            Controls.Add(cmdOcorrencias);
            Controls.Add(cmdUltVenda);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lbDataSolicitacao);
            Controls.Add(labNumPedExterno);
            Controls.Add(labEmpresa);
            Controls.Add(lbNumeroPedido);
            Controls.Add(txtNumPedExterno);
            Controls.Add(txtEmpresa);
            Controls.Add(txtNumeroPedido);
            Controls.Add(lbPedidos);
            Name = "frmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedido";
            Load += Pedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPedidos;
        private TextBox txtNumeroPedido;
        private TextBox txtEmpresa;
        private TextBox txtNumPedExterno;
        private Label lbNumeroPedido;
        private Label labEmpresa;
        private Label labNumPedExterno;
        private Label lbDataSolicitacao;
        private Label label1;
        private Label label4;
        private Button button1;
        private Button cmdUltVenda;
        private Button cmdOcorrencias;
        private Button cmdItensPedido;
        private Button cmdCadCliente;
        private TextBox txtxNatOperacao;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label labDescEndereco;
        private Label labDescCEP;
        private Label labDescNumero;
        private Label labDescCNPJ;
        private Label labDescUltCompra;
        private Label label15;
        private Label labDescVlrUltCompra;
        private TextBox txtObservacao;
        private Label label17;
        private TextBox textBox8;
        private TextBox txtTotalFaturando;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox textBox10;
        private Label label21;
        private TextBox textBox11;
        private Button cmdExcluir;
        private Button cmdNovo;
        private Button cmdGravar;
        private Button cmdSair;
        private Label labVendedor;
        private TextBox txtVendedor;
        private TextBox txtTotalItens;
        private CheckBox chkConcluido;
        private MaskedTextBox txtDataConfirmacao;
        private MaskedTextBox txtDataSolicitacao;
        private Button cmdImprimir;
        private MaskedTextBox txtValidadeProposta;
        private Label labValidadeProp;
        private Label labFatMinimo;
        private TextBox txtFatMinimo;
    }
}