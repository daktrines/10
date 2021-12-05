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
        
        
        List<int> list1 = new List<int>();//создаем коллекцию list1
        List<int> list2 = new List<int>();//создаем коллекцию list2


        private void Добавить_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(Zn.Text, out int zn) && zn>0)
            {
                list1.Add(zn);//добавляем элементы в коллекцию
               listBox1.Items.Add(zn);//добавляем элементы в listBox1
            } 
            else MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Rez.Clear();
            Zn.Clear();
            list1.Clear();
            list2.Clear();
        }

        private void Найти_Click(object sender, RoutedEventArgs e)
        {
            int pos = 0;
            for (int i = 0; i < list1.Count ; i++)
            {
                if (list1[i] > list2[i])
                {
                    pos = i + 1;
                    break;//немедленный выход из цикла
                }
            }
            Rez.Text = Convert.ToString(pos);// Rez.Text = pos.ToString() тоже самое
        }

        private void Добавить1_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(Zn.Text, out int zn) && zn > 0)
            {
                list2.Add(zn);//добавляем элементы в коллекцию
                listBox2.Items.Add(zn);//добавляем элементы в listBox2
            }
            else MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
