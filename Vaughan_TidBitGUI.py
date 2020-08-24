'''
    Sean Vaughan
    CIS 185
    Exercise 8.7
    Time to Completion: 1 hr 15 mins
'''
from breezypythongui import EasyFrame

MONTHLY_PAYMENT = 0.05
DOWN_PAYMENT = .10

class TidBitGUI(EasyFrame):

    def __init__(self):
        EasyFrame.__init__(self, title="TidBitGUI", height=350, width=400)

        # Labels
        self.purchaseLbl = self.addLabel(text="Purchase Price", row=0, column=0)
        self.interestLbl = self.addLabel(text="Annual Interest Rate", row=1, column=0)

        # Input Fields
        self.purchaseFld = self.addFloatField(value=0.00, row=0, column=2)
        self.interestFld = self.addFloatField(value=0.00, row=1, column=2)

        # Button to Calc Payments
        self.calcBtn = self.addButton(text="Calculate", row=2, column=1, command=self.calcMonthlyPayments)

        # Output Field
        self.resultFld = self.addTextArea("", row=3, column=0, columnspan=6)

    def calcMonthlyPayments(self):
        try:
            # Get user inputs
            purchaseAmount = self.purchaseFld.getNumber()
            annualRate = self.interestFld.getNumber() / 100

            # Set Header for Table
            result = "%5s%18s%10s%11s%9s%16s\n" % ("Month", "Starting Balance", "Interest", "Principal",
                                                   "Payment", "Ending Balance")

            # Initialize Starting Variables
            month = 0
            startingBalance = 0.00
            interestToPay = 0.00
            principalToPay = 0.00
            payment = 0.00

            # Get 1st month payment and the monthly payment
            amountToPay = purchaseAmount - (purchaseAmount * DOWN_PAYMENT)
            monthlyPayment = (amountToPay * MONTHLY_PAYMENT)

            # Program loop
            while amountToPay > 0:
                if amountToPay < monthlyPayment:  # Condtion for if the monthly payment is more than remaining amount.
                    month += 1
                    monthlyPayment = amountToPay
                    interestToPay = monthlyPayment
                    principalToPay = monthlyPayment
                    startingBalance = amountToPay
                    amountToPay -= monthlyPayment
                    result += str("%4d%18.2f%10.2f%11.2f%9.2f%16.2f\n" % (month, startingBalance, interestToPay,
                                                                     principalToPay, monthlyPayment, amountToPay))

                else:
                    month += 1
                    startingBalance = amountToPay
                    interestToPay = (startingBalance * (annualRate / 12))
                    principalToPay = monthlyPayment - interestToPay
                    amountToPay = startingBalance - monthlyPayment + interestToPay
                    result += str("%4d%18.2f%10.2f%11.2f%9.2f%16.2f\n" % (month, startingBalance, interestToPay,
                                                                        principalToPay, monthlyPayment, amountToPay))

            self.resultFld["state"] = "normal"
            self.resultFld.setText(result)
            self.resultFld["state"] = "disabled"
        except ValueError:
            self.messageBox(title="Error", message="Please enter proper values.")

def main():
    TidBitGUI().mainloop()


if __name__ == "__main__":
    main()
