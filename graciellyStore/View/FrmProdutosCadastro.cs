using graciellyStore.Data;
using graciellyStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graciellyStore.View
{
    public partial class FrmProdutosCadastro : Form
    {
        public FrmProdutosCadastro(int id, string operacao = "a")
        {
            InitializeComponent();
            if (id != 0)
            {
                ObterProduto(id);
            }

            //visualizar
            if (operacao == "v")
            {
                Text = "Visualizar Produtos";
                SalvarToolStripButton1.Enabled = false;
                Excluir_toolStripButton1.Enabled = false;
                limparToolStripButton1.Enabled = false;
                TravarFormulario();
            }
            //Excluir
            if (operacao == "e")
            {
                Text = "Excluir produto";
                SalvarToolStripButton1.Enabled = false;
                limparToolStripButton1.Enabled = false;
                TravarFormulario();
            }

            if(operacao == "a")
            {
                Text = "Adicionar produto";
                Excluir_toolStripButton1.Enabled = false;
                limparToolStripButton1.Enabled = false;
                Txt_Id.ReadOnly = true;
            }
        }
        private void TravarFormulario()
        {
            Txt_Id.ReadOnly = true;
            Txt_Nome.ReadOnly = true;
            Txt_Valor.ReadOnly = true;
        }

        public void ObterProduto(int id)
        {
            Txt_Id.Text = id.ToString();

            try
            {
                using (var context = new DataContext())
                {
                    var produto = context.Produtos.Find(id);
                    if (produto != null)
                    {
                        Txt_Nome.Text = produto.Descricao;
                        Txt_Valor.Text = (produto.Valor).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao Salvar.\n" + ex.Message);
            }
        }
        private void Lbl_Limpar_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {

        }

        private bool Salvar()
        {
            var produto = new Produtos();

            produto.Id = Convert.ToInt32("0" + Txt_Id.Text);
            produto.Descricao = Txt_Nome.Text;
            produto.Valor = Convert.ToDecimal(Txt_Valor.Text);

            try
            {
                using (var context = new DataContext())
                {
                    if (produto.Id == 0)
                        context.Produtos.Add(produto);
                    else

                        context.Entry(produto).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar!\n");
                return false;
            }

        }

        private void SalvarToolStripButton1_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }

        private void limparToolStripButton1_Click(object sender, EventArgs e)
        {
            Txt_Nome.Clear();
            Txt_Valor.Clear();
        }

        private void Excluir_toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Excluir())
                Close();
        }

        private bool Excluir()
        {
            try
            {
                using(var context = new DataContext())
                {
                    var produto = new Produtos();

                    produto.Id = Convert.ToInt32(Txt_Id.Text);
                    var entry  = context.Entry(produto);

                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        context.Produtos.Attach(produto);
                    }

                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao excluir " + ex.Message);
                return false;
            }
        }
    }
}
