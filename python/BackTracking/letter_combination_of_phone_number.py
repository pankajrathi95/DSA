class Solution:
    num_to_letters = {
        "2" : ["a", "b", "c"],
        "3" : ["d", "e", "f"],
        "4" : ["g", "h", "i"],
        "5" : ["j", "k", "l"],
        "6" : ["m", "n", "o"],
        "7" : ["p", "q", "r", "s"],
        "8" : ["t", "u", "v"],
        "9" : ["w", "x", "y", "z"]
    }

    def letter_solve(self, digits, val, result, current, n):
        if current == n:
            result.append(str(val))
            return

        arr = self.num_to_letters[digits[current]]
        for i in range(len(arr)):
            val += arr[i]
            self.letter_solve(digits, val, result, current + 1, n)
            val = val[:-1]

    def letterCombinations(self, digits: str) -> list[str]:
        result = []
        if digits == "":
            return result
        self.letter_solve(digits, "", result, 0, len(digits))
        return result

        