using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd2_trabalho_final.Enums;

namespace bd2_trabalho_final.Classes
{
    class Provider : Unique
    {
        private readonly Person person;
        private ProviderType providerType;
        private string registryIdentification;

        public Provider(int id, Person person, ProviderType providerType, string registryIdentification) : base(id)
        {
            this.person = person;
            this.providerType = providerType;
            this.registryIdentification = registryIdentification;
        }

        public string Name
        {
            get { return person.Name; }
            set { person.Name = value; }
        }

        public ProviderType ProviderType
        {
            get { return providerType; }
            set { providerType = value; }
        }

        public string RegistryIdentification
        {
            get { return registryIdentification; }
            set { registryIdentification = value; }
        }
    }
}
