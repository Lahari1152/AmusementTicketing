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
    public class PurchaseService
    {
        private AmuseDbContext _context;
        public PurchaseService(AmuseDbContext context)

        {
            _context = context;
        }

        public void AddPurchase(Purchase purchase)
        {
            var _purchase = new Purchase();
            {
                string AName = purchase.AName;
               // string Description = purchase.Description;
                long Price = purchase.Price;
            }
            _context.Purchases.Add(_purchase);
            _context.SaveChanges();
        }

        public List<Purchase> GetAllPurchases() => _context.Purchases.ToList();
        public Purchase GetPurchaseById(int purchaseId) => _context.Purchases.FirstOrDefault(n => n.PurchaseId == purchaseId);
        public Purchase UpdatePurchaseById(int purchaseId, Purchase purchase)
        {
            var _purchase = _context.Purchases.FirstOrDefault(n => n.Id == purchaseId);
            if (_purchase != null)
            {
                //_purchase.AName = purchase.AName;
               // _attraction.Description = attraction.Description;
                _purchase.Price = purchase.Price;

                _context.SaveChanges();
            }
            return _purchase;
        }

        public void DeletePurchaseById(int purchaseId)
        {
            var _purchase = _context.Purchases.FirstOrDefault(n => n.Id == purchaseId);
            if (_purchase != null)
            {
                _context.Purchases.Remove(_purchase);
                _context.SaveChanges();
            }
        }
        public object GetPurchaseById()
        {
            throw new NotImplementedException();
        }
    }
}
