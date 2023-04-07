using System;
using System.Windows;

namespace Практическая7_11_
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(ComboN.Text);
            int K = Convert.ToInt32(ComboK.Text);
            int x = Convert.ToInt32(TextX.Text);
            int y = Convert.ToInt32(TextY.Text);
            double S = 0;
            for(int i = 1; i<=N; i++)
                for(int j = 1; j<=K; j++)
                    S += Math.Round((Math.Abs(Math.Pow(x, i)) + Math.Cos(y) * Math.Pow(y, i)) / (i + 1) * j);
            this.Title = "Ответ: " + S.ToString();
        }
    }
}
