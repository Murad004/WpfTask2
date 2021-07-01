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

namespace CalculatorTaskWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Calculator";
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button bt)
            {
                if (ResultTxtBox.Text == String.Empty)
                {
                    ResultTxtBox.Text = bt.Content.ToString();
                }
                else
                {
                    ResultTxtBox.Text = ResultTxtBox.Text + bt.Content.ToString();
                }
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ResultTxtBox.Text.Length > 0)
            {
                ResultTxtBox.Text = ResultTxtBox.Text.Remove(ResultTxtBox.Text.Length-1,1);
            }
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultTxtBox.Text = String.Empty;
        }
        string optext;
        private void Op_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button bt)
            {
                optext = bt.Content.ToString();
                ResultTxtBox.Text = ResultTxtBox.Text + bt.Content.ToString();
                
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (optext)
            {
                case "+":
                    {
                        var num1 = double.Parse(ResultTxtBox.Text.Split('+')[0]);
                        var num2 = double.Parse(ResultTxtBox.Text.Split('+')[1]);
                        var result = num1 + num2;
                        ResultTxtBox.Text = result.ToString();
                        
                        break;
                    }
                case "-":
                    {
                        var num1 = double.Parse(ResultTxtBox.Text.Split('-')[0]);
                        var num2 = double.Parse(ResultTxtBox.Text.Split('-')[1]);
                        var result = num1 - num2;
                        ResultTxtBox.Text = result.ToString();
                        
                        break;
                    }
                case "/":
                    {
                        var num1 = double.Parse(ResultTxtBox.Text.Split('/')[0]);
                        var num2 = double.Parse(ResultTxtBox.Text.Split('/')[1]);
                        if (num1 > 0)
                        {
                            var result = num1 / num2;
                            ResultTxtBox.Text = result.ToString();
                        }
                        else
                        {
                            ResultTxtBox.Text = String.Empty;
                        }
                        
                        break;
                    }
                case "*":
                    {
                        var num1 = double.Parse(ResultTxtBox.Text.Split('*')[0]);
                        var num2 = double.Parse(ResultTxtBox.Text.Split('*')[1]);
                        var result = num1 * num2;
                        ResultTxtBox.Text = result.ToString();
                        break;
                    }
            }
        }
    }
}
