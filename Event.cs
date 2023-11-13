using System;

namespace Lab6
{
	internal class Event
	{
		private int _eventNumber;
		private string _location;

		public int EventNumber { set; get; }
		public string Location { set; get; }

		public Event(int eventNumber, string location) 
		{
			EventNumber = eventNumber;
			Location = location;
		}


	}
}
