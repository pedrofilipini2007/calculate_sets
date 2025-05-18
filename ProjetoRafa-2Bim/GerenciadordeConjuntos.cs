using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjetoRafa_2Bim
{
    internal class GerenciadordeConjuntos
    {
        //FUNÇÃO USADA PARA ADD

        //função que converte uma string em um vetor de inteiros
        public static int[] Converter_txtbox_vetordeinteiros(string txtbox)
        {
            try
            {
                //atribui o texto que esta no elemento txt_conjunA a uma string
                string txt_add = txtbox;

                //verifca se a string esta em branco ou nula
                if (!string.IsNullOrEmpty(txt_add))
                {
                    //cria um vetor com o nome numeros que separa toda a variavel txt_add por ',' e ' ' 
                    string[] numeros = txt_add.Split(',', ' ');

                    //cria uma lista de numeros, n lembro pq é melhor
                    List<int> lista = new List<int>();

                    //adiciona os numeros na lista 
                    foreach (string parte in numeros)
                    {
                        //transformo eles em numeros inteiros
                        if (int.TryParse(parte.Trim(), out int numero))
                        {
                            lista.Add(numero);
                        }
                    }

                    //atribui a lista transformada em vetor para o conjunA 
                    int[] conjun_A = lista.ToArray();

                    //retorna conjun A
                    return conjun_A;
                    

                }
                else
                {
                    MessageBox.Show("Voce não colocou nenhum numero para ser adicionado");
                    return new int[0]; //retorna valor vazio
                }
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);

                return new int[0]; //retorna valor vazio
            }
        }

        //FUNÇÃO USADA PARA REMOVER

        //remove os elementos do vetor de inteiros que tambem estão presentes na string
        public static int[] RemoverElementosDoVetor(string txtbox, int[] conjun)
        {
            try
            {
                //variavel armazenando a txtbox do conjun 
                string txt_remove = txtbox;

                //verifica se a string é nula ou esta em branco
                if (!string.IsNullOrEmpty(txt_remove))
                {
                    //separa os elemento por ',' ou ' '
                    string[] numeros = txt_remove.Split(',', ' ');

                    //cria uma lista de numeros int que tem o mesmo que o conjunto 
                    List<int> lista = new List<int>(conjun);

                    //percorre numeros, verifica se esta presente em conjun transforma em numeros int e depois adiciona na lista
                    foreach (string parte in numeros)
                    {
                        if (int.TryParse(parte.Trim(), out int numero) && conjun.Contains(numero))
                        {
                            lista.Remove(numero);
                        }
                    }

                    //iguala o conjun ao o que tem na lista de numeros int
                    //retorna conjun
                    return (conjun = lista.ToArray());

                }

                else
                {
                    MessageBox.Show("Voce não colocou nenhum numero para ser adicionado");
                    return new int[0]; //retorna valor vazio
                }
            }
            catch (Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);

                return new int[0]; //retorna valor vazio
            }
        }

    }
}

