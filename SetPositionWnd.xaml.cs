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
    /// Логика взаимодействия для SetPositionWnd.xaml
    /// </summary>
    public partial class SetPositionWnd : Window
    {
        int ChosenObjID { get; set; }
        WpaContext wpa_db { get; set; }
        public SetPositionWnd(int obj_id, WpaContext wpa_db)
        {
            InitializeComponent();
            ChosenObjID = obj_id;
            this.wpa_db = wpa_db;

            RefillPositions();
            btn_set_pos.IsEnabled = false;
        }

        void RefillPositions()
        {
            lb_positions.Items.Clear();
            foreach(var pos in wpa_db.positions)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = pos.name;
                lbi.DataContext = pos.id;
                lb_positions.Items.Add(lbi);
            }
        }

        private void lb_positions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_set_pos.IsEnabled = lb_positions.SelectedItem != null;
        }

        private void btn_set_pos_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selected_lbi = (ListBoxItem)lb_positions.SelectedItem;
            int pos_id = (int)selected_lbi.DataContext;
            if (wpa_db.position_obj_bindings.Any(bind => bind.hardware_id == ChosenObjID))
            {
                PositionObjBinding pos_bind = wpa_db.position_obj_bindings.Where(bind => bind.hardware_id == ChosenObjID).First();
                pos_bind.position_id = pos_id;
            }
            else
                wpa_db.position_obj_bindings.Add(new PositionObjBinding(null, ChosenObjID, pos_id));
            wpa_db.SaveChanges();
            this.Close();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
