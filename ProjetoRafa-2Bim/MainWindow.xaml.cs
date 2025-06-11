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

        Conjunto conjunA = new Conjunto();
        Conjunto conjunB = new Conjunto();

        Conjunto result = new Conjunto();


        //ADICIONANDO

        //Adicionando números no conjun A

        private void btn_add_conjunA_Click(object sender, RoutedEventArgs e)
        {
            conjunA.Adicionar(txt_conjunA.Text);

            lbl_conjunA.Text = conjunA.ToString();

            //limpa a txtbox
            txt_conjunA.Clear();
        }

        //Adicionando números no conjun B

        private void btn_add_conjunB_Click(object sender, RoutedEventArgs e)
        {
            conjunB.Adicionar(txt_conjunB.Text);

            lbl_conjunB.Text = conjunB.ToString();

            //limpa a txtbox
            txt_conjunB.Clear();


        }


        //REMOVENDO

        //Removendo elementos do Conjun A

        private void btn_remove_conjunA_Click(object sender, RoutedEventArgs e)
        {
            //Remove os números informados no TextBox do conjunto A
            conjunA.Remover(txt_conjunA.Text, conjunA);

            //Atualiza a interface.
            lbl_conjunA.Text = conjunA.ToString();

            //limpa txtbox do conjun A
            txt_conjunA.Clear();


        }

        //Removendo elementos do Conjun B

        private void btn_remove_conjunB_Click(object sender, RoutedEventArgs e)
        {

            //Remove os números informados no TextBox do conjunto B
            conjunB.Remover(txt_conjunB.Text, conjunB);

            //Atualiza a interface.
            lbl_conjunB.Text = conjunB.ToString();

            //limpa txtbox do conjun B
            txt_conjunB.Clear();

        }

        private void btn_random_conjunA_Click(object sender, RoutedEventArgs e)
        {
            conjunA.randomizar(conjunA);

            lbl_conjunA.Text = conjunA.ToString();

            txt_conjunA.Clear();
        }

        private void btn_random_conjunB_Click(object sender, RoutedEventArgs e)
        {
            conjunB.randomizar(conjunB);

            lbl_conjunB.Text = conjunB.ToString();

            txt_conjunB.Clear();
        }

        private void btnUniao_Click(object sender, RoutedEventArgs e)
        {
            Conjunto result = new Conjunto();
            result = result.Uniao(conjunA, conjunB);

            lbl_resultado.Text = result.ToString();

        }

        private void btnInterseçao__Click(object sender, RoutedEventArgs e)
        {
            Conjunto result = new Conjunto();
            result = result.Intersecao(conjunA, conjunB);

            lbl_resultado.Text = result.ToString();
        }

        private void btnDiferenca_AB_Click(object sender, RoutedEventArgs e)
        {
            Conjunto result = new Conjunto();
            result = result.Diferenca(conjunA, conjunB);

            lbl_resultado.Text = result.ToString();
        }

        private void btnDiferenca_BA_Click(object sender, RoutedEventArgs e)
        {
            Conjunto result = new Conjunto();
            result = result.Diferenca(conjunB, conjunA);

            lbl_resultado.Text = result.ToString();
        }
    }
}