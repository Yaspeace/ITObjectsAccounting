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
    /// Логика взаимодействия для RequirementsManagerWnd.xaml
    /// </summary>
    public partial class RequirementsManagerWnd : Window
    {
        long ChosenSoftID { get; set; }
        OcsWebContext ocs_db { get; set; }
        WpaContext wpa_db { get; set; }

        public RequirementsManagerWnd(OcsWebContext ocs_db, WpaContext wpa_db)
        {
            InitializeComponent();
            this.ocs_db = ocs_db;
            this.wpa_db = wpa_db;

            btn_set_req.IsEnabled = false;

            RefillSoft();
        }

        private void RefillSoft()
        {
            lb_soft.Items.Clear();
            foreach(var soft in ocs_db.software.ToList())
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = ocs_db.software_name.Where(name => name.ID == soft.NAME_ID).First().NAME + "; ver=" + ocs_db.software_version.Where(ver => ver.ID == soft.VERSION_ID).First().VERSION;
                lbi.DataContext = soft.ID;
                lb_soft.Items.Add(lbi);
            }
        }

        private void FillReqs(long soft_id = -1)
        {
            if(soft_id < 0)
            {
                tb_cpucores.Text = "";
                tb_cpufreq.Text = "";
                tb_dirver.Text = "";
                tb_ram.Text = "";
                tb_store.Text = "";
                tb_winver.Text = "";
            }
            else
            {
                if (wpa_db.software_requirements.Any(req => req.software_id == soft_id))
                {
                    SoftwareReq reqs = wpa_db.software_requirements.Where(req => req.software_id == soft_id).First();
                    tb_cpucores.Text = reqs.cpu_cores.ToString();
                    tb_cpufreq.Text = reqs.cpu_freq.ToString();
                    tb_dirver.Text = reqs.directx_version == null ? "" : reqs.directx_version.ToString();
                    tb_ram.Text = reqs.ram_memory_mb.ToString();
                    tb_store.Text = reqs.hard_drive_mem_amount_mb.ToString();
                    tb_winver.Text = reqs.os_windows_version == null ? "" : reqs.os_windows_version.ToString();
                }
                else
                {
                    tb_cpucores.Text = "";
                    tb_cpufreq.Text = "";
                    tb_dirver.Text = "";
                    tb_ram.Text = "";
                    tb_store.Text = "";
                    tb_winver.Text = "";
                }
            }
        }

        private void btn_set_req_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (wpa_db.software_requirements.Any(sreq => sreq.software_id == ChosenSoftID))
                {
                    SoftwareReq req = wpa_db.software_requirements.Where(sr => sr.software_id == ChosenSoftID).First();
                    req.directx_version = tb_dirver.Text == "" ? null : Convert.ToInt32(tb_dirver.Text);
                    req.cpu_cores = Convert.ToInt32(tb_cpucores.Text);
                    req.cpu_freq = Convert.ToInt32(tb_cpufreq.Text);
                    req.hard_drive_mem_amount_mb = Convert.ToInt32(tb_store.Text);
                    req.ram_memory_mb = Convert.ToInt32(tb_ram.Text);
                    req.os_windows_version = tb_winver.Text == "" ? null : Convert.ToInt32(tb_winver.Text);
                    wpa_db.SaveChanges();
                }
                else
                {
                    SoftwareReq req = new SoftwareReq
                    {
                        id = null,
                        software_id = ChosenSoftID,
                        directx_version = tb_dirver.Text == "" ? null : Convert.ToInt32(tb_dirver.Text),
                        cpu_cores = Convert.ToInt32(tb_cpucores.Text),
                        cpu_freq = Convert.ToInt32(tb_cpufreq.Text),
                        hard_drive_mem_amount_mb = Convert.ToInt32(tb_store.Text),
                        ram_memory_mb = Convert.ToInt32(tb_ram.Text),
                        os_windows_version = tb_winver.Text == "" ? null : Convert.ToInt32(tb_winver.Text)
                    };
                    wpa_db.software_requirements.Add(req);
                    wpa_db.SaveChanges();
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Введены некорректные данные!");
                return;
            }
        }
            
        private void btn_accept_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lb_soft_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lb_soft.SelectedItem == null)
            {
                btn_set_req.IsEnabled = false;
                FillReqs();
            }
            else
            {
                ChosenSoftID = (long)((ListBoxItem)lb_soft.SelectedItem).DataContext;
                btn_set_req.IsEnabled = true;
                FillReqs(ChosenSoftID);
            }
        }
    }
}
