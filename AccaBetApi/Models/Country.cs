using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccaBetApi.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(maximumLength: 30)]
        public string CountryName { get; set; }

        public virtual List<League> Leagues { get; set; }
    }
}
