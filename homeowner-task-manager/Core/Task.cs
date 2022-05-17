using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Task
    {
        public Task()
        {
        }

        public Task(int days)
        {
            this.DueDate = DateTime.Now.AddDays(days);
        }

        public DateTime DueDate { get; set; }
    }
}