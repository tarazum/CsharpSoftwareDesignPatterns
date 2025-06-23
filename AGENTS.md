# AGENTS.md

This file defines the autonomous agents responsible for analyzing, extending, and maintaining the `CsharpSoftwareDesignPatterns` repository.

## 🎨 PatternRecognitionAgent

- **Purpose**: Identify and classify the design pattern implemented in each folder or file.
- **Capabilities**:
  - Detects which design pattern is used (e.g., Singleton, Factory, Observer).
  - Provides a brief explanation of the pattern.
  - Can suggest potential improvements or variations of the pattern.

## 🧪 MsTestAgent

- **Purpose**: Create, execute, and maintain unit tests for design pattern implementations.
- **Capabilities**:
  - Generates MSTest unit tests for given C# classes.
  - Validates pattern behavior with assertions.
  - Refactors or extends existing tests as implementation evolves.

## 📚 DocumentationAgent

- **Purpose**: Generate and maintain documentation for each pattern.
- **Capabilities**:
  - Creates Markdown documentation files (`README.md`) in each pattern folder.
  - Adds XML doc comments to classes and methods.
  - Generates a summary table of all patterns.

## 🛠️ RefactorAgent

- **Purpose**: Improve code structure without changing behavior.
- **Capabilities**:
  - Applies C# best practices (naming, separation of concerns, SOLID).
  - Detects code duplication across pattern implementations.
  - Suggests improvements like DI integration or interface extraction.

## 🌐 IntegrationAgent *(future work)*

- **Purpose**: Demonstrate real-world integration scenarios for each pattern.
- **Capabilities**:
  - Shows how multiple patterns can be combined in a sample application.
  - Provides optional web-based examples using ASP.NET Core or Blazor.
