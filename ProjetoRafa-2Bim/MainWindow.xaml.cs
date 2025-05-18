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


        //ADICIONANDO

        //Adicionando números no conjun A

        private void btn_add_conjunA_Click(object sender, RoutedEventArgs e)
        {
            //usa a função para converter o texto da txtbox do conjun A em um vetor de inteiros
            conjun_A = GerenciadordeConjuntos.Converter_txtbox_vetordeinteiros(txt_conjunA.Text);

            //muda o conteudo da lbl do conjunto A para o que esta dentro do vetor
            lbl_conjunA.Content = string.Join(",", conjun_A);

            //limpa a txtbox
            txt_conjunA.Clear();
        }

        //Adicionando números no conjun B

        private void btn_add_conjunB_Click(object sender, RoutedEventArgs e)
        {
            //usa a função para converter o texto da txtbox do conjun B em um vetor de inteiros
            conjun_B = GerenciadordeConjuntos.Converter_txtbox_vetordeinteiros(txt_conjunB.Text);

            //muda o conteudo da lbl do conjunto B para o que esta dentro do vetor
            lbl_conjunB.Content = string.Join(",", conjun_B);

            //limpa a txtbox
            txt_conjunB.Clear();


        }





        //REMOVENDO

        //Removendo elementos do Conjun A

        private void btn_remove_conjunA_Click(object sender, RoutedEventArgs e)
        {
            //Remove os números informados no TextBox do conjunto A
            conjun_A = GerenciadordeConjuntos.RemoverElementosDoVetor(txt_conjunA.Text, conjun_A);

            //Atualiza a interface.
            lbl_conjunA.Content = String.Join(",", conjun_A);

            //limpa txtbox do conjun A
            txt_conjunA.Clear();


        }

        //Removendo elementos do Conjun B

        private void btn_remove_conjunB_Click(object sender, RoutedEventArgs e)
        {

            //Remove os números informados no TextBox do conjunto B
            conjun_B = GerenciadordeConjuntos.RemoverElementosDoVetor(txt_conjunB.Text, conjun_B);

            //Atualiza a interface.
            lbl_conjunB.Content = String.Join(",", conjun_B);

            //limpa txtbox do conjun B
            txt_conjunB.Clear();

        }
        
    }
}