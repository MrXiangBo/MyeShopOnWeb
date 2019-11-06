using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.BasketAggregate
{
   public  class Basket:BaseEntity,IAggregateRoot
    {
        public string BuyerId { get; set; }

    }
}
