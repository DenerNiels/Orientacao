using Orientacao.ContentContext.Enums;
using Orientacao.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
