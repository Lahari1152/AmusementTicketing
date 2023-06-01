using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repository
{
    
        public interface IPurchaseRepository
        {
            List<Purchase> GetAllPurchases();
            Purchase GetPurchaseById(int purchaseId);
            void AddPurchase(Purchase purchase);
            void UpdatePurchase(Purchase purchase);
            void DeletePurchase(int purchaseId);
        }

}
