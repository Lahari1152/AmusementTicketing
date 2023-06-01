using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Models;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;

namespace DataLayer.Repository
{

        public class PurchaseRepository : IPurchaseRepository
        {
            private readonly AmuseDbContext _dbContext;

            public PurchaseRepository(AmuseDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public List<Purchase> GetAllPurchases()
            {
                return _dbContext.Purchases.ToList();
            }

            public Purchase GetPurchaseById(int purchaseId)
            {
                return _dbContext.Purchases.FirstOrDefault(p => p.Id == purchaseId);
            }

         
            public void AddPurchase(Purchase purchase)
            {
                _dbContext.Purchases.Add(purchase);
                _dbContext.SaveChanges();
            }

            public void UpdatePurchase(Purchase purchase)
            {
                _dbContext.Purchases.Update(purchase);
                _dbContext.SaveChanges();
            }

            public void DeletePurchase(int purchaseId)
            {
                var purchase = GetPurchaseById(purchaseId);
                if (purchase != null)
                {
                    _dbContext.Purchases.Remove(purchase);
                    _dbContext.SaveChanges();
                }
            }
        }
    }


