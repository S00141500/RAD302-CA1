using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccaBetApi.Models
{
    public class Team
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required, StringLength(maximumLength: 75, MinimumLength = 3)]
        public string TeamName { get; set; }

        public int LeagueID { get; set; }

        [ForeignKey("LeagueID")]
        public virtual League League { get; set; }

    }
}
