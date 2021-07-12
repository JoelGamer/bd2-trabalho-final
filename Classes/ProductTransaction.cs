using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Enums;
using bd2_trabalho_final.Classes.Persons.Users;

namespace bd2_trabalho_final.Classes
{
    class ProductTransaction : Unique
    {
        private Product product;
        private Finantial finantial;
        private Client client;
        private Provider provider;
        private ProductTransactionType productTransactionType;

        public ProductTransaction(int id, Product product, Finantial finantial, Client client, ProductTransactionType productTransactionType) : base(id)
        {
            this.product = product;
            this.finantial = finantial;
            this.client = client;
            this.productTransactionType = productTransactionType;
        }

        public ProductTransaction(int id, Product product, Finantial finantial, Provider provider, ProductTransactionType productTransactionType) : base(id)
        {
            this.product = product;
            this.finantial = finantial;
            this.provider = provider;
            this.productTransactionType = productTransactionType;
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public Finantial Finantial
        {
            get { return finantial; }
            set { finantial = value; }
        }

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public Provider Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        public ProductTransactionType ProductTransactionType
        {
            get { return productTransactionType; }
            set { productTransactionType = value; }
        }
    }
}
