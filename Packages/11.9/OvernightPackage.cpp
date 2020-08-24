#include "pch.h"
#include "OvernightPackage.h"
#include <iostream>

//Default constructor
OvernightPackage::OvernightPackage() {

}

//Constructor
OvernightPackage::OvernightPackage(string senderName, string recieverName, string senderAddress,
	string recieverAddress, string senderCity, string recieverCity,
	string senderState, string recieverState, int senderZip, int recieverZip,
	double packageWeight, double costPerOunce, double overnightCostPerOunce) 
	: Package(senderName, recieverName, senderAddress, recieverAddress, 
		senderCity, recieverCity, senderState, recieverState,
		senderZip, recieverZip, packageWeight, costPerOunce)
{
	setOvernightCostPerOunce(overnightCostPerOunce);
	calculateCost();
}

//Deconstructor
OvernightPackage::~OvernightPackage()
{
}

//Getters and Setters
void OvernightPackage::setOvernightCostPerOunce(double overnightCostPerOunce) {
	this->overnightCostPerOunce = overnightCostPerOunce;
}
double OvernightPackage::getOvernightCostPerOunce() {
	return this->overnightCostPerOunce;
}

//Calculate cost method
void OvernightPackage::calculateCost() {

	//Get overall cost per ounce on overnight shipping
	double overallCostPerOunce = this->overnightCostPerOunce + getCostPerOunce();

	//Calc total cost
	this->overnightCost = getPackageWeight() * overallCostPerOunce;

	setPackageCost(overnightCost);

}

//toString method
void OvernightPackage::toString() {
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
	cout << "Overnight per/oz : $" << this->overnightCostPerOunce << endl;
	cout << "\nPackage Cost : $" << getPackageCost() << endl;
}