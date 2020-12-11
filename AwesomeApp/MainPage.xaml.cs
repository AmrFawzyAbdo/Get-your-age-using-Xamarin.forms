using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        int count = 0;
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            count++;


            ((Button)sender).Text = $"You clicked {count} times.";

            calcMethod();
            }

        private void calcMethod()
        {
            int calc = Convert.ToInt32(year.Text) - Convert.ToInt32(bornDate.Text);

            if (calc >=1 && calc <= 10)
            {
                we.Text = $"Too young, your age is: {calc.ToString()}";
            }
            else if (calc > 10 && calc <= 20)
            {
                we.Text = $"Be ready for challanges {calc.ToString()}'s Man!";
            }
            else if (calc > 20 && calc <= 50)
            {
                we.Text = $"Time to keep building, your age is: {calc.ToString()} ";
            }
            else if (calc > 50)
            {
                we.Text = $"Which you a long life, your age is: {calc.ToString()}";
            }
            else if (calc < 0)
            {
                we.Text = $"If you were porn in ancient ages you will be: {calc.ToString()}";
            }
            else if (calc == 0)
            {
                we.Text = $"A miracle you are a {calc.ToString()} year";
            }
            else {
                we.Text = "Try to input corect data";
            }
            
        }
    }
}
