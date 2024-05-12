using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POSA.Helpers.Settings
{
    public class SettingType
    {
        public SQL_Type Sql { get; set; }
        public class SQL_Type
        {
            public string Server { get; set; }
            public int Port { get; set; } = 1433;
            public string Username { get; set; }
            public string Password { get; set; }
            public string Database { get; set; }
            public override string ToString() =>
                $"Server={this.Server ?? "."},{this.Port};Database={this.Database ?? "LOGODB"};User Id={this.Username ?? "sa"};Password={this.Password ?? ""};";
            public string ConnectionString() => this.ToString();
        }
        public class SalePage
        {
            public List<GroupPage> GroupPages { get; set; }
        }
        public class GroupPage
        {
            public string PageName { get; set; }
            public string PageImageBase64 { get; set; }
            public List<Product> Products { get; set; }
        }
        public class Product
        {
            public string Name { get; set; }
            public string Barcode { get; set; }
            public string B64Image { get; set; }
        }
    }
}
