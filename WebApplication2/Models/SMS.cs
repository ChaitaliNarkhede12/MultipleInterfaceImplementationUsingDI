using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class SMS : IMessenger
    {
        public string CurrentName => nameof(SMS);
        public string SendMessage()
        {
            // code to send email
            return "Sent SMS";
        }
    }
}
