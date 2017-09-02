# [Split Strings](https://www.codewars.com/kata/split-strings/csharp)

---

Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

```
SplitString.Solution("abc"); // should return ["ab", "c_"]
SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]
```

---

### 中文大意

把字串變成 array，依每兩個字母分割，如果最後是單一字母就加上 _ 
