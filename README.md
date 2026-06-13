# Grayscale Image Filter

[![.NET](https://img.shields.io/badge/.NET-7.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-512BD4?logo=dotnet)](https://dotnet.microsoft.com/download/dotnet-framework)
[![Platform](https://img.shields.io/badge/Platform-Windows_x64-0078D6?logo=windows)](https://www.microsoft.com/windows)
[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Language](https://img.shields.io/badge/Language-x64_Assembly-6E4C13)](https://docs.microsoft.com/en-us/cpp/assembler/masm/)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A multithreaded grayscale image filter with dual implementation - x64 Assembly (SIMD) and C# - for performance comparison. Built as a university project at Silesian University of Technology.

## Features

- **Dual implementation** - compare native x64 ASM (SSE vectorized) vs managed C#
- **Multithreaded processing** - configurable thread count (1 to N cores)
- **Performance benchmarking** - execution time tracking in ticks, batch mode (10× runs), average calculation
- **Histogram visualization** - RGB channel distribution comparison (original vs filtered) via OxyPlot
- **Format support** - JPG and BMP

## Architecture

```
┌─────────────────────────────────────────────┐
│           Filter.GUI (.NET 7 WinForms)      │
│  ┌────────────┐  ┌────────────────────────┐ │
│  │ UI / Forms │  │ Services (ImageConvert) │ │
│  └─────┬──────┘  └───────────┬────────────┘ │
│        │                     │              │
│  ┌─────▼─────────────────────▼────────┐     │
│  │     MainMechanizm (Thread Mgmt)    │     │
│  └─────┬──────────────────────┬───────┘     │
└────────┼──────────────────────┼─────────────┘
         │                      │
   ┌─────▼──────┐       ┌──────▼──────┐
   │ Assembly   │       │   CSharp    │
   │ (x64 DLL) │       │ (.NET 4.8)  │
   └────────────┘       └─────────────┘
```

## Algorithm

```
Grayscale = 0.33×R + 0.33×G + 0.33×B
```

The ASM version uses SSE instructions (`mulps`, `haddps`) to process pixels in parallel via 128-bit XMM registers.

## Prerequisites

- Visual Studio 2022+ with:
  - .NET desktop development workload
  - C++ desktop development workload (for MASM)
- Windows x64

## Build

1. Open `Filter.sln` in Visual Studio
2. Set platform to **x64**
3. Build solution (Ctrl+Shift+B)

## Usage

1. Run the GUI application
2. Select an image (JPG/BMP)
3. Choose implementation: **ASM** or **C#**
4. Adjust thread count
5. Click apply - view result and execution time
6. Use histogram button to compare color distributions

## Author

Nikodem Wspaniały - Politechnika Śląska, Gliwice (2024)
