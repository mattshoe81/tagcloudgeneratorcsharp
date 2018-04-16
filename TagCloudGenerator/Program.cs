using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagCloudGenerator {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			TagCloudGenerator.ModelNS.Model model = new ModelNS.Model();
			TagCloudGenerator.View view = new View();
			TagCloudGenerator.ControllerNS.Controller controller = new ControllerNS.Controller(model, view);
			view.RegisterObserver(controller);
			Application.Run(view);			
		}
	}
}
