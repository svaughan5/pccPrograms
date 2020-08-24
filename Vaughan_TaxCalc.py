'''
    Sean Vaughan
    CIS 185
    Exercise 8.6
    Time to completion: 45 mins(Didn't do a tax calculation program early on so made it a value
                                that the user has to enter)
'''

from breezypythongui import EasyFrame


class TaxCalculator(EasyFrame):

    def __init__(self):
        EasyFrame.__init__(self)
        EasyFrame.setTitle(self, "Tax Calculator")
        EasyFrame.setSize(self, width=300, height=280)

        # Input Box W/ Label
        self.amountLbl = self.addLabel(row=0, column=0, text="Amount")
        self.amountToTaxFld = self.addFloatField(row=0, column=1, value=0.00)

        # Radio Buttons
        self.filingTypeGroup = self.addRadiobuttonGroup(row=1, column=0, rowspan=3)
        self.singleFile = self.filingTypeGroup.addRadiobutton(text="Single")
        self.marriedFile = self.filingTypeGroup.addRadiobutton(text="Married")
        self.divorcedFile = self.filingTypeGroup.addRadiobutton(text="Divorced")
        self.filingTypeGroup.setSelectedButton(self.singleFile)

        # Buttons
        self.calcBtn = self.addButton(text="Calculate", row=4, column=0, command=self.calculateTax)
        self.exitBtn = self.addButton(text="Exit", row=4, column=1, command=quit)

        # Label for displaying data
        self.calculationLbl = self.addLabel(text="", row=5, column=0)

    def calculateTax(self):
        try:
            amount = self.amountToTaxFld.getNumber()  # Grabs amount to tax

            radioBtnValue = self.filingTypeGroup.getSelectedButton()["text"]  # Radio btn selection
            taxableAmount = 0

            if radioBtnValue == "Single":
                taxableAmount = 0.2 * amount
            elif radioBtnValue == "Married":
                taxableAmount = 0.15 * amount
            elif radioBtnValue == "Divorced":
                taxableAmount = 0.1 * amount

            # Converts taxable amount to string for label display.
            displayString = "Taxable amount is: " + str(taxableAmount)
            self.calculationLbl.config(text=displayString)

        except ValueError:  # Catches improper inputs
            self.messageBox(title="Error", message="Please enter a valid number.")


def main():
    TaxCalculator().mainloop()


if __name__ == "__main__":
    main()
