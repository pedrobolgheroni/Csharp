using Aula10DB.Database;
using MySql.Data.MySqlClient;

namespace Aula10DB.Repositories;
class PedidoRepository
{
    private readonly DatabaseConfig _databaseConfig;
    public PedidoRepository(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }

    public List<Pedido> Listar() // lista para ler todos os registros do bdd
    {
        var pedido = new List<Pedido>();
        

        var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Pedido";

        var reader = command.ExecuteReader(); // ler uma linha do bdd

        while(reader.Read()) // enquanto houver informações, adiciona na classe
        {
            var pedidoId = reader.GetInt32(0);
            var empregadoId = reader.GetInt32(1);
            var codTransportadora = reader.GetInt32(2);
            var pedidoClienteId = reader.GetInt32(3);
            var dataPedido = reader.GetString(4);
            var peso = reader.GetString(5);
            var pedidos = ReaderToPedido(reader);
            pedido.Add(pedidos);
        }

        connection.Close();
        
        return pedido;
    }

    public Pedido Inserir(Pedido pedido)
    {
        var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Pedido (pedidoId, empregadoId, dataPedido, peso, codTransportadora, pedidoClienteID) " + "VALUES (@pedidoId, @empregadoId, @dataPedido, @peso, @codTransportadora, @pedidoClienteID)";
        command.Parameters.AddWithValue("@pedidoId", pedido.PedidoId);
        command.Parameters.AddWithValue("@empregadoId", pedido.EmpregadoId);
        command.Parameters.AddWithValue("@dataPedido", pedido.DataPedido);
        command.Parameters.AddWithValue("@peso", pedido.Peso);
        command.Parameters.AddWithValue("@codTransportadora", pedido.CodTransportadora);
        command.Parameters.AddWithValue("@pedidoClienteID", pedido.PedidoClienteId);

        command.ExecuteNonQuery();

        connection.Close();

        return pedido;
    }

    public Pedido Apresentar(int id){

        var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Pedido WHERE (pedidoId = @id)";
        command.Parameters.AddWithValue("@id", id);

        var reader = command.ExecuteReader();
        reader.Read();

        var pedido = ReaderToPedido(reader);

        connection.Close(); 

        return pedido;
    }

    public List<Pedido> MostrarPedidosCliente(int clienteId){
         var connection = new MySqlConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Pedido WHERE (pedidoClienteId = @clienteId)";
        command.Parameters.AddWithValue("@clienteId", clienteId);

        var reader = command.ExecuteReader();
        var pedidos = new List<Pedido>();

         while (reader.Read())
        {
            var p = ReaderToPedido(reader);
            pedidos.Add(p);
        }

        var pedido = ReaderToPedido(reader);

        connection.Close(); 

        return pedidos;
    }

    private Pedido ReaderToPedido(MySqlDataReader reader)
    {
        var pedido = new Pedido(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));

        return pedido;
    }
}
