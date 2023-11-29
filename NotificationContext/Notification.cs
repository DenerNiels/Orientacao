using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.NotificationContext
{
    public sealed class Notification
    {
        public Notification() 
        {

        }

        public Notification(string property, string messege)
        {
            Property = property;
            Messege = messege;
        }

        public string Property { get; set; }

        public string Messege { get; set; }
    }
}
