using Simplest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Simplest.ViewModel
{
	public class MainViewModel : BaseViewModel
	{
		private UserModel _CurrentUser;
		private ICommand _ChangeUserCommand;
		public UserModel CurrentUser { get => _CurrentUser; set => SetProperty(ref _CurrentUser, value); }
		public ICommand ChangeUserCommand { get => _ChangeUserCommand; set => SetProperty(ref _ChangeUserCommand, value); }

		private int Counter;

		public MainViewModel()
		{
			ChangeUserCommand = new Command(ChangeUser);
			ChangeUser();
		}

		private void ChangeUser()
		{
			CurrentUser = new UserModel(++Counter, "User " + Counter);
		}
	}
}
