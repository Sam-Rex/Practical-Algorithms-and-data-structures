using System;

namespace Data
{
    public class OrdersRecords
    {
        public  int Id { get; set; }
        public int NumberOfProducts { get; set; }
        public string ClientName { get; set; }

        public OrdersRecords(int id,int numbersOfProducts,string clientName)
        {
            Id = id;
            NumberOfProducts = numbersOfProducts;
            ClientName = clientName;
        }

    }
}
