using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn1
{
    class Notification
    {
        public virtual void notify()
        {
            Console.WriteLine("SMS or Email");
        }
    }

    class message: Notification
    {
        public override void notify()
        {
            Console.WriteLine("SMS");
        }
    }

    class email : Notification
    {
        public override void notify()
        {
            Console.WriteLine(" Email");
        }
    }

    class objcreate
    {
        public Notification obj1(String type)
        {
            if (type == "SMS")
                {
                message sms = new message();
                return sms; 
                }
            if (type == "SMS")
            {
                email email = new email();
                return email;
            }
            else
                return new Notification() ;
        }
    }
}
