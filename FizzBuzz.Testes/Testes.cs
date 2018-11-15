using System;
using Xunit;
using FizzBuzz.Model;

namespace FizzBuzz.Testes
{
    public class Testes
    {
        //[Fact]

        //public void Dado1Return12()
        //{
        //    var fb = new FizzBuzzModel();
        //    var resultadoEsperado = "1 2 ";
        //    var recebido = fb.GetResultado(2);
        //    Assert.Equal(resultadoEsperado, recebido);
        //}

        //[Fact]

        //public void Dado3Return12Fizz()
        //{
        //    var fb = new FizzBuzzModel();
        //    var resultadoEsperado = "1 2 Fizz ";
        //    var recebido = fb.GetResultado(3);
        //    Assert.Equal(resultadoEsperado, recebido);
        //}

        //[Fact]

        //public void Dado5Return12Fizz4Buzz()
        //{
        //    var fb = new FizzBuzzModel();
        //    var resultadoEsperado = "1 2 Fizz 4 Buzz ";
        //    var recebido = fb.GetResultado(5);
        //    Assert.Equal(resultadoEsperado, recebido);
        //}

        //[Fact]

        //public void Dado15Return12Fizz4Buzz_Etc()
        //{
        //    var fb = new FizzBuzzModel();
        //    var resultadoEsperado = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
        //    var recebido = fb.GetResultado(15);
        //    Assert.Equal(resultadoEsperado, recebido);
        //}

        [Theory] // Refatoração (Parametrização)
        [InlineData(2, "1 2 ")]
        [InlineData(3, "1 2 Fizz ")]
        [InlineData(5, "1 2 Fizz 4 Buzz ")]
        [InlineData (15, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ")] 
        
        public void Teste(int nmbr, string resultadoEsperado)
        {
            var fb = new FizzBuzzModel();
            var recebido = fb.GetResultado(nmbr);
            Assert.Equal(recebido, resultadoEsperado);
        }

    }
}
