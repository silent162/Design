using System;
using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows.Input;
using Prism.Navigation;

namespace FirstProject
{
	public class AuthorizationPageViewModel : BindableBase
	{
		private readonly INavigationService m_navigationService;

		public DelegateCommand NavigateCommand { get; set; }

		public AuthorizationPageViewModel (INavigationService navigationService)
		{
			m_navigationService = navigationService;
			NavigateCommand = new DelegateCommand (Navigate);
		}

		void Navigate ()
		{
			m_navigationService.Navigate ("RegistrationPage");
		}
	}
}


