/********************************
*   Programmer : Sean Vaughan   *
*       CIS 278 - Mansour       *
*      Chapter 10 : 10.11       *
*********************************/


#include "pch.h"
#include <iostream>
#include "Polynomial.h"
#include <chrono>
#include <thread>

using namespace std;

int main()
{
	Polynomial polynomial1, polynomial2, polynomial3 , tempPolynomial;

	//Sleep for specific amount of time.
	cout << "Preparing to enter data for first polynomial..\n\n";
	this_thread::sleep_for(chrono::milliseconds(1000));

	//Get amt of terms and print for polynomial 1.
	polynomial1.getUserTerms();
	cout << "Polynomial 1 is: \n";
	polynomial1.printPolynomial();

	//Sleep for specific amount of time.
	cout << "\nPreparing to enter data for second polynomial..\n\n";
	this_thread::sleep_for(chrono::milliseconds(1000));

	//Get amt of terms and print for polynomial 2.
	polynomial2.getUserTerms();
	cout << "Polynomial 2 is: \n";
	polynomial2.printPolynomial();

	//Keeps original value of poly1 stored in temp.
	tempPolynomial = polynomial1;

	//Add polynomials using overloaded operator+.
	cout << "\nAdding these polynomials togethers yields..\n";
	polynomial3 = polynomial1 + polynomial2;
	polynomial3.printPolynomial();

	//Subtract polynomials using overloaded operator-.
	cout << "\nSubtracting these polynomials yields..\n";
	polynomial3 = polynomial1 - polynomial2;
	polynomial3.printPolynomial();

	//Use overloaded += and reset val for poly 1.
	cout << "\nUsing += yields..\n";
	polynomial1 += polynomial2;
	polynomial1.printPolynomial();
	polynomial1 = tempPolynomial; //Resets polynomial 1.

	//Use overloaded -= and reset val for poly 1.
	cout << "\nUsing -= yields..\n";
	polynomial1 -= polynomial2;
	polynomial1.printPolynomial();
	polynomial1 = tempPolynomial; //Resets polynomial 1.

	//Multiply polynomials using overloaded operator *.
	cout << "\nMultiplying these polynomials together yields..\n";
	polynomial3 = polynomial1 * polynomial2;
	polynomial3.printPolynomial();

	//Using overloaded *=
	cout << "\nUsing *= yields..\n";
	polynomial1 *= polynomial2;
	polynomial1.printPolynomial();
}

