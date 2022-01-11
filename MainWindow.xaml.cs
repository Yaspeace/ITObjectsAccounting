using System.Windows;

namespace BD_Kursach_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, RoutedEventArgs e)
        {
            string conn = $"Host={host_tb.Text};Port={port_tb.Text};Database={schema_tb.Text};User={user_tb.Text};Password={password_tb.Password};ConvertZeroDateTime=True";
            string conn_wpa = $"Host={host_tb.Text};Port={port_tb.Text};Database=wpa_db;User={user_tb.Text};Password={password_tb.Password};ConvertZeroDateTime=True";
            InfoWindow iw = new InfoWindow(conn, conn_wpa);
            iw.Show();
            this.Close();
        }
    }
}
