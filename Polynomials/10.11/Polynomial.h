#ifndef POLYNOMIAL_H
#define POLYNOMIAL_H

class Polynomial
{
public:

	//Constructor
	Polynomial();

	//Overloaded operation headers
	Polynomial operator+(const Polynomial& polynomial);
	Polynomial operator-(const Polynomial& polynomial);
	const Polynomial operator=(const Polynomial& polynomial);
	Polynomial operator*(const Polynomial& polynomial);
	Polynomial& operator+=(const Polynomial& polynomial);
	Polynomial& operator-=(const Polynomial& polynomial);
	Polynomial& operator*=(const Polynomial& polynomial);

	//Getters and setters
	int getNumberOfTerms();
	int getTermExponent(int term);
	int getTermCoefficient(int term);
	void setCoefficient(int term, int coefficient);

	//Function to get input from user.
	void getUserTerms();

	//Function to print polynomials.
	void printPolynomial();

	//Deconstructor
	~Polynomial();

private:

	int numberOfTerms;
	int exponentArray[100];
	int coefficientArray[100];

};

#endif
