using System;

namespace Amoritization_Calc
{
  public class AmortizationModel
  {
    private readonly IAmortizationData _view;

    public AmortizationModel(IAmortizationData view)
    {
      _view = view;
      view.Calculate += Calculate;
    }

    private void Calculate(object sender, EventArgs e)
    {
      var principal = _view.Principal;
      var interest = _view.Interest;
      var payment = _view.Payment;

      decimal extraInterest = 0m;
      int months = -1;

      if (principal*(1 + interest/12m) - payment >= principal)
      {
        //Plan won't ever pay off loan
        _view.ExtraInterest = 0;
        _view.Months = 0;
        _view.Years = 0;
        return;
      }

      do
      {
        var newPrincipal = principal*(1 + interest/12m) - payment;
        var interestPaid = newPrincipal - principal + payment;
        extraInterest += interestPaid;
        months++;
        principal = newPrincipal;
      } while (principal > 0);

      extraInterest += principal;
      
      _view.ExtraInterest = extraInterest;
      _view.Months = months;
      _view.Years = (int) Math.Round(months/12d, 0d);
    }
  }
}
