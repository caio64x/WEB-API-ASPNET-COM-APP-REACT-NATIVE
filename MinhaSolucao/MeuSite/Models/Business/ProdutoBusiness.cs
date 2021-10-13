using Dapper;
using MeuSite.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuSite.Models.Business
{
    public class ProdutoBusiness : Conexao
    {
        internal List<Produto> Listar()
        {
            var list = conn.Query<Produto, Categoria, Produto>
                (
                @"select p.*, c.*
                from Produtos p 
                inner join Categorias c on p.IDCategoria = c.id
                order by p.Nome", (p, c) =>
                {
                    p.Categoria = c;
                    return p;
                }, new { }, splitOn: "ID").ToList();

            return list;
        }

        internal Produto Carregar(int id)
        {
            var obj = conn.Query<Produto, Categoria, Produto>
                (
                @"select p.*, c.*
                from Produtos p 
                inner join Categorias c on p.IDCategoria = c.id
                where p.ID = @pid", (p, c) =>
                {
                    p.Categoria = c;
                    return p;
                }, new { pid = id }, splitOn: "ID").SingleOrDefault();

            return obj;
        }

        internal bool Salvar(Produto produto)
        {
            try
            {
                if (produto.ID == 0)
                {
                    return conn.Execute(
                    "insert into Produtos " +
                    "(idcategoria, nome, marca, quantidade, valorunitario) values " +
                    "(@idcategoria, @nome, @marca, @quantidade, @valorunitario)", produto) == 1;
                }
                else
                {
                    return conn.Execute(
                    "update Produtos set " +
                    "idcategoria = @idcategoria, nome = @nome, marca = @marca, " +
                    "quantidade = @quantidade, valorunitario = @valorunitario " +
                    "where id = @id", produto) == 1;
                }
            }
            catch { return false; }
        }

        internal bool Apagar(int id)
        {
            try
            {
                return conn.Execute("delete FROM Produtos where id = @pId",
                     new { pId = id }) == 1;
            }
            catch { return false; }
        }
    }
}