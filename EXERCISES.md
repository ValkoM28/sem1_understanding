# Exercises: Understanding Code with AI

Use these after you have read the guide. Each exercise gives you a small piece of real C# code written by first-semester students. Your job is **not** to make the code better. Your job is to work out what it really does, using AI as a guide, and to check what the AI tells you against the code itself.

## The routine (same for every exercise)

1. **Step 0, no AI.** Look at the files. Which file is the starting point? What does each file seem to be for? Write down your first guess.
2. **Predict.** Before you ask the AI anything, write down what you think the code does or prints.
3. **Ask, one question at a time.** Keep the AI in read-only "explain" mode. Ask it to point to the file and line range behind every claim.
4. **Verify.** Open the files and check at least **two** of the AI's claims. Where possible, also *run* the code.
5. **Record.** Fill in the notes block below for each exercise.

**If you want a starter prompt to open a session** (optional, from the guide):

> You are a senior software engineer who knows this code well. I am a first-semester student and new to it. When you answer, always show the file and line range you are basing your answer on, like `/path/to/file.cs lines 10-20`.

**Notes block (copy this for every exercise):**

```
Exercise:
My prediction (before asking):
What the AI said (1-3 key claims, with the file:line it gave):
What I checked, and what I found (file:line, held up? yes / no / partly):
One thing the AI got wrong, oversimplified, or stated too confidently:
```

## Setup

- You need the .NET SDK. Run programs with `dotnet run`.
- Treat each exercise as its **own** small console project. If you put files with several `Main` methods into one project, it will not build. Your instructor will say if an exercise needs something different.

## Reflection (answer once, after all exercises)

1. Which of the AI's claims turned out to be wrong or overconfident? What made them easy or hard to catch?
2. Which check gave you the most useful information: reading, running the code, or asking the AI a follow-up?
3. Where were you tempted to skip verifying? What would have gone wrong?
