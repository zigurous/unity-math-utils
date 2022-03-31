---
slug: "/manual/chance"
---

# Random Chance

The **Math Utils** package contains several functions for generating random chance values, including rolling dice, picking random playing cards, and other utility functions.

<hr/>

## 🃏 Chance

The [Chance](/api/Zigurous.Math/Chance) class comes with several predefined static functions for generating random chance values relating to playing cards, coins, and generic types:

```csharp
Coin face = Chance.CoinFlip(); // heads, tails
Suit suit = Chance.RandomSuit(); // hearts, diamonds, clubs, spades
Card card = Chance.RandomCard(); // standard 52-card deck
```

```csharp
bool value = Chance.RandomBool(); // true, false
float value = Chance.PositiveOrNegative(); // +1f, -1f
float value = Chance.PositiveOrNegative(value); // +value, -value
```

<hr/>

## 🎲 Dice Rolls

The [Dice](/api/Zigurous.Math/Dice) class comes with several predefined static functions for common dice rolls, such as:

```csharp
int d4 = Dice.D4();
int d6 = Dice.D6();
int d8 = Dice.D8();
int d10 = Dice.D10();
int d12 = Dice.D12();
int d20 = Dice.D20();
```

For any of these functions you can also pass in a value for parameter `n` to indicate how many times you want to roll that dice. The function will return the sum of all rolls. For example, this would roll a 6-sided dice 3 times.

```csharp
int sum = Dice.D6(3);
```

The class also has functions for rolling custom dice, either n-sided dice or custom dice.

```csharp
int d7 = Dice.NSided(7); // 7-sided dice
int d7x3 = Dice.NSided(7, 3); // 7-sided dice 3 times
```

```csharp
int[] customValues = new int[] { 1, 3, 5, 7, 9 };
int[] probabilities = new int[] { 30, 25, 20, 15, 10 };

int roll = Dice.Roll(customValues); // equal probability
int roll = Dice.Roll(customValues, probabilities);
```
