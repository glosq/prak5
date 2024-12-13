using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pair;

namespace prak5
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Oprog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил \n Жаров Артём \n ИСП-34");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Piar par = new Piar();//оглавляешь переменную класса ПАИР
            par.value1=0;               //парсишь значения
            par.value2=0;               //парсишь значения
            Piar par2 = new Piar();//оглавляешь переменную класса ПАИР
            par2.value1 = 0;             //парсишь значения
            par2.value2 = 0;             //парсишь значения
            int a = par.Prais();        //находишь произведение внутри 1 пары
            Piar aa = par.Prais(par2);//находишь произведение между первой и второй 
            

        }
    }
}