using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        private MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var marcas = marcaRepositorio.Obter();

            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} - { marca.Nome}");//estou imprimindo no console o id e nome da marca

            }

        }
        [TestMethod()]
        public void ObterPorIdTest()
        {

            var marca = marcaRepositorio.Obter(1);
            Assert.AreEqual(marca.Nome, "Ford");

            marca = marcaRepositorio.Obter(8); //estanciei a variável marca recebendo a opção 8
            Assert.IsNull(marca);//perguntei afirmando se o resultado de marca é igual a null?

            //Console.WriteLine($"{marca}");
        }

    }
}