using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Cap001.VetorColecoes.Testes {
    [TestClass]
    public class ColecoesTeste {
        [TestMethod]
        public void listTeste() 
        {
            var inteiros = new List<int>(1000) { 16,3,2,-81};
            inteiros.Add(15); //para adicionar um elemente usar o add
            inteiros[0] = 23;// neste caso está sendo substituido o valor
            //inteiros[10] = 2;//essa posição não existe, por que não foi criada ainda

            var maisInteiros = new List<int> { 4, 2, 3 };

            inteiros.AddRange(maisInteiros);///adicionar uma rande de informações no caso uma lista inteira

            inteiros.Insert(0, 29);

            inteiros.Remove(2);//remove o número 2 da lista

            inteiros.RemoveAll(x=> x == 2);//expressão Lâmbida

            inteiros.RemoveAt(4);//remove o valor da posição 4;

            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();

            var ultimo = inteiros.Last();
            ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros) 
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");
            }



        }
    }
}
