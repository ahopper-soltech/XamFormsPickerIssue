using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace PickerIssue
{	
	public partial class Home : ContentPage
	{	
		public Home ()
		{
      System.Diagnostics.Debug.WriteLine("Home::ctor() - Enter");
			InitializeComponent ();
      System.Diagnostics.Debug.WriteLine("Home::ctor() - Exit");
		}
  }
}

