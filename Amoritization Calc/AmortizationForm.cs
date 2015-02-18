using System;

namespace Amoritization_Calc
{
  public partial class AmortizationForm : ViewBase, IAmortizationData
  {
    private event EventHandler CalculateHandler;

    public AmortizationForm()
    {
      InitializeComponent();
      Initialize();
    }

    private void ValueChanged(object sender, EventArgs e)
    {
      if (CalculateHandler != null) CalculateHandler(this, e);
    }

    event EventHandler IAmortizationData.Calculate
    {
      add { CalculateHandler += value; }
      remove { CalculateHandler -= value; }
    }

    decimal IAmortizationData.Principal
    {
      get { return principalTextBox.Text.ToDecimal(); }
      set { principalTextBox.Text = value.ToAmount(); }
    }

    decimal IAmortizationData.Interest
    {
      get { return interestTextBox.Text.ToDecimal()/100; }
      set { interestTextBox.Text = value.ToString(); }
    }

    decimal IAmortizationData.Payment
    {
      get { return paymentTextBox.Text.ToDecimal(); }
      set { paymentTextBox.Text = value.ToAmount(); }
    }

    int IAmortizationData.Months
    {
      get { return monthsLabel.Text.ToInt(); }
      set { monthsLabel.Text = value.ToString(); }
    }

    int IAmortizationData.Years
    {
      get { return yearsLabel.Text.ToInt(); }
      set { yearsLabel.Text = value.ToString(); }
    }

    decimal IAmortizationData.ExtraInterest
    {
      get { return interestLabel.Text.ToDecimal(); }
      set { interestLabel.Text = value.ToAmount(); }
    }

    private void GraphButtonClick(object sender, EventArgs e)
    {
      var data = (IAmortizationData)this;
      var form = new AmortizationGraphForm();
      form.Run(data.Principal, data.Interest);
      form.ShowDialog(this);
    }
  }

}
