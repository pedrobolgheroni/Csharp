/* Pode-se remover elementos de uma lista genérica. 
- Em vez de uma instrução FOREACH, é usada uma instrução FOR que itera em ordem decrescente. 
- Isso é feito porque o método RemoveAt faz com que os elementos após um elemento removido, tenham um valor de índice menor. */

var numeros = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for (var index = numeros.Count - 1; index >= 0; index--)
{ 
    if (numeros[index] % 2 == 1) 
    { 
        numeros.RemoveAt(index); 
    }
}

numeros.ForEach(numero => Console.Write(numero + " "));