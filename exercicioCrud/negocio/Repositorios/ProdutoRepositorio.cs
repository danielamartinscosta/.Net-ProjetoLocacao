using MySql.Data.MySqlClient;
using Negocio.Entidades;
//using System;

namespace Negocio.Repositorios;


public class ProdutoRepositorio
{

    //private static readonly string conexao = "Server=localhost;Database=produtos;Uid=root;Pwd=root;";
    private static readonly string? conexao = Environment.GetEnvironmentVariable("DATABASE_URL");
    public static void Salvar(Produto produto)
    {

        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var query = $"insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('{produto.Nome}', '{produto.Descricao}', '{produto.DataCriacao}', '{produto.DataValidade.ToString("dd/MM/yyyy")}', '{produto.QuantidadeEstoque}');";

            if (produto.Id > 0)

                query = $"update produtos set nome='{produto.Nome}', '{produto.Descricao}', '{produto.DataCriacao}', '{produto.DataValidade.ToString("dd/MM/yyyy")}', '{produto.QuantidadeEstoque}' where id = {produto.Id}";

            var command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();

        }

    }

    public static List<Produto> BuscaPorIdOuNome(string idOuNome)
    {
        var produtos = new List<Produto>();
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var query = $"select * from produtos where id = '{idOuNome}' ou nome like '%{idOuNome}%'";

            var command = new MySqlCommand(query, conn);
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                produtos.Add(new Produto
                {
                    Id = Convert.ToInt32(dataReader["id"]),
                    Nome = dataReader["nome"].ToString(),
                    Descricao = dataReader["descricao"].ToString(),
                    DataCriacao = Convert.ToDateTime(dataReader["data_criacao"]),
                    DataValidade = Convert.ToDateTime(dataReader["data_validade"]),
                    QuantidadeEstoque = Convert.ToInt32(dataReader["quantidade_estoque"]),
                });
            }

            conn.Close();

        }

        return produtos;

    }


    public static List<Produto> Todos()
    {
        var produtos = new List<Produto>();
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var query = $"""
                select * from produtos
            """;

            var command = new MySqlCommand(query, conn);
            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                produtos.Add(new Produto
                {
                    Id = Convert.ToInt32(dataReader["id"]),
                    Nome = dataReader["nome"].ToString(),
                    Descricao = dataReader["descricao"].ToString(),
                    DataCriacao = Convert.ToDateTime(dataReader["data_criacao"]),
                    DataValidade = Convert.ToDateTime(dataReader["data_validade"]),
                    QuantidadeEstoque = Convert.ToInt32(dataReader["quantidade_estoque"]),
                });
            }

            conn.Close();
        }

        return produtos;
    }

    public static void ApagarPorId(int id)
    {
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var query = $"delete from produtos where id = {id}";

            var command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();

        }

    }

    public static Produto? BuscaPorId(int id)
    {
        var produto = new Produto();
        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var query = $"select * from produtos where id = '{id}'";

            var command = new MySqlCommand(query, conn);
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                produto = new Produto
                {
                    Id = Convert.ToInt32(dataReader["id"]),
                    Nome = dataReader["nome"].ToString(),
                    Descricao = dataReader["descricao"].ToString(),
                    DataCriacao = Convert.ToDateTime(dataReader["data_criacao"]),
                    DataValidade = Convert.ToDateTime(dataReader["data_validade"]),
                    QuantidadeEstoque = Convert.ToInt32(dataReader["quantidade_estoque"]),
                };
            }

            conn.Close();

        }

        return produto.Id == 0? null : produto;
    }
}