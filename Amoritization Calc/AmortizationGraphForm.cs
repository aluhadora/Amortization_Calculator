using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Amoritization_Calc
{
  public partial class AmortizationGraphForm : ViewBase, IAmortizationData
  {
    private event EventHandler CalculateHandler;
    private DataTable _table;
    public AmortizationModel Model;

    private const string PaymentColumn = "Payment";
    private const string MonthsColumn = "Months";

    public AmortizationGraphForm()
    {
      InitializeComponent();
      Initialize();

      chart.MouseMove += ChartMouseMove;
      chart.MouseDown += ChartMouseDown;
      chart.MouseUp += ChartMouseUp;
      chart.Titles.Add(new Title("Amortization", Docking.Top, new Font("Arial", 32), Color.Black));
    }

    public void Run(decimal principal, decimal interest)
    {
      Principal = principal;
      Interest = interest;
      
      _table = new DataTable("Data");
      _table.Columns.Add(PaymentColumn, typeof (decimal));
      _table.Columns.Add(MonthsColumn, typeof (int));

      Model = new AmortizationModel(this);

     var start = double.IsNaN(chart.ChartAreas[0].Axes[0].Minimum) ? 50 : (decimal) Math.Max(50, chart.ChartAreas[0].Axes[0].Minimum);
     var end = double.IsNaN(chart.ChartAreas[0].Axes[0].Maximum) ? Principal : (decimal)Math.Min((double)Principal, chart.ChartAreas[0].Axes[0].Maximum);
     for (var i = start; i < end; i += (end - start) / chart.Width)
      {
        Payment = i;
        Calculate();
      }

      var series = new Series("Payment vs Months") {ChartType = SeriesChartType.SplineArea};

      foreach (DataRow row in _table.Rows)
      {
        series.Points.AddXY(row[PaymentColumn], row[MonthsColumn]);
      }
      

      chart.Series.Clear();
     
      chart.Series.Add(series);

    }

    private void ChartMouseUp(object sender, MouseEventArgs e)
    {
      if (!_mouseStart.HasValue) return;
      var start = _mouseStart.Value;
      var x = chart.ChartAreas[0].Axes[0].PixelPositionToValue(e.X);
      var y = chart.ChartAreas[0].Axes[1].PixelPositionToValue(e.Y);
      var end = new Point((int) x, (int) y);

      if (end.X == start.X || end.Y == start.Y)
      {
        _mouseStart = null;
        return;
      }

      chart.ChartAreas[0].Axes[0].Minimum = Math.Min(start.X, end.X);
      chart.ChartAreas[0].Axes[0].Maximum = Math.Max(start.X, end.X);
      chart.ChartAreas[0].Axes[1].Minimum = Math.Min(start.Y, end.Y);
      chart.ChartAreas[0].Axes[1].Maximum = Math.Max(start.Y, end.Y);

      Run(Principal, Interest);
      _mouseStart = null;
    }

    private Point? _mouseStart;
    private void ChartMouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Middle)
      {
        chart.ChartAreas[0].Axes[0].Minimum = 0;
        chart.ChartAreas[0].Axes[0].Maximum = (double)Principal;
        chart.ChartAreas[0].Axes[1].Minimum = 0;
        chart.ChartAreas[0].Axes[1].Maximum = 300;

        Run(Principal, Interest);
      }
      else
      {
        var x = chart.ChartAreas[0].Axes[0].PixelPositionToValue(e.X);
        var y = chart.ChartAreas[0].Axes[1].PixelPositionToValue(e.Y);
        _mouseStart = new Point((int) x, (int) y);
      }
    }

    private void ChartMouseMove(object sender, MouseEventArgs e)
    {
      var pos = chart.HitTest(e.X, e.Y);
      if (pos.ChartElementType != ChartElementType.DataPoint) return;
      string tip = "Monthly payments of {0} pays off loan in {1} months";
      DataPoint point = chart.Series[0].Points[pos.PointIndex];
      tip = string.Format(tip, point.XValue.ToString("$###,###,##0.00"), point.YValues[0].ToString());
      toolTip.SetToolTip(chart, tip);
    }

    private void Calculate()
    {
      if (CalculateHandler != null) CalculateHandler(this, new EventArgs());
    }

    event EventHandler IAmortizationData.Calculate
    {
      add { CalculateHandler += value; }
      remove { CalculateHandler -= value; }
    }

    public decimal Principal { get; set; }

    public decimal Interest { get; set; }

    public decimal Payment { get; set; }

    int IAmortizationData.Months
    {
      get { return 0; }
      set { AddRow(Payment, value); }
    }

    private void AddRow(decimal payment, int months)
    {
      var row = _table.NewRow();
      row[PaymentColumn] = payment;
      row[MonthsColumn] = months;
      _table.Rows.Add(row);
    }

    int IAmortizationData.Years { get; set; }

    decimal IAmortizationData.ExtraInterest { get; set; }
  }

}
