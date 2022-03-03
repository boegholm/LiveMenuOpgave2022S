using System;
using System.Collections.Generic;

namespace MenuOpgave;

class SortOpgave : IMenuItem
{
    public string Title { get; } = "Sortopgave";

    public void Select()
    {
        Console.Clear();

        List<Car> cars = new List<Car>
        {
            new Car{Model="Octavia", Make="Skoda", Price = 100000},
            new Car{Model="Fabia", Make="Skoda", Price = 10000},
            new Car{Model="Felicia", Make="Skoda", Price = 40000},
            new Car{Model="Citigo", Make="Skoda", Price = 1000},
            new Car{Model="Citigo", Make="Skoda", Price = 10002},
            new Car{Model="Citigo", Make="Skoda", Price = 100055},
            new Car{Model="Citigo", Make="Skoda", Price = 10001},
            new Car{Model="M1", Make="BMW", Price = 1000000},
            new Car{Model="M2", Make="BMW", Price = 2000000}
        };
        Console.WriteLine("her er de usorteret:");
        foreach (var item in cars)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Her er de sorteret:");
        cars.Sort(new CarComp());
        foreach (var item in cars)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

        
    }
}
