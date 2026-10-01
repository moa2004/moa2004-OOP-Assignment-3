# Part 03 — answers

---
## BlockedUsers

- **Time complexity before:** $O(N \times M)$ (where N is the number of blocked IDs and M is the number of requests). `List.Contains()` performs a linear search, which takes $O(N)$ time for each of the M iterations.
- **Time (ms) before:** [اكتب الرقم اللي طلعلك قبل التعديل هنا، مثلاً: 4500]
- **What did you change?** I changed the data structure of `blockedIds` from `List<int>` to `HashSet<int>`.
- **Time complexity after:** $O(M)$ (where M is the number of requests). `HashSet.Contains()` uses hashing to perform an $O(1)$ constant-time lookup, dropping the inner loop complexity.
- **Time (ms) after:** [اكتب الرقم اللي طلعلك بعد التعديل هنا، مثلاً: 15]

---
## Students

- **What was the problem?** The method eagerly generated and loaded all 1,000,000 student objects into a `List` in memory at once. Even if the caller only needed the first 3 students and stopped, the system still wasted significant memory and CPU cycles creating the remaining 999,997 objects.
- **What did you change?** I changed the return type to `IEnumerable<Student>` and used `yield return` inside the loop. This implements "Lazy Evaluation" (deferred execution). The method now yields one student at a time on demand. If the caller stops iterating after 3 items, the execution pauses, and the remaining 999,997 objects are never instantiated.