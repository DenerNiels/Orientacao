﻿using Orientacao.NotificationContext;
using Orientacao.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao.SubscriptionContext
{
    public class User : Base 
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
