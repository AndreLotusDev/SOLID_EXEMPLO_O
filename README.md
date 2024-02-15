## Open/Closed Principle (O)

The Open/Closed Principle (O) is a design principle that emphasizes the idea that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. This means that you should be able to extend the behavior of a module without modifying its source code.

### Explanation:

- **Open for Extension**: The Open/Closed Principle suggests that classes or modules should allow for their behavior to be extended without requiring modifications to their source code. This is typically achieved through the use of inheritance, composition, or dependency injection.

- **Closed for Modification**: Once a class or module is implemented, it should be closed for modification. This means that changes to its existing behavior should not be necessary when new functionality is added. Instead, new functionality should be added through extension points provided by the class or module.

### Benefits:

- **Maintainability**: By adhering to the Open/Closed Principle, code becomes more maintainable because changes to existing functionality are minimized. This reduces the risk of introducing bugs and makes the codebase easier to understand and extend.

- **Reusability**: Classes or modules that follow the Open/Closed Principle are often more reusable since they can be extended without modifying their existing behavior. This promotes code reuse and leads to more modular and flexible designs.

### Example:

```csharp
// Before applying the Open/Closed Principle

public class Shape
{
    public string Type { get; set; }
    
    public double Area()
    {
        if (Type == "Circle")
        {
            // Calculate area for a circle
        }
        else if (Type == "Rectangle")
        {
            // Calculate area for a rectangle
        }
        // More shapes...
    }
}

// After applying the Open/Closed Principle

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public override double Area()
    {
        // Calculate area for a circle
    }
}

public class Rectangle : Shape
{
    public override double Area()
    {
        // Calculate area for a rectangle
    }
}
```

In the above example, the `Shape` class violates the Open/Closed Principle because it requires modification when a new shape is introduced. In contrast, the refactored version adheres to the Open/Closed Principle by allowing new shapes to be added without modifying existing code.
