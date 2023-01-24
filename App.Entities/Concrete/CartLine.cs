using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Concrete
{
    public class CartLine : IEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
