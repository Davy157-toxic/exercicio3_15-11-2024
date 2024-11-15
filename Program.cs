using System;

public class Exe3
{
    //exercicio 3
    public static void Main(string[] args)
    {
        int idade = 20;
        bool eCasado = true;

        if (idade < 18)
        {
            Console.WriteLine("É menor de idade");
        }
        else if (idade >= 18 && idade < 65)
        {
            if (eCasado)
            {
                Console.WriteLine("És casado");
            }
            else if(!eCasado)
            {
                Console.WriteLine("És solteiro");
            }
            Console.WriteLine("És adulto");
        }

        else
        {
            Console.WriteLine("Ès adulto e solteiro");
        }


    }
}
