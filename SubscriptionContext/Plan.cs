using Orientacao.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}
