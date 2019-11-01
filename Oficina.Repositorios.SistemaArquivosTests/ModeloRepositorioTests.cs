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
    public class ModeloRepositorioTests
    {
        ModeloRepositorio repositorio = new ModeloRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var modelos = repositorio.ObterPorMarca(2);

            foreach (var modelo in modelos)
            {
                Console.WriteLine($"{modelo.Id} - {modelo.Nome} - {modelo.Marca.Nome}");

            }
            modelos = repositorio.ObterPorMarca(10);
            Assert.IsTrue(modelos.Count == 0);

        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            var modelo = repositorio.Obter(3);

            Assert.AreEqual(modelo.Nome, "Fox");

            modelo = repositorio.Obter(28);
            Assert.IsNull(modelo);
            
        }
    }
}