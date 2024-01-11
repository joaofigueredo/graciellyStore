
namespace graciellyStore
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            Btn_Adicionar = new ToolStripButton();
            Btn_Visualizar = new ToolStripButton();
            Btn_Deletar = new ToolStripButton();
            Btn_atualiza = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Btn_Adicionar, Btn_Visualizar, Btn_Deletar, Btn_atualiza });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Btn_Adicionar
            // 
            Btn_Adicionar.Image = Properties.Resources.botao_adicionar;
            Btn_Adicionar.ImageTransparentColor = Color.Magenta;
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(97, 24);
            Btn_Adicionar.Text = "Adicionar";
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // Btn_Visualizar
            // 
            Btn_Visualizar.Image = Properties.Resources.visualizar;
            Btn_Visualizar.ImageTransparentColor = Color.Magenta;
            Btn_Visualizar.Name = "Btn_Visualizar";
            Btn_Visualizar.Size = new Size(96, 24);
            Btn_Visualizar.Text = "Visualizar";
            Btn_Visualizar.Click += Btn_Visualizar_Click;
            // 
            // Btn_Deletar
            // 
            Btn_Deletar.Image = Properties.Resources.excluir;
            Btn_Deletar.ImageTransparentColor = Color.Magenta;
            Btn_Deletar.Name = "Btn_Deletar";
            Btn_Deletar.Size = new Size(82, 24);
            Btn_Deletar.Text = "Deletar";
            Btn_Deletar.Click += Btn_Deletar_Click;
            // 
            // Btn_atualiza
            // 
            Btn_atualiza.Image = Properties.Resources.troca;
            Btn_atualiza.ImageTransparentColor = Color.Magenta;
            Btn_atualiza.Name = "Btn_atualiza";
            Btn_atualiza.Size = new Size(78, 24);
            Btn_atualiza.Text = "Alterar";
            Btn_atualiza.Click += Btn_atualiza_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 413);
            dataGridView1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton Btn_Adicionar;
        private ToolStripButton Btn_Deletar;
        private ToolStripButton Btn_Visualizar;
        private DataGridView dataGridView1;
        private ToolStripButton Btn_atualiza;
    }
}
