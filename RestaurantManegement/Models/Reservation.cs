using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Models
{
    public  class Reservation:BaseModel
    {
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Note{ get; set; }
    }
}
