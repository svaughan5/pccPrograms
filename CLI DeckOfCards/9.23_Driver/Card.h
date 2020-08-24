
#ifndef CARD_H
#define CARD_H

#include <string>

using namespace std;
class Card
{
public:

	//Declare enums for suit and face
	enum SUIT { HEARTS = 0, DIAMONDS, CLUBS, SPADES  };
	enum FACE { TWO = 0, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN,
	JACK, QUEEN, KING, ACE };

	//Card constructor/deconstructor
	Card(SUIT suit, FACE face);
	Card();
	~Card();

	//Getters and setters for suit and face
	SUIT getSuit();
	void setSuit(SUIT suit);
	FACE getFace();
	void setFace(FACE face);

	string toString();

private:
	SUIT suit;
	FACE face;
	static string stringOfFaces[13];
	static string stringOfSuits[4];
};


#endif
