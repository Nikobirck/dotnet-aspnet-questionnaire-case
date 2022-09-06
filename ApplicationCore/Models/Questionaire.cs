using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Questionaire
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        //public string Description { get; set; }
        public List<Question>? Questions { get; set; }
    }
}
