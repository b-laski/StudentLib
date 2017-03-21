using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Models.API.Collage
{
    class Colleges
    {
        [JsonProperty("colleges")]
        public List<Models.API.Collage.College> data { get; set; }
    }
}
