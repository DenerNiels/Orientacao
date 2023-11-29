using Orientacao.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lecture = new List<Lecture>();
        }
        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lecture { get; set; }
    }
}
