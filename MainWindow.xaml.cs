﻿using System;
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
       // int Tafelgetal = 0; //user imput tafel
        Random random = new Random();
        int[] factor_array = { 0, 0, 0, 0, 0 }; // storage of random numbers for factors
        int[] table_array = { 0, 0, 0, 0, 0 }; // storage of (random) numbers for the tablenumber
        int[] awnser_array = { 0, 0, 0, 0, 0 };  // user imput awnser
        int[] checker_array = { 0, 0, 0, 0, 0 }; // checks the random multiplier
        int eindcijfer;  // user output
        int Rchecker; // random asset
        int inputflag = 0; //checks if all fields are filled

        public MainWindow()
        {
            InitializeComponent();
        }

        private void genereer(object sender, RoutedEventArgs e)
        {
            reset();
            inputflag = 0;

            // user imput lezen //
            try
            {
                table_array[0] = Int32.Parse(tgetal.Text);
                table_array[1] = Int32.Parse(tgetal.Text);
                table_array[2] = Int32.Parse(tgetal.Text);
                table_array[3] = Int32.Parse(tgetal.Text);
                table_array[4] = Int32.Parse(tgetal.Text);
            }
            catch (Exception)
            {
                table_array[0] = 0;
                table_array[1] = 0;
                table_array[2] = 0;
                table_array[3] = 0;
                table_array[4] = 0;
                inputflag = 1;
            }

            if (inputflag == 0){
                // random number generator//
                for (int i = 0; i < 5; i++)
                {
                    Rchecker = random.Next(1, 10);
                    while (Rchecker == factor_array[0] || Rchecker == factor_array[1] || Rchecker == factor_array[2] || Rchecker == factor_array[3] || Rchecker == factor_array[4])
                    {
                        Rchecker = random.Next(1, 10);
                    }
                    factor_array[i] = Rchecker;
                }

                som1.Content = table_array[0] + " x " + factor_array[0] + " =";
                som2.Content = table_array[1] + " x " + factor_array[1] + " =";
                som3.Content = table_array[2] + " x " + factor_array[2] + " =";
                som4.Content = table_array[3] + " x " + factor_array[3] + " =";
                som5.Content = table_array[4] + " x " + factor_array[4] + " =";
            }
            else
            {
              MessageBox.Show("Voer alleen een heel getal in","Fout");
            }
        }


        private void controleer(object sender, RoutedEventArgs e)
        {
            inputflag = 0;

            // parsing //
            try
            {
                awnser_array[0] = Int32.Parse(antwoord1.Text);
            }
            catch (Exception)
            {
                awnser_array[0] = 0;
                inputflag = 1;
            }
            try
            {
                awnser_array[1] = Int32.Parse(antwoord2.Text);
            }
            catch (Exception)
            {
                awnser_array[1] = 0;
                inputflag = 1;
            }
            try
            {
                awnser_array[2] = Int32.Parse(antwoord3.Text);
            }
            catch (Exception)
            {
                awnser_array[2] = 0;
                inputflag = 1;
            }
            try
            {
                awnser_array[3] = Int32.Parse(antwoord4.Text);
            }
            catch (Exception)
            {
                awnser_array[3] = 0;
                inputflag = 1;
            }
            try
            {
                awnser_array[4] = Int32.Parse(antwoord5.Text);
            }
            catch (Exception)
            {
                awnser_array[4] = 0;
                inputflag = 1;
            }

            // Awnser Check//

            if (inputflag == 0)
            {
                if ((factor_array[0] * table_array[0]) == awnser_array[0])
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

                if ((factor_array[1] * table_array[1]) == awnser_array[1])
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

                if ((factor_array[2] * table_array[2]) == awnser_array[2])
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

                if ((factor_array[3] * table_array[3]) == awnser_array[3])
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

                if ((factor_array[4] * table_array[4]) == awnser_array[4])
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
            }
            

            // eindcijfer bepaling + kleur op basis van cijfer//
            if (inputflag == 0)
            {
                score_text.Content = "Je hebt een:";
                cijfer.Content = eindcijfer * 2;

                if (eindcijfer > 4 || eindcijfer == 4)
                {
                    cijfer.Foreground = Brushes.Gold;
                }
                else if (eindcijfer < 2 || eindcijfer == 2)
                {
                    cijfer.Foreground = Brushes.Red;
                }
                else if (eindcijfer > 2 && eindcijfer < 4)
                {
                    cijfer.Foreground = Brushes.Black;
                }
            }
            else
            {
                score_text.Content = "Je hebt een vraag niet ingevuld";
            }
        }


       
        private void genereer_random(object sender, RoutedEventArgs e)
        {
            reset();
            //generates the factor//
            for (int i = 0; i < 5; i++)
            {
                factor_array[i] = random.Next(1, 10);
            }

            //generates the table and checks if the multiplication already exicst//
            for (int i = 0; i < 5; i++)
            {
                Rchecker = random.Next(1, 10)*factor_array[i];
                while (Rchecker == checker_array[0] || Rchecker == checker_array[1] || Rchecker == checker_array[2] || Rchecker == checker_array[3] || Rchecker == checker_array[4])
                {
                    Rchecker = random.Next(1, 10)*factor_array[i];

                }

                checker_array[i] = Rchecker;
                Rchecker = Rchecker / factor_array[i];
                table_array[i] = Rchecker;

                som1.Content = table_array[0] + " x " + factor_array[0] + " =";
                som2.Content = table_array[1] + " x " + factor_array[1] + " =";
                som3.Content = table_array[2] + " x " + factor_array[2] + " =";
                som4.Content = table_array[3] + " x " + factor_array[3] + " =";
                som5.Content = table_array[4] + " x " + factor_array[4] + " =";
            }
        }

        private void reset()
        {
            eindcijfer = 0;
            antwoord1.Text = "";
            antwoord2.Text = "";
            antwoord3.Text = "";
            antwoord4.Text = "";
            antwoord5.Text = "";
            table_array[0] = 0;
            table_array[1] = 0;
            table_array[2] = 0;
            table_array[3] = 0;
            table_array[4] = 0;
            checker_array[0] = 0;
            checker_array[1] = 0;
            checker_array[2] = 0;
            checker_array[3] = 0;
            checker_array[4] = 0;
            factor_array[0] = 0;
            factor_array[1] = 0;
            factor_array[2] = 0;
            factor_array[3] = 0;
            factor_array[4] = 0;
            gf1.Content = "";
            gf2.Content = "";
            gf3.Content = "";
            gf4.Content = "";
            gf5.Content = "";
            score_text.Content = "";
            cijfer.Content = "";
        }

    }
}