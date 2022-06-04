using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum PropertyType
    {
        SingleFamilyHome,
        Apartment,
        Condo,
    }

    public interface IProperty
    {
        IAddress Address { get; }
        string Description { get; }
        bool IsOwned { get; }
        DateTime MoveInDate { get; }
        int NumberOfBathrooms { get; }
        int NumberOfBedrooms { get; }
        PropertyType PropertyType { get; }
    }
}