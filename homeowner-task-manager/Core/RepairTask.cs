using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RepairTask : Task
    {
        public RepairTask(string name, int days)
            : base(days)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}