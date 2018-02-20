using Context.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Context
{
    public class SettingsContext :DbContext
    {
        public DbSet<Setting> Settings { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=10.1.3.145\SQLEXPRESS;Initial Catalog=CaseManagement;User Id=sa;Password=Site@cnh;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=SettingsDynamic;Integrated Security=False;User Id=sa;Password=Site@cnh;MultipleActiveResultSets=True;");

        }
    }
}
