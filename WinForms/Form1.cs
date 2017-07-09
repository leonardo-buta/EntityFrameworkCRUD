using Data;
using Domain;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        // Contexto do banco
        private ProdutoDBContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new ProdutoDBContext();
        }

        /// <summary>
        /// Método de Insert para inserir uma nova loja e um novo produto no banco
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja() { Nome = "Loja teste " };
            Produto produto = new Produto { Nome = "Produto teste", Valor = 20, Loja = loja };

            _context.Lojas.Add(loja);
            _context.Produtos.Add(produto);

            _context.SaveChanges();
        }

        /// <summary>
        /// Método de Insert Select
        /// </summary>
        private void btnSelectInsert_Click(object sender, EventArgs e)
        {
            Loja loja = _context.Lojas.Find(1);
            Produto novoProduto = new Produto()
            {
                Nome = "Novo Produto",
                Valor = 100,
                LojaId = loja.Id,
                Loja = loja
            };

            _context.Produtos.Add(novoProduto);
            _context.SaveChanges();
        }

        /// <summary>
        /// Método de Select
        /// </summary>
        private void btnSelectLojaProduto_Click(object sender, EventArgs e)
        {
            Produto produto = _context.Produtos.Find(2);
            Loja lojaProduto = produto.Loja;
            string nomeLoja = produto.Loja.Nome;
        }

        /// <summary>
        /// Select com Where
        /// </summary>
        private void btnSelectWhere_Click(object sender, EventArgs e)
        {
            IEnumerable<Produto> produtosIniciadosComA;
            IEnumerable<Produto> produtosDaLoja;
            IEnumerable<Produto> produtosDaLoja2;

            produtosIniciadosComA = _context.Produtos.Where(p => p.Nome.StartsWith("P"));
            produtosDaLoja = _context.Produtos.Where(p => p.LojaId == 1);
            produtosDaLoja2 = _context.Lojas.Find(1).Produtos;
        }

        /// <summary>
        /// Método de Update
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Loja loja = _context.Lojas.Find(1);
            Produto produto = _context.Produtos.Find(2);

            loja.Nome = "Teste update";
            produto.Nome = "Update produto";
            produto.Loja.Nome = "Update via produto";

            loja.Produtos.ToList().ForEach(p => p.Valor += p.Valor * 0.1m);

            _context.SaveChanges();
        }

        /// <summary>
        /// Método de Delete
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Loja loja = _context.Lojas.Find(1);
            Produto produto = _context.Produtos.Find(3);

            _context.Lojas.Remove(loja);
            _context.Produtos.Remove(produto);

            _context.SaveChanges();
        }

        /// <summary>
        /// Update atraves do Entity State
        /// </summary>
        private void btnUpdateEntityState_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = 2,
                Nome = "Teste produto",
                LojaId = 2
            };

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
