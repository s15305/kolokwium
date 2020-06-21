using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace kolokwium.Models
{
    public class Track
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrack { get; set; }
        [MaxLength(20)]
        [Required]
        public string TrackName { get; set; }
        [Required]
        public float Duration { get; set; }
        public int IdMusicAlbum { get; set; }
        [ForeignKey("IdMusicAlbum")]
        public virtual Album Album { get; set; }
        public virtual ICollection<Musician_Track> Musician_Track { get; set; }
    }
}
