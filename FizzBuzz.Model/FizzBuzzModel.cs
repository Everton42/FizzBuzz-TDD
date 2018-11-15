using System;

namespace FizzBuzz.Model
{
    public class FizzBuzzModel
    {
        public string GetResultado(int nmbr)
        {
            // string resultado = string.Empty;  Primeiro o teste deve falhar RED
            var resultado = "";

            for (int i = 1; i<= nmbr; i++) // Solução para os testes passarem GREEN
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    resultado += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    resultado += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    resultado += "Buzz ";
                }
                else
                {
                    resultado += i.ToString() + " ";
                }
            }
            return resultado;
        }
    }
}
