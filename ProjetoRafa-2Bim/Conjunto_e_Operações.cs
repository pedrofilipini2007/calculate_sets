using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoRafa_2Bim
{
    public class Conjunto_e_Operações
    {

        public HashSet<int> elementos;
        private const int max_limit = 20; // Definindo o limite máximo de elementos no conjunto

        public Conjunto_e_Operações()
        {
            elementos = new HashSet<int>();
        }

        public void Adicionar(string entrada, int len_conjun)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(entrada))
                {
                    //cria um vetor com o nome números que separa a string por ',' e ' ' 
                    string[] numeros = entrada.Split(',', ' ');

                    foreach (var parte in numeros)
                    {
                        if (numeros.Length + len_conjun > max_limit)
                        {
                            MessageBox.Show("O conjunto já atingiu o limite máximo de " + max_limit + " elementos.");
                            return;
                        }
                        else
                        {
                            //transformo eles em números inteiros
                            if (int.TryParse(parte.Trim(), out int numero))
                            {
                                elementos.Add(numero);
                            }
                            else
                            {
                                MessageBox.Show("Entrada inválida: " + parte.Trim() + ". Por favor, insira números inteiros.");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Voce não colocou nenhum numero para ser adicionado");
                }
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }
        }

        public void Remover(string entrada, Conjunto_e_Operações conjunto)
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
                    MessageBox.Show("Voce não colocou nenhum numero para ser removido");
                }
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }
        }

        public void randomizar(Conjunto_e_Operações conjunto)
        {
            elementos.Clear(); // Limpa os elementos existentes

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                elementos.Add(random.Next(1, 100)); // Gera números entre 1 e 99
            }
        }



     
        //Operações de conjuntos
        public Conjunto_e_Operações Uniao(Conjunto_e_Operações conjuntoA, Conjunto_e_Operações conjuntoB)
        {
            try
            {
                Conjunto_e_Operações result = new Conjunto_e_Operações();
                result.elementos = (conjuntoA.elementos.Union(conjuntoB.elementos).ToHashSet());

                return result;
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
                return null;
            }
        }

        public Conjunto_e_Operações Intersecao(Conjunto_e_Operações conjuntoA, Conjunto_e_Operações conjuntoB)
        {
            try
            {
                Conjunto_e_Operações result = new Conjunto_e_Operações();
                result.elementos = (conjuntoA.elementos.Intersect(conjuntoB.elementos).ToHashSet());

                return result;
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
                return null;
            }
        }

        public Conjunto_e_Operações Diferenca(Conjunto_e_Operações conjuntoA, Conjunto_e_Operações conjuntoB)
        {
            try
            {
                Conjunto_e_Operações result = new Conjunto_e_Operações();
                result.elementos = (conjuntoA.elementos.Except(conjuntoB.elementos).ToHashSet());

                return result;
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
                return null;
            }
        }

        






        //override faz mostrar os elementos da classe em vez de só o nome da classe
        //OrderBy() é um método de extensão LINQ que ordena os elementos de uma sequência em ordem crescente ou decrescente.
        //e => e define a ordenação como  crecente (menor para o maior)
        //ToString() é um método que retorna uma string que representa o objeto atual.
        public override string ToString() => string.Join(", ", elementos.OrderBy(e => e));
        
    }
}
