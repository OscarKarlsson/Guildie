using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guild.DTO.Models
{
    public class ClassModel
    {
        public int Id { get; set; }
        [Required]
        public string HeroClass { get; set; }
        public double modStr { get; set; }
        public double modAgi { get; set; }
        public double modInt { get; set; }
        public double modHealth { get; set; }

    }
}
