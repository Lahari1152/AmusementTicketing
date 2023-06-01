using DataLayer.Data;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class AttractionService
    {
        private AmuseDbContext _context;
        public AttractionService(AmuseDbContext context)

        {
            _context = context; 
        }

        public void AddAttraction(Attraction attraction)
        {
            var _attraction = new Attraction();
            {
                string AName = attraction.AName;
                string Description = attraction.Description;
                long Price = attraction.Price;
            }
            _context.Attractions.Add(_attraction);
            _context.SaveChanges();
        }

        public List<Attraction> GetAllAttractions() => _context.Attractions.ToList();
        public Attraction GetAttractionById(int attractionId) => _context.Attractions.FirstOrDefault(n => n.AttractionId == attractionId);
        public Attraction UpdateAttractionById(int attractionId, Attraction attraction) 
        {
            var _attraction = _context.Attractions.FirstOrDefault(n => n.Id == attractionId);
            if(_attraction != null) 
            {
                _attraction.AName = attraction.AName;
                _attraction.Description = attraction.Description;
                _attraction.Price = attraction.Price;

                _context.SaveChanges();
            }
            return _attraction;
        }

        public void DeleteAttractionById(int attractionId)
        {
            var _attraction = _context.Attractions.FirstOrDefault(n => n.Id == attractionId);
            if( _attraction != null )
            {
                _context.Attractions.Remove(_attraction);
                _context.SaveChanges();
            }
        }
        public object GetAttractionById()
        {
            throw new NotImplementedException();
        }
    }
}
