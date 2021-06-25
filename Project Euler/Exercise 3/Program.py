#Finds biggest prime factor from given number

import math



def FindLowestFactor(p):
	possi = 2

	factorFound = False

	while factorFound == False:
		if float(p) % float(possi) == 0:
			factorFound = True
		else:
			print(possi)
			possi += 1
			if possi > math.floor(math.sqrt(p)):
				return 1
				break

	return int(possi)


def FindBiggestPrimeFactor(n):

	while True:
		primeFactor = FindLowestFactor(n)
		if primeFactor == 1:
			break
		else:
			n = n / primeFactor


	return int(n)

number = int(input("Select a number: "))

print(FindBiggestPrimeFactor(number))

input()

	