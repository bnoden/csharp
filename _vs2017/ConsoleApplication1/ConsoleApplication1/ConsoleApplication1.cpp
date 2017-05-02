// Brandon Oden
// COSC 1437
// Program 4.2

#include <iostream>
#include <string.h>
#include <ctype.h>

using namespace std;

bool valid = true;
bool CheckIdentifier(char[]);

int main() {
	char identifier[256];

	cout << "Enter the C++ identifier: ";
	cin >> identifier;

	if (CheckIdentifier(identifier)) {
		cout << identifier << " IS a valid C++ identifier" << endl;
	}
	else {
		cout << identifier << " is NOT a valid C++ identifier" << endl;
	}

	return 0; 
}

bool CheckIdentifier(char id[]) {
	int num = strlen(id);
	if (valid) {
		if (!isalpha(id[0])) {
			valid = false;
			CheckIdentifier(id);
		}
		num--;
		while (num) {
			if (!(isalpha(id[num]) || isdigit(id[num]))) {
				valid = false;
				CheckIdentifier(id);
			}
			num--;
		}
	}
	return valid;
} 