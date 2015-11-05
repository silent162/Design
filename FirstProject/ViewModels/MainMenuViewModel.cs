using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace FirstProject
{
	public class Marker
	{
		public string Name { get; set ; }

		public string Image { get; set; }
	}

	public class MainMenuViewModel
	{
		public MainMenuViewModel ()
		{			
		}

		static MainMenuViewModel ()
		{
			Markers = new ObservableCollection<Marker> ();
			Markers.Add (new Marker (){ Name = "Маяк М12", Image = "menu_system_icon1" });
			Markers.Add (new Marker (){ Name = "Сигнализация DV12", Image = "menu_system_icon1" });
			Markers.Add (new Marker (){ Name = "Mazda 524", Image = "menu_system_icon1" });
			Markers.Add (new Marker (){ Name = "Пирожок ВАЗ 214", Image = "menu_system_icon1" });
			Markers.Add (new Marker (){ Name = "Мотосистема МР - 25", Image = "menu_system_icon1" });
			Markers.Add (new Marker (){ Name = "Mazda 524", Image = "menu_system_icon1" });
			Markers.Add (new Marker (){ Name = "Пирожок ВАЗ 214", Image = "menu_system_icon1" });
		}

		public static ObservableCollection<Marker> Markers { private set; get; }
	}

}


