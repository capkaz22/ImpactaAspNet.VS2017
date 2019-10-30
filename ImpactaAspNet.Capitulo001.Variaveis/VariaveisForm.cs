using System;
using System.Windows.Forms;//ctrl + . remove todos os itens inúteis

namespace ImpactaAspNet.Capitulo001.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;//Quando a variável está a nível de classe ela se chama field, atributo
        int a = 10;


        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6, c = 10;
            var d = 13;

            resultadoListBox.Items.Add("a = " + a);// o sinal de "+" concatena informação
            resultadoListBox.Items.Add(string.Concat("b = ", b));
            resultadoListBox.Items.Add(string.Format("c = {0}, d = {1}", c, d));
            resultadoListBox.Items.Add($"d ={d}");//concatenação interpolada

            resultadoListBox.Items.Add($"c * d ={c * d}");//multiplicação
            resultadoListBox.Items.Add($"d / a = {d / a}");//divisão
            resultadoListBox.Items.Add($"d % a = {d % a}");//operador módulo










            //string nome = "Carlos";
            //var endereco = "R. Tal, 45";
            //var valor = 20.29m;/* o m é para confirmar que é do tipo decimal quando utilizado o var*/
            //var aprovado = true;
            //var nascimento = new DateTime(1976,09,08);//posicionar o cursos dentro do parenteses e pressionar ctrl+shift+barra de espaço
            ///*O C# é case sencitive diferencia maiusculas de minusculas*/
            ///*a linguagem é estaticamente tipada quando uma variável é criada ele é o seu tipo até o fim do código*/
            ///*variáveis do tipo object é um tipo camaleão, podendo mudar conforme a variação de uso*/
            //object coisa = "texto";
            //coisa = DateTime.Now;
            ////var e = 58;
            //var @class = "E3";//Para poder usar uma palavra reservada em outro contexto, quebrando a palavra reservada






        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            //x = x - 3;
            resultadoListBox.Items.Add($"x = {x}");
            x -= 3;//operação aritmético reduzido
            resultadoListBox.Items.Add($"x = {x}");


        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 5;
            resultadoListBox.Items.Add("Exemplo de pré-incremento");
            resultadoListBox.Items.Add($"a = {a}");
            resultadoListBox.Items.Add($"2+ ++a = {2 + ++a}");
            resultadoListBox.Items.Add($"a = {a}");


            //int a = 5;
            resultadoListBox.Items.Add("Exemplo de pós-incremento");
            resultadoListBox.Items.Add($"a = {a}");
            resultadoListBox.Items.Add($"2+ a++ = {2 + a++}");
            resultadoListBox.Items.Add($"a = {a}");

        }

        private void boleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValoresVariaveis();

            resultadoListBox.Items.Add($"w < = z = {w <= z}");
            resultadoListBox.Items.Add($"x < == z = {x == z}");
            resultadoListBox.Items.Add($"x != z = {x != z}");


        }

        private void ExibirValoresVariaveis()
        {
            resultadoListBox.Items.Add($"x = {x}");
            resultadoListBox.Items.Add($"y = {y}");
            resultadoListBox.Items.Add($"w = {w}");
            resultadoListBox.Items.Add($"z = {z}");
            resultadoListBox.Items.Add(new string('-',50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValoresVariaveis();

            
            resultadoListBox.Items.Add($"w <= x || y == 16 = {w <= x || y == 16}");//tabela verdadeiro ou falso OU
            ///Usar o pipe || ou && dobrado para fazer um short circuit
            resultadoListBox.Items.Add($"x == z = && z != x = {x == z && z != x}");
            resultadoListBox.Items.Add($"!(y > w) = {!(y > w)}");



        }

        private void ternarioToolStripMenuItem_Click(object sender, EventArgs e) {

            int ano;
            ano = 2014;

            //resultadoListBox.Items.
            //    Add($"O ano {ano} é bissexto? {(ano%4 == 0?"Sim":"Não")}.");
            ///dá para quebrar a linha nos pontos
            ///o ternário recebe três condições, a pergunta, a primeira condição e a terceira condição
            ///fazendo um paralalelo com o excel é a condição SE

            ano = 2020;
            resultadoListBox.Items.
                Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano)? "Sim" : "Não")}.");



        }
    }
}
