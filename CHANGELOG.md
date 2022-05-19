# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.1.1] - 2022/05/19

### Fixed

- Fixed certain edge cases where values were wrapping unintentionally even while in range

## [1.1.0] - 2021/07/12

### Added

- New `Dice` static class for rolling dice + additional dice roll functions
- New `NumberAbbreviation` data structure + extensions `ToAbbreviatedString`
- New `DoubleEqualityComparer` to compare doubles based on # of decimals
- New `Vector2Int` extensions class
- New `Vector3Int` extensions class
- New `List` extensions class
- Extension methods for shuffling arrays and lists `Shuffle()`
- Extension method `RandomPointInside` for `BoundsInt`
- Additional `IsBetween` variants for inclusive/exclusive number ranges
- Dozens of new input processors and support for more types

### Changed

- Dice roll functions moved from `Chance` class to new `Dice` class
- Overhauled documentation comments
- Updated package description and README

## [1.0.4] - 2021/06/30

### Changed

- Renamed package to Math Utils

## [1.0.3] - 2021/04/13

### Added

- Wrap01 processors

### Changed

- Decay function now does nothing if the input is zero

## [1.0.2] - 2021/03/21

### Changed

- Updated package metadata

## [1.0.1] - 2021/03/07

### Changed

- Updated package metadata

## [1.0.0] - 2021/02/27

### Added

- Processor Functions
- Chance Functions
- Float Equality Comparer
- Number Extensions
- Comparable Extensions
- Bounds/Collider Extensions
