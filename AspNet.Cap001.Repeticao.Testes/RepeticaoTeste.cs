using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Cap001.Repeticao.Testes {
    [TestClass]
    public class RepeticaoTeste {
        [TestMethod]
        public void TabuadaTest() 
        {
            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 1; j <= 10; j++) 
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");//'ctrl r + r' ou 'ctrl + .'  = Renomear
                }
                Console.WriteLine(new string('-',50));//cw+tab+tab
            }
        }

        [TestMethod]//testm + tab tab
        public void EstruturForTest() 
        {
            var i = 1;
            for (Console.WriteLine("Iniciou")/*roda uma vez*/; i <= 3; Console.WriteLine(i++))//i++ = iniciou, 1, 2 e 3 - ++i = iniciou, 2, 3 e 4
            {
                //i++;

                /*
                 for(1. Inicialização; 2. Critério; 4. Pós-execução)
                {    
                    3. Execução
                }
                 */
            }
        }
        [TestMethod]
        public void ForApenasComCondicaoTest()
        {
            var i = 1;
            for (; i < 3;) ///As extremedidas do For não são obrigatórias
            {
                Console.WriteLine(i++);
            }

        }

        [TestMethod]
        public void ContinueTeste() 
        {
            for (int i = 1; i <= 10; i++) 
            {
                if (i <= 5) 
                {
                    continue;//ignora e continua a instrução
                }
                Console.WriteLine(i);

            }
        }

        [TestMethod]
        public void BreakTeste() 
            {
            for (int i = 1; i <= 10; i++) 
                {
                    if (i > 5) {
                        break;//para a instrução quando a condição é atendida
                }
                Console.WriteLine(i);

            }
        }

    }

}

