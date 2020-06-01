using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entrada N (Linhas)");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entrada M (Colunas)");
        int M = Convert.ToInt32(Console.ReadLine());

        if (N>=2 && N<=50 && M>=2 && M<=50)     //Verificar Entradas
            verificarcondicao(N, M);            //Funcao Verificar Regra Geral
        else 
        Console.WriteLine("Insira numeros entre 2 e 50");
    }
    static void verificarcondicao(int N, int M)
    {
        if ((N==(M*2 -1)) || (M==(N*2-1)))
        {
            switch (N>M)
            {
                case true:
                    respostal(N, M); //Chamada da Funcao Linhas > Colunas
                    break;
                case false:
                    respostac(N,M); //Chamada da Funcao Colunas > Linhas
                    break;
            }
        }
        else
            Console.WriteLine("NAO E POSSIVEL GERAR PIRAMIDE");         
    }
    static void respostal(int N, int M)         //Funcao Linhas>Colunas
    {
        int l = 0, c = M, cont = 0;
        //Formar Piramide:
        for(l=0; l<M; l++)
        {
            for(cont = 1; cont < c;cont++)
                Console.Write("---");
            c--;                               //Diminuir quantidade de [#] gradativamente.
            for(cont = l; cont >= 0; cont--)
                Console.Write("[#]");
            Console.WriteLine("\n");
        }
        c = M;
        for(l = 1; l < M; l++)                  //Inicia com 1 para nao repetir a linha composta somente por [#]
        { 
            for(cont = 0; cont < l; cont++)
                Console.Write("---");
            c--;                                //Diminuir quantidade de [#] gradativamente.
            for(cont = 0; cont < c; cont++)
                Console.Write("[#]");
            Console.WriteLine("\n");                     
        }
    }
    static void respostac(int N, int M)
    {    //Funcao para Colunas > Linhas
        int l = 0, c = 0, cont = 0;
        //Formar Piramide:
        for(l = 0; l < N; l++)
        {
            for(cont=0; cont<(l*3); cont++)
                Console.Write("-");         //Adicionar "-" inicio
            for(c = 0; c < M; c++)
                Console.Write("[#]");       //Adicionar "[#]"
            M-=2;
            for(cont = 0; cont<(l*3); cont++)
            Console.Write("-");
            Console.WriteLine("\n");        //Adicionar "-" final
        }
    }
}