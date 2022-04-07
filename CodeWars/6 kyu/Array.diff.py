# Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

# It should remove all values from list a, which are present in list b keeping their order.

# array_diff([1,2],[1]) == [2]
# If a value is present in b, all of its occurrences must be removed from the other:

# array_diff([1,2,2,2,3],[2]) == [1,3]

import array


def array_diff(a, b):
    output = []
    for num in a:
        if num not in b:
            output.append(num)
    return output

input_a = [1, 2, 2, 2, 3]
input_b = [2]
result = array_diff(input_a, input_b)
print(result)