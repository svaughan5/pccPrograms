#include "pch.h"
#include "TwoDayPackage.h"
#include <iostream>


//Default constructor
TwoDayPackage::TwoDayPackage() {

}

//Constructor
TwoDayPackage::TwoDayPackage(string senderName, string recieverName, string senderAddress,
	string recieverAddress, string senderCity, string recieverCity,
	string senderState, string recieverState, int senderZip, int recieverZip,
	double packageWeight, double costPerOunce, double twoDayFee)
	: Package(senderName, recieverName, senderAddress, recieverAddress,
		senderCity, recieverCity, senderState, recieverState,
		senderZip, recieverZip, packageWeight, costPerOunce)
{
	setTwoDayFee(twoDayFee);
	calculateCost();
}

//Deconstructor
TwoDayPackage::~TwoDayPackage()
{
}

//--- Getter and setter ---

void TwoDayPackage::setTwoDayFee(double twoDayFee) {
	this->twoDayFee = twoDayFee;
}
double TwoDayPackage::getTwoDayFee() {
	return this->twoDayFee;
}
//--- End Getter and Setter ---


//Method to calc the cost of a two day package.
void TwoDayPackage::calculateCost() {
	//Adds two day fee to initial shipping fee.
	this->twoDayCost = getPackageCost() + this->twoDayFee;

	setPackageCost(this->twoDayCost);

}

//toString method
void TwoDayPackage::toString() {
	cout << "---------------------------------------------\n\n";
	cout << "		   Package Info " << endl;
	cout << "-Sender Information-" << endl;
	cout << "Name             : " << getSenderName() << endl;
	cout << "Address          : " << getSenderAddress() << endl;
	cout << "City, State      : " << getSenderCity() << ", " << getSenderState() << endl;
	cout << "Zip              : " << getSenderZip() << endl;
	cout << "\n-Recipent Information-" << endl;
	cout << "Name             : " << getRecieverName() << endl;
	cout << "Address          : " << getRecieverAddress() << endl;
	cout << "City, State      : " << getRecieverCity() << ", " << getRecieverState() << endl;
	cout << "Zip              : " << getRecieverZip() << endl;
	cout << "\n-Package Information-" << endl;
	cout << "Package Weight   : " << getPackageWeight() << "oz" << endl;
	cout << "Cost Per Ounce   : $" << getCostPerOunce() << endl;
	cout << "Two Day Fee      : $" << twoDayFee << endl;
	cout << "\nTotal Package Cost : $" << getPackageCost() << endl;
}

