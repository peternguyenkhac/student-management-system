using src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Data
{
    public class Context
    {
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
