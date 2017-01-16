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

namespace BiuroPodróży
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Podroz plan =new Podroz();
        public MainWindow()
        {
            InitializeComponent();
            imiejscSamolot.Visibility = Visibility.Hidden;
            miejscaSamolot.Visibility = Visibility.Hidden;
            DodajSamolot.Visibility = Visibility.Hidden;
            dlugoscLab.Visibility = Visibility.Hidden;
            dlugosc.Visibility = Visibility.Hidden;
            dataLab.Visibility = Visibility.Hidden;
            dataPT.Visibility = Visibility.Hidden;
            dataG.Visibility = Visibility.Hidden;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            imiejscSamolot.Visibility = Visibility.Hidden;
            miejscaSamolot.Visibility = Visibility.Hidden;
            DodajSamolot.Visibility = Visibility.Hidden;
            dlugoscLab.Visibility = Visibility.Hidden;
            dlugosc.Visibility = Visibility.Hidden;

            imiejscExpress.Visibility = Visibility.Visible;
            miejscaExpress.Visibility = Visibility.Visible;
            DodajExpress.Visibility = Visibility.Visible;
            

        }

        private void samolot_Click(object sender, RoutedEventArgs e)
        {
            imiejscExpress.Visibility = Visibility.Hidden;
            miejscaExpress.Visibility = Visibility.Hidden;
            DodajExpress.Visibility = Visibility.Hidden;
            
            imiejscSamolot.Visibility = Visibility.Visible;
            miejscaSamolot.Visibility = Visibility.Visible;
            DodajSamolot.Visibility = Visibility.Visible;
            dlugoscLab.Visibility = Visibility.Visible;
            dlugosc.Visibility = Visibility.Visible;
        }

        private void data_Click(object sender, RoutedEventArgs e)
        {
            dataLab.Visibility = Visibility.Visible;
            dataPT.Visibility = Visibility.Visible;
            dataG.Visibility = Visibility.Visible;
        }

        private void usun_Click(object sender, RoutedEventArgs e)
        {
            plan.UsunOstatni();
            podrozTB.Text = plan.ToString();

        }

        private void czyszczenie_Click(object sender, RoutedEventArgs e)
        {
            plan.Wyczysc();
            podrozTB.Text = plan.ToString();
        }

        private void DodajExpress_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int iloscMiejsc = int.Parse(miejscaExpress.Text);
                if (iloscMiejsc <= 0) throw new ArgumentNullException();
                plan.DodajExpress(iloscMiejsc);
                podrozTB.Text = plan.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DodajSamolot_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    int iloscMiejsc = int.Parse(miejscaSamolot.Text);
                    int dystans = int.Parse(dlugosc.Text);
                    if (iloscMiejsc <= 0) throw new ArgumentNullException();
                    if (dystans <= 0) throw new ArgumentNullException();
                    plan.DodajSamolot(iloscMiejsc,dystans);
                    podrozTB.Text = plan.ToString();
                }
                catch 
                {
                    MessageBox.Show("Jedna z wartości jest niepoprawna!");
                }
            }

        }

        private void dataPT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dataG_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime data = DateTime.Parse(dataPT.Text);
                
                if (plan.SprawdzDate() == true) MessageBox.Show("Data jest poprawna");
                else MessageBox.Show("Data jest niepoprawna");
               
            }
            catch
            {
                
            }
            
        }
    }
}
