using System;

using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Commands;

namespace FirstProject
{
	public class RegistrationPageViewModel : BindableBase
	{
		private readonly INavigationService m_navigationService;

		public DelegateCommand NavigateCommand { get; set; }

		public RegistrationPageViewModel (INavigationService navigationService)
		{
			m_navigationService = navigationService;
			NavigateCommand = new DelegateCommand (GoBack);
		}

		void GoBack ()
		{
			m_navigationService.GoBack ();
		}

	}
}


