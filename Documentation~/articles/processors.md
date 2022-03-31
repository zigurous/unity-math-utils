---
slug: "/manual/processors"
---

# Input Processors

The **Math Utils** package contains various functions for processing input values. An input processor takes a value and returns a processed result for it of the same type. See the [Processors](/api/Zigurous.Math/Processors) class for all available functions, or the reference below:

<hr/>

### [Abs](/api/Zigurous.Math/Processors/Abs)

Returns the absolute value of the input.

<hr/>

### [Axis Deadzone](/api/Zigurous.Math/Processors/AxisDeadzone)

An axis deadzone scales the input such that any value with an absolute value smaller than `min` is 0, and any value with an absolute value larger than `max` is 1 or -1.

<hr/>

### [Ceil](/api/Zigurous.Math/Processors/Ceil)

Rounds the input up to the nearest whole number.

<hr/>

### [Clamp](/api/Zigurous.Math/Processors/Clamp)

Clamps the input to the range [`min`..`max`].

<hr/>

### [Clamp01](/api/Zigurous.Math/Processors/Clamp01)

Clamps the input to the range [0..1].

<hr/>

### [Decay](/api/Zigurous.Math/Processors/Decay)

Decays the input back to zero over time at a given `rate`.<br/>The `rate` is multiplied by `Time.deltaTime`.

<hr/>

### [Floor](/api/Zigurous.Math/Processors/Floor)

Rounds the input down to the nearest whole number.

<hr/>

### [Invert](/api/Zigurous.Math/Processors/Invert)

Inverts the input by multiplying by -1.

**Note**: Vectors can be inverted on a per-component basis.

<hr/>

### [Normalize](/api/Zigurous.Math/Processors/Normalize)

Normalizes the input in the range [`min`..`max`] to unsigned normalized form [0..1] if `min` is >= `zero`, and to signed normalized form [-1..1] if `min` < `zero`.

**Note**: Vectors are normalized by setting the unit length to 1 (the same as `vector.normalized`).

<hr/>

### [Round](/api/Zigurous.Math/Processors/Round)

Rounds the input to the nearest whole number.

<hr/>

### [Scale](/api/Zigurous.Math/Processors/Scale)

Multiplies the input by `factor`.

**Note**: Vectors can be scaled on a per-component basis.

<hr/>

### [Stick Deadzone](/api/Zigurous.Math/Processors/StickDeadzone)

A stick deadzone scales the input such that any value with a magnitude smaller than `min` results in (0,0), and any value with a magnitude greater than `max` is normalized to unit length (1).

<hr/>

### [Wrap](/api/Zigurous.Math/Processors/Wrap)

Wraps the input to the range [`min`..`max`]. If the value exceeds `max` it wraps around to `min`, and if the value is less than `min` is wraps back to `max`.

**Note**: Integers are wrapped [inclusive..exclusive) to make it easier for arrays.

<hr/>

### [Wrap01](/api/Zigurous.Math/Processors/Wrap01)

Wraps the input to the range [0..1]. If the value exceeds 1 it wraps around to 0, and if the value is less than 0 it wraps back to 1.
