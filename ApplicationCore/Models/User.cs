using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class User
    {
        public string? UserName { get; set; }
        public List<Questionaire>? Questionaires { get; set; }
    }
}
