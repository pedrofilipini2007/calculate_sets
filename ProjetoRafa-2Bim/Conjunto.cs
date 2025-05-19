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
                    //cria um vetor com o nome numeros que separa toda a variavel txt_add por ',' e ' ' 
                    string[] numeros = entrada.Split(',', ' ');

                    foreach (var parte in numeros)
                    {
                        //transformo eles em numeros inteiros
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










        public override string ToString() => string.Join(", ", elementos);
        
    }
}
