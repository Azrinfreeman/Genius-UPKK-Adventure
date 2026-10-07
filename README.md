# Genius UPKK Adventure

A Unity educational adventure prototype that combines a world-building game framework with Malay multiple-choice revision questions. Its custom learning layer includes question groups, answer feedback, per-player scores, and local learner profiles.

## Learning layer

- Question data covers **Akidah, Ibadah, Sirah, and Adab**, arranged into 20 declared groups across five stages.
- Each question session advances through five attempts. Both correct and incorrect responses advance the attempt counter; this is not a requirement to answer five questions correctly.
- Questions and the correct answer's button position are randomized. Levels 1–12 use three choices; later levels use four.
- Correct answers add **10 points** to the current player's stored score, with sound and visual feedback. Incorrect responses reveal the correct button before advancing.
- Local player creation and switching use Unity `PlayerPrefs`; these profiles are not authenticated online accounts.

The repository also includes Watermelon Core and game-framework systems for worlds, resources, buildings, helpers, and upgrades. Those included systems form the underlying game framework; the scripts below identify the learning/profile adaptation. This overview does not claim that the entire framework was authored for this project.

## Open the project

1. Clone the full repository and open its root folder through Unity Hub.
2. Use **Unity 6000.0.62f1**, recorded in [ProjectVersion.txt](ProjectSettings/ProjectVersion.txt).
3. Allow assets and [package dependencies](Packages/manifest.json) to resolve. The manifest includes URP 17.2.0, Input System 1.14.2, AI Navigation 2.0.8, and uGUI 2.0.0.
4. Start from the `Init` scene under `Assets/Project Files/Game/Scenes/`, then check game initialization and question access using test learner data.

[EditorBuildSettings.asset](ProjectSettings/EditorBuildSettings.asset) enables seven scenes: `Init`, `Game`, and `World 0` through `World 4`. `MainMenu`, `World 1_1`, and the included example scenes are disabled. The configured world scenes do not establish that every question group is reachable or complete.

**External reporting:** `GameStartupController` contains a POST integration with the Hanana service. With a current player present, startup can submit a name, identifier, collected totals, and device name. The server implementation and availability were not verified; review this integration before running with real learner information.

## Source guide

| Area | Source |
| --- | --- |
| Question groups, options, and correct-answer indices | [QuestionClasses.cs](Assets/QuestionClasses.cs) |
| Question display, randomized choices, feedback, and attempts | [QuestionController.cs](Assets/QuestionController.cs) |
| Opening and assigning the question panel | [QuestionAssign.cs](Assets/QuestionAssign.cs) |
| Per-player score storage | [ScoreController.cs](Assets/ScoreController.cs) |
| Profile storage and external reporting | [GameStartupController.cs](Assets/GameStartupController.cs) |
| Profile switching | [DetailPlayer.cs](Assets/DetailPlayer.cs) |

See [validation notes](docs/VALIDATION.md) for source observations and manual checks. Unity compilation, gameplay, reporting, and device builds were not tested during this documentation review. Question content requires educator review before being presented as curriculum-complete or authoritative.

## Included assets and framework

Preserve the original notices and applicable terms for Watermelon Core, game assets, fonts, and other bundled components. No new repository-wide license is added by this documentation change, and it does not establish redistribution rights for every included asset.
