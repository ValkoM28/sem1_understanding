
## Exercise 4: A guided tour of a small project

**Files:** the whole `MyApp` folder (5 files)

**a) Step 0, no AI (about 5 minutes).** List the files. Guess what each is for from its name. Find the entry point. Read the comment at the top of the file that has `Main`.

**b) Ask the AI, one at a time:**

- "What does this project do? Give me a high-level summary."
- "What is each file responsible for?"
- "What is the entry point?"
- "Explain what happens, step by step, from the moment `ExecuteAttack()` is called to the line printed on the console."

**c) Mental model.** *Before* you look at the AI's summary, write your own summary of the project in 3 to 5 sentences. Then ask the AI: "Give me a summary of this codebase as if you were onboarding a new developer. What are the most important things to know?" Compare the two. What did it include that you missed?

**d) Verify at least three claims** with a file and line. Include at least one claim about how damage is calculated and one about health.

**e) Answer these from the code**, and note whether the AI's answer agreed:

- Which class decides how much damage an attack does?
- What stops a character's health from going below zero?
- If you ran the fight twice, would it always end the same way? Can you tell who wins by reading the code alone? What did the AI say, and how sure did it sound?
- If you wanted to add a third character type, which files would you need to touch?

**Turn in:** notes block, your own summary from (c), and your answers to (e).
