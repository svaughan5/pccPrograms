#ifndef OVERNIGHTPACKAGE_H
#define OVERNIGHTPACKAGE_H
#include "Package.h"

class OvernightPackage : public Package
{
public:

	//Constructors/deconstructor
	OvernightPackage();
	OvernightPackage(string senderName, string recieverName, string senderAddress,
		string recieverAddress, string senderCity, string recieverCity,
		string senderState, string recieverState, int senderZip, int recieverZip,
		double packageWeight, double costPerOunce, double overnightCostPerOunce);
	~OvernightPackage();

	//Getter/setter
	void setOvernightCostPerOunce(double overnightCostPerOunce);
	double getOvernightCostPerOunce();

	//Overnight calc cost
	virtual void calculateCost() override;

	//toString
	void toString() override;

private:
	//Data member to old overnight cost per ounce
	double overnightCostPerOunce;
	double overnightCost;
};

#endif