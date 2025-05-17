using System.Text;
using System.IO;
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

                    //mudo o conteudo da lbl do conjunto A
                    lbl_conjunA.Content = string.Join(",", conjun_A);  
                
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

                }
                else
                {
                    MessageBox.Show("Voce não colocou nenhum numero para ser adicionado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }
        }
    }
}