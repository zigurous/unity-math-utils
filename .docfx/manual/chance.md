# Random Chance

The Math Utils package contains several functions for generating random chance values, including rolling dice, picking random playing cards, and other utility functions.

### Chance

The [Chance](xref:Zigurous.Math.Chance) class comes with several predefined static functions for generating random chance numbers:

```csharp
Coin face = Chance.CoinFlip(); // heads, tails
Suit suit = Chance.RandomSuit(); // hearts, diamonds, clubs, spades
Card card = Chance.RandomCard(); // standard 52-card deck
bool value = Chance.RandomBool(); // true, false
float value = Chance.PositiveOrNegative(); // +1.0f, -1.0f
float value = Chance.PositiveOrNegative(value); // +value, -value
```

### Dice Rolls

The [Dice](xref:Zigurous.Math.Dice) class comes with several predefined static functions for common dice rolls, such as:

```csharp
int d4 = Dice.D4();
int d6 = Dice.D6();
int d8 = Dice.D8();
int d10 = Dice.D10();
int d12 = Dice.D12();
int d20 = Dice.D20();
...
```

For any of these functions you can also pass in a value for parameter `n` to indicate how many times you want to roll that dice. The function will return the sum of all rolls. For example, this would roll a 6-sided dice 3 times.

```csharp
int sum = Dice.D6(3);
```

The class also has functions for rolling custom dice, either n-sided dice or dice with specific values.

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
