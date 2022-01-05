using System;
using Microsoft.EntityFrameworkCore;

namespace BD_Kursach_WPF
{
    public class OcsWebContext : DbContext
    {
        public DbSet<accesslogModel> accesslog { get; set; }
        public DbSet<accountinfoModel> accountinfo { get; set; }
        public DbSet<accountinfo_configModel> accountinfo_config { get; set; }
        public DbSet<archiveModel> archive { get; set; }
        public DbSet<assets_categoriesModel> assets_categories { get; set; }
        public DbSet<auth_attemptModel> auth_attempt { get; set; }
        public DbSet<batteriesModel> batteries { get; set; }
        public DbSet<biosModel> bios { get; set; }
        public DbSet<blacklist_macaddressesModel> blacklist_macaddresses { get; set; }
        public DbSet<blacklist_serialsModel> blacklist_serials { get; set; }
        public DbSet<blacklist_subnetModel> blacklist_subnet { get; set; }
        public DbSet<configModel> config { get; set; }
        public DbSet<conntrackModel> conntrack { get; set; }
        public DbSet<controllersModel> controllers { get; set; }
        public DbSet<cpusModel> cpus { get; set; }
        public DbSet<cve_searchModel> cve_search { get; set; }
        public DbSet<cve_search_computerModel> cve_search_computer { get; set; }
        public DbSet<cve_search_correspondanceModel> cve_search_correspondance { get; set; }
        public DbSet<cve_search_historyModel> cve_search_history { get; set; }
        public DbSet<deleted_equivModel> deleted_equiv { get; set; }
        public DbSet<deployModel> deploy { get; set; }
        public DbSet<devicesModel> devices { get; set; }
        public DbSet<devicetypeModel> devicetype { get; set; }
        public DbSet<dico_ignoredModel> dico_ignored { get; set; }
        public DbSet<dico_softModel> dico_soft { get; set; }
        public DbSet<download_affect_rulesModel> download_affect_rules { get; set; }
        public DbSet<download_availableModel> download_available { get; set; }
        public DbSet<download_enableModel> download_enable { get; set; }
        public DbSet<download_historyModel> download_history { get; set; }
        public DbSet<download_serversModel> download_servers { get; set; }
        public DbSet<downloadwk_conf_valuesModel> downloadwk_conf_values { get; set; }
        public DbSet<downloadwk_fieldsModel> downloadwk_fields { get; set; }
        public DbSet<downloadwk_historyModel> downloadwk_history { get; set; }
        public DbSet<downloadwk_packModel> downloadwk_pack { get; set; }
        public DbSet<downloadwk_statut_requestModel> downloadwk_statut_request { get; set; }
        public DbSet<downloadwk_tab_valuesModel> downloadwk_tab_values { get; set; }
        public DbSet<drivesModel> drives { get; set; }
        public DbSet<engine_mutexModel> engine_mutex { get; set; }
        public DbSet<engine_persistentModel> engine_persistent { get; set; }
        public DbSet<extensionsModel> extensions { get; set; }
        public DbSet<filesModel> files { get; set; }
        public DbSet<groupsModel> groups { get; set; }
        public DbSet<groups_cacheModel> groups_cache { get; set; }
        public DbSet<hardwareModel> hardware { get; set; }
        public DbSet<hardware_osname_cacheModel> hardware_osname_cache { get; set; }
        public DbSet<inputsModel> inputs { get; set; }
        public DbSet<itmgmt_commentsModel> itmgmt_comments { get; set; }
        public DbSet<javainfoModel> javainfo { get; set; }
        public DbSet<journallogModel> journallog { get; set; }
        public DbSet<languagesModel> languages { get; set; }
        public DbSet<local_groupsModel> local_groups { get; set; }
        public DbSet<local_usersModel> local_users { get; set; }
        public DbSet<locksModel> locks { get; set; }
        public DbSet<memoriesModel> memories { get; set; }
        public DbSet<modemsModel> modems { get; set; }
        public DbSet<monitorsModel> monitors { get; set; }
        public DbSet<netmapModel> netmap { get; set; }
        public DbSet<network_devicesModel> network_devices { get; set; }
        public DbSet<networksModel> networks { get; set; }
        public DbSet<notificationModel> notification { get; set; }
        public DbSet<notification_configModel> notification_config { get; set; }
        public DbSet<operatorsModel> operators { get; set; }
        public DbSet<portsModel> ports { get; set; }
        public DbSet<printersModel> printers { get; set; }
        public DbSet<prolog_conntrackModel> prolog_conntrack { get; set; }
        public DbSet<regconfigModel> regconfig { get; set; }
        public DbSet<registryModel> registry { get; set; }
        public DbSet<registry_name_cacheModel> registry_name_cache { get; set; }
        public DbSet<registry_regvalue_cacheModel> registry_regvalue_cache { get; set; }
        public DbSet<repositoryModel> repository { get; set; }
        public DbSet<saasModel> saas { get; set; }
        public DbSet<saas_expModel> saas_exp { get; set; }
        public DbSet<save_queryModel> save_query { get; set; }
        public DbSet<schedule_WOLModel> schedule_WOL { get; set; }
        public DbSet<simModel> sim { get; set; }
        public DbSet<slotsModel> slots { get; set; }
        public DbSet<snmp_communitiesModel> snmp_communities { get; set; }
        public DbSet<snmp_configsModel> snmp_configs { get; set; }
        public DbSet<snmp_labelsModel> snmp_labels { get; set; }
        public DbSet<snmp_linksModel> snmp_links { get; set; }
        public DbSet<snmp_mibsModel> snmp_mibs { get; set; }
        public DbSet<snmp_typesModel> snmp_types { get; set; }
        public DbSet<softwareModel> software { get; set; }
        public DbSet<software_categoriesModel> software_categories { get; set; }
        public DbSet<software_categories_linkModel> software_categories_link { get; set; }
        public DbSet<software_category_expModel> software_category_exp { get; set; }
        public DbSet<software_linkModel> software_link { get; set; }
        public DbSet<software_nameModel> software_name { get; set; }
        public DbSet<software_publisherModel> software_publisher { get; set; }
        public DbSet<software_versionModel> software_version { get; set; }
        public DbSet<softwares_name_cacheModel> softwares_name_cache { get; set; }
        public DbSet<soundsModel> sounds { get; set; }
        public DbSet<ssl_storeModel> ssl_store { get; set; }
        public DbSet<storagesModel> storages { get; set; }
        public DbSet<subnetModel> subnet { get; set; }
        public DbSet<tagsModel> tags { get; set; }
        public DbSet<temp_filesModel> temp_files { get; set; }
        public DbSet<usbdevicesModel> usbdevices { get; set; }
        public DbSet<videosModel> videos { get; set; }
        public DbSet<virtualmachinesModel> virtualmachines { get; set; }

        public OcsWebContext(DbContextOptions opt) : base(opt)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<download_historyModel>().HasKey("HARDWARE_ID", "PKG_ID");
            builder.Entity<engine_mutexModel>().HasKey("NAME", "TAG");
            builder.Entity<filesModel>().HasKey("NAME", "OS", "VERSION");
            builder.Entity<groups_cacheModel>().HasKey("GROUP_ID", "HARDWARE_ID");
            builder.Entity<local_groupsModel>().HasKey("HARDWARE_ID", "ID");
            builder.Entity<local_usersModel>().HasKey("HARDWARE_ID", "ID");
            builder.Entity<tagsModel>().HasKey("Login", "Tag");
            builder.Entity<cve_searchModel>().HasNoKey();
            builder.Entity<cve_search_computerModel>().HasNoKey();
            builder.Entity<saasModel>().HasNoKey();
        }
    }
}
