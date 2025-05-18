using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoRafa_2Bim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int[] conjun_A = [0];
        int[] conjun_B = [0];

        //Adicionando numeros no conjun A

        private void btn_add_conjunA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //atribui o texto que esta no elemento txt_conjunA a uma string
                string txt_add = txt_conjunA.Text;

                //verifca se a string esta em branco ou nula
                if (!string.IsNullOrEmpty(txt_add))
                {
                    //cria um vetor com o nome numeros que separa toda a variavel txt_add por ',' e ' ' 
                    string[] numeros = txt_add.Split(',',' ');

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
                    conjun_A = lista.ToArray();

                    //muda o conteudo da lbl do conjunto A
                    lbl_conjunA.Content = string.Join(",", conjun_A);  

                    //limpa a txtbox
                    txt_conjunA.Clear();
                
                }
                else
                {
                    MessageBox.Show("Voce não colocou nenhum numero para ser adicionado");
                }
            }
            catch(Exception ex)
            {
                //se der erro aparece a mensagem de erro
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }
        }

        //Adicionando numeros no conjun B

        private void btn_add_conjunB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //atribui o texto que esta no elemento txt_conjunB a uma string
                string txt_add = txt_conjunB.Text;

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
                    conjun_B = lista.ToArray();

                    //mudo o conteudo da lbl do conjunto A
                    lbl_conjunB.Content = string.Join(",", conjun_B);

                    //limpa a txtbox
                    txt_conjunB.Clear();

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

        //Removendo elementos do Conjun A

        private void btn_remove_conjunA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //variavel armazenando a txtbox do conjun A
                string txt_remove = txt_conjunA.Text;

                //verifica se a string é nula ou esta em branco
                if(!string.IsNullOrEmpty(txt_remove))
                {
                    //separa os elemento por ',' ou ' '
                    string[] numeros = txt_remove.Split(',', ' ');

                    //cria uma lista de numeros int que tem o mesmo que o conjunto A 
                    List<int> lista = new List<int> (conjun_A);

                    //percorre numeros, verifica se esta presente em conjun A transforma em numeros int e depois adiciona na lista
                    foreach (string parte in numeros)
                    {
                        if(int.TryParse(parte.Trim(), out int numero) && conjun_A.Contains(numero))
                        {
                            lista.Remove(numero);
                        }
                    }

                    //iguala o conjun A ao o que tem na lista de numeros int
                    conjun_A = lista.ToArray();

                    //muda a lbl do conjun A para os elementos do conjun A e os separa por virgulas
                    lbl_conjunA.Content = String.Join(",", conjun_A);

                    //limpa txtbox do conjun A
                    txt_conjunA.Clear();
                }
                else
                {
                    MessageBox.Show("Não tem nada para remover no conjunto");
                }
            }
            catch(Exception ex)
            {
                //mostra a mensagem de erro se houver
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message); 
            }
        }

        //Removendo elementos do Conjun B
        private void btn_remove_conjunB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //variavel armazenando a txtbox do conjun A
                string txt_remove = txt_conjunB.Text;

                //verifica se a string é nula ou esta em branco
                if (!string.IsNullOrEmpty(txt_remove))
                {
                    //separa os elemento por ',' ou ' '
                    string[] numeros = txt_remove.Split(',', ' ');

                    //cria uma lista de numeros int que tem o mesmo que o conjunto A 
                    List<int> lista = new List<int>(conjun_B);

                    //percorre numeros, verifica se esta presente em conjun A transforma em numeros int e depois adiciona na lista
                    foreach (string parte in numeros)
                    {
                        if (int.TryParse(parte.Trim(), out int numero) && conjun_B.Contains(numero))
                        {
                            lista.Remove(numero);
                        }
                    }

                    //iguala o conjun A ao o que tem na lista de numeros int
                    conjun_B = lista.ToArray();

                    //muda a lbl do conjun A para os elementos do conjun A e os separa por virgulas
                    lbl_conjunB.Content = String.Join(",", conjun_B);

                    //limpa txtbox do conjun B
                    txt_conjunB.Clear();
                }
                else
                {
                    MessageBox.Show("Não tem nada para remover no conjunto");
                }
            }
            catch (Exception ex)
            {
                //mostra a mensagem de erro se houver
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }
        }
    }
    
}