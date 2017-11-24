using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeiro, FUNC:
            Func<int,int,int> variavel = soma;
            Console.WriteLine(variavel(50,60));

            Func<int, int, double> variavel2 = Atividade.Subtrair;
            Console.WriteLine(variavel2(10,5));

            Func<int, int, string> variavel3 = Atividade.Multiplicar;
            Console.WriteLine(variavel3(10,5));

            //Agora ACTION:
            Action<int,int> variavel4 = soma2;
            variavel4(5,5);

            //Agora, PREDICATE:
            //Predicate<int> variavel5 = Par;
            //Console.WriteLine(variavel5(33));

            //Agora, uma função anônima com DELEGATE
            Data dt = delegate(string msg){
                return msg + " hoje é " + DateTime.Now.ToShortDateString();
                };
            Console.WriteLine(dt("Oba"));

            //Analisando uma estrutura sem utilização do Lambda expression:
            //int[] valores = {40,56,1,23,9,11,22,0};
            //foreach(int i in valores)
            //if(Par(i)){
                //Console.WriteLine(i);
            //}
            
            //Analisando uma estrutura sem utilização do Lambda expression, mas com delegate anonimo:
            //int[] valores = {40,56,1,23,9,11,22,0};
            
            //Func<int,bool> variavel7 = delegate( int x)
            //{
                //return x%2 == 0;
            //};

            //Agora fazendo tudo de novo, mas com o LAMBDA:
            //int[] valores = {40,56,1,23,9,11,22,0};
            //Func<int,bool> variavel7 = r => r % 2 == 0;

            //foreach(int i in valores)
            //if(variavel7(i)){
                //Console.WriteLine(i);
            //}

            //Segundo exemplo de LAMBDA:
            Func<double,double,double> calculo = (x,y) => x/y;
            Console.WriteLine(calculo(23,5));

        }
        static int soma(int v1, int v2){
            return v1+v2;
        }
        static void soma2(int v1, int v2){
            Console.WriteLine(v1+v2);
        }
        //static bool Par(int valor){
            //return valor%2==0;
        //}
        delegate string Data(string mensagem);
        
    }
}
