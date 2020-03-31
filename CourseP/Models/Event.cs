using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Event
    {
        private int id;
        private string name;
        private string description;
        private DateTime startTime;
        private DateTime endTime;
        private int id_pub;

        public Event(int id, string name, string description, DateTime startTime, DateTime endTime, int id_pub)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.startTime = startTime;
            this.endTime = endTime;
            this.id_pub = id_pub;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int Id_pub { get => id_pub; set => id_pub = value; }
        public string Description { get => description; set => description = value; }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   id == @event.id &&
                   name == @event.name &&
                   description == @event.description &&
                   startTime == @event.startTime &&
                   endTime == @event.endTime &&
                   id_pub == @event.id_pub;
        }
    }
}
