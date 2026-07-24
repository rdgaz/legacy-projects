# 🏛️ Legacy Projects

A curated collection of projects developed between **2006-2016** — significant milestones in my journey as a developer, long before the era of generative AI.

> **"These projects were built with creativity, dedication, and manual research. There was no Stack Overflow, no GitHub Copilot, no ChatGPT. Only documentation, forums, and lots of debugging."**

---

## 📚 About This Repository

This repository preserves old projects that I'm proud to have developed when:
- 🔍 Documentation was limited and fragmented
- 📖 Research meant reading entire tutorials or academic papers
- 💻 Stack Overflow had far fewer answers
- 🤖 Generative AI didn't exist
- 🧠 Everything was solved with creativity, debugging, and persistence

Each project includes:
- Historical context
- Technologies used
- Technical challenges faced
- Lessons learned

---

## 📂 Projects

### 🎮 Tic-Tac-Toe / Jogo da Velha (Early 2010s)

**Period:** Early development era
**Tech Stack:** C# • .NET Framework • Windows Forms (WinForms)
**Status:** Complete & Preserved
**Location:** `/JogoDaVelha/`

#### Description
A fully functional Tic-Tac-Toe game built in C# using Windows Forms. This project was developed 100% from scratch with zero documentation lookups, no AI assistance, and no external code references—only manual problem-solving and debugging. The game features a complete 3×3 button grid UI, turn-based X/O gameplay, and hand-coded win-condition detection for all 8 possible winning lines.

#### Technical Challenges
- **Win-condition algorithm:** Manually coded all 8 line checks (3 horizontal, 3 vertical, 2 diagonal) without loops or board abstractions
- **UI/Logic coupling:** Learned early-stage WinForms patterns with tightly coupled game state and button controls
- **Event handling:** Hours of hands-on debugging to get button click events, state switching, and UI updates working correctly
- **Application lifecycle:** Implemented game reset via `Application.Restart()` for new games and draw detection

#### Key Learnings
- **Problem-solving from first principles:** Built game logic without referencing existing implementations
- **Trial-by-fire debugging:** Raw hands-on experience with .NET event model and UI responsiveness
- **Design simplicity vs. maintainability:** Direct button control approach works but showed early lessons in separation of concerns
- **Pure logic under pressure:** Win-detection logic solved 100% independently, demonstrating grit and persistence

#### Files
- `JogoDaVelha/JogoDaVelha/Program.cs` — Application entry point
- `JogoDaVelha/JogoDaVelha/FrmInicial.cs` — Game logic & win-condition detection
- `JogoDaVelha/JogoDaVelha/FrmInicial.Designer.cs` — UI control definitions
- `JogoDaVelha/JogoDaVelha/JogoDaVelha.csproj` — .NET 4.8 project configuration

#### How to Run
```bash
# Prerequisites: Visual Studio 2013+ or msbuild; .NET 4.8 runtime

# From command line:
cd JogoDaVelha
msbuild JogoDaVelha.csproj /p:Configuration=Release
JogoDaVelha\bin\Release\JogoDaVelha.exe

# Or open in Visual Studio:
# 1. Open JogoDaVelha/JogoDaVelha.sln
# 2. Build → Build Solution (Ctrl+Shift+B)
# 3. Debug → Start (F5)
```

---

## 🎓 Why Preserve Legacy Projects?

1. **Technical History** - Shows evolution and learning journey
2. **Unique Perspective** - Built without AI assistance
3. **Raw Creativity** - Creative solutions developed without modern tools
4. **Era Documentation** - Captures development techniques and practices from the 2000s-2010s

---

## 💡 Contributing (Memories)

If you remember:
- Additional context about these projects
- Challenges I didn't mention
- Impact these projects had

Open an **Issue** or **Discussion** to share your thoughts!

---

## 📅 Timeline

```
2006-2008: [Early Projects]
2008-2010: [Consolidation Era]
2010-2012: [More Complex Projects]
2012-2016: [Final Projects of This Era]
```

---

## ⚠️ Important Note

These projects:
- ✅ Represent an important moment in technology history
- ✅ Demonstrate creativity and problem-solving
- ❌ Don't necessarily follow modern best practices
- ❌ May contain "legacy code" (as expected)
- ❌ Are not examples to be copied in production today

---

**Last Updated:** 2026
**Developer:** [@rdgaz](https://github.com/rdgaz)

---

*"Old code isn't bad. It's a bridge between ignorance and wisdom."* 🌉
