'''
    Sean Vaughan
    CIS 185
    Exercise 11.2
    Time to presentation:
'''

import time


'''
Complexity is O(n) since each element is only visited once.
'''
def reverse(list):
    # intializing pointers
    left = 0
    right = len(list) - 1

    # condition for termination
    while left < right:
        # swapping
        temp = list[left]
        list[left] = list[right]
        list[right] = temp

        # updating pointers
        left += 1
        right -= 1

    return list


def main():
    myList = []
    count = 0
    numberToTest = 10000000

    print("Filling list with ", numberToTest, " elements.")
    for i in range(0, numberToTest):
        myList.append(i)

    beforeTime = time.perf_counter()
    print("Time elapsed before reverse function: ", beforeTime)
    reverse(myList)

    afterTimer = time.perf_counter()
    print("Time after execution of reversal function: ", afterTimer)

    reversalTime = afterTimer - beforeTime

    print("Total time for reverse function: ", reversalTime)


if __name__ == "__main__":
    main()
