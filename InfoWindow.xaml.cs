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
        int ChosenCompID { get; set; }
        int ChosenDivisionID { get; set; } = 0;
        OcsWebContext ocs_db;
        WpaContext wpa_db;
        public InfoWindow(string connString)
        {
            InitializeComponent();
            ConnString = connString;
            ChosenCompID = 0;

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseMySql(ConnString, new MySqlServerVersion(new Version(8, 0, 27)));
            ocs_db = new OcsWebContext(builder.Options);

            builder = new DbContextOptionsBuilder();
            string localConn = "Host=localhost;Port=3306;Username=root;Password=0201;Database=WPA_DB;ConvertZeroDateTime=True";
            builder.UseMySql(localConn, new MySqlServerVersion(new Version(8, 0, 27)));
            wpa_db = new WpaContext(builder.Options);

            WpaIntegrityUpdate(); //Синхронизация данных локальной бд и OCS-ки
        }

        private void WpaIntegrityUpdate()
        {
            foreach(var bind in wpa_db.unit_bindings)
            {
                if (ocs_db.hardware.Find(bind.hardware_id) == null)
                    wpa_db.unit_bindings.Remove(bind);
            }
        }

        private void FillHardwareInfo()
        {
            hardwareModel? ChosenComp = ocs_db.hardware.Find(ChosenCompID);

            sp_disks.Children.Clear();
            sp_drives.Children.Clear();
            sp_rams.Children.Clear();
            sp_vidcards.Children.Clear();
            
            if (ChosenComp != null)
            {
                tb_pc_name.Text = ChosenComp.NAME;
                tb_arch.Text = "Архитектура: " + ChosenComp.ARCH;
                tb_os_name.Text = "Название: " + ChosenComp.OSNAME;
                tb_os_ver.Text = "Версия: " + ChosenComp.OSVERSION;
                tb_proc_name.Text = "Название: " + ChosenComp.PROCESSORT;
                tb_ram_amount.Text = "Оьъём памяти (МБ): " + ChosenComp.MEMORY.ToString();
                
                int counter = 1;
                foreach (var ram in ocs_db.memories.Where(mem => mem.HARDWARE_ID == ChosenCompID && mem.TYPE != "Empty slot"))
                {
                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.DemiBold;
                    tb.Text = $"Устройство {counter}: " + ram.CAPTION;
                    sp_rams.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Описание: " + ram.DESCRIPTION;
                    sp_rams.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Объём памяти (МБ): " + ram.CAPACITY.ToString();
                    sp_rams.Children.Add(tb);
                    counter++;
                }
                
                counter = 1;
                foreach (var stor in ocs_db.storages.Where(st => st.HARDWARE_ID == ChosenCompID))
                {
                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.DemiBold;
                    tb.Text = $"Жёсткий диск {counter}: " + stor.NAME;
                    sp_drives.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Описание: " + stor.DESCRIPTION;
                    sp_drives.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Модель: " + stor.MODEL;
                    sp_drives.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Объём памяти (МБ): " + stor.DISKSIZE;
                    sp_drives.Children.Add(tb);
                    counter++;
                }
                
                foreach (var disk in ocs_db.drives.Where(dr => dr.HARDWARE_ID == ChosenCompID))
                {
                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.DemiBold;
                    tb.Text = "Диск " + disk.LETTER;
                    sp_disks.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Тип: " + disk.TYPE;
                    sp_disks.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Объём (МБ): " + disk.TOTAL;
                    sp_disks.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Доступно (МБ): " + disk.FREE;
                    sp_disks.Children.Add(tb);

                    ProgressBar pb = new ProgressBar();
                    pb.Width = sp_disks.ActualWidth / 4;
                    pb.Height = 10;
                    pb.Minimum = 0;
                    pb.Maximum = (double)disk.TOTAL;
                    pb.Value = (double)(disk.TOTAL - disk.FREE);
                    sp_disks.Children.Add(pb);
                }
                
                counter = 1;
                foreach (var vid in ocs_db.videos.Where(v => v.HARDWARE_ID == ChosenCompID))
                {
                    TextBlock tb = new TextBlock();
                    tb.FontWeight = FontWeights.DemiBold;
                    tb.Text = $"Видеокарта {counter}: " + vid.NAME;
                    sp_vidcards.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Видеопамять (МБ): " + vid.MEMORY;
                    sp_vidcards.Children.Add(tb);

                    tb = new TextBlock();
                    tb.Text = "Разрешение: " + vid.RESOLUTION;
                    sp_vidcards.Children.Add(tb);
                }
            }
        }

        private void FillSoftwareInfo()
        {
            List<SoftVisualModel> softList = new List<SoftVisualModel>();
            foreach(var soft in ocs_db.software.Where(s => s.HARDWARE_ID == ChosenCompID && s.FOLDER != "" && s.FOLDER != null).ToList())
            {
                string softname = ocs_db.software_name.Where(s_name => s_name.ID == soft.NAME_ID).First().NAME;
                string softver = ocs_db.software_version.Where(s_ver => s_ver.ID == soft.VERSION_ID).First().VERSION;
                softList.Add(new SoftVisualModel(softname, soft.FOLDER, softver));
            }
            dg_soft.ItemsSource = softList;
        }

        private void FillPeripheryInfo()
        {
            sp_monitors.Children.Clear();
            sp_inputs.Children.Clear();
            sp_printers.Children.Clear();

            int counter = 1;
            foreach(var monik in ocs_db.monitors.Where(m => m.HARDWARE_ID == ChosenCompID))
            {
                TextBlock tb = new TextBlock();
                tb.FontWeight = FontWeights.DemiBold;
                tb.Text = $"Монитор {counter}: " + monik.MANUFACTURER;
                sp_monitors.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Тип: " + monik.TYPE;
                sp_monitors.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Описание: " + monik.DESCRIPTION;
                sp_monitors.Children.Add(tb);
                
                counter++;
            }

            counter = 1;
            foreach(var printer in ocs_db.printers.Where(p => p.HARDWARE_ID == ChosenCompID))
            {
                TextBlock tb = new TextBlock();
                tb.FontWeight = FontWeights.DemiBold;
                tb.Text = $"Устройство {counter}: " + printer.NAME;
                sp_printers.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Описание: " + printer.DESCRIPTION;
                sp_printers.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Порт подключения: " + printer.PORT;
                sp_printers.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Разрешение: " + printer.RESOLUTION;
                sp_printers.Children.Add(tb);
                
                counter++;
            }

            counter = 1;
            foreach(var input in ocs_db.inputs.Where(i => i.HARDWARE_ID == ChosenCompID))
            {
                TextBlock tb = new TextBlock();
                tb.FontWeight = FontWeights.DemiBold;
                tb.Text = $"Устройство {counter}: " + input.CAPTION;
                sp_inputs.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Тип: " + input.TYPE;
                sp_inputs.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Описание: " + input.DESCRIPTION;
                sp_inputs.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Производитель: " + input.MANUFACTURER;
                sp_inputs.Children.Add(tb);

                tb = new TextBlock();
                tb.Text = $"Интерфейс: " + input.INTERFACE;
                sp_inputs.Children.Add(tb);

                counter++;
            }
        }

        //Выбран конкретный ИТ-объект в левом дереве
        private void ComputerSelected(object s, RoutedEventArgs e)
        {
            e.Handled = true; //Disable execution of methods which are for tvi's higher by hierarchy

            ChosenCompID = Convert.ToInt32(((TreeViewItem)s).Name.Substring(9));
            object_info_tab.IsSelected = true;
            
            FillHardwareInfo();
            FillSoftwareInfo();
            FillPeripheryInfo();
            
        }

        //Выбран элемент "Подразделения" в левом TreeView
        private void tvi_divisions_Selected(object sender, RoutedEventArgs e)
        {
            divisions_tab.IsSelected = true;
            tvi_divisions.Items.Clear();
            lb_divisions.Items.Clear();
            foreach(var div in wpa_db.units.ToList())
            {
                TreeViewItem tvi = new TreeViewItem();
                tvi.Name = "tvi_div_" + div.id.ToString();
                tvi.Header = div.name;
                tvi.Selected += tvi_div_selected;
                tvi.DataContext = div.id;
                tvi_divisions.Items.Add(tvi);
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = div.name;
                lbi.DataContext = div.id;
                lb_divisions.Items.Add(lbi);
                foreach (var obj in ocs_db.hardware)
                {
                    if (wpa_db.unit_bindings.Any(ub => ub.hardware_id == obj.ID && ub.unit_id == div.id))
                    {
                        TreeViewItem tvi_comp = new TreeViewItem();
                        tvi_comp.Name = "tvi_comp_" + obj.ID.ToString();
                        tvi_comp.Header = obj.NAME;
                        tvi_comp.Selected += ComputerSelected;
                        tvi_comp.DataContext = obj.ID;
                        tvi.Items.Add(tvi_comp);
                    }
                }
            }
        }

        //Выбор конкретного подразделения (страничка с возможностью добавления в него компов)
        private void tvi_div_selected(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            division_edit_tab.IsSelected = true;
            lb_assigned_objects.Items.Clear();
            lb_unassigned_objects.Items.Clear();

            TreeViewItem selected_tvi = (TreeViewItem)sender;
            int cur_div_id = (int)selected_tvi.DataContext;
            ChosenDivisionID = cur_div_id;
            foreach(var obj in ocs_db.hardware)
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = obj.NAME;
                lbi.DataContext = obj.ID;
                if (wpa_db.unit_bindings.Any(bind => bind.hardware_id == obj.ID && bind.unit_id == cur_div_id))
                    lb_assigned_objects.Items.Add(lbi);
                else
                    lb_unassigned_objects.Items.Add(lbi);
            }
        }

        //Открытие странички "добавление подразделения"
        private void btn_add_division_Click(object sender, RoutedEventArgs e)
        {
            division_adding_tab.IsSelected = true;
            e.Handled = true;
        }

        //Выбор какого-либо подразделения из списка (на страничке с добавлением подразделений в правом окне)
        private void lb_divisions_Selected(object sender, RoutedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            if (lb.SelectedItem != null)
            {
                ListBoxItem lbi = lb.SelectedItem as ListBoxItem;
                string? selected_div_name = lbi.Content.ToString();
                tb_division_desc.Text = wpa_db.units.Find((int)lbi.DataContext).descriprion;
            }
            else
                tb_division_desc.Text = String.Empty;
        }

        //Нажатие на кнопку "Добавить" на страничке добавления подразделения
        private void btn_add_div_Click(object sender, RoutedEventArgs e)
        {
            Unit u = new Unit();
            if (wpa_db.units.Count() > 0)
                u.id = wpa_db.units.Max(u => u.id) + 1;
            else
                u.id = 1;
            u.name = tb_div_name.Text;
            u.descriprion = tb_div_desc.Text;
            wpa_db.units.Add(u);
            wpa_db.SaveChanges();

            tvi_divisions_Selected(tvi_divisions, e);
        }

        private void btn_del_division_Click(object sender, RoutedEventArgs e)
        {
            if(lb_divisions.SelectedItem != null)
            {
                ListBoxItem lbi = lb_divisions.SelectedItem as ListBoxItem;
                lb_divisions.Items.Remove(lbi);
                wpa_db.Remove(wpa_db.units.Find((int)lbi.DataContext));
                wpa_db.SaveChanges();
            }
        }

        //Добавление компов в подразделение
        private void btn_assign_objects_Click(object sender, RoutedEventArgs e)
        {
            foreach (var sel in lb_unassigned_objects.SelectedItems)
            {
                ListBoxItem lbi = (ListBoxItem)sel;
                wpa_db.unit_bindings.Add(new UnitBinding(null, (int)lbi.DataContext, ChosenDivisionID));
            }
            wpa_db.SaveChanges();
            tvi_divisions.IsSelected = true;
            tvi_divisions_Selected(tvi_divisions, e);
        }

        //Удаление компов из подразделения
        private void btn_unassign_objects_Click(object sender, RoutedEventArgs e)
        {
            foreach (var sel in lb_assigned_objects.SelectedItems)
            {
                ListBoxItem lbi = (ListBoxItem)sel;
                wpa_db.unit_bindings.RemoveRange(wpa_db.unit_bindings.Where(bind 
                    => bind.hardware_id == (int)lbi.DataContext && bind.unit_id == ChosenDivisionID));
            }
            wpa_db.SaveChanges();
            tvi_divisions.IsSelected = true;
            tvi_divisions_Selected(tvi_divisions, e);
        }
    }
}
