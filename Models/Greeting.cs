using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poc_net_simple.Models
{
    public class Greeting
    {
        public Greeting()
        {

        }

        public Greeting(long Id, String Content)
        {
            this.Id = Id;
            this.Content = Content;
        }

        public long Id { get; set; }
        public String Content { get; set; }
    }
}