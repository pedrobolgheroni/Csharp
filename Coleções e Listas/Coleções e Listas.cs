// Coleções e Listas
/* O foreach é um recurso do C# que possibilita executar um conjunto de comandos para cada elemento presente em uma coleção (Array, List, Stack, Queue e outras). 
Portanto, diferentemente do while e do for, não precisamos definir uma condição de parada.
Isso é definido de forma implícita, pelo tamanho da coleção */

// Se o conteúdo de uma coleção for conhecido com antecedência, pode-se usar um inicializador de coleção para inicializar a coleção.

var peixes = new List<string>();
peixes.Add("Bagre Ensaboado");
peixes.Add("Tilápia");
peixes.Add("Camarão");
peixes.Add("Sardinha");

foreach (var peixe in peixes) 
{ 
    Console.Write(peixe + " ");
}


// Pode-se usar uma instrução FOR em vez de uma instrução FOREACH
// remoção de elementos

var peixes = new List<string> {"Bagre Ensaboado2", "Tilápia2", "Camarão2", "Sardinha2"};

peixes.Remove("Tilápia2");

for (var index = 0; index < peixes.Count; index++)
{ 
    Console.Write(peixes[index] + " " );
}
