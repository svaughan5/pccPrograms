#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/*
	Sean Vaughan
	CIS 265
	IO File Project
	Note : I was going to create a general file instance but the first two methods require the file to be in
	read mode and the 3rd option requires it to be appended so I decided to call the open method in each method.
*/

//Opening a file in read mode
FILE* openFileAppendPlus() {
	FILE *fp;
	fp = fopen("C:\\Users\\Sean\\source\\repos\\IO File Project\\CIS265.txt", "a+");

	if (fp == NULL)
	{
		printf("Error!");
		exit(1);
	}
}

//Method for searching for words in file.
void searchWordInFile() {
	FILE *fp;
	fp = openFileAppendPlus(); //Opens file

	char searchWord[15]; //User-entered word
	char *fileWord; //Flag to see if word is in file
	char buffer[500]; //Used to read words from file
	int findCount = 0; //Counter for occurences of a word in file.

	printf("Enter a word to search for: ");
	scanf("%s", searchWord);
	printf("\n");

	printf("\n");

	while (fscanf(fp, "%s", buffer) != EOF) //Reads file word by word
	{
		fileWord = strstr(buffer, searchWord); //If user-entered word is in file
		if (fileWord && ((strlen(buffer) == strlen(searchWord)))) //Checks to make sure not words including user entered word.
		{
			printf("[%s] ", &buffer);
			findCount++;
		}
		else
		{
			printf("%s ", &buffer);
		}
	}

	printf("\nThe word %s appeared %d times.\n", searchWord, findCount); //Prints final count


	fclose(fp);
}

//Method to display specified amount of lines in file.
void displayLinesInFile() {
	FILE *fp;
	fp = openFileAppendPlus();

	int numOfLines, count = 0;
	char buffer[500];

	printf("How many lines would you like to display? ");
	scanf("%d", &numOfLines); //Get num of lines to read
	printf("\n");

	while (fgets(buffer, sizeof(buffer), fp)) {
		if (count < numOfLines) { //Compares num of lines alr read to amount user entered.
			printf("%s", &buffer);
			count++;
		}
	}

	printf("\n\n");

	fclose(fp);
}

//Method to append file.
void appendToFile() {
	FILE *fp;
	fp = openFileAppendPlus();

	char stringToAppend[500];
	int numOfLines;

	//Gets number of lines then asks for text for each line 1 at a time.
	printf(" Input the number of lines to be written : ");
	scanf("%d", &numOfLines);
	printf(" The lines are : \n");
	for (int i = 0; i < numOfLines + 1; i++)
	{
		fgets(stringToAppend, sizeof(stringToAppend), stdin);
		fputs(stringToAppend, fp); //Add text to end of file
	}
	fclose(fp);
}

int main(void) {
	char userChar = ' ';

	while (userChar != 'Q'){
		printf("1 - Press (S) to search for a word.\n");
		printf("2 - Press (L) to display specified number of lines to screen.\n");
		printf("3 - Press (A) to append new content to file.\n");
		printf("4 - Press (Q) to quit.\n");

		scanf(" %c", &userChar);

		if (userChar == 'S') //Search
		{
			searchWordInFile();
		}
		else if (userChar == 'L') //Print Line
		{
			displayLinesInFile();
		}
		else if (userChar == 'A') //Append to file
		{
			appendToFile();
		}
	}

	return 0;
}