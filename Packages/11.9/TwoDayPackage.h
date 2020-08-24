#ifndef TWODAYPACKAGE_H
#define TWODAYPACKAGE_H
#include "Package.h"

class TwoDayPackage : public Package
{
public:
	//Constructors/deconstructor
	TwoDayPackage();
	TwoDayPackage(string senderName, string recieverName, string senderAddress,
		string recieverAddress, string senderCity, string recieverCity,
		string senderState, string recieverState, int senderZip, int recieverZip,
		double packageWeight, double costPerOunce, double twoDayFee);
	~TwoDayPackage();

	//Getter/setters
	void setTwoDayFee(double twoDayFee);
	double getTwoDayFee();

	//Method to calc cost
	virtual void calculateCost() override;

	//toString method
	void toString() override;

private:
	//Data member to hold two day fee.
	double twoDayFee;
	double twoDayCost;
};

#endif

