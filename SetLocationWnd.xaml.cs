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
    /// Логика взаимодействия для SetLocationWnd.xaml
    /// </summary>
    public partial class SetLocationWnd : Window
    {
        int ChosenObjID { get; set; }
        OcsWebContext ocs_db { get; set; }
        WpaContext wpa_db { get; set; }
        public SetLocationWnd(int obj_id, OcsWebContext ocs_db, WpaContext wpa_db)
        {
            InitializeComponent();
            ChosenObjID = obj_id;
            this.ocs_db = ocs_db;
            this.wpa_db = wpa_db;

            FillLocations();
            btn_set_loc.IsEnabled = false;
        }

        private void FillLocations()
        {
            foreach(var loc in wpa_db.locations)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = loc.name;
                lbi.DataContext = loc.id;
                lb_locations.Items.Add(lbi);
            }
        }

        private void btn_set_loc_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selected_lbi = (ListBoxItem)lb_locations.SelectedItem;
            int loc_id = (int)selected_lbi.DataContext;
            if(wpa_db.location_bindings.Any(bind => bind.hardware_id == ChosenObjID))
            {
                LocationBinding loc_bind = wpa_db.location_bindings.Where(bind => bind.hardware_id == ChosenObjID).First();
                loc_bind.location_id = loc_id;
            }
            else
            {
                wpa_db.location_bindings.Add(new LocationBinding(null, ChosenObjID, loc_id));
            }
            wpa_db.SaveChanges();
            this.Close();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lb_locations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_locations.SelectedItem == null)
                btn_set_loc.IsEnabled = false;
            else
                btn_set_loc.IsEnabled = true;
        }
    }
}
