#include "pch.h"
#include <iostream>
#include <time.h>
#include "Block.h"
#include "TreeNode.h"

using namespace std;

const size_t ARRAY_SIZE = 100;

void fillBinaryTree(TreeNode<Block*> binaryTree[], Block* blockArray[]);

int main()
{

	//Array to hold binary tree
	TreeNode<Block*> binaryTree[ARRAY_SIZE - 1];

	//Variable to hold time
	size_t currentTime = time(0);

	//Create genesis block, store at position 0 of array
	Block* genesisBlock = new Block(0, 0, 0, currentTime);
	Block* blockArray[ARRAY_SIZE];
	blockArray[0] = genesisBlock;

	//loop to fill other 99 elements
	for (int i = 1; i < ARRAY_SIZE; i++) {
		long randomNum;
		randomNum = rand() % 10000 + 1;
		currentTime = time(0);
		Block* newBlock = new Block(i, blockArray[i - 1]->getPreviousHash(), randomNum, currentTime);
		blockArray[i] = newBlock;
	}

	fillBinaryTree(binaryTree, blockArray);

}

template <typename T>
void fillBinaryTree(TreeNode<Block*> binaryTree[], Block* blockArray[]) {

	TreeNode<T> node;
	//Set Root
	binaryTree[0].data = blockArray[1];

	for (int i = 1; i < ARRAY_SIZE; i++) {
		if (binaryTree[i].data = 0) {
			binaryTree[i].data = blockArray[i]->getNonce();
		}
		else if(binaryTree[i].left == nullptr){
			binaryTree[i].left = binaryTree[i];
		}
		else if (binaryTree[i].right == nullptr) {
			binaryTree[i].right = binaryTree[i];
		}
	}
}