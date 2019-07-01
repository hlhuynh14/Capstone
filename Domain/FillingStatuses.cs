using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class FillingStatuses
    {
        [Key]
        public int Id { get; set; }
        public string FillingStatus { get; set; }
    }
}
