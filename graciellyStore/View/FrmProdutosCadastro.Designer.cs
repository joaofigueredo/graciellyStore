namespace graciellyStore.View
{
    partial class FrmProdutosCadastro
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
            Lbl_Nome = new Label();
            Lbl_Valor = new Label();
            Txt_Nome = new TextBox();
            Txt_Valor = new TextBox();
            Lbl_Id = new Label();
            Txt_Id = new TextBox();
            toolStrip1 = new ToolStrip();
            SalvarToolStripButton1 = new ToolStripButton();
            Excluir_toolStripButton1 = new ToolStripButton();
            limparToolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Nome
            // 
            Lbl_Nome.AutoSize = true;
            Lbl_Nome.Location = new Point(15, 98);
            Lbl_Nome.Name = "Lbl_Nome";
            Lbl_Nome.Size = new Size(50, 20);
            Lbl_Nome.TabIndex = 0;
            Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Valor
            // 
            Lbl_Valor.AutoSize = true;
            Lbl_Valor.Location = new Point(15, 135);
            Lbl_Valor.Name = "Lbl_Valor";
            Lbl_Valor.Size = new Size(43, 20);
            Lbl_Valor.TabIndex = 1;
            Lbl_Valor.Text = "Valor";
            // 
            // Txt_Nome
            // 
            Txt_Nome.BorderStyle = BorderStyle.FixedSingle;
            Txt_Nome.Location = new Point(71, 95);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(480, 27);
            Txt_Nome.TabIndex = 2;
            // 
            // Txt_Valor
            // 
            Txt_Valor.BorderStyle = BorderStyle.FixedSingle;
            Txt_Valor.Location = new Point(71, 133);
            Txt_Valor.Name = "Txt_Valor";
            Txt_Valor.Size = new Size(143, 27);
            Txt_Valor.TabIndex = 3;
            // 
            // Lbl_Id
            // 
            Lbl_Id.AutoSize = true;
            Lbl_Id.Location = new Point(15, 63);
            Lbl_Id.Name = "Lbl_Id";
            Lbl_Id.Size = new Size(22, 20);
            Lbl_Id.TabIndex = 6;
            Lbl_Id.Text = "Id";
            // 
            // Txt_Id
            // 
            Txt_Id.BorderStyle = BorderStyle.FixedSingle;
            Txt_Id.Location = new Point(70, 56);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new Size(144, 27);
            Txt_Id.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { SalvarToolStripButton1, Excluir_toolStripButton1, limparToolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(560, 27);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // SalvarToolStripButton1
            // 
            SalvarToolStripButton1.Image = Properties.Resources.salve_;
            SalvarToolStripButton1.ImageTransparentColor = Color.Magenta;
            SalvarToolStripButton1.Name = "SalvarToolStripButton1";
            SalvarToolStripButton1.Size = new Size(73, 24);
            SalvarToolStripButton1.Text = "Salvar";
            SalvarToolStripButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            SalvarToolStripButton1.Click += SalvarToolStripButton1_Click;
            // 
            // Excluir_toolStripButton1
            // 
            Excluir_toolStripButton1.Image = Properties.Resources.excluir;
            Excluir_toolStripButton1.ImageTransparentColor = Color.Magenta;
            Excluir_toolStripButton1.Name = "Excluir_toolStripButton1";
            Excluir_toolStripButton1.Size = new Size(76, 24);
            Excluir_toolStripButton1.Text = "Excluir";
            Excluir_toolStripButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            Excluir_toolStripButton1.Click += Excluir_toolStripButton1_Click;
            // 
            // limparToolStripButton1
            // 
            limparToolStripButton1.Image = Properties.Resources.limpar_limpo;
            limparToolStripButton1.ImageTransparentColor = Color.Magenta;
            limparToolStripButton1.Name = "limparToolStripButton1";
            limparToolStripButton1.Size = new Size(79, 24);
            limparToolStripButton1.Text = "Limpar";
            limparToolStripButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            limparToolStripButton1.Click += limparToolStripButton1_Click;
            // 
            // FrmProdutosCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 205);
            Controls.Add(toolStrip1);
            Controls.Add(Txt_Id);
            Controls.Add(Lbl_Id);
            Controls.Add(Txt_Valor);
            Controls.Add(Txt_Nome);
            Controls.Add(Lbl_Valor);
            Controls.Add(Lbl_Nome);
            MaximizeBox = false;
            Name = "FrmProdutosCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProdutos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Nome;
        private Label Lbl_Valor;
        private TextBox Txt_Nome;
        private TextBox Txt_Valor;
        private Label Lbl_Id;
        private TextBox Txt_Id;
        private ToolStrip toolStrip1;
        private ToolStripButton SalvarToolStripButton1;
        private ToolStripButton Excluir_toolStripButton1;
        private ToolStripButton limparToolStripButton1;
    }
}