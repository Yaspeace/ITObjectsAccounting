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
        OcsWebContext ocs_db;
        public InfoWindow(string connString)
        {
            InitializeComponent();
            ConnString = connString;
            ChosenCompID = 0;

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

        private void ComputerSelected(object s, RoutedEventArgs e)
        {
            ChosenCompID = Convert.ToInt32(((TreeViewItem)s).Name.Substring(9));
            FillHardwareInfo();
            FillSoftwareInfo();
            FillPeripheryInfo();
        }
    }
}
