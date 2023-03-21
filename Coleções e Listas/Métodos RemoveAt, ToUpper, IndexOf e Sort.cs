// Métodos RemoveAt, ToUpper, IndexOf e Sort

// RemoveAt

var numeros = new List<int>{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
for (var index = numeros.Count -1; index >= 0; index--)
{ 
    if (numeros[index] % 2 == 1) 
    { 
        numeros.RemoveAt(index); 
    }
}

numeros.ForEach( numero => Console.Write(numero + " ") // => "concatena" a informação );


// ToUpper
var nomes = new List<String> {"Pedro", "Ana", "Felipe", "Claudia"}; 

nomes.Add("Maria");
nomes.Add("Bill");

nomes.Remove("Ana");

foreach(var nome in nomes)
{
   Console.WriteLine($"Olá {nome.ToUpper()}"); // '$' concatenar uma literal com o conteudo da variavel
}

Console.WriteLine($"Meu nome é {nomes[0]}");
Console.WriteLine($"Adicionei {nomes[3]} e {nomes[4]} na lista");
Console.WriteLine($"A lista tem {nomes.Count} pessoas");

// IndexOf

var index = nomes.IndexOf("Pedro");
if (index == -1 )
 
{
    Console.WriteLine($"Item não encontrado {index}");
}
else
{
    Console.WriteLine($"O nome {nomes[index]} está no índice {index}");
}

//Sort 

nomes.Sort();

foreach(var nome in nomes)
{
    Console.WriteLine($"Olá {nome.ToUpper()}!");
}