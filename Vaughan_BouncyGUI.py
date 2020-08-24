'''
    Sean Vaughan
    CIS 185
    Exercise 8.2
    Time to Completion: 45 mins
'''
from breezypythongui import EasyFrame


class Bouncy(EasyFrame):

    def __init__(self):
        EasyFrame.__init__(self)
        EasyFrame.setTitle(self, "BouncyGUI")

        # Labels
        self.addLabel(text="Height", row=0, column=0)
        self.addLabel(text="Bounciness Index", row=1, column=0)
        self.addLabel(text="Num Of Bounces", row=2, column=0)

        # Fields
        self.heightFld = self.addFloatField(row=0, column=2, value=0, width=10)
        self.bouncyIndexFld = self.addFloatField(row=1, column=2, value=0, width=10)
        self.numOfBouncesFld = self.addIntegerField(row=2, column=2, value=0, width=10)

        # Output field
        self.totalDistanceFld = self.addTextField(row=4, column=1, width=17, text="")

        # Buttons
        self.calcBtn = self.addButton(text="Calculate Distance", row=3, column=1, command=self.calculateDistance)

    def calculateDistance(self):
        try:  # Get valid inputs from fields using Try/Except
            bouncinessIndex = self.bouncyIndexFld.getNumber()
            height = self.heightFld.getNumber()
            numOfBounces = self.numOfBouncesFld.getNumber()

            totalDistance = height

            for i in range(1, numOfBounces + 1):  # Loops to track accumlation of distance traveled.
                    if i == 1:
                        newDis = (totalDistance * bouncinessIndex)
                    else:
                        newDis = (newDis * bouncinessIndex)

                    if i < numOfBounces:
                        totalDistance += (2 * newDis)
                    else:
                        totalDistance += newDis

            # Converts value to formatted string.
            self.totalDistanceFld.setText("{0:.3f}".format(totalDistance) + "units")
        except ValueError:  # Catches non integer inputs.
            self.messageBox(title="Error", message="Please enter proper numbers.")

def main():
    Bouncy().mainloop()


if __name__ == "__main__":
    main()
