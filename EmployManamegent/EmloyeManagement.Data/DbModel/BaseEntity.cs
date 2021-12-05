using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmloyeManagement.Data.DbModel
{
   public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
