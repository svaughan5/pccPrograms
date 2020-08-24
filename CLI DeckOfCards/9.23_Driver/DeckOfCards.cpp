#include "pch.h"
#include "DeckOfCards.h"
#include "Card.h"
#include <string>
#include <stdlib.h>
#include <stdio.h>
#include <time.h>

using namespace std;

//Constructor
DeckOfCards::DeckOfCards()
{
	//Double for loop to loop through both the face and suit string arrays.
	int i = 0;
	for (int s = 0; s < 4; s++) {
		for (int f = 0; f < 13; f++) {
			Card card((Card::SUIT)s, (Card::FACE)f); //Assigns a specific face/suit to a card in the deck.
			deck[i++] = card;
		}
	}
	//Sets current card to the first card in the deck.
	currentCard = 0;
}

//Deconstructor
DeckOfCards::~DeckOfCards()
{
}

//Method to shuffle cards in the deck.
void DeckOfCards::shuffleDeck() {
	
	//Loops to shuffle deck
	for (int i = 0; i < 52; ++i) {
		//Gets a true random number
		srand(time(NULL));
		int randDeckSpot = rand() % (52 - i) + 1;
		//Swap out values using a temp card object.
		Card temp = deck[i];
		deck[i] = deck[randDeckSpot];
		deck[randDeckSpot] = temp;
	}
}

//Method to deal cards
Card DeckOfCards::dealCard() {
	if (moreCards()) { //Checks if there are more cards in the deck.
		return deck[currentCard++];
	}
}

//Method to check if there are still cards in the deck.
bool DeckOfCards::moreCards() {
	if (currentCard > 52) {
		return false;
	}
	else {
		return true;
	}
}


