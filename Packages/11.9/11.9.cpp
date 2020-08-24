/******************************
*  Programmer : Sean Vaughan  *
*      CIS 278 - Mansour      *
*     Chapter 12 : 12.12      *
*******************************/

#include "pch.h"
#include <iostream>
#include <chrono>
#include <thread>
#include <vector>
#include "Package.h"
#include "OvernightPackage.h"
#include "TwoDayPackage.h"

using namespace std;

int main()
{
	//Create vector and fill vector with packages.
	vector<Package *> packages(3);
	packages[0] = new Package("Sean", "Tim", "9000 Leet St.", "1337 Leet St.", "Tucson",
		"Vail", "Az", "Az", 85730, 85747, 100.00, 0.25);
	packages[1] = new TwoDayPackage("Bob", "Jim", "9111 Leet St.", "6996 Leet St.", "Tucson",
		"Wakanda", "Az", "Fv", 85730, 13337, 100.00, 0.25, 5.00);
	packages[2] = new OvernightPackage("Joe", "Rick", "9000 Leet St.", "1000 Leet St.", "Tucson",
		"San Diego", "Az", "Ca", 85730, 12345, 100.00, 0.25, 0.15);

	//Variable to hold total for all packages.
	double totalCost = 0;

	//Foreach loop to print packages and information
	for (Package* p : packages) {
		p->toString();
		totalCost += p->getPackageCost();
	}

	cout << "\nThe total shipping cost of all packages is : $" << totalCost << endl;
	
}
