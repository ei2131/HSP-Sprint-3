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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zahnrad
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Klicken Sie auf die Schaltfläche, um das Klickereignis auszulösen
        private void Bt_calculate_Click(object sender, RoutedEventArgs e)
        {
            Double a, b, c, d, e1, h, f, g, i, j, k, n;         //Definieren Sie Variablen vom Typ double zum Empfangen von Daten und zum Berechnen von Daten
            a = Convert.ToDouble(text_a.Text.ToString());       //a变量接收文本框的值，并且需要把文本框的字符串类型的值转成double类型
            b = Convert.ToDouble(text_b.Text.ToString());
            c = Convert.ToDouble(text_c.Text.ToString());
            d = Convert.ToDouble(text_d.Text.ToString());

            e1 = 0.167 * a;//Definieren e=0,167*a.              //rechnen
            h = 2 * a + e1;//Definieren h=2*a+e.
            f = a + e1;//Definieren f=a+e.
            g = a;//Definieren g=a.
            text_e.Text = e1.ToString();//Weisen Sie das berechnete Ergebnis textbox, textboxfor, textboxg zu und konvertieren Sie es in String typ
            text_f.Text = f.ToString();
            text_g.Text = g.ToString();

            i = Math.PI * a;                                            
            text_i.Text = i.ToString();
            j = c - 2 * (a + e1);//Definieren j=c - 2 * (a + e).
            n = c + 2 * (a + e1);
            text_j.Text = j.ToString();
            text_n.Text = n.ToString();

            k = a * b * Math.Cos(20 * Math.PI / 180);
            text_k.Text = k.ToString();

        }
    }
}
