using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace Bablo
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {

            InitializeComponent();
            DatePicker arrivalCalendarDatePicker = new DatePicker();
            arrivalCalendarDatePicker.Text = "Gay";
            

        }

        public class DataObject
        {
            public string Призначення { get; set; }
            public double Сумма { get; set; }
            public double Кількість { get; set; }
            public string Дата { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = new ObservableCollection<DataObject>();
            list.Add(new DataObject() { Призначення = Txt1.Text, Сумма = double.Parse(Txt2.Text), Кількість = double.Parse(Txt3.Text), Дата = DatePicker.Text });
            
            this.dataGrid1.ItemsSource = list;
        }
    }
}
