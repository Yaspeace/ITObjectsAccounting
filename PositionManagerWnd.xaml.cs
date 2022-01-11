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
    /// Логика взаимодействия для PositionManagerWnd.xaml
    /// </summary>
    public partial class PositionManagerWnd : Window
    {
        private WpaContext wpa_db { get; set; }
        public PositionManagerWnd(WpaContext wpa_db)
        {
            InitializeComponent();
            this.wpa_db = wpa_db;

            RefillPositions();
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
        void RefillSoft(int pos_id)
        {
            lb_soft.Items.Clear();
            if (wpa_db.position_software_bindings.Any(b => b.position_id == pos_id))
            {
                foreach (var bind in wpa_db.position_software_bindings.Where(b => b.position_id == pos_id))
                {
                    ListBoxItem lbi = new ListBoxItem();
                    lbi.Content = bind.soft_name;
                    lbi.DataContext = bind.id;
                    lb_soft.Items.Add(lbi);
                }
            }
        }

        private void lb_positions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lb_positions.SelectedItem == null)
            {
                tb_pos_desc.Text = "";
                lb_soft.Items.Clear();
                btn_add_soft.IsEnabled = false;
                btn_del_soft.IsEnabled = false;
                btn_del_pos.IsEnabled = false;
            }
            else
            {
                int selected_pos_id = (int)((ListBoxItem)lb_positions.SelectedItem).DataContext;
                RefillSoft(selected_pos_id);
                tb_pos_desc.Text = wpa_db.positions.Find(selected_pos_id).description;
                btn_add_soft.IsEnabled = true;
                btn_del_pos.IsEnabled = true;
            }
        }

        private void lb_soft_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_del_soft.IsEnabled = lb_soft.SelectedItem != null;
        }

        private void btn_add_pos_Click(object sender, RoutedEventArgs e)
        {
            NameDescDialog wnd = new NameDescDialog();
            wnd.ShowDialog();
            if(!wnd.Cancelled)
            {
                wpa_db.positions.Add(new Position(null, wnd.NameValue, wnd.DescValue));
                wpa_db.SaveChanges();
                RefillPositions();
            }
        }

        private void btn_del_pos_Click(object sender, RoutedEventArgs e)
        {
            int sel_pos = (int)((ListBoxItem)lb_positions.SelectedItem).DataContext;
            wpa_db.positions.Remove(wpa_db.positions.Find(sel_pos));
            wpa_db.SaveChanges();
            RefillPositions();
        }

        private void btn_add_soft_Click(object sender, RoutedEventArgs e)
        {
            int sel_pos = (int)((ListBoxItem)lb_positions.SelectedItem).DataContext;
            NameDescDialog wnd = new NameDescDialog();
            wnd.ShowDialog();
            if (!wnd.Cancelled)
            {
                wpa_db.position_software_bindings.Add(new PositionSoftBinding(null, sel_pos, wnd.NameValue));
                wpa_db.SaveChanges();
                RefillSoft(sel_pos);
            }
        }

        private void btn_del_soft_Click(object sender, RoutedEventArgs e)
        {
            int sel_soft = (int)((ListBoxItem)lb_soft.SelectedItem).DataContext;
            wpa_db.position_software_bindings.Remove(wpa_db.position_software_bindings.Find(sel_soft));
            wpa_db.SaveChanges();
            int sel_pos = (int)((ListBoxItem)lb_positions.SelectedItem).DataContext;
            RefillSoft(sel_pos);
        }

        private void btn_quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
