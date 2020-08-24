#include "pch.h"
#include "Polynomial.h"
#include <iostream>

using namespace std;

//Default constructor
Polynomial::Polynomial()
{
	//Assigns all values in coefficient and exponent array to 0.
	for (int i = 0; i < 100; i++) {
		this->coefficientArray[i] = 0;
		this->exponentArray[i] = 0;
	}
}

//Overloaded operator+ function
Polynomial Polynomial::operator+(const Polynomial& polynomial) {
	Polynomial tempPolynomial;
	int i;

	//Copy array being passed through into the temp object.
	for (i = 0; (i < 100) && (polynomial.exponentArray[i] != 0); i++) {
		tempPolynomial.coefficientArray[i] = polynomial.coefficientArray[i];
		tempPolynomial.exponentArray[i] = polynomial.exponentArray[i];
	}

	for (int j = 0; j < 100; j++) {
		//Flag to false, only sets true if exponent found.
		bool exponentExists = false;

		for (int k = 0; (k < 100) && (!exponentExists); k++) {
			//Checks exponent array with temp exponent array.
			if (this->exponentArray[k] == tempPolynomial.exponentArray[j]) {
				//Adds curr object coefficient with temp.
				tempPolynomial.coefficientArray[k] += this->coefficientArray[j];
				exponentExists = true;
			}
		}
		//If exponent isn't found, inserts into temp polynomial.
		if (!exponentExists) {
			tempPolynomial.exponentArray[i] = this->exponentArray[j];
			tempPolynomial.coefficientArray[i] += this->coefficientArray[j];
			i++;
		}
	}

	return tempPolynomial;
}

//Overloaded operator- function
Polynomial Polynomial::operator-(const Polynomial& polynomial) {
	Polynomial tempPolynomial;
	int i;


	//Copy array being passed through into the temp object.
	for (i = 0; (i < 100) && (polynomial.exponentArray[i] != 0); i++) {
		tempPolynomial.coefficientArray[i] = polynomial.coefficientArray[i];
		tempPolynomial.exponentArray[i] = polynomial.exponentArray[i];
	}

	for (int j = 0; j < 100; j++) {
		//Flag to false, only sets true if exponent found.
		bool exponentExists = false;

		for (int k = 0; (k < 100) && (!exponentExists); k++) {
			//Checks exponent array with temp exponent array.
			if (this->exponentArray[j] == tempPolynomial.exponentArray[k]) {
				//Subtracts curr poly coefficient from temp.
				tempPolynomial.coefficientArray[k] -= this->coefficientArray[j];
				exponentExists = true;
			}
		}
		//If exponent isn't found, inserts into temp polynomial.
		if (!exponentExists) {
			tempPolynomial.exponentArray[i] = this->exponentArray[j];
			tempPolynomial.coefficientArray[i] -= this->coefficientArray[j];
			i++;
		}
	}

	return tempPolynomial;
}

//Overloaded assignment operator
const Polynomial Polynomial::operator=(const Polynomial& polynomial) {
	//Sets 1st position of curr obj to new val.
	this->exponentArray[0] = polynomial.exponentArray[0];
	this->coefficientArray[0] = polynomial.coefficientArray[0];

	//Loops through exp/coeff arrays.
	for (int i = 1; i < 100; i++) {
		if (polynomial.exponentArray[i] != 0) { //If new val isn't 0 assign curr obj new vals.
			this->exponentArray[i] = polynomial.exponentArray[i];
			this->coefficientArray[i] = polynomial.coefficientArray[i];
		}
		else {
			//If curr exp = 0 set both at pos equal to 0 and break out of loop.
			if (this->exponentArray[i] == 0) {
				this->exponentArray[i] = 0;
				this->coefficientArray[i] = 0;
				break;
			}
		}
	}
	return *this;
}


//Method for overloading operator*
Polynomial Polynomial::operator*(const Polynomial& polynomial) {

	Polynomial tempPolynomial;
	//Subscript for temp poly location
	int subscr = 1;

	//Double for loop to loop through 2 arrays.
	for (int i = 0; (i < 100) && (i == 0 || this->coefficientArray[i] != 0); i++) {
		for (int j = 0; (j < 100) && (j == 0 || polynomial.coefficientArray[j] != 0); j++) {
			if (this->coefficientArray[i] == polynomial.coefficientArray[j]) {
				if (this->exponentArray[i] == 0 && polynomial.exponentArray[j] == 0) {
					tempPolynomial.coefficientArray[0] += this->coefficientArray[i] * polynomial.coefficientArray[j];
				}
				else {
					tempPolynomial.coefficientArray[subscr] = this->coefficientArray[i] * polynomial.coefficientArray[j];
					tempPolynomial.exponentArray[subscr] = this->exponentArray[i] + polynomial.exponentArray[j];
					subscr++;
				}
			}
		}
	}

	//Return new poly.
	return tempPolynomial;
}

//Overloaded method for operator +=.
Polynomial &Polynomial::operator+=(const Polynomial& polynomial) {
	//Use *this to refer to current object as a whole.
	*this = *this + polynomial;
	return *this;
}

//Overloaded method for operator -=.
Polynomial &Polynomial::operator-=(const Polynomial& polynomial) {
	//Use *this to refer to current object as a whole.
	*this = *this - polynomial;
	return *this;
}

//Overloaded method for operator *=.
Polynomial &Polynomial::operator*=(const Polynomial& polynomial) {
	//Use *this to refer to current object as a whole.
	*this = *this * polynomial;
	return *this;
}

//--GETTERS AND SETTERS--
int Polynomial::getNumberOfTerms() {
	return this->numberOfTerms;
}

int Polynomial::getTermExponent(int term) {
	return this->exponentArray[term];
}

int Polynomial::getTermCoefficient(int term) {
	return this->coefficientArray[term];
}

void Polynomial::setCoefficient(int term, int coefficient) {
	if (this->coefficientArray[term] == 0) {
		cout << "Term does not exist..\n";
	}
	else {
		this->coefficientArray[term] = coefficient;
	}
}

//--END GETTERS AND SETTERS--

//Method to get amt of term from user.
void Polynomial::getUserTerms() {
	int coeff, exp;

	cout << "Please enter the number of polynomial terms you'd like to use.\n";
	cin >> this->numberOfTerms;

	for (int i = 0; i < this->numberOfTerms; i++) {
		//Get coefficient
		cout << "Enter coefficient..\n";
		cin >> coeff;
		//Get exponent
		cout << "Enter exponent..\n";
		cin >> exp;

		coefficientArray[i] = coeff;
		exponentArray[i] = exp;
	}
}

//Method for printing polynomials
void Polynomial::printPolynomial() {
	int start;
	bool isZero = false;

	if (this->coefficientArray[0] != 0) {
		start = 0;
		isZero = true;
		for (int i = start; i < 100; i++) {
			if (this->coefficientArray[i] != 0) {
				if (i > 0) {
					cout << " + ";
				}
				cout << this->coefficientArray[i] << "x";
				if ((this->exponentArray[i] != 0) && (this->exponentArray[i] != 1)) {
					cout << "^" << this->exponentArray[i];
				}
				isZero = true;
			}
		}
	}

	if (!isZero) {
		cout << "0";
	}

	cout << endl;
}

Polynomial::~Polynomial()
{
}
