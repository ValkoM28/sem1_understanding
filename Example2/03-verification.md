
# Checking the AI's answers

Six questions were asked about Ecotropolis, in one session, after priming (see `01-priming.md`). Each question's answer is in its own file (listed below). For every question, some claims are checked together and the rest is for you.

Repository: https://github.com/ValkoM28/Ecotropolis

| Question     | Topic                                | Raw answer                                          |
| ------------ | ------------------------------------ | --------------------------------------------------- |
| **Q1** | What does this project do?           | Your answers (example in`02-prompt-responses.md`) |
| **Q2** | Directory structure                  | ...                                                 |
| **Q3** | Business problem                     | ...                                                 |
| **Q4** | Game flow                            | ...                                                 |
| **Q5** | Data structures                      | ...                                                 |
| **Q6** | The area you will work in (PawnShop) | ...                                                 |

## Q1. What does this project do?

**Prompt:** `What does this project do? Give me a high-level summary.`

### Checked together

**Q1.1** *"Game.cs:33-37: the constructor creates a Player, loads every JSON file in jsons/ via LocationLoader, then calls GamePlay()"*
**Check:** open `Game.cs`, lines 33-37.
**Result:** exactly those three statements, in that order. Confirmed.

**Q1.2** *"Location.cs:17-36 (Name, WelcomeMessage, UrbanChallenges, RewardItems)"*
**Check:** open `Location.cs`, lines 17-36.
**Result:** the class starts on line 17 and the four properties end on line 36. Confirmed.

### Your turn

Pick at least two more and check them.

- **Q1.a** The gameplay loop is said to be `Game.cs:54-100`. Does the loop start and end on those lines?
- **Q1.b** "Prints a welcome message (`Game.cs:55`, text in `Messager.cs:56`)". Open both places.
- **Q1.c** "A numbered travel menu (`Game.cs:106-113`), plus a Help option". Find the Help option.
- **Q1.d** `GameEnd()` "prints the final sustainability score with tiered feedback" (`Game.cs:120-143`). What are the tiers?
- **Q1.e** The cities are Amsterdam, Barcelona, Los Angeles, Manila, São Paulo and Tokyo, and live in `jsons/`. Do the files match?
- **Q1.f** `jsons/LosAngeles.json:1-59` "defines" the challenge structure. What is on those lines?
- **Q1.g** A comment at `Program.cs:8` describes the game as "a text-based adventure game...". Does it?

---

## Q2. Directory structure

**Prompt:** `Walk me through the directory structure and what each folder is responsible for.`

### Checked together

**Q2.1 A claim that something doesn't exist.** *"No `src/`, no test project currently exists at the root."*
**Check:** you can't prove absence by opening one file. List the folder, then search:

```
ls
find . -iname "*test*" -not -path "./bin/*" -not -path "./obj/*" -not -path "./.git/*"
grep -i "xunit\|nunit\|mstest" WorldOfZuul.csproj
```

**Result:** no `src` folder, and both searches print nothing. Confirmed, for what was searched (file names and the project file).

### Your turn

Pick at least three more and check them.

- **Q2.a** The other class lines and doc-comment ranges, for example `Location.cs:17` with comment `9-13`, `Player.cs:14` with comment `7`, `PawnShop.cs:13` with comment `5-7`. Do the ranges match the comments?
- **Q2.b** "Has an inner `Inventory` class (`Player.cs:90`)". Find the class.
- **Q2.c** `WorldOfZuul.csproj` is a ".NET 8 project file" that "still carries its original template name". Where do you see each?
- **Q2.d** `jsons/` has six files of "~110-133 lines", each with "challenges, choice options with score impacts, and reward items".
- **Q2.e** "`.idea/` is JetBrains Rider project metadata". What is inside? Is that evidence or an assumption? Are `bin/` and `obj/` in the repository?
- **Q2.f** The closing line, "Program → Game → Location/... → Player → Messager → PawnShop". What would the arrows mean, and is that true? (Search for where `Messager` is used.)
- **Q2.g** Compare the table's file list with `ls` in your clone. Is anything different?

---

## Q3. Business problem

**Prompt:** `What business problem is this project aiming to solve?`

### Checked together

**Q3.1** *"Each challenge's options carry a `scoreImpact` (e.g. `jsons/LosAngeles.json:29-37`)"*
**Check:** read lines 29-37.
**Result:** each option has a `description` and a `scoreImpact` (line 30 is `"scoreImpact": 3`). Confirmed.

**Q3.2** *"`README.md:1` contains only the title... there's no written project brief in the repo"*
**Check:** `cat README.md` and `wc -l README.md`.
**Result:** one line, `# Ecotropolis`. Confirmed.

### Your turn

Pick at least two more and check them.

- **Q3.a** The other four Los Angeles lines: `44`, `62`, `80`, `98`. Does each match the topic listed?
- **Q3.b** The four Barcelona lines: `27`, `41`, `59`, `77`. Do they match the topics listed, and in the order listed?
- **Q3.c** "Per `Program.cs:6-9`... 'a text-based adventure game that aims to raise awareness...'". Open those lines.
- **Q3.d** The answer says the other four cities "presumably" have similar themes. Read one of them. Does it?
- **Q3.e** "There's no company, users, or revenue model." How would you search the project for evidence either way?
- **Q3.f** Scores are "computed and reported in `Game.cs:120-143`". Is that what those lines do?

---

## Q4. Game flow

**Prompt:** `Explain the game flow end-to-end.`

### Checked together

**Q4.1** *"`player.IncreaseScore(...)` (`UrbanChallenge.cs:63`)... bumps both the global score and the location tracker (`Player.cs:43-46`)"*
**Check:** follow the call. Open `UrbanChallenge.cs:63`, then `Player.cs:43-46`.
**Result:** line 63 is `player.IncreaseScore(Options[choice].ScoreImpact);`. The method adds `amount` to both `SustainabilityScore` and `LocationScoreTracker`. Confirmed.

**Q4.2** *"`0` → exits immediately (`Game.cs:74-76`)"*
**Check:** read the switch in `GamePlay()`, and find where the input is turned into a number.
**Result:** `case -1:` is the exit branch (lines 74-76). The input is reduced by one (`int.Parse(input) - 1`), so typing `0` gives `-1`. Confirmed.

### Your turn

Pick at least three more and check them.

- **Q4.a** `LocationLoader.cs:16-45`: "skipping/logging any that fail (29-35)". What happens to a file that can't be read?
- **Q4.b** In the Pawn Shop, choices `"1"`, `"2"` and `"0"` (`PawnShop.cs:53-82`). Read the code, or run the game. How many prompts are there between pressing `1` and buying something?
- **Q4.c** `Game.cs:124-135`: "`>=85` high, `>=50` moderate, else low". Are those the thresholds?
- **Q4.d** `Player.cs:75-86`: "walks the player's full inventory and prints each item's name, value, description, and feedback". Does it?
- **Q4.e** "A challenge can't be skipped or answered invalidly" (`UrbanChallenge.cs:56-77`). Try to break it: run the game and give bad input.
- **Q4.f** "There is no save/load and no branching between cities." How would you search for evidence?

---

## Q5. Data structures

**Prompt:** `What are the main data structures and how do they relate to each other?`

### Checked together

**Q5.1** *"`Item` has two constructors (`Item.cs:26-31` and `Item.cs:33-39`)"*
**Check:** open `Item.cs`.
**Result:** a three-parameter constructor on lines 26-31, and a `[JsonConstructor]` one with four parameters on lines 33-39. Confirmed that both exist. (The claim also says *where each one is used*; that part is left for you.)Your turn

Pick at least three more and check them.

- **Q5.a** "`LocationLoader` is the only place JSON becomes objects... Nothing else in the codebase touches `System.Text.Json` directly." How do you check a claim that *nothing else* does something?
- **Q5.b** The three-parameter `Item` constructor is "used for the hardcoded pawn-shop items (`PawnShop.cs:23-25`)". Look at those three calls. How many arguments does each pass?
- **Q5.c** `Player`'s `Inventory` (`Player.cs:98-120`) is "encapsulated so nothing outside `Player` touches the list directly". Can another class reach the list?
- **Q5.d** "`Player` is a passive data/state holder, not an active participant." Which classes call `Player`'s methods, and does `Player` call any of theirs?
- **Q5.e** `UrbanChallenge.cs:32-37` is a `[JsonConstructor]`. Is it?
- **Q5.f** The composition diagram: pick two arrows and find the code that creates them.

---

## Q6. The area you will work in (PawnShop)

**Prompt:** `Explain the PawnShop, as that is the thing I will be working on. Point out its function, the design choices, documented compromises and everything else that might be important.`

### Checked together

**Q6.1 Read the lines.** *"`Dictionary<int, Item>` keyed by cost (`PawnShop.cs:22-26`)... `_uniqueItems.Remove(costs)` (`PawnShop.cs:98`)"*
**Check:** open `PawnShop.cs` at both places.
**Result:** the dictionary has keys 2, 3, 4 (lines 22-26), and line 98 is `_uniqueItems.Remove(costs);`. Confirmed.
**

#### Down below you can see more interesting claims, that will be more difficult to verify just by look.

**Q6.2 A claim about "only".** *"It's instantiated and run from exactly one call site: `Game.cs:97-98`... Nothing else in the codebase touches it."*
**Check:** you can't prove "only" by opening one file. Search the whole project:

```
grep -n "PawnShop" *.cs
```

**Result:** apart from `PawnShop.cs` itself, the only hit is `Game.cs:97`. Confirmed.

**Q6.3 A claim about history.** *"Originally... `Item.Value` was overloaded to mean 'token cost' — `BuyItem` checked `player.Tokens >= item.Value`."*
**Check:** the current file can't tell you. Look at an old version:

```
git log --oneline -- PawnShop.cs
git show eae2d85:PawnShop.cs | grep -n "Tokens"
```

**Result:** the log lists `eae2d85` among the oldest commits, and the old file has `if (player.Tokens >= item.Value) {` followed by `player.Tokens -= item.Value;`. Confirmed.

### Your turn

Pick at least three more and check them.

- **Q6.a** "Tokens are earned only from top-tier city rewards (`Location.cs:84-87`)." Search the project for everything that changes `Tokens`.
- **Q6.b** "`b5aa300` refactored to `Dictionary<int,Item>`... cost became the key, and `Value` became score." Run `git show b5aa300 -- PawnShop.cs`. What are the item values before and after?
- **Q6.c** "On purchase it calls `player.IncreaseScore(item.Value)` (`PawnShop.cs:96-97`)... with the comment `// Add to the sustainability score`." Find it.
- **Q6.d** "There are only two ways `SustainabilityScore` increases in the whole game." How would you search for that?
- **Q6.e** "If you add two items at the same price, the collection initializer throws." Try it: add a fourth item with cost 2 and run the game.
- **Q6.f** `Location`, `UrbanChallenge`, `Item` and `ChallengeOption` are `public` "because they need to be reachable by `System.Text.Json`'s deserializer". Is that reason written anywhere in the code? How could you test it?
- **Q6.g** Read the comment on `PawnShop.cs:16-18`, then the field on line 22. Do they agree?

---
