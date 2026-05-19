namespace Tela1_Acesso
{
    partial class Orçamentos
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orçamentos));
            label2 = new Label();
            dgvListadeServicos = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Servico = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label9 = new Label();
            LbOrçamentos = new Label();
            lbAgenda = new Label();
            obOrcamento = new PictureBox();
            pbAgenda = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pbHome = new PictureBox();
            btnSair = new Button();
            lbClientes = new Label();
            pbClientes = new PictureBox();
            label13 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnEmitirComprovante = new Button();
            pbOrcamento = new PictureBox();
            label8 = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            btnAdicionarOrçamento = new Button();
            cbClientes = new ComboBox();
            btnAlterarOrçamento = new Button();
            btnExcluirOrçamento = new Button();
            pnlAlterarOrçamento = new Panel();
            lblServiço = new Label();
            lblCliente = new Label();
            btnCancelarAlteracao = new Button();
            btnSalvarAlteracao = new Button();
            txtAlterarCelular = new TextBox();
            txtAlterarNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListadeServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obOrcamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAgenda).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOrcamento).BeginInit();
            pnlAlterarOrçamento.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(492, 51);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 49;
            label2.Text = "Orçamento";
            // 
            // dgvListadeServicos
            // 
            dgvListadeServicos.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvListadeServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadeServicos.Columns.AddRange(new DataGridViewColumn[] { Data, Servico, Valor, Status });
            dgvListadeServicos.Enabled = false;
            dgvListadeServicos.EnableHeadersVisualStyles = false;
            dgvListadeServicos.Location = new Point(431, 287);
            dgvListadeServicos.Name = "dgvListadeServicos";
            dgvListadeServicos.RowHeadersVisible = false;
            dgvListadeServicos.Size = new Size(929, 325);
            dgvListadeServicos.TabIndex = 66;
            // 
            // Data
            // 
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle5.SelectionForeColor = Color.Orange;
            Data.DefaultCellStyle = dataGridViewCellStyle5;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Servico
            // 
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle6.SelectionForeColor = Color.Orange;
            Servico.DefaultCellStyle = dataGridViewCellStyle6;
            Servico.HeaderText = "Servico";
            Servico.Name = "Servico";
            // 
            // Valor
            // 
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle7.SelectionForeColor = Color.Orange;
            Valor.DefaultCellStyle = dataGridViewCellStyle7;
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Status
            // 
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle8.SelectionForeColor = Color.Orange;
            Status.DefaultCellStyle = dataGridViewCellStyle8;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(431, 241);
            label9.Name = "label9";
            label9.Size = new Size(150, 25);
            label9.TabIndex = 76;
            label9.Text = "Listas de Serviços";
            // 
            // LbOrçamentos
            // 
            LbOrçamentos.AutoSize = true;
            LbOrçamentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbOrçamentos.ForeColor = Color.DarkOrange;
            LbOrçamentos.Location = new Point(84, 438);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(92, 21);
            LbOrçamentos.TabIndex = 100;
            LbOrçamentos.Text = "Orçamento";
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgenda.ForeColor = SystemColors.ButtonFace;
            lbAgenda.Location = new Point(84, 346);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(67, 21);
            lbAgenda.TabIndex = 103;
            lbAgenda.Text = "Agenda";
            // 
            // obOrcamento
            // 
            obOrcamento.ErrorImage = null;
            obOrcamento.Image = (Image)resources.GetObject("obOrcamento.Image");
            obOrcamento.Location = new Point(24, 414);
            obOrcamento.Name = "obOrcamento";
            obOrcamento.Size = new Size(63, 57);
            obOrcamento.SizeMode = PictureBoxSizeMode.Zoom;
            obOrcamento.TabIndex = 104;
            obOrcamento.TabStop = false;
            // 
            // pbAgenda
            // 
            pbAgenda.Cursor = Cursors.Hand;
            pbAgenda.ErrorImage = null;
            pbAgenda.Image = (Image)resources.GetObject("pbAgenda.Image");
            pbAgenda.Location = new Point(24, 322);
            pbAgenda.Name = "pbAgenda";
            pbAgenda.Size = new Size(72, 66);
            pbAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            pbAgenda.TabIndex = 106;
            pbAgenda.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(LbOrçamentos);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pbHome);
            panel3.Controls.Add(obOrcamento);
            panel3.Controls.Add(lbAgenda);
            panel3.Controls.Add(btnSair);
            panel3.Controls.Add(pbAgenda);
            panel3.Controls.Add(lbClientes);
            panel3.Controls.Add(pbClientes);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 622);
            panel3.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(97, 550);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 98;
            label1.Text = "Sair";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 527);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // pbHome
            // 
            pbHome.Cursor = Cursors.Hand;
            pbHome.Image = (Image)resources.GetObject("pbHome.Image");
            pbHome.Location = new Point(24, 174);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(63, 56);
            pbHome.SizeMode = PictureBoxSizeMode.Zoom;
            pbHome.TabIndex = 99;
            pbHome.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.OrangeRed;
            btnSair.ForeColor = SystemColors.Control;
            btnSair.Location = new Point(2347, 603);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 94;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // lbClientes
            // 
            lbClientes.AutoSize = true;
            lbClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes.ForeColor = Color.AliceBlue;
            lbClientes.Location = new Point(84, 271);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(61, 21);
            lbClientes.TabIndex = 87;
            lbClientes.Text = "Cliente";
            // 
            // pbClientes
            // 
            pbClientes.Cursor = Cursors.Hand;
            pbClientes.ErrorImage = null;
            pbClientes.Image = (Image)resources.GetObject("pbClientes.Image");
            pbClientes.Location = new Point(24, 253);
            pbClientes.Name = "pbClientes";
            pbClientes.Size = new Size(63, 46);
            pbClientes.SizeMode = PictureBoxSizeMode.Zoom;
            pbClientes.TabIndex = 90;
            pbClientes.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SeaShell;
            label13.Location = new Point(84, 201);
            label13.Name = "label13";
            label13.Size = new Size(55, 21);
            label13.TabIndex = 86;
            label13.Text = "Home";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-4, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(264, 228);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 107;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(431, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 89;
            pictureBox3.TabStop = false;
            // 
            // btnEmitirComprovante
            // 
            btnEmitirComprovante.BackColor = Color.DarkOrange;
            btnEmitirComprovante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprovante.Font = new Font("Segoe UI", 10F);
            btnEmitirComprovante.ForeColor = Color.Black;
            btnEmitirComprovante.Location = new Point(1082, 161);
            btnEmitirComprovante.Name = "btnEmitirComprovante";
            btnEmitirComprovante.Size = new Size(185, 40);
            btnEmitirComprovante.TabIndex = 111;
            btnEmitirComprovante.Text = "Emitir Comprovante";
            btnEmitirComprovante.TextAlign = ContentAlignment.MiddleRight;
            btnEmitirComprovante.UseVisualStyleBackColor = false;
            btnEmitirComprovante.Click += btnEmitirComprovante_Click;
            // 
            // pbOrcamento
            // 
            pbOrcamento.BackColor = Color.Transparent;
            pbOrcamento.ErrorImage = null;
            pbOrcamento.Image = (Image)resources.GetObject("pbOrcamento.Image");
            pbOrcamento.Location = new Point(1094, 161);
            pbOrcamento.Name = "pbOrcamento";
            pbOrcamento.Size = new Size(26, 40);
            pbOrcamento.SizeMode = PictureBoxSizeMode.Zoom;
            pbOrcamento.TabIndex = 108;
            pbOrcamento.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(440, 123);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 112;
            label8.Text = "Cliente";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(440, 209);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(169, 23);
            txtValor.TabIndex = 115;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(440, 191);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(35, 15);
            lblValor.TabIndex = 114;
            lblValor.Text = "Valor";
            // 
            // btnAdicionarOrçamento
            // 
            btnAdicionarOrçamento.BackColor = Color.DarkOrange;
            btnAdicionarOrçamento.FlatStyle = FlatStyle.Flat;
            btnAdicionarOrçamento.ForeColor = Color.Black;
            btnAdicionarOrçamento.Location = new Point(794, 140);
            btnAdicionarOrçamento.Name = "btnAdicionarOrçamento";
            btnAdicionarOrçamento.Size = new Size(122, 23);
            btnAdicionarOrçamento.TabIndex = 116;
            btnAdicionarOrçamento.Text = "Adicionar Orçamento";
            btnAdicionarOrçamento.UseVisualStyleBackColor = false;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(440, 141);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(169, 23);
            cbClientes.TabIndex = 117;
            // 
            // btnAlterarOrçamento
            // 
            btnAlterarOrçamento.BackColor = Color.DarkOrange;
            btnAlterarOrçamento.Cursor = Cursors.Hand;
            btnAlterarOrçamento.FlatStyle = FlatStyle.Flat;
            btnAlterarOrçamento.ForeColor = Color.Black;
            btnAlterarOrçamento.Location = new Point(792, 182);
            btnAlterarOrçamento.Name = "btnAlterarOrçamento";
            btnAlterarOrçamento.Size = new Size(124, 23);
            btnAlterarOrçamento.TabIndex = 120;
            btnAlterarOrçamento.Text = "Alterar Orçamento";
            btnAlterarOrçamento.UseVisualStyleBackColor = false;
            btnAlterarOrçamento.Click += btnAlterarOrçamento_Click;
            // 
            // btnExcluirOrçamento
            // 
            btnExcluirOrçamento.BackColor = Color.DarkOrange;
            btnExcluirOrçamento.Cursor = Cursors.Hand;
            btnExcluirOrçamento.FlatStyle = FlatStyle.Flat;
            btnExcluirOrçamento.ForeColor = Color.Black;
            btnExcluirOrçamento.Location = new Point(792, 223);
            btnExcluirOrçamento.Name = "btnExcluirOrçamento";
            btnExcluirOrçamento.Size = new Size(124, 23);
            btnExcluirOrçamento.TabIndex = 119;
            btnExcluirOrçamento.Text = "Excluir Orçamento";
            btnExcluirOrçamento.UseVisualStyleBackColor = false;
            btnExcluirOrçamento.Click += btnExcluirOrçamento_Click;
            // 
            // pnlAlterarOrçamento
            // 
            pnlAlterarOrçamento.Controls.Add(label3);
            pnlAlterarOrçamento.Controls.Add(label4);
            pnlAlterarOrçamento.Controls.Add(lblServiço);
            pnlAlterarOrçamento.Controls.Add(lblCliente);
            pnlAlterarOrçamento.Controls.Add(btnCancelarAlteracao);
            pnlAlterarOrçamento.Controls.Add(btnSalvarAlteracao);
            pnlAlterarOrçamento.Controls.Add(txtAlterarCelular);
            pnlAlterarOrçamento.Controls.Add(txtAlterarNome);
            pnlAlterarOrçamento.Location = new Point(1018, 253);
            pnlAlterarOrçamento.Name = "pnlAlterarOrçamento";
            pnlAlterarOrçamento.Size = new Size(366, 278);
            pnlAlterarOrçamento.TabIndex = 121;
            pnlAlterarOrçamento.Visible = false;
            // 
            // lblServiço
            // 
            lblServiço.AutoSize = true;
            lblServiço.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServiço.ForeColor = Color.White;
            lblServiço.Location = new Point(215, 25);
            lblServiço.Name = "lblServiço";
            lblServiço.Size = new Size(52, 15);
            lblServiço.TabIndex = 8;
            lblServiço.Text = "Serviço:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(35, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(38, 15);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Valor:";
            // 
            // btnCancelarAlteracao
            // 
            btnCancelarAlteracao.ForeColor = Color.Black;
            btnCancelarAlteracao.Location = new Point(243, 227);
            btnCancelarAlteracao.Name = "btnCancelarAlteracao";
            btnCancelarAlteracao.Size = new Size(94, 23);
            btnCancelarAlteracao.TabIndex = 6;
            btnCancelarAlteracao.Text = "Cancelar";
            btnCancelarAlteracao.UseVisualStyleBackColor = true;
            // 
            // btnSalvarAlteracao
            // 
            btnSalvarAlteracao.ForeColor = Color.Black;
            btnSalvarAlteracao.Location = new Point(40, 227);
            btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            btnSalvarAlteracao.Size = new Size(94, 23);
            btnSalvarAlteracao.TabIndex = 5;
            btnSalvarAlteracao.Text = "Salvar";
            btnSalvarAlteracao.UseVisualStyleBackColor = true;
            // 
            // txtAlterarCelular
            // 
            txtAlterarCelular.Location = new Point(215, 59);
            txtAlterarCelular.Name = "txtAlterarCelular";
            txtAlterarCelular.Size = new Size(123, 23);
            txtAlterarCelular.TabIndex = 1;
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.Location = new Point(35, 59);
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.Size = new Size(146, 23);
            txtAlterarNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 132);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Serviço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 132);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Cliente:";
            // 
            // Orçamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1419, 624);
            Controls.Add(pnlAlterarOrçamento);
            Controls.Add(btnAlterarOrçamento);
            Controls.Add(btnExcluirOrçamento);
            Controls.Add(cbClientes);
            Controls.Add(btnAdicionarOrçamento);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(label8);
            Controls.Add(pbOrcamento);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(pictureBox3);
            Controls.Add(dgvListadeServicos);
            Controls.Add(label2);
            Controls.Add(btnEmitirComprovante);
            Name = "Orçamentos";
            Text = "Orçamentos";
            Load += Orçamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListadeServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)obOrcamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAgenda).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOrcamento).EndInit();
            pnlAlterarOrçamento.ResumeLayout(false);
            pnlAlterarOrçamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Panel panel4;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lblAgenda;
        private Label label2;
        private DataGridView dgvListadeServicos;
        private Label LbOrçamentos;
        private Label lbAgenda;
        private PictureBox obOrcamento;
        private PictureBox pbAgenda;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pbHome;
        private Button btnSair;
        private Label lbClientes;
        private PictureBox pictureBox3;
        private PictureBox pbClientes;
        private Button btnEmitirComprovante;
        private PictureBox pictureBox4;
        private PictureBox pbOrcamento;
        private Label label8;
        private TextBox txtValor;
        private Label lblValor;
        private Button btnAdicionarOrçamento;
        private ComboBox cbClientes;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Servico;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Status;
        private Button btnAlterarOrçamento;
        private Button btnExcluirOrçamento;
        private Panel pnlAlterarOrçamento;
        private Label lblServiço;
        private Label lblCliente;
        private Button btnCancelarAlteracao;
        private Button btnSalvarAlteracao;
        private TextBox txtAlterarCelular;
        private TextBox txtAlterarNome;
        private Label label3;
        private Label label4;
    }
}