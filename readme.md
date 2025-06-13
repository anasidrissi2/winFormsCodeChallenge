# WinForms Code Challenge

## Getting Started

### Cloning the Repository

First, clone the repository to your local machine:

```bash
git clone https://github.com/anasidrissi2/winFormsCodeChallenge.git
```

### Opening the Solution

1. Open **Visual Studio** (2019 or later recommended).
2. Go to `File` > `Open` > `Project/Solution...`.
3. Navigate to the root of this repository and select the `.sln` file (e.g., `ForterroAnasIdrissiCodeChallenge.sln`).
4. Click `Open`.
5. Build and run the solution using Visual Studio's built-in tools.

## Project Architecture Overview

This solution is structured as a classic Windows Forms (WinForms) application (.Net Framwork). The main components are:

- **UI Layer**: Contains WinForms forms and controls for user interaction.
- **Business Logic Layer**: Handles core application logic, validation, and processing.
- **Data Access Layer**: Manages data storage, retrieval, and persistence (if applicable).
- **Models**: Defines data structure for the main enitity used in this project `Product`

Each layer is organized into separate folders or projects within the solution, promoting separation of concerns and maintainability.

## Functional Notes

- **Only the "Add Product" feature is currently functional.**
- Update and delete features are not included, as they were not part of the original requirements. Some initial code for these features exists, so they could be added later without breaking existing code.

## Notes and Future Improvements

- The current structure is simple and could be further cleaned up or modularized as the project grows.
- No asynchronous programming is used, as the current use case is straightforward and does not require it.
- Possible extensions include:
  - Adding more advanced data persistence ( database integration).
  - Implementing asynchronous operations if the application grows in complexity.
  - Improving testability and maintainability by refactoring to use interfaces and dependency injection frameworks.

---
