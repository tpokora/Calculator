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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Operations calc = new Operations();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttondel_Click(object sender, RoutedEventArgs e)
        {
            current.Text = calc.DeleteLast();
        }

        private void buttonclear_Click(object sender, RoutedEventArgs e)
        {
            current.Text = calc.Clear();
            result.Text = calc.Result;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button7.Content.ToString());
            current.Text = calc.Current;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button8.Content.ToString());
            current.Text = calc.Current;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button9.Content.ToString());
            current.Text = calc.Current;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button4.Content.ToString());
            current.Text = calc.Current;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button5.Content.ToString());
            current.Text = calc.Current;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button6.Content.ToString());
            current.Text = calc.Current;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button1.Content.ToString());
            current.Text = calc.Current;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button2.Content.ToString());
            current.Text = calc.Current;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button3.Content.ToString());
            current.Text = calc.Current;
        }

        private void buttoncoma_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, buttoncoma.Content.ToString());
            current.Text = calc.Current;
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, button0.Content.ToString());
            current.Text = calc.Current;
        }

        private void buttonadd_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, buttonadd.Content.ToString());
            current.Text = calc.Current;
        }

        private void buttonremove_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, buttonremove.Content.ToString());
            current.Text = calc.Current;
        }

        private void buttondivide_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, buttondivide.Content.ToString());
            current.Text = calc.Current;
        }

        private void buttonmulti_Click(object sender, RoutedEventArgs e)
        {
            calc.AddToCurrent(current.Text, buttonmulti.Content.ToString());
            current.Text = calc.Current;
        }
    }
}
