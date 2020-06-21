using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium.DTOs.Request
{
    public class MusicianDtoRequest
    {
        public int IdMusician { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
    }

    public class AddMusician
    {
        public AddMusician()
        {
            author = new HashSet<MusicianDtoRequest>();
        }
        public DateTime DataPrzyjęcia { get; set; }
        public string Uwagi { get; set; }
        public ICollection<MusicianDtoRequest> author { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
    }
}
