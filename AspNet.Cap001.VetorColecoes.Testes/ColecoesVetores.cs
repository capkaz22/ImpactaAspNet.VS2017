using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Cap001.VetorColecoes.Testes
{
    [TestClass]
    public class ColecoesVetores
    {
        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2019, 11, 2), "Finados");
            feriados.Add(Convert.ToDateTime("15/11/2019"), "Proclamãção da República");
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Consciência Negra");
            //feriado.Add(Convert.ToDateTime("20/11/2019"), "Natal"); não é possível ter dois valores iguais como chave
            var finados = feriados[new DateTime(2019, 11, 2)];
            

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key} : {feriado.Value}");//com horas
                Console.WriteLine($"{feriado.Key.ToShortDateString()} : {feriado.Value}");//sem horas
                Console.WriteLine($"{feriado.Key.ToString("dd/MM/yyyy")} : {feriado.Value}");//sem horas chumbado
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("15/11/2019")));//valida se a data existe dentro da coleção
            Console.WriteLine(feriados.ContainsValue("Finados"));//valida se a string existe dentro da coleção 
        }
    }
}
