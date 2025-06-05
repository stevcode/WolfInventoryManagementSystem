---
applyTo: '**/*'
---

# Copilot Instructions
# This file contains instructions for GitHub Copilot to follow when generating code suggestions.
# It is not intended to be executed as code.
# The instructions are written in Markdown format and should be clear and concise.

# General Guidelines
- Always provide clear and concise code suggestions.
- Use meaningful variable and function names.
- Follow best practices for code readability and maintainability.
- Ensure that the code is well-commented where necessary.
- Adhere to the coding standards of the project.
- Avoid generating code that is overly complex or difficult to understand.
- When generating code, consider the context and purpose of the code being written.
- If the code is part of a larger project, ensure that it integrates well with existing code.
- If the code is for a specific programming language, follow the conventions and idioms of that language.

## Namespaces and Imports
- Use file-scoped namespaces that match the folder structure.
- Place `using` directives at the top of the file, grouped by system, third-party, and project-specific namespaces.
- Avoid unnecessary using directives to keep the code clean.

## Immutability
- Prefer immutable types unless mutability is requested.
- Prefer records over classes for immutable types.

## File Organization
- Organize code files logically, grouping related classes and functions together.
- Use partial classes to split large classes into manageable pieces if necessary.
- Keep files focused on a single responsibility or related functionality.
- Define one type per file, unless they are closely related and small enough to be grouped together.

## Record Design
- Use records for data transfer objects (DTOs) and simple data structures.
- Define record's properties on the same line with record declaration when possible.
- Use immutable collections in records unless requested otherwise.
- Use `ImmutableList<T>` in records whenever possible.