#ifndef PACKAGE_H
#define PACKAGE_H

#include <string>
using namespace std;

class Package
{
public:

	//Default constructor
	Package();

	//Constructor/deconstructor
	Package(string senderName, string recieverName, string senderAddress,
		string recieverAddress, string senderCity, string recieverCity,
		string senderState, string recieverState, int senderZip, int recieverZip,
		double packageWeight, double costPerOunce);
	~Package();

	//---GETTERS AND SETTERS---
	void setSenderName(string senderName);
	string getSenderName();

	void setRecieverName(string recieverName);
	string getRecieverName();

	void setSenderAddress(string senderAddress);
	string getSenderAddress();

	void setRecieverAddress(string recieverAddress);
	string getRecieverAddress();

	void setSenderCity(string senderCity);
	string getSenderCity();

	void setRecieverCity(string recieverCity);
	string getRecieverCity();

	void setSenderState(string senderState);
	string getSenderState();

	void setRecieverState(string recieverState);
	string getRecieverState();

	void setSenderZip(int senderZip);
	int getSenderZip();

	void setRecieverZip(int recieverZip);
	int getRecieverZip();

	//Package
	void setPackageWeight(double packageWeight);
	double getPackageWeight();

	void setCostPerOunce(double costPerOunce);
	double getCostPerOunce();

	void setPackageCost(double extraCost);
	double getPackageCost();
	//---END GETTERS AND SETTERS---

	//Other methods
	virtual void calculateCost();
	virtual void toString();

private:
	//Reciever/sender data members
	string senderName, recieverName;
	string senderAddress, recieverAddress;
	string senderCity, recieverCity;
	string senderState, recieverState;
	int senderZip, recieverZip;

	//Package data members
	double packageWeight;
	double costPerOunce;
	double packageCost;
};

#endif

