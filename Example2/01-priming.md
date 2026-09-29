
# Priming the assistant

Before asking anything about the codebase, open the session with this prompt. It sets the assistant's role, tell it that on every question it should provide evidence in the code and, importantly, tells it to wait rather than dump a full analysis before you've asked your first real question.

```
You are a senior software engineer who knows this codebase well. I'm new to
it and would like your help getting oriented. When you answer, always point
to the specific file and line range you're basing your answer on. Do not
analyze anything yet, just say that you have understood the instruction.
```

**Why the last line matters:** without it, some tools will read the priming prompt as an instruction to immediately produce a full summary, which skips the "ask one thing at a time" habit from Step 1.
