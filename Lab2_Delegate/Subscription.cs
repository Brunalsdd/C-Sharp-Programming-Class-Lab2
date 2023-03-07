using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Delegate
{
    internal class Subscription
    {
        public static List<SendViaEmail> emailSubscription = new List<SendViaEmail>();
        public static List<SendViaMobile> mobilelSubscription = new List<SendViaMobile>();

        public static Publisher publisher = new Publisher();

    }
}
