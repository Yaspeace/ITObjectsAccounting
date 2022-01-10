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
using System.Windows.Shapes;

namespace BD_Kursach_WPF
{
    /// <summary>
    /// Логика взаимодействия для NameDescDialog.xaml
    /// </summary>
    public partial class NameDescDialog : Window
    {
        public string NameValue { get; set; }
        public string DescValue { get; set; }
        public bool Cancelled { get; set; } = false;
        public NameDescDialog()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, RoutedEventArgs e)
        {
            NameValue = tb_name.Text;
            DescValue = tb_desc.Text;
            this.Close();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            Cancelled = true;
            this.Close();
        }
    }
}
