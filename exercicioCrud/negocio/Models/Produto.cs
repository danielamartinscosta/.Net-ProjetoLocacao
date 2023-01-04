using MySql.Data.MySqlClient;

namespace Negocio.Models;


public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; } = default!;
    public string? Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataValidade { get; set; }
    public int QuantidadeEstoque { get; set; }



    private static readonly string conexao = "Server=localhost;Database=estoque;Uid=root;Pwd=2411dmcroot*;";
    public void Salvar()
    {

        using (var conn = new MySqlConnection(conexao))
        {
            conn.Open();
            var query = $"insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque)values('{this.Nome}', '{this.Descricao}', '{this.DataCriacao}', '{this.DataValidade.ToString("dd/MM/yyyy")}', '{this.QuantidadeEstoque}');";

            if (this.Id > 0)

                query = $"update produtos set nome='{this.Nome}', '{this.Descricao}', '{this.DataCriacao}', '{this.DataValidade.ToString("dd/MM/yyyy")}', '{this.QuantidadeEstoque}' where id = {this.Id}";

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