using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
