using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus_16__WPF_
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnKmToMiles_Click(object sender, RoutedEventArgs e)
        {
            float annettuArvo;
            bool result = float.TryParse(tbInputField.Text, out annettuArvo);
            if (result)
            {
                string conversionText = annettuArvo + " kilometriä = " + KmToMiles(annettuArvo).ToString() + " mileä";
                UpdateText(conversionText);
            }
            else
            {
                UpdateText("Teksti kenttään ei saa laittaa muuta kuin vain numeroita.");
            }
        }
        private void btnMilesToKm_Click(object sender, RoutedEventArgs e)
        {
            float annettuArvo;
            bool result = float.TryParse(tbInputField.Text, out annettuArvo);
            if (result)
            {
                string conversionText = annettuArvo + " mileä = " + MilesToKm(annettuArvo).ToString() + " kilometriä";
                UpdateText(conversionText);
            }
            else
            {
                UpdateText("Teksti kenttään ei saa laittaa muuta kuin vain numeroita.");
            }
        }
        private void UpdateText(string text)
        {
            tbCoversionResult.Text = text;
        }
        private static float KmToMiles(float i)
        {
            float conversion = 0.62137f;

            return i * conversion;
        }
        private static float MilesToKm(float i)
        {
            float conversion = 1.609344f;

            return i * conversion;
        }
    }
}