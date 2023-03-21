// 20 primeiros números sequência de Fibonacci

var fibonacci = new List<int> {1,1};

for(int i=0; i<= 19; i++)
{ 
    var previo = fibonacci[fibonacci.Count -1]; 
    var previo2 = fibonacci[fibonacci.Count -2]; 
    
    fibonacci.Add(previo + previo2);

    Console.WriteLine("Item " +(i+1)+ ": " +fibonacci[i]);
}

