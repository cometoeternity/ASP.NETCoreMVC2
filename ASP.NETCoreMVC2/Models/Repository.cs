using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC2.Models
{
    public static class Repository
    {
        private static List<Guests> responses = new List<Guests>();
        public static IEnumerable<Guests> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse (Guests response)
        {
            responses.Add(response);
        }
    }
}
