using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Display_and_Interaction_Learning
{
	public class Datarow
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Datarow(string Name, string Description) { 
			this.Name = Name;
			this.Description = Description;
		}
	}
}
