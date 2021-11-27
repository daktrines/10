using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина Максимовна. 10 пр.  " +
                "\nВ первом одномерном массиве хранятся " +
                "затраты на производство продуктов, во " +
                "втором — цены на эти продукты.Указать номер первого продукта, " +
                "затраты на производство которого превышают цены.");
        }

        //Выход из программы
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Добавить_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Очистить_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Найти_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
