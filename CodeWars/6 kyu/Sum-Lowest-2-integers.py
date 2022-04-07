# Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.

# For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.

# [10, 343445353, 3453445, 3453545353453] should return 3453455.

def sum_two_smallest_numbers(numbers):
    numbers.sort()
    return numbers[0] + numbers[1]

entry1 = [19, 5, 42, 2, 77]
entry2 = [10, 343445353, 3453445, 3453545353453]
result1 = sum_two_smallest_numbers(entry1)
result2 = sum_two_smallest_numbers(entry2)
print(result1)
print(result2)