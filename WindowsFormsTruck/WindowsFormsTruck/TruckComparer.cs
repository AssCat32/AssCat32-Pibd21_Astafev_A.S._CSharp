using System.Collections.Generic;

public class TruckComparer : IComparer<Vehicle>
{
    public int Compare(Vehicle x, Vehicle y)
    {
        // Реализовать метод сравнения для объектов
        return 0;
    }

    private int ComparerTruck(Truck x, Truck y)
    {
        if (x.MaxSpeed != y.MaxSpeed)
        {
            return x.MaxSpeed.CompareTo(y.MaxSpeed);
        }
        if (x.Weight != y.Weight)
        {
            return x.Weight.CompareTo(y.Weight);
        }
        if (x.MainColor != y.MainColor)
        {
            return x.MainColor.Name.CompareTo(y.MainColor.Name);
        }
        return 0;
    }

    private int ComparerDumpTruck(DumpTruck x, DumpTruck y)
    {
        var res = ComparerTruck(x, y);
        if (res != 0)
        {
            return res;
        }
        if (x.DopColor != y.DopColor)
        {
            return x.DopColor.Name.CompareTo(y.DopColor.Name);
        }
        if (x.Trailer != y.Trailer)
        {
            return x.Trailer.CompareTo(y.Trailer);
        }
        if (x.Cargo != y.Cargo)
        {
            return x.Cargo.CompareTo(y.Cargo);
        }
        return 0;
    }
}
