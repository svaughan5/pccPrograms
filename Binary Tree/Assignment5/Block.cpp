#include "pch.h"
#include "Block.h"

using namespace std;



Block::Block()
{
	setId(0);
	setHash(0);
	setPreviousHash(0);
	setNonce(0);
	setTimeId(0);
}

Block::Block(long id)
{
	setId(id);
	setHash(0);
	setPreviousHash(0);
	setNonce(0);
	setTimeId(0);
}

Block::Block(long id, char hash, char* prevHash, long nonce, size_t timeId) {
	setId(id);
	setHash(hash);
	setPreviousHash(prevHash);
	setNonce(nonce);
	setTimeId(timeId);
}

Block::Block(long id, char* prevHash, long nonce, size_t timeId) {
	setId(id);
	setPreviousHash(prevHash);
	setNonce(nonce);
	setTimeId(timeId);
	generateHash();
}

Block::~Block()
{
}

//-------Getters and setters-------

//Id 
long Block::getId() { return this->id; }
void Block::setId(long id) { this->id = id; }

//Hash
char* Block::getHash() { return this->hash; }
void Block::setHash(char hash) {
	char* hashPtr = &hash;
	this->hash = hashPtr;
}

//Prev Hash
char* Block::getPreviousHash() { return this->previousHash; }
void Block::setPreviousHash(char* previousHash) {
	char* prevHashPtr = previousHash;
	this->previousHash = prevHashPtr;
}

//Nonce
long Block::getNonce() { return this->nonce; }
void Block::setNonce(long nonce) { this->nonce = nonce; }

//Time Id
size_t Block::getTimeId() { return this->timeId; }
void Block::setTimeId(size_t timeId) { this->timeId = timeId; }

//Generate Hash
size_t Block::generateHash() {
	size_t h1 = sizeof(this->previousHash);
	size_t h2 = sizeof(this->nonce);

	return h1 ^ (h2 << 1);
}
