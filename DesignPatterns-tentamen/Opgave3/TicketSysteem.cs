using System;
using System.Collections.Generic;

namespace Opgave3
{
    public class TicketSysteem
    {
        private static TicketSysteem uniqueInstance;
        public Dictionary<string, int> Tickets { get; set; }

        private TicketSysteem()
        {
            Tickets = new Dictionary<string, int>();
            Tickets.Add("Bruno Mars", 250); 
            Tickets.Add("Coldplay", 175); 
            Tickets.Add("Ed Sheeran", 150);
        }

        public static TicketSysteem GetInstance()
        {
            if(uniqueInstance is null)
            {
                uniqueInstance = new TicketSysteem();
            }
            return uniqueInstance;
        }
        
        public void PrintOverzicht()
        {
            foreach (KeyValuePair<string, int> item in Tickets)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }

        public void VerkoopTickets(string artiest, int aantal)
        {
            if (Tickets.ContainsKey(artiest))
            {
                int beschikbaar;
                Tickets.TryGetValue(artiest, out beschikbaar);
                if (beschikbaar > aantal)
                {
                    Tickets.Remove(artiest);
                    Tickets.Add(artiest, beschikbaar - aantal);
                }
            }
        }
    }
}
