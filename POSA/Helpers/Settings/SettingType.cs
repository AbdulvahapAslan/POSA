using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using POSA.Dto;
namespace POSA.Helpers.Settings
{
    public class SettingType
    {
        public string MainCS { get; set; } = "Server=localhost\\SQLEXPRESS;Database=POSA;User Id=sa;Password=Avp*Posa*2024!;";
        public string LastSuccesfullyLoggedUser { get; set; } = "";
        public bool RememberMe { get; set; } = false;
        public string Password { get; set; } = "";
        public SQL_Type Sql { get; set; } = new SQL_Type();
        public class SQL_Type
        {
            public string Server { get; set; } = @"localhost\SQLEXPRESS";
            public int Port { get; set; } = 1433;
            public string Username { get; set; } = "sa";
            public string Password { get; set; } = "Avp*Posa*2024!";
            public string Database { get; set; } 
            public override string ToString() =>
                $"Server={this.Server},{this.Port};Database={this.Database};User Id={this.Username};Password={this.Password};";
            public string ConnectionString() => this.ToString();
        }
    }
    
}
