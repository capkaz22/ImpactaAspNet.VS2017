using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Cap001.VetorColecoes.Testes {
    [TestClass]
    public class VetoresTeste {
        [TestMethod]
        public void InicializacaoTeste() 
        {
            var inteiros = new int[5];

            inteiros[0] = 48;
            inteiros[1] = 20;
            //inteiros[-5] = 8; CUIDADO O BUILD NÃO QUEBRA, CRASHA

            var decimais = new decimal[] { 0.2m, 5, 2.52m, 1.9m};
            decimal[] maisDecimais = { 4.71m, 7.78m, 89.47m, 5};///outro jeito de fazer o vetor

            foreach (var @decimal in decimais) 
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é {decimais.Length}");//nameof garante que o nome da varíave será mostrada

        }

        [TestMethod]
        public void RedimensionamentoTeste() 
        {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };

            Array.Resize(ref decimais, 5);

            decimais[3] = 1.7m;

            Assert.AreEqual(decimais[4], 0m);//'Asser' afirmação para pergunta, 'AreEqual' será que é igual
            ///vetor, existe um valor defaut para números primitivos

        }


        [TestMethod]
        public void OrdenacaoTeste() 
        {

            var decimais = new decimal[] { 2.1m, 1.6m, -8 };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -8m);

        }

        [TestMethod]
        public void ParamsTeste() 
        {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };
            Console.WriteLine(Media(decimais));//chamar o método média
            Console.WriteLine(Media(1.9m, 2.19m, -8m));
            Console.WriteLine(decimais.Average());

        }
        /// <summary>
        /// Calcula a média dos valores informados
        /// </summary>
        /// <param name="valor1">Valores a serem claculados</param>
        /// <param name="valor2">A média</param>
        /// <returns></returns>
        private decimal Media(decimal valor1, decimal valor2) 
        {
            return (valor1 + valor2) / 2; ///return interrompe a execução do método
        }

        private decimal Media(params decimal[] valores) 
        {
            var soma = 0m;

            foreach (var valor in valores) ///preciso eleger uma nome para a posição do vetor 'valor'
            {
                soma += valor;
            }

            return soma / valores.Length;
        }

        ///CONTRAIR TODOS OS ELEMENTOS NA CLASSE CTRL + M + O
        ///EXPANDIR CTRL + M + L
        ///
        [TestMethod]
        public void TodaStringEhUmVetor() 
        {
            var nome = "Carlos";
            Assert.AreEqual(nome[0],'C');
            //StringBuilder; tem mais perfomance

            foreach (var letra in nome) 
            {
                Console.Write(letra);
            }
        }



    }
}
