# SecureNumber

Protects your important numbers from memory tampering using Cheats engine, etc.

# nuget

https://www.nuget.org/packages/SecureNumber/1.0.0

# Usage

The usage is almost the same as the primitive type.
However, it is recommended that you do not use it for numbers that change at high speed.

## SecureNumber Types

- Int16_s
- Int32_s
- Int64_s
- Single
- Double
- UInt16
- UInt32
- UInt64

## Initialization

It can be initialized by assigning a base primitive type.

```csharp
Int32_s money1 = 3000;
Int64_s money2 = 3000l;
```

## Operator

Same operator support as primitive types

```csharp

// Int32_s + Int32(int)
Int32_s money = 3000;
money += 5000;
money = money + 5000;

// Int32_s + Int32_s
Int32_s money = 3000;
Int32_s bonus = 5000;
money += bonus;
money = money + bonus;
```

## Conversion to primitive types

```csharp
Int32_s money = 3000;
int32 originMoney = money.GetPrimitive();
```

