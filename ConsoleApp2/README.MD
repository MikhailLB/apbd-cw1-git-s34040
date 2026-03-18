* **Merge**: Resulted in a "diamond" shape history. It preserved the original 
context of the branch but added a dedicated merge commit.
* **Rebase**: Produced a **perfectly linear history**. By "replaying" 
`feature-min` commits on top of the latest `main`, we avoided 
the merge commit and made the logs much cleaner and easier to read.
