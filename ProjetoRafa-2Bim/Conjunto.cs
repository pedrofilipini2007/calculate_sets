using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRafa_2Bim
{
    public class Conjunto
    {
        private HashSet<int> elementos;

        public Conjunto()
        {
            elementos = new HashSet<int>();
        }

        public void Adicionar(string entrada)
        {
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    //cria um vetor com o nome números que separa a string por ',' e ' ' 
                    string[] numeros = entrada.Split(',', ' ');

                    foreach (var parte in numeros)
                    {
                        //transformo eles em números inteiros
                        if (int.TryParse(parte.Trim(), out int numero))
                        {
                            elementos.Add(numero);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Voce não colocou nenhum numero para ser adicionado");
                }
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
            }

        }

        public void Remover(string entrada, Conjunto conjunto)
        {
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    string[] numeros = entrada.Split(',', ' ');

                    foreach (var parte in numeros)
                    {
                        if (int.TryParse(parte.Trim(), out int numero))
                        {
                            elementos.Remove(numero);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Voce não colocou nenhum numero para ser removido");
                }
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
            }
        }

        public void randomizar(Conjunto conjunto)
        {
            elementos.Clear(); // Limpa os elementos existentes

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                elementos.Add(random.Next(1, 100)); // Gera números entre 1 e 99
            }
        }



     







        //override faz mostrar os elementos da classe em vez de só o nome da classe
        //OrderBy() é um método de extensão LINQ que ordena os elementos de uma sequência em ordem crescente ou decrescente.
        //e => e define a ordenação como  crecente (menor para o maior)
        //ToString() é um método que retorna uma string que representa o objeto atual.
        public override string ToString() => string.Join(", ", elementos.OrderBy(e => e));
        
    }
}
