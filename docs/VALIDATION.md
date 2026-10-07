# Documentation review and manual checks

Baseline: `3b11b7f2fc3005b2570e460da8c094c9f95fc45d`.

## Scope

README and validation notes only. No gameplay code, question content, scenes, assets, packages, settings, saved data, or existing build outputs are changed.

Reviewed question models and group declarations, panel assignment, question/answer selection, correct/incorrect feedback, attempt counting, score storage, player switching, reporting, project version, and enabled scenes. Checked local documentation links against repository paths and patch whitespace. No Unity runtime, build, or live service was invoked. This is not a complete asset-rights or history/security audit.

## Source observations

- `QuestionController.RepeatQuestion()` increments the session counter after both correct and incorrect answers, hiding the panel after five attempts. The random question selection does not exclude previously selected questions, so repetition is possible.
- The controller indexes `levels[level - 1]`. Verify that level assignment occurs before question access and remains within the populated list, including transitions between worlds.
- `QuestionClasses.Start()` appends 20 declared groups to the serialized `levels` list. Inspect its initial serialized state to ensure existing entries do not shift the intended group mapping.
- The controller assumes three answer strings for levels up to 12 and four afterward, valid `AnswerOnButton` indices, and four assigned button transforms. Validate the full question bank and scene references rather than treating a declaration count as a runtime test.
- `QuestionAssign` finds `QuestionController` by object name after a short delayed invocation. Check object availability and activation across scene changes and repeated sessions.
- `DetailPlayer` extracts only the last character of stored player-key names when selecting a profile. Check switching when profile indices reach two digits.
- `GameStartupController.Start()` calls the reporting coroutine. With a current player, the code posts learner identifiers, collected totals, and device name to an external PHP endpoint. No live request or backend verification was performed.
- Included framework, generated APK/debug outputs, and bundled assets are retained. Existing builds do not verify current source behavior, and this documentation does not grant asset redistribution permission.

## Manual validation before a release

1. Import in Unity 6000.0.62f1; inspect compilation, missing assets, and initialization from Init.
2. Review reporting configuration and use test learner information with a controlled development service for network testing.
3. Visit each enabled world and confirm the intended question groups are reachable.
4. Exercise three/four-choice questions, correct/wrong answers, repeated questions, fifth-attempt closure, reopening, and score persistence.
5. Check profile creation/switching, including multi-digit indices, then restart and verify saved scores.
6. Have an educator check wording, choices, answer indices, and coverage. Confirm asset permissions and test the intended platform build before release.

Source concerns above remain unchanged in this documentation-only PR.
