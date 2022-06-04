using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Appliance : IAppliance
    {
        public string Description => throw new NotImplementedException();

        public bool IsUnderWarranty => throw new NotImplementedException();

        public string Make => throw new NotImplementedException();

        public string Model => throw new NotImplementedException();

        public DateTime PurchaseDate => throw new NotImplementedException();

        public string SerialNumber => throw new NotImplementedException();

        public IEnumerable<IService> ServiceHistory => throw new NotImplementedException();

        public DateTime WarrantyExpiration => throw new NotImplementedException();
    }
}