using System;
using System.Collections.Generic;
using System.Text;

namespace App8.Models
{
    class Pays
    {
        public int id 
        { 
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public List<Ville> vilelist;
    }
}
