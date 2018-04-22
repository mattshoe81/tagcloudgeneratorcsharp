using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagCloudGenerator.MVC.Views;
using TagCloudGenerator.MVC.Models;
using TagCloudGenerator.MVC.Controllers;

namespace TagCloudGenerator {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Model model = new Model();
			MainView view = new MainView();
			Controller controller = new Controller(model, view);
			view.RegisterObserver(controller);
			Application.Run(view);			
		}
	}
}
