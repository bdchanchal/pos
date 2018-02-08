using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PointOfSale.Models
{
    public class Branch
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

    }
}