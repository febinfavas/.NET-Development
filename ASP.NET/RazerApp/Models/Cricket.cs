using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazerApp.Models
{
    public class Cricket
    {
        public int Id { get; set; }

        [Display(Name = "Player Jersy Number")]
        [Required]
        public int PlayerNum { get; set; }

        [Display(Name = "Player Name")]
        [Required]
        public string PlayerName { get; set; }

        [Display(Name = "Position In Team")]
        [Required]
        public string Position { get; set; }

        [Display(Name = "IPL Team")]
        [Required]
        public string IplTeam { get; set; }
    }
}
