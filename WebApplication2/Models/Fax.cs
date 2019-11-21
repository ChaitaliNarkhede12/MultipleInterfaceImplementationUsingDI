using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Fax : IMessenger
    {
        public string CurrentName => nameof(Fax);
        public string SendMessage()
        {
            // code to send email
            return "Sent Fax";
        }
    }
}
