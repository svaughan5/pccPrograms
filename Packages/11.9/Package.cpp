#include "pch.h"
#include "Package.h"
#include <string>
#include <iostream>


using namespace std;

Package::Package() {
	//Set sender information
	setSenderName("");
	setSenderAddress("");
	setSenderCity("");
	setSenderState("");
	setSenderZip(0);

	//Set reciever information
	setRecieverName("");
	setRecieverAddress("");
	setRecieverCity("");
	setRecieverState("");
	setRecieverZip(0);

	//Set package information
	setPackageWeight(0.0);
	setCostPerOunce(0.0);
}

//Constructor for package
Package::Package(string senderName, string recieverName, string senderAddress,
	string recieverAddress, string senderCity, string recieverCity,
	string senderState, string recieverState, int senderZip, int recieverZip,
	double packageWeight, double costPerOunce)
{
	//Set sender information
	setSenderName(senderName);
	setSenderAddress(senderAddress);
	setSenderCity(senderCity);
	setSenderState(senderState);
	setSenderZip(senderZip);

	//Set reciever information
	setRecieverName(recieverName);
	setRecieverAddress(recieverAddress);
	setRecieverCity(recieverCity);
	setRecieverState(recieverState);
	setRecieverZip(recieverZip);

	//Set package information
	setPackageWeight(packageWeight);
	setCostPerOunce(costPerOunce);

	//Calculates cost
	calculateCost();

}

//Deconstructor
Package::~Package()
{
}

//---GETTERS AND SETTERS---

void Package::setSenderName(string senderName) {
	this->senderName = senderName;
}
string Package::getSenderName() {
	return this->senderName;
}

void Package::setRecieverName(string recieverName) {
	this->recieverName = recieverName;
}
string Package::getRecieverName() {
	return this->recieverName;
}

void Package::setSenderAddress(string senderAddress) {
	this->senderAddress = senderAddress;
}
string Package::getSenderAddress() {
	return this->senderAddress;
}

void Package::setRecieverAddress(string recieverAddress) {
	this->recieverAddress = recieverAddress;
}
string Package::getRecieverAddress() {
	return this->recieverAddress;
}

void Package::setSenderCity(string senderCity) {
	this->senderCity = senderCity;
}
string Package::getSenderCity() {
	return this->senderCity;
}

void Package::setRecieverCity(string recieverCity) {
	this->recieverCity = recieverCity;
}
string Package::getRecieverCity() {
	return this->recieverCity;
}

void Package::setSenderState(string senderState) {
	int lengthOfString = senderState.size(); //Gets size of state string

	while (lengthOfString != 2) { //Makes sure state code is 2 chars long.
		cout << "\nPlease enter the correct state 2 character code.\n";
		cin >> senderState;
		lengthOfString = senderState.size();
	}

	this->senderState = senderState;
}
string Package::getSenderState() {
	return this->senderState;
}

void Package::setRecieverState(string recieverState) {
	int lengthOfString = recieverState.size(); //Gets size of state string

	while (lengthOfString != 2) { //Checks for size of 2 (all state codes are 2 chars long)
		cout << "\nPlease enter the correct state 2 character code.\n";
		cin >> recieverState;
		lengthOfString = recieverState.size();
	}

	this->recieverState = recieverState;
}
string Package::getRecieverState() {
	return this->recieverState;
}

void Package::setSenderZip(int senderZip) {
	this->senderZip = senderZip;
}
int Package::getSenderZip() {
	return this->senderZip;
}

void Package::setRecieverZip(int recieverZip) {
	this->recieverZip = recieverZip;
}
int Package::getRecieverZip() {
	return this->recieverZip;
}

//Package getters and setters
void Package::setPackageWeight(double packageWeight) {
	this->packageWeight = packageWeight;
}
double Package::getPackageWeight() {
	return this->packageWeight;
}

void Package::setCostPerOunce(double costPerOunce) {
	this->costPerOunce = costPerOunce;
}
double Package::getCostPerOunce() {
	return this->costPerOunce;
}

double Package::getPackageCost() {
	return this->packageCost;
}

void Package::setPackageCost(double extraCost) {
	this->packageCost = extraCost;
}

//--- END GETTERS AND SETTERS ---

//Method to calculate a basic package cost.
void Package::calculateCost() {
	//Calc total cost using package weight and cost per ounce.
	this->packageCost = this->packageWeight * this->costPerOunce;
	
}

//tostring method
void Package::toString() {
	cout << "-----------------------------------------------\n\n";
	cout << "		   Package Info " << endl;
	cout << "-Sender Information-" << endl;
	cout << "Name             : " << senderName << endl;
	cout << "Address          : " << senderAddress << endl;
	cout << "City, State      : " << senderCity << ", " << senderState << endl;
	cout << "Zip              : " << senderZip << endl;
	cout << "\n-Recipent Information-" << endl;
	cout << "Name             : " << recieverName << endl;
	cout << "Address          : " << recieverAddress << endl;
	cout << "City, State      : " << recieverCity << ", " << recieverState << endl;
	cout << "Zip              : " << recieverZip << endl;
	cout << "\n-Package Information-" << endl;
	cout << "Package Weight   : " << packageWeight << "oz" << endl;
	cout << "Cost Per Ounce   : $" << costPerOunce << endl;
	cout << "\nPackage Cost : $" << packageCost << endl;
}