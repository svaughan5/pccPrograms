#include "pch.h"
#include "Card.h"

//Default Constructor
Card::Card() {

}

//Constructor
Card::Card(SUIT suit, FACE face)
{
	this->suit = suit;
	this->face = face;
}

//Deconstructor
Card::~Card()
{
}

//Assign values to the string arrays.
string Card::stringOfFaces[] = {"Two", "Three" , "Four", "Five", "Six", "Seven", "Eight", "Nine",
"Ten", "Jack", "Queen", "King", "Ace"};

string Card::stringOfSuits[] = { "Hearts", "Diamonds", "Clubs", "Spades" };

//------ GETTERS AND SETTERS ------------
void Card::setSuit(SUIT suit) {
	this->suit = suit;
}

Card::SUIT Card::getSuit() {
	return this->suit;
}

void Card::setFace(FACE face) {
	this->face = face;
}

Card::FACE Card::getFace() {
	return this->face;
}

//-------- END GETTERS AND SETTERS --------

string Card::toString() {
	return stringOfFaces[face] + " of " + stringOfSuits[suit];
}
