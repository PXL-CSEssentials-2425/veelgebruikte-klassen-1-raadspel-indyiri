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

namespace H4Oef1Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            randomNumber = rnd.Next(1, 101);
        }

        Random rnd = new Random();
        int number = 0;
        int amountOfGuesses = 0;
        int randomNumber;

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void newLabel_Click(object sender, RoutedEventArgs e)
        {
            int randomNumber = rnd.Next(1, 101);
            numberTextBox.Focus();
            output1TextBox.Clear();
            output2TextBox.Clear();
            amountOfGuesses = 0;
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            string inputNumber = numberTextBox.Text;
            bool isInputNumberValid = int.TryParse(inputNumber, out number);

            if (isInputNumberValid && number <= 100 && number >= 0)
            {
               
                    if (number < randomNumber)
                    {
                        output1TextBox.Text = "Raad hoger!";
                    }
                    if (number > randomNumber)
                    {
                        output1TextBox.Text = "Raad lager";
                    }
                    if (number == randomNumber)
                    {
                        output1TextBox.Text = "Proficiat! U hebt het getal geraden";
                    }
                    amountOfGuesses++;
                    output2TextBox.Text = $"Aantal keer geraden: {amountOfGuesses}";    
                    numberTextBox.Focus();
            }
            else
            {
                output1TextBox.Text = "Geef een getal in tussen 1 en 100";
                output2TextBox.Text = "Geef een getal in tussen 1 en 100";
                numberTextBox.Focus();
                numberTextBox.Clear();                
            }
        }      
    }
}