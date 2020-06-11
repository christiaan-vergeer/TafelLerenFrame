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

namespace TafelLerenFrame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        int Tafelgetal = 0;
        Random random = new Random();
        int[] table_array = { 0, 0, 0, 0, 0 };
        int[] awnser_array = { 0, 0, 0, 0, 0 };
        int eindcijfer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void genereer(object sender, RoutedEventArgs e)
        {

            try
            {
                Tafelgetal = Int32.Parse(tafelgetal.Text);
            }
            catch (Exception)
            {
                Tafelgetal = 0;
            }

            for (int i = 0; i < 5; i++)
            {
                table_array[i] = random.Next(1, 10);
            }

            som1.Content = Tafelgetal + " x " + table_array[0] + " =";
            som2.Content = Tafelgetal + " x " + table_array[1] + " =";
            som3.Content = Tafelgetal + " x " + table_array[2] + " =";
            som4.Content = Tafelgetal + " x " + table_array[3] + " =";
            som5.Content = Tafelgetal + " x " + table_array[4] + " =";
        }


        private void controleer(object sender, RoutedEventArgs e)
        {

            // parsing //

            try
            {
                awnser_array[0] = Int32.Parse(antwoord1.Text);
            }
            catch (Exception)
            {
                awnser_array[0] = 0;
            }
            try
            {
                awnser_array[1] = Int32.Parse(antwoord2.Text);
            }
            catch (Exception)
            {

                awnser_array[1] = 0;
            }
            try
            {
                awnser_array[2] = Int32.Parse(antwoord3.Text);
            }
            catch (Exception)
            {

                awnser_array[2] = 0;
            }
            try
            {
                awnser_array[3] = Int32.Parse(antwoord4.Text);
            }
            catch (Exception)
            {

                awnser_array[3] = 0;
            }
            try
            {
                awnser_array[4] = Int32.Parse(antwoord5.Text);
            }
            catch (Exception)
            {

                awnser_array[4] = 0;
            }

            // Awnser Check//

            if ((table_array[0] * Tafelgetal) == awnser_array[0])
            {
                gf1.Content = "goed!"; 
                gf1.Foreground = Brushes.Green;
                eindcijfer++;
            }
            else
            {
                gf1.Content = "fout";
                gf1.Foreground = Brushes.Red;
            }

            if ((table_array[1] * Tafelgetal) == awnser_array[1])
            {
                gf2.Content = "goed!";
                gf2.Foreground = Brushes.Green;
                eindcijfer++;
            }
            else
            {
                gf2.Content = "fout";
                gf2.Foreground = Brushes.Red;
            }

            if ((table_array[2] * Tafelgetal) == awnser_array[2])
            {
                gf3.Content = "goed!";
                gf3.Foreground = Brushes.Green;
                eindcijfer++;
            }
            else
            {
                gf3.Content = "fout";
                gf3.Foreground = Brushes.Red;
            }

            if ((table_array[3] * Tafelgetal) == awnser_array[3])
            {
                gf4.Content = "goed!";
                gf4.Foreground = Brushes.Green;
                eindcijfer++;
            }
            else
            {
                gf4.Content = "fout";
                gf4.Foreground = Brushes.Red;
            }

            if ((table_array[4] * Tafelgetal) == awnser_array[4])
            {
                gf5.Content = "goed!";
                gf5.Foreground = Brushes.Green;
                eindcijfer++;
            }
            else
            {
                gf5.Content = "fout";
                gf5.Foreground = Brushes.Red;
            }

            // eindcijfer bepaling + kleur op basis van cijfer//

            cijfer.Content = eindcijfer * 2;

            if (eindcijfer > 4)
            {
                cijfer.Foreground = Brushes.Gold;
            }
            else if (eindcijfer < 2)
            {
                cijfer.Foreground = Brushes.Red;
            }
            else if (eindcijfer > 2 && eindcijfer < 4)
            {
                cijfer.Foreground = Brushes.Black;
            }
            eindcijfer = 0;
            Tafelgetal = 0;

        }
                
    }
}