# First look, no AI

We will be using this repository: [https://github.com/ValkoM28/Ecotropolis](https://github.com/ValkoM28/Ecotropolis)

Clone the repository, open in your favourite code editor.

## The README

On the first glance: the README turns out to contain nothing but the project title — no written documentation at all. That's worth noting immediately: there's nothing to read here, so orientation will have to come from the code itself.

## The file list

Next, skim the top-level file list:

`Program.cs`, `Game.cs`, `Player.cs`, `Location.cs`, `LocationLoader.cs`, `Item.cs`, `ChallengeOption.cs`, `UrbanChallenge.cs`, `PawnShop.cs`, `Messager.cs`, plus the `jsons/` folder.

Already, just from the names, a shape starts to form: a *Player* moving between *Locations*, dealing with *Items*, *Challenges*, and a *PawnShop*, with data loaded from JSON files. `Program.cs` is the obvious guess for the entry point, by naming convention alone — that's the file to open first.

## One step further, still without AI

Open `Program.cs`. It's short — about 25 lines — and most of that is a comment block. Reading it costs almost nothing:

* The top comment explains, in the author's own words, what the project is and that it's built on a university-provided template called "WorldOfZuul." That's a small but useful fact: the overall shape of this code may not be original to this team, which explains why it might look similar to other first-semester projects using the same template.
* The actual code is one line inside `Main()`: `Game game = new Game();`. So the entire entry point does exactly one thing — hand off to `Game`.
* Using the editor's **"Go to definition"** on `Game` jumps straight to `Game.cs`. Its class comment says it "is responsible for managing the game loop and the player's progress throughout the game" — which matches the guess already forming, that this is where the real logic lives.
* Skimming just the field declarations at the top of `Game.cs` — `_player` and `_locations` — suggests that there's one player, and a collection of locations to move between.

None of this required asking an LLM anything yet. It took a few minutes, and it means the AI's answers in Example 2 will land on top of a frame you've already built yourself — you'll notice immediately if an answer contradicts what you just saw with your own eyes.

**Files referenced:**

* [https://github.com/ValkoM28/Ecotropolis/blob/main/README.md](https://github.com/ValkoM28/Ecotropolis/blob/main/README.md)
* [https://github.com/ValkoM28/Ecotropolis/blob/main/Program.cs](https://github.com/ValkoM28/Ecotropolis/blob/main/Program.cs)
* [https://github.com/ValkoM28/Ecotropolis/blob/main/Game.cs](https://github.com/ValkoM28/Ecotropolis/blob/main/Game.cs)
