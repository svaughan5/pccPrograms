#ifndef BLOCK_H
#define BLOCK_H


#include <functional>

using namespace std;

class Block
{

private:
	long id;
	char* hash;
	char* previousHash;
	long nonce;
	int timeId;

public:
	//Constructors/Deconstructor
	Block();
	Block(long id);
	Block(long id, char hash, char* previousHash, long nonce, size_t timeId);
	Block(long id, char* previousHash, long nonce, size_t timeId);
	~Block();

	//-----Getters and setters-----

	//Id
	long getId();
	void setId(long id);

	//Hash
	char* getHash();
	void setHash(char hash);

	//Prev Hash
	char* getPreviousHash();
	void setPreviousHash(char* previousHash);

	//Nonce
	long getNonce();
	void setNonce(long nonce);

	//TimeId
	size_t getTimeId();
	void setTimeId(size_t timeId);

	//Generate Hash
	size_t generateHash();
};

#endif // !BLOCK_H