using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Display_and_Interaction_Learning
{
	public class Datarow
	{
		private string _name;


		public string Description { get; set; }
		public Datarow(string Name, string Description) { 
			this.Name = Name;
			this.Description = Description;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


	}
}
