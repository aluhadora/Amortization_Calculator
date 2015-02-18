using System.Windows.Forms;

namespace Amoritization_Calc
{
  public partial class ViewBase : Form
  {
    public ViewBase()
    {
      InitializeComponent();
    }

    public void Initialize()
    {
      foreach (Control control in Controls)
      {
        control.KeyDown += ControlKeyDown;
      }
    }

    private void ControlKeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Enter) return;
      e.Handled = true;
      e.SuppressKeyPress = true;
      SelectNextControl((Control)sender, true, true, true, true);
    }
  }
}
