using System;

namespace Amoritization_Calc
{
  public interface IAmortizationData
  {
    //Inputs
    decimal Principal { get; set; }
    decimal Interest { get; set; }
    decimal Payment { get; set; }

    //Outputs
    int Months { get; set; }
    int Years { get; set; }
    decimal ExtraInterest { get; set; }

    //Events
    event EventHandler Calculate;
  }
}
