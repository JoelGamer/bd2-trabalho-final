using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Enums;

namespace bd2_trabalho_final.Classes
{
    class Product : Unique
    {
        private string name;
        private readonly ProductCategory productCategory;
        private readonly Provider provider;
        private double price;

        public Product(int id, string name, ProductCategory productCategory, Provider provider, double price) : base(id)
        {
            this.name = name;
            this.productCategory = productCategory;
            this.provider = provider;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductCategoryName
        {
            get { return productCategory.Name; }
            set { productCategory.Name = value; }
        }

        public Provider Provider
        {
            get { return provider; }
        }

        public string ProviderName
        {
            get { return provider.Name; }
            set { provider.Name = value; }
        }

        public ProviderType ProviderType
        {
            get { return provider.ProviderType; }
            set { provider.ProviderType = value; }
        }

        public string ProviderRegistryIdentification
        {
            get { return provider.RegistryIdentification; }
            set { provider.RegistryIdentification = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
