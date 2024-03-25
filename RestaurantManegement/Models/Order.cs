using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Models
{
    public  class Order:BaseModel
    {
        public int ReservationId { get; set; }
        public Reservation Reservations { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Quantity { get; set; }
    }
}
