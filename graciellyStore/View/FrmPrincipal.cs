using graciellyStore.Data;
using graciellyStore.View;

namespace graciellyStore
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from produtos in context.Produtos select produtos).ToList();
            }
            ConfigurarGrade();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            var id = 0;

            using (var frm = new FrmProdutosCadastro(id))
                frm.ShowDialog();
        }

        public void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["id"].HeaderText = "Id";
            dataGridView1.Columns["id"].Width = 80;
            dataGridView1.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 250;

            dataGridView1.Columns["valor"].HeaderText = "Valor";
            dataGridView1.Columns["valor"].Width = 250;
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            using (var frm = new FrmProdutosCadastro(id, "e"))
                frm.ShowDialog();
        }

        private void Btn_atualiza_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            using (var frm = new FrmProdutosCadastro(id))
                frm.ShowDialog();
        }

        private void Btn_Visualizar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            using (var frm = new FrmProdutosCadastro(id, "v"))
                frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}