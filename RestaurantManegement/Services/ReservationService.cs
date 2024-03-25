using RestaurantManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManegement.Services
{
    public class ReservationService : IBaseService<Reservation>
    {
        private ApplicationDbContext _context;
        public ReservationService()
        {
                _context = new ApplicationDbContext();
        }
        public void Add(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public Reservation Get(int id)
        {
            var reservation = _context.Reservations.FirstOrDefault(x => x.Id == id);
            return reservation;
        }

        public List<Reservation> GetAll()
        {
            List<Reservation> reservationList = _context.Reservations.Where(x => x.IsDElete == false).ToList();
            if (reservationList.Count>0)
            {
                return reservationList;
            }        
            else
            {
                return null;
            }
        }

        public void Remove(Reservation id)
        {
            Reservation DeleteReservation = _context.Reservations.Find(id);
            DeleteReservation.IsDElete = true;
            _context.SaveChanges();
        }

        public void Update(Reservation reservasion)
        {
            Reservation updateReservation = _context.Reservations.FirstOrDefault(x=>x.Id==reservasion.Id);
            updateReservation.customer=reservasion.customer;
            updateReservation.Note=reservasion.Note;
            updateReservation.ReservationDate=reservasion.ReservationDate;
            updateReservation.ReservationDate = reservasion.ReservationDate;
            _context.SaveChanges();
        }
    }
}
