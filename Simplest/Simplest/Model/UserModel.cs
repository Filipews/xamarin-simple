using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplest.Model
{
	public class UserModel : BaseModel
	{
		private int _ID;
		private string _Name;

		public int ID { get => _ID; set => SetProperty(ref _ID, value); }
		public string Name { get => _Name; set => SetProperty(ref _Name, value); }

		public UserModel()
		{
		}

		public UserModel(int ID, string Name)
		{
			_ID = ID;
			_Name = Name;
		}
	}
}
