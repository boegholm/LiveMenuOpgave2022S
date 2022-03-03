using System.Collections.Generic;

namespace MenuOpgave;

// abe
// ane

// hans
// sven

// abe
// abe

class CarComp : IComparer<Car>
{
    public int Compare(Car x, Car y)
    {
        int r;
        r = x.Make.CompareTo(y.Make);
        if (r != 0)
            return r;
        r = x.Model.CompareTo(y.Model);
        if (r != 0)
            return r;

        return -x.Price.CompareTo(y.Price);
    }
}
