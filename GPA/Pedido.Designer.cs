namespace Formularios
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.lbPedidos = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNumPedExterno = new System.Windows.Forms.TextBox();
            this.lbNumeroPedido = new System.Windows.Forms.Label();
            this.labEmpresa = new System.Windows.Forms.Label();
            this.labNumPedExterno = new System.Windows.Forms.Label();
            this.txtDataSolicitacao = new System.Windows.Forms.TextBox();
            this.lbDataSolicitacao = new System.Windows.Forms.Label();
            this.txtDataConfirmacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdItensPedido = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtxNatOperacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labDescEndereco = new System.Windows.Forms.Label();
            this.labDescCEP = new System.Windows.Forms.Label();
            this.labDescNumero = new System.Windows.Forms.Label();
            this.labDescCNPJ = new System.Windows.Forms.Label();
            this.labDescUltCompra = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labDescVlrUltCompra = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdGravar = new System.Windows.Forms.Button();
            this.cmdSair = new System.Windows.Forms.Button();
            this.labVendedor = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbPedidos
            // 
            this.lbPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbPedidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPedidos.ForeColor = System.Drawing.Color.Black;
            this.lbPedidos.Location = new System.Drawing.Point(12, 9);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(632, 30);
            this.lbPedidos.TabIndex = 2;
            this.lbPedidos.Text = "Pedido Saida";
            this.lbPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(12, 61);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroPedido.TabIndex = 3;
            this.txtNumeroPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroPedido_KeyDown);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(118, 61);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(549, 23);
            this.txtEmpresa.TabIndex = 4;
            this.txtEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpresa_KeyDown);
            // 
            // txtNumPedExterno
            // 
            this.txtNumPedExterno.Location = new System.Drawing.Point(674, 61);
            this.txtNumPedExterno.Name = "txtNumPedExterno";
            this.txtNumPedExterno.Size = new System.Drawing.Size(114, 23);
            this.txtNumPedExterno.TabIndex = 5;
            // 
            // lbNumeroPedido
            // 
            this.lbNumeroPedido.AutoSize = true;
            this.lbNumeroPedido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumeroPedido.Location = new System.Drawing.Point(12, 43);
            this.lbNumeroPedido.Name = "lbNumeroPedido";
            this.lbNumeroPedido.Size = new System.Drawing.Size(77, 15);
            this.lbNumeroPedido.TabIndex = 6;
            this.lbNumeroPedido.Text = "Numero - F1";
            // 
            // labEmpresa
            // 
            this.labEmpresa.AutoSize = true;
            this.labEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labEmpresa.Location = new System.Drawing.Point(118, 43);
            this.labEmpresa.Name = "labEmpresa";
            this.labEmpresa.Size = new System.Drawing.Size(78, 15);
            this.labEmpresa.TabIndex = 7;
            this.labEmpresa.Text = "Empresa - F1";
            // 
            // labNumPedExterno
            // 
            this.labNumPedExterno.AutoSize = true;
            this.labNumPedExterno.Location = new System.Drawing.Point(688, 43);
            this.labNumPedExterno.Name = "labNumPedExterno";
            this.labNumPedExterno.Size = new System.Drawing.Size(87, 15);
            this.labNumPedExterno.TabIndex = 8;
            this.labNumPedExterno.Text = "Pedido Externo";
            // 
            // txtDataSolicitacao
            // 
            this.txtDataSolicitacao.Location = new System.Drawing.Point(12, 176);
            this.txtDataSolicitacao.Name = "txtDataSolicitacao";
            this.txtDataSolicitacao.Size = new System.Drawing.Size(100, 23);
            this.txtDataSolicitacao.TabIndex = 9;
            // 
            // lbDataSolicitacao
            // 
            this.lbDataSolicitacao.AutoSize = true;
            this.lbDataSolicitacao.Location = new System.Drawing.Point(12, 157);
            this.lbDataSolicitacao.Name = "lbDataSolicitacao";
            this.lbDataSolicitacao.Size = new System.Drawing.Size(91, 15);
            this.lbDataSolicitacao.TabIndex = 10;
            this.lbDataSolicitacao.Text = "Data Solicitação";
            // 
            // txtDataConfirmacao
            // 
            this.txtDataConfirmacao.Location = new System.Drawing.Point(118, 175);
            this.txtDataConfirmacao.Name = "txtDataConfirmacao";
            this.txtDataConfirmacao.Size = new System.Drawing.Size(100, 23);
            this.txtDataConfirmacao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Confirmação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(454, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data Ultima Compra: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ultimas Compras";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(674, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ocorrencias";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmdItensPedido
            // 
            this.cmdItensPedido.Location = new System.Drawing.Point(673, 415);
            this.cmdItensPedido.Name = "cmdItensPedido";
            this.cmdItensPedido.Size = new System.Drawing.Size(115, 23);
            this.cmdItensPedido.TabIndex = 17;
            this.cmdItensPedido.Text = "Itens Pedido";
            this.cmdItensPedido.UseVisualStyleBackColor = true;
            this.cmdItensPedido.Click += new System.EventHandler(this.cmdItensPedido_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(674, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Dados Cliente";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtxNatOperacao
            // 
            this.txtxNatOperacao.Location = new System.Drawing.Point(237, 175);
            this.txtxNatOperacao.Name = "txtxNatOperacao";
            this.txtxNatOperacao.Size = new System.Drawing.Size(430, 23);
            this.txtxNatOperacao.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Natureza da Operação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(296, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "CNPJ/CPF: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Endereço: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "CEP: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(118, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Numero: ";
            // 
            // labDescEndereco
            // 
            this.labDescEndereco.AutoSize = true;
            this.labDescEndereco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescEndereco.Location = new System.Drawing.Point(83, 96);
            this.labDescEndereco.Name = "labDescEndereco";
            this.labDescEndereco.Size = new System.Drawing.Size(203, 15);
            this.labDescEndereco.TabIndex = 25;
            this.labDescEndereco.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // labDescCEP
            // 
            this.labDescCEP.AutoSize = true;
            this.labDescCEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescCEP.Location = new System.Drawing.Point(44, 118);
            this.labDescCEP.Name = "labDescCEP";
            this.labDescCEP.Size = new System.Drawing.Size(49, 15);
            this.labDescCEP.TabIndex = 26;
            this.labDescCEP.Text = "xxxxxx";
            // 
            // labDescNumero
            // 
            this.labDescNumero.AutoSize = true;
            this.labDescNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescNumero.Location = new System.Drawing.Point(183, 118);
            this.labDescNumero.Name = "labDescNumero";
            this.labDescNumero.Size = new System.Drawing.Size(49, 15);
            this.labDescNumero.TabIndex = 27;
            this.labDescNumero.Text = "xxxxxx";
            // 
            // labDescCNPJ
            // 
            this.labDescCNPJ.AutoSize = true;
            this.labDescCNPJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescCNPJ.Location = new System.Drawing.Point(357, 96);
            this.labDescCNPJ.Name = "labDescCNPJ";
            this.labDescCNPJ.Size = new System.Drawing.Size(91, 15);
            this.labDescCNPJ.TabIndex = 28;
            this.labDescCNPJ.Text = "xxxxxxxxxxxx";
            // 
            // labDescUltCompra
            // 
            this.labDescUltCompra.AutoSize = true;
            this.labDescUltCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescUltCompra.Location = new System.Drawing.Point(585, 96);
            this.labDescUltCompra.Name = "labDescUltCompra";
            this.labDescUltCompra.Size = new System.Drawing.Size(49, 15);
            this.labDescUltCompra.TabIndex = 29;
            this.labDescUltCompra.Text = "xxxxxx";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(454, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "Valor Ultima Compra: ";
            // 
            // labDescVlrUltCompra
            // 
            this.labDescVlrUltCompra.AutoSize = true;
            this.labDescVlrUltCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labDescVlrUltCompra.Location = new System.Drawing.Point(587, 118);
            this.labDescVlrUltCompra.Name = "labDescVlrUltCompra";
            this.labDescVlrUltCompra.Size = new System.Drawing.Size(49, 15);
            this.labDescVlrUltCompra.TabIndex = 31;
            this.labDescVlrUltCompra.Text = "xxxxxx";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 254);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(655, 184);
            this.txtObservacao.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(15, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Observações";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(675, 254);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(113, 23);
            this.textBox8.TabIndex = 34;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(675, 298);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(113, 23);
            this.textBox9.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(677, 236);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "Total Itens";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(677, 280);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 37;
            this.label19.Text = "Faturando";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(677, 321);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 15);
            this.label20.TabIndex = 39;
            this.label20.Text = "Impostos";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(675, 339);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(113, 23);
            this.textBox10.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(675, 368);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 15);
            this.label21.TabIndex = 41;
            this.label21.Text = "Comissão";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(673, 386);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(113, 23);
            this.textBox11.TabIndex = 40;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcluir.BackgroundImage")));
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.Location = new System.Drawing.Point(650, 9);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(30, 30);
            this.cmdExcluir.TabIndex = 45;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackgroundImage = global::Formularios.Properties.Resources.folder;
            this.cmdNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdNovo.Location = new System.Drawing.Point(686, 9);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(30, 30);
            this.cmdNovo.TabIndex = 44;
            this.cmdNovo.UseVisualStyleBackColor = true;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdGravar
            // 
            this.cmdGravar.BackgroundImage = global::Formularios.Properties.Resources.save;
            this.cmdGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdGravar.Location = new System.Drawing.Point(722, 9);
            this.cmdGravar.Name = "cmdGravar";
            this.cmdGravar.Size = new System.Drawing.Size(30, 30);
            this.cmdGravar.TabIndex = 43;
            this.cmdGravar.UseVisualStyleBackColor = true;
            this.cmdGravar.Click += new System.EventHandler(this.cmdGravar_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackgroundImage = global::Formularios.Properties.Resources.logout;
            this.cmdSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdSair.Location = new System.Drawing.Point(758, 9);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(30, 30);
            this.cmdSair.TabIndex = 42;
            this.cmdSair.UseVisualStyleBackColor = true;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // labVendedor
            // 
            this.labVendedor.AutoSize = true;
            this.labVendedor.Location = new System.Drawing.Point(567, 206);
            this.labVendedor.Name = "labVendedor";
            this.labVendedor.Size = new System.Drawing.Size(57, 15);
            this.labVendedor.TabIndex = 47;
            this.labVendedor.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(567, 225);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 23);
            this.txtVendedor.TabIndex = 46;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labVendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdNovo);
            this.Controls.Add(this.cmdGravar);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.labDescVlrUltCompra);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labDescUltCompra);
            this.Controls.Add(this.labDescCNPJ);
            this.Controls.Add(this.labDescNumero);
            this.Controls.Add(this.labDescCEP);
            this.Controls.Add(this.labDescEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtxNatOperacao);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cmdItensPedido);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataConfirmacao);
            this.Controls.Add(this.lbDataSolicitacao);
            this.Controls.Add(this.txtDataSolicitacao);
            this.Controls.Add(this.labNumPedExterno);
            this.Controls.Add(this.labEmpresa);
            this.Controls.Add(this.lbNumeroPedido);
            this.Controls.Add(this.txtNumPedExterno);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.lbPedidos);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbPedidos;
        private TextBox txtNumeroPedido;
        private TextBox txtEmpresa;
        private TextBox txtNumPedExterno;
        private Label lbNumeroPedido;
        private Label labEmpresa;
        private Label labNumPedExterno;
        private TextBox txtDataSolicitacao;
        private Label lbDataSolicitacao;
        private TextBox txtDataConfirmacao;
        private Label label1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button cmdItensPedido;
        private Button button5;
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
        private TextBox textBox9;
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
    }
}