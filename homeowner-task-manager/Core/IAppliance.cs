using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IAppliance
    {
        string Description { get; }
        bool IsUnderWarranty { get; }
        string Make { get; }
        string Model { get; }
        DateTime PurchaseDate { get; }
        string SerialNumber { get; }
        IEnumerable<IService> ServiceHistory { get; }
        DateTime WarrantyExpiration { get; }
    }
}