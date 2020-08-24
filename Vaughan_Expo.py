'''
    Sean Vaughan
    CIS 185
    Exercise 11.3
    Time to Completion : 30 mins
'''


'''
Computational complexity is O(n). If you were to not use a recursive function it would be O(1).
'''

def expo(base, exponent):
    product = base
    for i in range(exponent):
        product *= base
    return product


def main():
    baseNum = int(input("Please enter a base number: "))
    exponent = int(input("Please enter the exponent: "))
    print(baseNum, "^", exponent, " evaulates to..")
    for i in range(exponent):
        print(expo(baseNum, i))


if __name__ == "__main__":
    main()
