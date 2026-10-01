## Data Structures Selection

| # | Scenario | Recommended Data Structure |
| :--- | :--- | :--- |
| **S1** | Find a student by national ID — thousands of times a day.[cite: 4] | `Dictionary<TKey, TValue>` |
| **S2** | Keep the tags of a course. The same tag must never be stored twice.[cite: 4] | `HashSet<T>` |
| **S3** | Keep a student's grades in the order they were entered. The same grade can appear more than once.[cite: 4] | `List<T>` |
| **S4** | A public method returns the course price list. Callers can read prices but must not add or change any.[cite: 4] | `IReadOnlyDictionary<TKey, TValue>` |
| **S5** | A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order.[cite: 4] | `SortedDictionary<TKey, TValue>` |
| **S6** | A method returns results that the caller only loops over once — and may stop early.[cite: 4] | `IEnumerable<T>` (using `yield return`) |