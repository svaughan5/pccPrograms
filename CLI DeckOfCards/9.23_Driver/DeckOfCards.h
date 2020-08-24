#ifndef DECKOFCARDS_H
#define DECKOFCARDS_H

#include <array>
#include "Card.h"

using namespace std;

class DeckOfCards
{
public:
	//Constructor/deconstructor
	DeckOfCards();
	~DeckOfCards();

	//Methods to shuffle deck, deal cards, and check if there are more cards in the deck.
	void shuffleDeck();
	Card dealCard();
	bool moreCards();

private:
	//Array of cards used as deck and a variable to hold current card value.
	Card deck[52];
	int currentCard;
};


#endif