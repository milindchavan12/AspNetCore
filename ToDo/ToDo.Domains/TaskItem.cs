using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ToDo.Domains
{
    public class TaskItem
    {
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public TaskItem(string task, DateTime date)
        {
            Description = task;
            var dueDatePattern = new Regex(@"(jan|feb|mar|apr|may|jun|jul|aug|sep|oct|nov|dec)\s(\d+)");
            var hasDueDate = dueDatePattern.IsMatch(task);
            if(hasDueDate)
            {
                var dueDate = dueDatePattern.Match(task);
                var monthInput = dueDate.Groups[1].Value;
                var month = DateTime.ParseExact(monthInput, "MMM", CultureInfo.CurrentCulture).Month;
                var day = Convert.ToInt32(dueDate.Groups[2].Value);
                if(date != null)
                {
                    if(day <= DateTime.DaysInMonth(date.Year, month))
                    {
                        DueDate = new DateTime(date.Year, month, day);
                    }
                }
            }
        }
    }
}
