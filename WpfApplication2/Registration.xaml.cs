using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            reset();
            Boolean valid = true;
            if (string.IsNullOrWhiteSpace(std_id.Text))
            {
                error1.Content = "* Student ID Field is Required";
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(std_name.Text))
            {
                error2.Content = "* Student Name Field is Required";
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(std_cnic.Text))
            {
                error3.Content = "* Student CNIC Field is Required";
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(std_program.Text))
            {
                error4.Content = "* Student program Field is Required";
                valid = false;
            }
            if (valid)
            {
                MessageBox.Show("Student Register successfully");
            }
        }
        public void reset()
        {
            error1.Content = "";
            error2.Content = "";
            error3.Content = "";
            error4.Content = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        }
    }

