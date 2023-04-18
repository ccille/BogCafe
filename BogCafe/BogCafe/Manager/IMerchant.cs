using BookLibrary.model;

namespace BogCafe.Manager
{
    public interface IMerchant
    {
        Merchant Create(Merchant newmerchant);

        List<Merchant> GetAll();

        Merchant Delete(int id);

        Merchant Get(int id);

        Merchant Update(int id, Merchant updatemerchant);

        List<Merchant> Getname(string name);
    }
}
