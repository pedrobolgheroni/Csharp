using MySql.Data.MySqlClient;
using Aula10DB.Database;
using Aula10DB.Repositories;
using Aula10DB;

var databaseConfig = new DatabaseConfig();
var databaseSetup = new DatabaseSetup(databaseConfig);
var clienteRepository = new ClienteRepository(databaseConfig);
var pedidoRepository = new PedidoRepository(databaseConfig);

var modelName = args[0];
var modelAction = args[1];


if(modelName == "Cliente")
{
    if(modelAction == "Listar") // apresenta todos os registros do bdd
    {
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("Id Cliente   Endereço do Cliente      Cidade      Região      Código Postal   País      Telefone");

        foreach (var cliente in clienteRepository.Listar())
        {
            Console.WriteLine($"{cliente.ClienteId, -12} {cliente.Endereco, -24} {cliente.Cidade, -11} {cliente.Regiao, -11} {cliente.CodigoPostal, -15} {cliente.Pais, -9} {cliente.Telefone}");
        }
    }

    if(modelAction == "Inserir") // adiciona no bdd
    {
        Console.WriteLine("Inserção de Clientes");
        
        Console.WriteLine("Digite o id: ");
        int clienteId = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o endereco: ");
        string endereco = Console.ReadLine();

        Console.WriteLine("Digite a cidade: ");
        string cidade = Console.ReadLine();

        Console.WriteLine("Digite a regiao: ");
        string regiao = Console.ReadLine();

        Console.WriteLine("Digite o codigo postal: ");
        string codigoPostal = Console.ReadLine();

        Console.WriteLine("Digite o pais: ");
        string pais = Console.ReadLine();

        Console.WriteLine("Digite o telefone: ");
        string telefone = Console.ReadLine();

        var cliente = new Cliente(clienteId, endereco, cidade, regiao, codigoPostal, pais, telefone);
        clienteRepository.Inserir(cliente);
    }       

        if(modelAction == "Apresentar"){
              Console.WriteLine("Apresentar Cliente: ");

              Console.WriteLine("Digite o id do cliente: ");
              int clienteId = int.Parse(Console.ReadLine());

            var cliente = clienteRepository.Apresentar(clienteId);
            Console.WriteLine($"{cliente.ClienteId}, {cliente.Endereco}, {cliente.Cidade}, {cliente.Regiao}, {cliente.CodigoPostal}, {cliente.Pais}, {cliente.Telefone}");

        }
}

if(modelName == "Pedido")
{
    if(modelAction == "Listar") // apresenta todos os registros do bdd
    {
        Console.WriteLine("Lista de Pedidos");
        Console.WriteLine("Nro Pedido   Id Empregado   Data do Pedido   Peso      Codigo da Transportadora   Id do Cliente");

        foreach (var pedido in pedidoRepository.Listar())
        {
            Console.WriteLine($"{pedido.PedidoId, -12} {pedido.EmpregadoId, -14} {pedido.DataPedido, -16} {pedido.Peso, -9} {pedido.CodTransportadora, -26} {pedido.PedidoClienteId}");
        }
    }

    if(modelAction == "Inserir") // adiciona no bdd
    {
        Console.WriteLine("Inserção de Pedidos");

        Console.WriteLine("Digite o id: ");
        int pedidoId = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o id do empregado: ");
        int empregadoId = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a data: ");
        string dataPedido = Console.ReadLine();

        Console.WriteLine("Digite o peso: ");
        string peso = Console.ReadLine();

        Console.WriteLine("Digite o codigo da transportadora: ");
        int codTransportadora = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o id do cliente: ");
        int pedidoClienteId = int.Parse(Console.ReadLine());

        var pedido = new Pedido(pedidoId, empregadoId, dataPedido, peso, codTransportadora, pedidoClienteId);
        pedidoRepository.Inserir(pedido);
    }       

    if(modelAction == "Apresentar"){
              Console.WriteLine("Apresentar Pedido: ");

              Console.WriteLine("Digite o id do pedido: ");
              int pedidoId = int.Parse(Console.ReadLine());

            var pedido = pedidoRepository.Apresentar(pedidoId);
            Console.WriteLine($"{pedido.PedidoId}, {pedido.EmpregadoId}, {pedido.DataPedido}, {pedido.Peso}, {pedido.CodTransportadora}, {pedido.PedidoClienteId}");

        }

    if(modelAction == "MostrarPedidosCliente"){
              Console.WriteLine("Mostrar Pedidos do Cliente: ");

              Console.WriteLine("Digite o id do cliente: ");
              int clienteId = int.Parse(Console.ReadLine());

            var pedidos = pedidoRepository.MostrarPedidosCliente(clienteId);

            foreach(var pedido in pedidos)
            {
                Console.WriteLine($"{pedido.PedidoId}, {pedido.EmpregadoId}, {pedido.DataPedido}, {pedido.Peso}, {pedido.CodTransportadora}, {pedido.PedidoClienteId}");
            }
        }
}

