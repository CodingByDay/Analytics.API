using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;

namespace AspNetCoreDashboardBackend.Code
{
    public class CustomFileStorage : DashboardFileStorage
    {

        public CustomFileStorage(string workingDirectory)
            : base(workingDirectory)
        {
        }

        protected override System.Xml.Linq.XDocument LoadDashboard(string dashboardID)
        {
            string path = this.ResolveFileName(dashboardID);
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml(path);
            foreach (var dataSource in dashboard.DataSources)
            {
                if (dataSource is DashboardSqlDataSource)
                    dataSource.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            }
            return dashboard.SaveToXDocument();
        }
    }
}
