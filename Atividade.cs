using System;

namespace Lambda
{
    public abstract class Atividade
    {
        public static double Subtrair(int v1, int v2){
            return v1-v2;
        }
        public static string Multiplicar(int v1, int v2){
            return "O resultado é " + (v1 * v2);
        }
    }
}
