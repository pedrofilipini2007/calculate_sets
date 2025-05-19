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

        int[] conjun_A = [0];
        int[] conjun_B = [0];


        //ADICIONANDO

        //Adicionando números no conjun A

        private void btn_add_conjunA_Click(object sender, RoutedEventArgs e)
        {
            conjunA.Adicionar(txt_conjunA.Text);

            lbl_conjunA.Content = conjunA.ToString();

            //limpa a txtbox
            txt_conjunA.Clear();
        }

        //Adicionando números no conjun B

        private void btn_add_conjunB_Click(object sender, RoutedEventArgs e)
        {
            conjunB.Adicionar(txt_conjunB.Text);

            lbl_conjunB.Content = conjunB.ToString();

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
            lbl_conjunA.Content =conjunA.ToString();

            //limpa txtbox do conjun A
            txt_conjunA.Clear();


        }

        //Removendo elementos do Conjun B

        private void btn_remove_conjunB_Click(object sender, RoutedEventArgs e)
        {

            //Remove os números informados no TextBox do conjunto B
            conjunB.Remover(txt_conjunB.Text, conjunB);

            //Atualiza a interface.
            lbl_conjunB.Content = conjunB.ToString();

            //limpa txtbox do conjun B
            txt_conjunB.Clear();

        }
        
    }
}