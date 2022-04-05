# Implement the function unique_in_order which takes as argument a sequence and returns a list of items without 
# any elements with the same value next to each other and preserving the original order of elements.

# For example:

# unique_in_order('AAAABBBCCDAABBB') == ['A', 'B', 'C', 'D', 'A', 'B']
# unique_in_order('ABBCcAD')         == ['A', 'B', 'C', 'c', 'A', 'D']
# unique_in_order([1,2,2,3,3])       == [1,2,3]


def unique_in_order(iterable):
    uniques = []
    uniques.append(iterable[0])

    print(f"Input length = {len(iterable)}")
    print("Output starting out")
    print(uniques)

    for i in range(0, len(iterable)-1):
        print(f"Step {i+1}")
        for j in range(i+1, len(iterable)):
            if iterable[i] != iterable[j]:
                print(f"Adding: {iterable[j]}")
                uniques.append(iterable[j])
                break
            else:
                break

    return uniques

iterable = 'ABBCcAD'
print(unique_in_order(iterable))

