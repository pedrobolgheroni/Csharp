using Aula10DB.Database;
using MySql.Data.MySqlClient;

namespace Aula10DB.Repositories;
class ClienteRepository
{
    private readonly DatabaseConfig _databaseConfig;
    public ClienteRepository(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }

    public List<Cliente> Listar() // lista para ler todos os registros do bdd
    {
        var cliente = new List<Cliente>();
        

        var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Cliente";

        var reader = command.ExecuteReader(); // ler uma linha do bdd

        while(reader.Read()) // enquanto houver informações, adiciona na classe
        {
            var clienteId = reader.GetInt32(0);
            var endereco = reader.GetString(1);
            var cidade = reader.GetString(2);
            var regiao = reader.GetString(3);
            var codigoPostal = reader.GetString(4);
            var pais = reader.GetString(5);
            var telefone = reader.GetString(6);
            var clientes = ReaderToCliente(reader);
            cliente.Add(clientes);
        }

        connection.Close();
        
        return cliente;
    }

    public Cliente Inserir(Cliente cliente)
    {
       var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Cliente (clienteId, endereco, cidade, regiao, codigoPostal, pais, telefone) " + "VALUES (@clienteId, @endereco, @cidade, @regiao, @codigoPostal, @pais, @telefone)";
        command.Parameters.AddWithValue("@clienteId", cliente.ClienteId);
        command.Parameters.AddWithValue("@endereco", cliente.Endereco);
        command.Parameters.AddWithValue("@cidade", cliente.Cidade);
        command.Parameters.AddWithValue("@regiao", cliente.Regiao);
        command.Parameters.AddWithValue("@codigoPostal", cliente.CodigoPostal);
        command.Parameters.AddWithValue("@pais", cliente.Pais);
        command.Parameters.AddWithValue("@telefone", cliente.Telefone);

        command.ExecuteNonQuery();
        connection.Close();

        return cliente;
    }

    public Cliente Apresentar(int id){

        var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Cliente WHERE (clienteId = @id)";
        command.Parameters.AddWithValue("@id", id);

        var reader = command.ExecuteReader();
        reader.Read();

        var cliente = ReaderToCliente(reader);

        connection.Close(); 

        return cliente;
    }


    private Cliente ReaderToCliente(MySqlDataReader reader)
    {
        var cliente = new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));

        return cliente;
    }
}
