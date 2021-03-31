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
