using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Email : IMessenger
    {
        public string CurrentName => nameof(Email);
        public string SendMessage()
        {
            // code to send email
            return "Sent Email";
        }
    }
}
