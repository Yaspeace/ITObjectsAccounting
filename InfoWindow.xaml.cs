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

            foreach(var comp in ocs_db.hardware)
            {
                TreeViewItem tvi = new TreeViewItem();
                tvi.Name = "tvi_comp_" + comp.ID.ToString();
                tvi.Selected += ComputerSelected;
                tvi.Header = comp.NAME;
                tvi_computers.Items.Add(tvi);
            }
        }
        private void ComputerSelected(object s, RoutedEventArgs e)
        {
            int comp_id = Convert.ToInt32(((TreeViewItem)s).Name.Substring(9));
            dg_db_viewer.ItemsSource = ocs_db.hardware.Where(h => h.ID == comp_id).ToList();
        }
    }
}
