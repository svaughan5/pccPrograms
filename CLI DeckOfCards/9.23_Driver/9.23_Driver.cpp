/** * * * * * * * * * * * * * *
*  Programmer : Sean Vaughan  *
*      CIS 278 - Mansour      *
*      Chapter 9 : 9.23       *
* * * * * * * * * * * * * * * */

#include "pch.h"
#include <iostream>
#include <iomanip>
#include "Card.h"
#include "DeckOfCards.h"

int main()
{
	//Creates deck object
	DeckOfCards deck;

	//Shuffles deck
	deck.shuffleDeck();
	
	//Counter variable used to format printing
	int count = 1;
	//Loops through deck drawing cards.
	for (int i = 0; i < 52; ++i) {
		cout << left << setw(18) << deck.dealCard().toString() << " ";
		//After every 4th card, creates a new line.
		if (count % 4 == 0) {
			cout << endl;
		}
		count++;
	}
}

