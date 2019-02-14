using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public class Task: INotifyPropertyChanged
    {
        public Task()
        {
        }

        public Task(string name, string priority, DateTime deadline, string comment)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Priority = priority ?? throw new ArgumentNullException(nameof(priority));
            Deadline = deadline;
            Comment = comment ?? throw new ArgumentNullException(nameof(comment));
        }

        public string Name { get; set; }
        public string Priority { get; set; }
        public DateTime Deadline { get; set; }
        public string Comment { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
