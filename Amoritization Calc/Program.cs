using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Amoritization_Calc
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      var view = new AmortizationForm();
      var model = new AmortizationModel(view);
      Application.Run(view);
    }
  }
}
