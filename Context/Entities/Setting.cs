using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Context.Entities
{
    public class Setting
    {
        [Column(Order = 0)]
        public string SettingID { get; set; }
        [Column(Order = 1)]
        public string Type { get; set; }
        [Column(Order = 2)]
        public string Description { get; set; }
        
        public Int32? IntegerValue { get; set; }
        public double? Numeric4Value { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public String StringValue { get; set; }
    }
}