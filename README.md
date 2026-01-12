## 1st Project
## 🔐 Password Strength Analyzer (Blazor)

A Blazor WebAssembly project for checking password strength and generating secure passwords.

### Features
- Password strength validation (length, upper/lower case, digits, symbols)
- Secure password generator (14–20 characters)
- Cryptographically secure randomness
- Fisher–Yates shuffle (no LINQ)
- Sensitive `char[]` buffer cleared from memory after use

### Tech Stack
- C#, .NET, Blazor WebAssembly
- ASP.NET Core
- System.Security.Cryptography

### Pages
- Home
- Registration (password validation & generation)

### Purpose
Portfolio project focused on application logic, security

## 2nd Project
## 🔐 Caesar Cipher Web App (Blazor)

A modern Blazor WebAssembly for encrypting messages using the classic Caesar Cipher algorithm, featuring a custom dark-mode UI.

### Features
- Encryption Logic: Custom implementation of the Caesar shift algorithm using character arrays.
- Custom Alphabet: Supports lowercase letters (a-z), spaces, dots, and commas.
- Interactive UI: Dark mode design with neon gradients and glassmorphism effects.
- State Management: Real-time text processing and result rendering.
- CSS Animations: Smooth fade-ins and floating icon effects.

### Tech Stack
- C#, .NET 8
- Blazor WebAssembly
- HTML5 & CSS3 (Scoped Styles)

### Pages
- Home: Main interface for entering text, executing encryption, and viewing results.

### Purpose
Educational project focused on string manipulation algorithms, C# logic implementation, and creating responsive UI with Blazor components.

## 3rd Project
## 📝 Secure Notes Manager (Blazor)

A Blazor Web App project for encrypting simple text notes.

### Features
- Custom text encryption logic (letters and digits shifted, other symbols replaced with *)
- Supports upper-case, lower-case letters, and digits
- Non-reversible encryption by design
- Manual memory cleanup for sensitive char[] data
- Clear separation of UI and application logic

### Tech Stack
- C#, .NET, Blazor Web App
- ASP.NET Core
- System.Security.Cryptography

### Pages
- Home (note input & encryption)

### Purpose

Portfolio project focused on encryption logic, memory safety, and Blazor fundamentals.
