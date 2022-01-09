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
    /// Логика взаимодействия для LocationManagerWnd.xaml
    /// </summary>
    public partial class LocationManagerWnd : Window
    {
        WpaContext wpa_db { get; set; }
        public LocationManagerWnd(WpaContext wpa_db)
        {
            InitializeComponent();
            this.wpa_db = wpa_db;

            RefillLocations();
            main_tab.IsSelected = true;
        }

        private void RefillLocations()
        {
            lb_locations.Items.Clear();
            foreach(var loc in wpa_db.locations)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = loc.name;
                lbi.DataContext = loc.id;
                lb_locations.Items.Add(lbi);
            }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            tb_new_loc_name.Text = "";
            tb_new_loc_desc.Text = "";
            adding_tab.IsSelected = true;
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selected_lbi = (ListBoxItem)lb_locations.SelectedItem;
            int id_to_delete = (int)selected_lbi.DataContext;
            wpa_db.locations.Remove(wpa_db.locations.Find(id_to_delete));
            wpa_db.SaveChanges();
            RefillLocations();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_add_new_loc_Click(object sender, RoutedEventArgs e)
        {
            if (tb_new_loc_name.Text == null || tb_new_loc_name.Text == "")
                return;
            wpa_db.locations.Add(new Location(null, tb_new_loc_name.Text, tb_new_loc_desc.Text));
            wpa_db.SaveChanges();
            RefillLocations();
            main_tab.IsSelected = true;
        }

        private void btn_add_cancel_Click(object sender, RoutedEventArgs e)
        {
            main_tab.IsSelected = true;
        }

        private void lb_locations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_delete.IsEnabled = lb_locations.SelectedItem != null;
        }
    }
}
