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

namespace Sobitie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseDown += MainWindow_MouseDown;
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            MessageBox.Show("Кордината x=" + p.X.ToString() + " y=" + p.Y.ToString());
        }
        //private void textbox1_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragDrop.DoDragDrop(textbox1, textbox1.Text, DragDropEffects.Copy);
        //}

        //private void button1_Drop(object sender, DragEventArgs e)
        //{
        //    button1.Content = e.Data.GetData(DataFormats.Text);
        //}

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Получение фокуса");
        }
        //private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    int val;
        //    if (!Int32.TryParse(e.Text, out val) && e.Text != "-")
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Space)
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
    


}
