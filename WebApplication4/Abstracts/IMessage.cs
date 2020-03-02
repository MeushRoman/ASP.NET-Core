using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Abstracts
{
    public interface IMessage
    {
        string Send(string text);
    }
}
