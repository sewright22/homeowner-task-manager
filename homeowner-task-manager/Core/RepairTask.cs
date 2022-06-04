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

        public string Name { get; set; }

        /// <summary>
        /// Calculates the number of days until the due date.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int CalculateNumberOfDaysTilDueDate()
        {
            // Check if Due date is less than today.
            if (this.DueDate < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Due date is in the past.");
            }

            return (int)Math.Floor(this.DueDate.Subtract(DateTime.Now).TotalDays);
        }

        public void PerformExample()
        {
            throw new NotImplementedException();
        }
    }
}