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
using Microsoft.EntityFrameworkCore;

namespace BD_Kursach_WPF
{
    /// <summary>
    /// Логика взаимодействия для InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        string ConnString { get; set; }
        OcsWebContext ocs_db;
        public InfoWindow(string connString)
        {
            InitializeComponent();
            ConnString = connString;

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseMySql(ConnString, new MySqlServerVersion(new Version(8, 0, 27)));
            ocs_db = new OcsWebContext(builder.Options);

            //test_dg.ItemsSource = ocs_db.accountinfo.ToList();
            //test_dg.ItemsSource = ocs_db.software.ToList();
            test_dg.ItemsSource = ocs_db.software.ToList();
        }
    }
}
