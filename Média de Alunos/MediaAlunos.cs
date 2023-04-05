class Media
{
    public static double Calculo(double nota1, double nota2)
    {
        double media = (nota1 + nota2)/2;
        return media;
    }
}

class Programa
{
    static void Main (string[]args)
    {
        bool fimPrograma = false;
        string not1 = "";
        string not2 = "";
        double nota1 = 0; 
        double nota2 = 0; 
        double media, soma = 0;
        int nota = 0;
        

        while (!fimPrograma)
        {
            Console.WriteLine("Digite a nota 1: ");
            not1 = Console.ReadLine();

            while (!double.TryParse(not1, out nota1)) 
            { 
                Console.Write("Nota Inválida. Digite uma nota válida: "); 
                not1 = Console.ReadLine();
            }

            Console.WriteLine("Digite a nota 2: ");
            not2 = Console.ReadLine();

            while (!double.TryParse(not2, out nota2)) 
            { 
                Console.Write("Nota Inválida. Digite uma nota válida: "); 
                not2 = Console.ReadLine();
            }

            try
            {
                media = Media.Calculo(nota1, nota2);

                if(double.IsNaN(media))
                {
                    Console.WriteLine("Essa operação resultará em um erro. \n");
                }
                else
                    Console.WriteLine("A média do aluno foi: {0:0.##}\n", media);
                    {
                        nota++;
                        soma = soma + media; //soma += media;
                    }
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocorreu uma exceção. \nDetalhes: "+e.Message);
            }

            Console.Write("Digite 'n' para encerrar a execução ou digite qualquer tecla para continuar: ");
            if (Console.ReadLine() == "n")
                fimPrograma = true;
            Console.WriteLine("\n");
            
        }
        Console.Write("A média da turma foi: {0:0.##}\n" ,(soma/nota) );
        return;
    }
}
