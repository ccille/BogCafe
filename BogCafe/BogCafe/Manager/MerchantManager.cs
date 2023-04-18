using BookLibrary.model;
using System.Runtime.CompilerServices;

namespace BogCafe.Manager
{
    public class MerchantManager : IMerchant
    {
        private static List<Merchant> liste = new List<Merchant>()
        {
            new Merchant(2, "cecilie", "fe@mail.com", "20342211"),
            new Merchant(3, "Olga", "s@mail.com", "20345511"),
            new Merchant(4, "Oliver", "ne@mail.com", "70342211")
        };

        public Merchant Create(Merchant newmerchant)
        {
            liste.Add(newmerchant);
            return newmerchant;
        }

        public Merchant Delete(int id)
        {
            Merchant del = Get(id);
            liste.Remove(del);
            return del;
        }

        public Merchant Get(int id)
        {
            return liste.Find(m => m.ID == id);
        }

        public List<Merchant> GetAll()
        {

            return liste;
        }

        public List<Merchant> Getname(string name)
        {
            if (name is null)
            {
                return new List<Merchant>();
            }

            return liste.Where(m => m.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public Merchant Update(int id, Merchant updatemerchant)
        {
            Merchant upmerchant = Get(id);
            if (upmerchant is not null)
            {
                upmerchant.ID = updatemerchant.ID;
                upmerchant.Name = updatemerchant.Name;
                upmerchant.Email = updatemerchant.Email;
                upmerchant.Phone = updatemerchant.Phone;
            }
            return upmerchant;
        }
    }
}
