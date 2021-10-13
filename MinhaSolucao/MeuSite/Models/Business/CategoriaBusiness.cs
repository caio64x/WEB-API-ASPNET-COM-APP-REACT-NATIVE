using Dapper;
using MeuSite.Models.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuSite.Models.Business
{
    public class CategoriaBusiness : Conexao
    {
        internal List<Categoria> Listar()
        {
            return conn.Query<Categoria>("SELECT * FROM Categorias order by Nome").ToList();
        }

        internal Categoria Carregar(int id)
        {
            return conn.Query<Categoria>("SELECT * FROM Categorias where id = @pId",
                new { pId = id }).SingleOrDefault();
        }

        internal bool Apagar(int id)
        {
            try
            {
                return conn.Execute("delete FROM Categorias where id = @pId",
                     new { pId = id }) == 1;
            }
            catch { return false; }
        }

        internal bool Novo(Categoria categoria)
        {
            try
            {
                return conn.Execute(
                "insert into Categorias " +
                "(id, nome) values (@id, @nome)", categoria) == 1;
            }
            catch { return false; }
        }

        internal bool Alterar(Categoria categoria)
        {
            try
            {
                return conn.Execute(
                "update Categorias " +
                "set nome = @nome " +
                "where id = @id", categoria) == 1;
            }
            catch { return false; }
        }
    }
}