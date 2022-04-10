def sum_dig_pow(a, b):
    output = []
    for x in range(a, b):
        digits = [int(num) for num in str(x)]
        exp_sum = 0
        for y in digits:
            exp_sum += y**(digits.index(y)+1)
        if x == exp_sum:
            output.append(x)
    return output