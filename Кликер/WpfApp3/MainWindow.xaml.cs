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
using System.Windows.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        string[] homes = { "однокомнатная", "двухкомнатная", "трехкомнатная", "четырехкомнатная", "пятикомнатная", "шестикомнатная", "семикомнатная", "восьмикомнатная" };
        int[] homesprice = { 8000000, 12000000, 15000000, 200000000, 25000000, 32000000, 40000000, 50000001 };
        string[] car = {"жигули", "девятка", "ауди", "бэха", "патриот", "гелик" };
        int[] carprice = { 30000, 40000, 900000, 1200000, 600000, 2000000 };
        string[] valera = { "Валера JUNIOR","Валера MIDDLE","Валера SENIOR" };
        int[] valeraprice = { 1000000,10000000,100000000};
        string[] rab = {"бомж","ученик 1-го класса","выпускник школы","первокурсник КСТ","выпускник КСТ","Putin" };
        int[] rabprice = { 5000,20000,50000,70000,120000,1000000 };

        long point = 1000;
        static int click = 1;
        double sol_b1;
        double sol_b2;
        double sol_b3;
        double sol_b4;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            foreach (var item in homes)
            {
                combobox1.Items.Add(item);
            }
            foreach (var item in car)
            {
                combobox2.Items.Add(item);
            }
            foreach (var item in valera)
            {
                combobox3.Items.Add(item);

            }
            foreach (var item in rab)
            {
                combobox4.Items.Add(item);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            point += click;
            Update();
        }

        public void Update()

        {
            sol_b1 = 10 + 10 * (30 + click * 0.2);
            sol_b2 = 20 + 20 * (60 + click * 0.4);
            sol_b3 = 40 + 40 * (90 + click * 0.6);
            sol_b4 = 60 + 60 * (120 + click * 0.8);
            poi.Content = "Points: " + point; // Вывод Points в первый label

            cli.Content = "Points for click: " + click; // Вывод Points per click во второй label

            Upgrade1.Content = (sol_b1).ToString(); //

            Upgrade2.Content = (sol_b2).ToString(); // Вывод цены Upgrade для Points per click на кнопке
            Upgrade3.Content = (sol_b3).ToString();
            Upgrade4.Content = (sol_b4).ToString();
            

        }

        private void cheburechek_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += click;
            Update();
        }

        private void Upgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b1))

            {

                point -= Convert.ToInt64(Math.Round(sol_b1));

                click += 3;

                Update();

            }
        }

        private void Upgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b2))

            {

                point -= Convert.ToInt64(Math.Round(sol_b2));

                click += 6;

                Update();

            }
        }

        private void Upgrade3_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b3))

            {

                point -= Convert.ToInt64(Math.Round(sol_b3));

                click += 9;

                Update();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (point >= (sol_b4))

            {

                point -= Convert.ToInt64(Math.Round(sol_b4));

                click += 12;

                Update();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (point >= (homesprice[combobox1.SelectedIndex]))

            {

                point -= homesprice[combobox1.SelectedIndex];

                tb4.AppendText(combobox1.Text + "\n");


                Update();

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (point >= (carprice[combobox2.SelectedIndex]))

            {

                point -= carprice[combobox2.SelectedIndex];

                tb4.AppendText(combobox2.Text + "\n");


                Update();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (point >= (valeraprice[combobox3.SelectedIndex]))

            {

                point -= valeraprice[combobox3.SelectedIndex];

                tb4.AppendText(combobox3.Text + "\n");


                Update();
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (point >= (rabprice[combobox4.SelectedIndex]))

            {

                point -= rabprice[combobox4.SelectedIndex];

                tb4.AppendText(combobox4.Text + "\n");


                Update();
            }
        }
    }
}
