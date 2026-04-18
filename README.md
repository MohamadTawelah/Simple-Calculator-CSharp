# 🧮 Simple Calculator — Windows Forms (C#)

## 📸 Preview

### 🖥️ Calculator UI
![Calculator UI](assets/calculator.png)

---

## 📖 Overview

This project — **Simple Calculator** — is a **desktop application** built using **C# and Windows Forms**.

It simulates a real calculator that supports:

- Basic arithmetic operations  
- Decimal numbers  
- Parentheses  
- Expression evaluation  

Unlike traditional step-by-step calculators, this version evaluates the **entire mathematical expression at once**, similar to modern calculators.

---

## 🎯 Learning Purpose

This project is part of my journey in learning **C# and .NET development**.

Through building this calculator, I practiced:

- Event-driven programming (WinForms)  
- Handling user input dynamically  
- Building and evaluating expressions  
- Writing clean and reusable helper methods  

It also helped me understand how real applications handle **user interaction + logic together**.

---

## ⚙️ Features

### 🔢 Smart Input
- Prevents invalid inputs (like ++ or ..)  
- Avoids multiple leading zeros  

---

### ➕ Full Expression Support

Supports:
- + Addition  
- - Subtraction  
- * Multiplication  
- / Division

  
Example:
(5 + 3) * 2 = 16

---

### 🔘 Parentheses Support
- Supports ( and )  
- Prevents unbalanced parentheses  

---

### 🔢 Decimal Numbers
- Prevents adding . more than once per number  

---

### ⌫ Backspace & Clear
- Remove last character  
- Reset calculator  

---

## 🧪 Edge Cases Handled

- Division by zero → handled safely  
- Empty input evaluation → prevented  
- Invalid expressions → avoided before evaluation  

---

## ⭐ Repository Goals
This project demonstrates:
- Clean WinForms UI design
- Real-time expression evaluation
- Beginner-to-intermediate C# skills

--- 

## 🔧 Technologies

- 💻 C# (.NET Framework)  
- 🪟 Windows Forms (WinForms)  
- 🧮 DataTable().Compute() for expression evaluation  

---

⚠️ Note: DataTable.Compute is convenient but not intended for complex production-grade calculators.

---
## ⚡ Fast Evaluation

Uses built-in .NET feature:

```csharp
var result = new DataTable().Compute(expression, null);
```
This allows solving full expressions instantly without writing complex math logic.

## 🧩 Project Structure

```
📂 SimpleCalculator
┣ 📁 assets
┃ ┣ calculator.png
┃ ┗ demo.gif
┣ 📄 Form1.cs
┣ 📄 Form1.Designer.cs
┣ 📄 Program.cs
┗ 📄 App.config
```
## 🚀 How to Run

1. Open the project in Visual Studio  
2. Press **F5**  
3. Start calculating 🎉
---

📌 Future Improvements
* Add calculation history
* Dark mode
* Keyboard input support
* Scientific functions

---

💬 Final Thought

This project may look simple, but it represents a big step:

From just writing code ➜ to building a real interactive application 💪

“Good software isn’t about complexity — it’s about clarity and control.”
  
---

git clone https://github.com/MohamadTawelah/Simple-Calculator-CSharp


