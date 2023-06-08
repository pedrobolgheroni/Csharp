using MySql.Data.MySqlClient;

namespace Aula10DB.Database;

class DatabaseSetup
{
    private readonly DatabaseConfig _databaseConfig;  // variável de configuração para poder criar a tabela

    public DatabaseSetup(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
        CreateClienteTable();
        CreatePedidoTable();
    }

    private void CreateClienteTable()
    {
        
        var connection = new MySqlConnection(_databaseConfig.ConnectionString); // faz a conexão ao banco
        connection.Open(); // abre a conexão
        var command = connection.CreateCommand();
        command.CommandText = @"                    
            CREATE TABLE IF NOT EXISTS Cliente(
                clienteId int not null primary key,
                endereco varchar(100) not null,
                cidade varchar(100) not null,
                regiao varchar(100) not null,
                codigoPostal varchar(100) not null,
                pais varchar(100) not null,
                telefone varchar(100) not null
            );
        ";
        //@ para criação da tabela

        command.ExecuteNonQuery(); // manda executar a operação realizada
        connection.Close(); // fecha a conexão
    }

    private void CreatePedidoTable()
    {
        
        var connection = new MySqlConnection(_databaseConfig.ConnectionString); // faz a conexão ao banco
        connection.Open(); // abre a conexão
        var command = connection.CreateCommand();
        command.CommandText = @"                    
            CREATE TABLE IF NOT EXISTS Pedido(
                pedidoId int not null primary key,
                empregadoId int not null,
                dataPedido varchar(100) not null,
                peso varchar(100) not null,
                codTransportadora int not null,
                pedidoClienteId int not null,
                FOREIGN KEY (pedidoClienteId) REFERENCES Cliente (clienteId)
                
            );
        ";
        //@ para criação da tabela

        command.ExecuteNonQuery(); // manda executar a operação realizada
        connection.Close(); // fecha a conexão
    }
}