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
    

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

     
        Conjunto_e_Operações conjunA = new Conjunto_e_Operações();
        Conjunto_e_Operações conjunB = new Conjunto_e_Operações();

        Conjunto_e_Operações result = new Conjunto_e_Operações();
        bool testes = false;



        private void btn_add_conjunA_Click(object sender, RoutedEventArgs e)
        {
            conjunA.Adicionar(txt_conjunA.Text, conjunA.elementos.Count);

            lbl_conjunA.Text = conjunA.ToString();

            if (testes)
            {
                txttask1_1.Text = "✔️";
            }
            //limpa a txtbox
            txt_conjunA.Clear();
        }

        //Adicionando números no conjun B

        private void btn_add_conjunB_Click(object sender, RoutedEventArgs e)
        {
            conjunB.Adicionar(txt_conjunB.Text, conjunB.elementos.Count);

            lbl_conjunB.Text = conjunB.ToString();

            if (testes)
            {
                txttask1_1.Text = "✔️";
            }
            //limpa a txtbox
            txt_conjunB.Clear();


        }


        //REMOVENDO

   

        private void btn_remove_conjunA_Click(object sender, RoutedEventArgs e)
        {
            //Remove os números informados no TextBox do conjunto A
            conjunA.Remover(txt_conjunA.Text, conjunA);

            //Atualiza a interface.
            lbl_conjunA.Text =conjunA.ToString();

            if (testes)
            {
                txttask1_2.Text = "✔️";
            }

            //limpa txtbox do conjun A
            txt_conjunA.Clear();


        }


        private void btn_remove_conjunB_Click(object sender, RoutedEventArgs e)
        {

            //Remove os números informados no TextBox do conjunto B
            conjunB.Remover(txt_conjunB.Text, conjunB);

            //Atualiza a interface.
            lbl_conjunB.Text = conjunB.ToString();

            if (testes)
            {
                txttask1_2.Text = "✔️";
            }

            //limpa txtbox do conjun B
            txt_conjunB.Clear();

        }


        //função random
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



        //Operações entre conjuntos
        private void btnUniao_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_conjunA.Text) || !string.IsNullOrEmpty(lbl_conjunB.Text))
            {
                result = result.Uniao(conjunA, conjunB);
                if (testes)
                {
                    txttask2_1.Text = "✔️";
                }
                lbl_resultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Não tem nada em nenhumdos conjuntos");
            }

        }

        private void btnInterseçao__Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_conjunA.Text) || !string.IsNullOrEmpty(lbl_conjunB.Text))
                {
                result = result.Intersecao(conjunA, conjunB);
                if (testes)
                {
                    txttask2_2.Text = "✔️";
                }
                lbl_resultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Não tem nada em nenhum dos conjuntos");
            }
           
        }

        private void btnDiferenca_AB_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_conjunA.Text) || !string.IsNullOrEmpty(lbl_conjunB.Text))
                {
                result = result.Diferenca(conjunA, conjunB);
                if (testes)
                {
                    txttask2_3.Text = "✔️";
                }
                lbl_resultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Não tem nada em nenhum dos conjuntos");
            }
        }

        private void btnDiferenca_BA_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_conjunA.Text) || !string.IsNullOrEmpty(lbl_conjunB.Text))
            {
                result = result.Diferenca(conjunB, conjunA);
                if (testes)
                {
                    txttask2_4.Text = "✔️";
                }
                lbl_resultado.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Não tem nada em nenhum dos conjuntos");
            }
        }

        //Testes

        private void btnTestes_Click(object sender, RoutedEventArgs e)
        {
            testes = true;

            conjunA.elementos.Clear();
            conjunA.Adicionar("1,2,3,4,5,6,7,8,9,10", conjunA.elementos.Count);
            lbl_conjunA.Text = conjunA.ToString();

            conjunB.elementos.Clear();
            conjunB.Adicionar("5,6,7,8,9,10,11,12,13,14,15", conjunB.elementos.Count);
            lbl_conjunB.Text = conjunB.ToString();


        }
    }
}