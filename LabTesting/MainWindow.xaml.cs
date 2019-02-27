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

namespace LabTesting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string enteredString = "";
        private char ratio = '>';
        public MainWindow()
        {
            InitializeComponent();
        }

        private void runButtonHandler(object sender, RoutedEventArgs e)
        {
            string enteredString = fillTextBox.Text;
            string outputString = "";
            int[] data;
            InputOutputHandler.isDev = (bool)DevBox.IsChecked;

            try
            {
                data = InputOutputHandler.ConvertStringToArray(enteredString, 10);
            }
            catch (System.Exception ex)
            {
                answerTextBox.Text = ex.Message;
                return;
            }

            ArrayHandler arrayHandler = new ArrayHandler(data, ratio);

            Answer answer = arrayHandler.GetArray();
            if (answer.log != "Error")
            {
                outputString = InputOutputHandler.ConvertArrayToString(ref answer.array);
            }
            else
                outputString = "Чисел согласно заданным условиям не обнаружено!";

            answerTextBox.Text = outputString;
        }

        private void ChangeRatioRB(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            if (pressed.Content.ToString() == "Больше")
            {
                ratio = '>';
            } else
            {
                ratio = '<';
            }
        }
    }
}
