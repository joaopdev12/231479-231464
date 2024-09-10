namespace _231479___231464
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblvendas = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvlt = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.dvgProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vunitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtalterar = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvenda = new System.Windows.Forms.Label();
            this.btngravar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produtos";
            // 
            // lblvendas
            // 
            this.lblvendas.AutoSize = true;
            this.lblvendas.Location = new System.Drawing.Point(353, 42);
            this.lblvendas.Name = "lblvendas";
            this.lblvendas.Size = new System.Drawing.Size(13, 13);
            this.lblvendas.TabIndex = 2;
            this.lblvendas.Text = "0";
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(356, 104);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(564, 20);
            this.txtproduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // txtqnt
            // 
            this.txtqnt.Location = new System.Drawing.Point(356, 163);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(176, 20);
            this.txtqnt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Unitario";
            // 
            // txtvlt
            // 
            this.txtvlt.Location = new System.Drawing.Point(356, 212);
            this.txtvlt.Name = "txtvlt";
            this.txtvlt.Size = new System.Drawing.Size(176, 20);
            this.txtvlt.TabIndex = 7;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(588, 170);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(150, 62);
            this.btninserir.TabIndex = 8;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(761, 170);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(159, 62);
            this.btnremover.TabIndex = 9;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // dvgProdutos
            // 
            this.dvgProdutos.AllowUserToAddRows = false;
            this.dvgProdutos.AllowUserToOrderColumns = true;
            this.dvgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.Vunitario,
            this.total});
            this.dvgProdutos.Location = new System.Drawing.Point(297, 250);
            this.dvgProdutos.Name = "dvgProdutos";
            this.dvgProdutos.ReadOnly = true;
            this.dvgProdutos.Size = new System.Drawing.Size(640, 226);
            this.dvgProdutos.TabIndex = 10;
            this.dvgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProdutos_CellClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Vunitario
            // 
            this.Vunitario.HeaderText = "V.Unitario";
            this.Vunitario.Name = "Vunitario";
            this.Vunitario.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alterar Quantidade do item selecionado";
            // 
            // txtalterar
            // 
            this.txtalterar.Location = new System.Drawing.Point(479, 533);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(189, 20);
            this.txtalterar.TabIndex = 12;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(728, 523);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(154, 38);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "total da venda";
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Location = new System.Drawing.Point(403, 589);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(45, 13);
            this.lblvenda.TabIndex = 15;
            this.lblvenda.Text = "R$ 0,00";
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(346, 615);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(102, 51);
            this.btngravar.TabIndex = 16;
            this.btngravar.Text = "Gravar venda";
            this.btngravar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(503, 615);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(108, 51);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "Cancelar venda";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(681, 615);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(120, 51);
            this.btnfechar.TabIndex = 18;
            this.btnfechar.Text = "Finalizar sistema";
            this.btnfechar.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 669);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dvgProdutos);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtvlt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtqnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.lblvendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvendas;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvlt;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView dvgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vunitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtalterar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}

