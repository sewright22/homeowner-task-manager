using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IService
    {
        string Name { get; }
        decimal Price { get; }
        DateTime ServiceDate { get; }
    }
}