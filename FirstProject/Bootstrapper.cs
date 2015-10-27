﻿using System;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;


namespace FirstProject
{
	public class Bootstrapper : UnityBootstrapper
	{
		protected override Xamarin.Forms.Page CreateMainPage ()
		{
			return Container.Resolve<AuthorizationPage> ();
		}

		protected override void RegisterTypes ()
		{
			Container.RegisterTypeForNavigation<RegistrationPage> ();

		}
	}
}

