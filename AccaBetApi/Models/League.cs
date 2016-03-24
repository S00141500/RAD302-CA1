using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccaBetApi.Models
{
    public class League
    {
        [Required,Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required, StringLength(maximumLength: 50, MinimumLength = 3)]
        public string LeagueName { get; set; }

        public string LeagueIcon { get; set; }

        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }

        public virtual List<Team> Teams { get; set; }


    }
}
