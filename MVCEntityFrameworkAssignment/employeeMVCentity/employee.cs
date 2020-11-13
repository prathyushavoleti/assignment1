using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace employeeMVC.Models
{
    [Table("tblemployee")]
    public class employee
    {
        
        
            [Key]
            public int ID { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }

       
    }
}