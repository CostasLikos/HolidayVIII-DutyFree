using System;
using System.Linq;

public class Kata
{
    public static int DutyFree(int normPrice, int Discount, int hol) => (int)Math.Floor(hol / (normPrice * (Discount / 100.0)));

}