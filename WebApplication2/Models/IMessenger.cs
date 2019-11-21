using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    
    public interface IMessenger
    {
        string CurrentName { get; }
        string SendMessage();
    }
}
