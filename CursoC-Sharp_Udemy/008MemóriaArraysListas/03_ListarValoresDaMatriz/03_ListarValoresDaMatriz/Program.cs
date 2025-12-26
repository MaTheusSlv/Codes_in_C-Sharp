using System;

namespace _03_ListarValoresDaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pede o formato da matriz
            Console.WriteLine("Informe o formato da Matriz (Ex: Lin Col)");
            string[] lin_col = Console.ReadLine().Split(" ");
            int linhas = int.Parse(lin_col[0]);
            int colunas = int.Parse(lin_col[1]);

            //cria a matriz
            int[,] matriz = new int[linhas, colunas];

            //pede os valores da matriz
            Console.WriteLine("Informe os valores da Matriz no formato " + linhas + " Linhas X " + colunas + " Colunas:");
            
            //pega os valores digitados e insere na matriz por linha
            for (int linha = 0; linha < linhas; linha++) //passa por cada linha informada...
            {
                string[] lista = Console.ReadLine().Split(" "); //...quebrando os números numa lista
                for (int colunadalista = 0; colunadalista < colunas; colunadalista++) //passa por cada número dessa lista
                {
                    matriz[linha, colunadalista] = int.Parse(lista[colunadalista]); //insere na matriz, com base na linha e na coluna dele
                }
            }

            //pede o número contido na matriz a ser pesquisado
            Console.Write("\nInforme o número a ser observado: ");
            int find = int.Parse(Console.ReadLine());

            //lê a matriz e mostra os resultados verificando a posição do número procurado
            for (int i = 0; i < linhas; i++) //i = linhas
            {
                for (int j = 0; j < colunas; j++) //j = colunas
                {
                    if (matriz[i, j] == find) //Se achar o valor...
                    {
                        Console.WriteLine("\nPosition " + i + "," + j + ":"); //Posição

                        if (j > 0) //Se não estiver no canto esquerdo...
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]); //Left
                        }
                        if (i > 0) //Se não estiver no topo...
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]); //Up
                        }
                        if (j < colunas - 1) //Se não estiver no canto direito...
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]); //Right
                        }
                        if (i < linhas - 1) //Se não estiver no rodapé...
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]); //Down
                        }
                    }
                }
            }
        }
    }
}
