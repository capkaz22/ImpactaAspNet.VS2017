using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public List<Cor> Obter()//Retorna um um list do tipo cor o nome do método é obter
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))///criando o objeto cor
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0,5));
                cor.Nome = linha.Substring(5);
                cores.Add(cor);                  
            }

            return cores;
        }

        public Cor Obter(int id)
        {

            var cor = new Cor();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))///criando o objeto cor
            {
                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaId)///Ctrl + K + S --> envolver e criar um código, sound round, digitar o comando, no caso if
                {
                    cor = new Cor();
                    cor.Id = linhaId;
                    cor.Nome = linha.Substring(5);

                    break;
                }
                
            }



            return cor;
        }

    }
}
