# What is an anagram? Well, two words are anagrams of each other if they both contain the same letters. For example:

    # 'abba' & 'baab' == true
    # 'abba' & 'bbaa' == true
    # 'abba' & 'abbba' == false
    # 'abba' & 'abca' == false

# Write a function that will find all the anagrams of a word from a list. You will be given two inputs a word and an array with words. You should return an array of all the anagrams or an empty array if there are none. For example:

    # anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']
    # anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']
    # anagrams('laser', ['lazing', 'lazy',  'lacer']) => []

def anagrams(word, words):
    test_str = ''.join(sorted(word))
    output = []
    print(f'Sorted test word: {test_str}')
    for str in words:
        sorted_word = ''.join(sorted(str))
        print(f'Sorted word from list: {sorted_word}')
        if test_str == sorted_word:
            output.append(str)
    return output

def anagrams_trimmed(word, words):
    return [item for item in words if sorted(item) == sorted(word)]

word = 'abba'
words = ['aabb', 'abcd', 'bbaa', 'dada']
result = anagrams_trimmed(word, words)
print(result)