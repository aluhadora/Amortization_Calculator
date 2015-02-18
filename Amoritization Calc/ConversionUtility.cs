using System;

namespace Amoritization_Calc
{
  public static class ConversionUtility
  {
    public static decimal ToDecimal(this string value)
    {
      decimal convertedValue;

      string formatedValue = string.Empty;

      foreach (var character in value)
      {
        if (character.IsNumericCharacter()) formatedValue += character;
      }

      if (formatedValue.Length == 0) return 0;
      if (decimal.TryParse(formatedValue, out convertedValue)) return convertedValue;
      if (formatedValue.EndsWith(".")) return formatedValue.Remove(value.Length - 1, 1).ToDecimal();
      if (formatedValue.StartsWith(".")) return formatedValue.Remove(0, 1).ToDecimal();

      return 0;
    }

    public static int ToInt(this string value)
    {
      return (int) Math.Round(value.ToDecimal());
    }

    public static bool IsNumericCharacter(this char character)
    {
      return character.IsIntegerCharacter() || character == '.';
    }

    public static bool IsIntegerCharacter(this char character)
    {
      if (character >= '1' || character <= '9') return true;
      if (character == '0') return true;
      return false;
    }

    public static string ToAmount(this decimal value)
    {
      return value.ToString("$###,###,###.00");
    }
  }
}
