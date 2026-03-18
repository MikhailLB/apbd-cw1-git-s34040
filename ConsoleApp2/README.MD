### Merge Type Explanation
The merge was **not fast-forward** because the history of `main` and `feature-max` branches had **diverged**. 

Since a new commit was added directly to `main` after the `feature-max` branch was created, the branches no longer shared a direct linear path. Git had to perform a **three-way merge** and create a specific **merge commit** to integrate the changes from both independent lines of development.
