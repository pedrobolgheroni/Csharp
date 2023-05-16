using Microsoft.Data.Sqlite;

namespace Aula09DB.Database;

class DatabaseSetup
{
    private readonly DatabaseConfig _databaseConfig;  // variável de configuração para poder criar a tabela

    public DatabaseSetup(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
        CreateComputerTable();
    }

    private void CreateComputerTable()
    {
        
        var connection = new SqliteConnection(_databaseConfig.ConnectionString); // faz a conexão ao banco
        connection.Open(); // abre a conexão
        var command = connection.CreateCommand();
        command.CommandText = @"                    
            CREATE TABLE IF NOT EXISTS Computers(
                id int not null primary key,
                ram varchar(100) not null,
                processor varchar(100) not null
            );
        ";
        //@ para criação da tabela

        command.ExecuteNonQuery(); // manda executar a operação realizada
        connection.Close(); // fecha a conexão
    }
}