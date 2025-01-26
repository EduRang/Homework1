## Markdown Tagging Options

- **Headings**:  
  Use `#` for headings. The number of `#` determines the level of the heading.  
  Example:  
  `# This is a level 1 heading`  
  `## This is a level 2 heading`  
  `### This is a level 3 heading`

- **Bold**:  
  Use `**` or `__` to make text bold.  
  Example:  
  `**This is bold text**`  
  `__This is also bold text__`

- **Italic**:  
  Use `*` or `_` to make text italic.  
  Example:  
  `*This is italic text*`  
  `_This is also italic text_`

- **Lists**:  
  - Unordered list:  
    Use `-`, `*`, or `+` followed by a space.  
    Example:  
    `- Item 1`  
    `* Item 2`  
  - Ordered list:  
    Use numbers followed by a period.  
    Example:  
    `1. First item`  
    `2. Second item`

- **Links**:  
  To create a link:  
  `[Link text](http://url.com)`

- **Images**:  
  Similar to links but with an exclamation mark at the beginning.  
  `![Alt text](image_url.jpg)`

- **Code Blocks**:  
  Inline code: Use backticks `` ` ``.  
  Example:  
  `` `code` ``  
  Code block: Use triple backticks (```), with an optional language tag.  
  Example:  
  ``` 
  ```C sharp
  Console.WriteLine('Hello World');
  ```
  ```

## Git Commands Used

- **Check the status of a local repository**:
  To see the status of your repository, run:
  ```bash
  git status
  ```

- **Add individual files or globally**:
  - To add a specific file to staging:
    ```bash
    git add filename
    ```
  - To add all modified files to staging:
    ```bash
    git add .
    ```

- **Add comments to the commit**:
  After staging the files, commit your changes with a message explaining the change:
  ```bash
  git commit -m "Your commit message here"
  ```

- **Upload your changes to the remote repository**:
  To push your changes to the remote repository (typically `origin` and the branch name):
  ```bash
  git push origin branch-name
  ```

- **Create, browse, and delete branches**:
  - To create a new branch:
    ```bash
    git branch new-branch-name
    ```
  - To switch to a branch:
    ```bash
    git checkout branch-name
    ```
  - To create and switch to a new branch in one command:
    ```bash
    git checkout -b new-branch-name
    ```
  - To list all branches:
    ```bash
    git branch
    ```
  - To delete a branch:
    ```bash
    git branch -d branch-name
    ```

- **Roll back a repository to a specific commit**:
  To revert to a previous commit:
  ```bash
  git checkout commit-hash
  ```
  - If you want to permanently undo changes and reset the repository to a previous commit:
    ```bash
    git reset --hard commit-hash
    ```
  - To reset the repository to a previous commit but keep the changes in the working directory (useful for making changes on top of that commit):
    ```bash
    git reset commit-hash
    ```