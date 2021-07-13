# Input Processors

The Math Utils package contains various functions for processing input values. An input processor takes a value and returns a processed result for it of the same type. See the [Processors](xref:Zigurous.Math.Processors) class for all available functions, or the reference below:

#### [Abs](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Abs_System_Single_)

Returns the absolute value of the input.

#### [Axis Deadzone](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_AxisDeadzone_System_Single_System_Single_System_Single_)

An axis deadzone scales the input such that any value with an absolute value smaller than `min` is 0, and any value with an absolute value larger than `max` is 1 or -1.

#### [Ceil](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Ceil_System_Single_)

Rounds the input up to the nearest whole number.

#### [Clamp](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Clamp_System_Single_System_Single_System_Single_)

Clamps the input to the range [`min`..`max`].

#### [Clamp01](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Clamp01_System_Single_)

Clamps the input to the range [0..1].

#### [Decay](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Decay_System_Single_System_Single_System_Single_)

Decays the input back to zero over time at a given `rate`.<br/>The `rate` is multiplied by `Time.deltaTime`.

#### [Floor](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Floor_System_Single_)

Rounds the input down to the nearest whole number.

#### [Invert](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Invert_System_Single_)

Inverts the input by multiplying by -1.

**Note**: Vectors can be inverted on a per-component basis.

#### [Normalize](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Normalize_System_Single_System_Single_System_Single_System_Single_)

Normalizes the input in the range [`min`..`max`] to unsigned normalized form [0..1] if `min` is >= `zero`, and to signed normalized form [-1..1] if `min` < `zero`.

**Note**: Vectors are normalized by setting the unit length to 1 (the same as `vector.normalized`).

#### [Round](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Round_System_Single_)

Rounds the input to the nearest whole number.

#### [Scale](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Scale_System_Single_System_Single_)

Multiplies the input by `factor`.

**Note**: Vectors can be scaled on a per-component basis.

#### [Stick Deadzone](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_StickDeadzone_Vector2_System_Single_System_Single_)

A stick deadzone scales the input such that any value with a magnitude smaller than `min` results in (0,0), and any value with a magnitude greater than `max` is normalized to unit length (1).

#### [Wrap](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Wrap_System_Single_System_Single_System_Single_)

Wraps the input to the range [`min`..`max`]. If the value exceeds `max` it wraps around to `min`, and if the value is less than `min` is wraps back to `max`.

**Note**: Integers are wrapped [inclusive..exclusive) to make it easier for arrays.

#### [Wrap01](xref:Zigurous.Math.Processors#Zigurous_Math_Processors_Wrap01_System_Single_)

Wraps the input to the range [0..1]. If the value exceeds 1 it wraps around to 0, and if the value is less than 0 it wraps back to 1.
