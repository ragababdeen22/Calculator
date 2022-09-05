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
        double n1, n2, rs;
        string process="";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
           
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
           //btn_min.Content
        }

        private void btn_po(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                n1 = Convert.ToDouble(lb_result.Content);
                process = btn.Content.ToString();
                lb_cal.Content = lb_cal.Content.ToString() + btn.Content;
                lb_result.Content = "";
            }
            catch
            {

            }
          
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                n2 = Convert.ToDouble(lb_result.Content);
                if (process == "+")
                {
                    rs = n1 + n2;
                    lb_result.Content = rs.ToString();
                }
                else if (process == "-")
                {
                    rs = n1 + n2;
                    lb_result.Content = rs.ToString();
                }
                else if (process == "*")
                {
                    rs = n1 * n2;
                    lb_result.Content = rs.ToString();
                }
                else if (process == "/")
                {
                    rs = n1 / n2;
                    lb_result.Content = rs.ToString();
                }
                // lb_cal.Content = "";
                lb_cal.Content = lb_result.Content;
            }
            catch
            {

            }

        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            lb_result.Content = "";
            lb_cal.Content = "";
            n1 = n2 = rs = 0;
            process = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                this.MouseDown += delegate
                {
                    DragMove();
                };
            }
            catch
            {

            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void btn_number(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                if (lb_result.Content.ToString() == "0")
                {
                    lb_result.Content = "";
                    lb_result.Content = lb_result.Content.ToString() + btn.Content;
                    lb_cal.Content = lb_result.Content;
                }
                else
                {
                    //if(lb_cal.Content.ToString() == "")
                    if (process == "")
                    {
                        lb_result.Content = lb_result.Content.ToString() + btn.Content;
                        lb_cal.Content = lb_result.Content;

                    }
                    else
                    {
                        lb_result.Content = lb_result.Content.ToString() + btn.Content;
                        //lb_cal.Content = lb_cal.Content.ToString() + lb_result.Content;
                    }
                }
            }
            catch
            {

            }

          
        }
    }
}
