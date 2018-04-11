using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Password
    {
        //primary key
        public int PasswordId { get; set; }

        public string UserPassword { get; set; }
        
        public DateTime LastUpdate { get; set; }
    }
}
