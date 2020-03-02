using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Abstracts;

namespace WebApplication4.Entities
{
    public class SMSMassage : IMessage
    {
        public string Send(string text)
        {
            return text + " From: SMS";
        }
    }
}
