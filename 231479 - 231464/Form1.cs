using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231479___231464
{
    public partial class Form1 : Form
    {
        double contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txtqnt.Text) * double.Parse(txtvlt.Text);

            dvgProdutos.Rows.Add(txtproduto.Text, txtqnt.Text, txtvlt.Text,total);

            txtproduto.Clear();
            txtqnt.Clear();
            txtvlt.Clear();

            MessageBox.Show("Produto inserido", "Inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (dvgProdutos.RowCount > 0)
            {
                lblvendas.Text = dvgProdutos.RowCount.ToString();
            }

            //preço
            if (dvgProdutos.RowCount > 0)
            {
                //double qnt = double.Parse(txtqnt.Text);
                //double vlt = double.Parse(txtvlt.Text);

                contador += total;

                lblvenda.Text =  contador.ToString("C");
            }

        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            //REMOVER
            if(dvgProdutos.RowCount > 0)
            {
                double removerValor = double.Parse(dvgProdutos.CurrentRow.Cells["Quantidade"].Value.ToString()) *
                    double.Parse(dvgProdutos.CurrentRow.Cells["Vunitario"].Value.ToString());

                //removendo linha selecionada
                dvgProdutos.Rows.RemoveAt(dvgProdutos.CurrentCell.RowIndex);

                double totalAlterado = contador - removerValor;

                lblvendas.Text = dvgProdutos.RowCount.ToString();

                lblvenda.Text = totalAlterado.ToString("c");

                MessageBox.Show("Venda removida com sucesso", "Exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Você não celecionou nenhum registro", "Exclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dvgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgProdutos.RowCount > 0)
            {
                txtalterar.Text = dvgProdutos.CurrentRow.Cells["Quantidade"].Value.ToString();

            }
        }
        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtalterar.Text != "")
            {
                dvgProdutos.CurrentRow.Cells["Quantidade"].Value = txtalterar.Text;

                txtalterar.Clear();

                //preço
                if (dvgProdutos.RowCount > 0)
                {
                    double total = double.Parse(dvgProdutos.CurrentRow.Cells["Quantidade"].Value.ToString()) * double.Parse(dvgProdutos.CurrentRow.Cells["Vunitario"].Value.ToString());

                    //double qnt = double.Parse(txtqnt.Text);
                    //double vlt = double.Parse(txtvlt.Text);

                    contador += total;

                    lblvenda.Text = contador.ToString("C");
                }

                MessageBox.Show("alteração frita com sucesso", "Alteração",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("preencha os campos corretamente para alterar", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (dvgProdutos.RowCount > 0)
            {
                dvgProdutos.RowCount = 0;
                lblvenda.Text = "R$ 00,00";
                lblvendas.Text = "0";
                txtqnt.Clear();
                txtvlt.Clear();
                txtalterar.Clear();

                MessageBox.Show("Venda cancelada com sucesso", "Cancelamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Você ainda não tem vendas", "Cancelamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (dvgProdutos.RowCount > 0)
            {
                dvgProdutos.RowCount = 0;
                lblvenda.Text = "R$ 00,00";
                lblvendas.Text = "0";
                txtqnt.Clear();
                txtvlt.Clear();
                txtalterar.Clear();

                MessageBox.Show("Venda registrada com sucesso", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Você registrou 0 vendas", "Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
