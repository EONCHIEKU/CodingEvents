using System;
namespace CodingEvents.Models
{
	public class Event
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? ContactEmail { get; set; }
		public string? Location { get; set; }
		public int NumOfAttendees { get; set; }
		public bool MustRegister { get; set; }

        public int Id { get; set; }

        public Event()
        {
        }

        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        //      public int Id { get; set; }
        //static private int nextId = 1;

        //public Event()
        //{
        //	Id = nextId;
        //	nextId++;
        //}

        //public Event(string name, string description, string contactEmail, string location, int numOfAttendees, bool mustRegister)
        //{
        //	Name = name;
        //	Description = description;
        //	ContactEmail = contactEmail;
        //	Id = nextId;
        //	nextId++;
        //	Location = location;
        //	NumOfAttendees = numOfAttendees;
        //	MustRegister = mustRegister;
        //}

        public override string? ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
			return obj is Event @event && Id == @event.Id;
        }

        public override int GetHashCode()
        {
			return HashCode.Combine(Id);
        }
    }
}