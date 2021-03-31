# CSharp.11.POO

Herencia:
```csharp
public class Vehicle {}

public class Car: Vehicle {}
```

en el caso de los constructores se debe usar el keyword "base"
```csharp
public Motorcycle(int displacement, decimal maxVelocity, int wheelQuantity, string brand, string model) : base(maxVelocity, wheelQuantity, brand, model)
{
    Displacement = displacement;
}
```

usualemente se sobreescriben:
```csharp
ToString();
GetHashCode();
``` 

Operadores de comparacion: 
```csharp
<
>
!=
```

Una clase no puede ser hija de dos clases base, pero para ese caso se podria hacer esto:
```csharp
public Duck Duck { get; set; }
public Toy Toy { get; set; }

public DuckToy(Duck duck = default, Toy toy = default)
{            
    Duck = duck;
    Toy = toy;            
}

public DuckToy(string color, string race, string material, int quantityBateries)
{
    Duck = new Duck()
    {
        Color = color,
        Race = race                
    };

    Toy = new Toy()
    {
        Material = material,
        QuantityBateries = quantityBateries
    };            
}
```
