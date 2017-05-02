// Brandon Oden
// COSC 1437
// Program 4.3

#include <iostream>
#include <string>

using namespace std;

void getChange(double);


int main()
{
	double amount = 0.0;
	while (!(amount >= 0.01 && amount <= 9.99)) {
		cout << "Enter the amount (double): ";
		cin >> amount;
	}
	getChange(amount);

	return 0;
}

void getChange(double total) {
	int temp = total*100;
	double changemade = 0.0;
	string names[7] = { "dollar", "half-dollar", "quarter", "dime", "nickel", "penny", "pennies" };
	int change[6] = { 0,0,0,0,0,0 };
	double values[6] = { 100, 50, 25, 10, 5, 1 };
	for (int i = 0; i < 6; i++) {
		while (temp>=values[i]) {
			change[i]++;
			changemade+=values[i]/100;
			temp-=values[i];

		}
		if (change[i]>1) {
			names[i]+="s";
		}
	}
	if (change[5]>1) {names[5]=names[6]; }
	cout << "Change returned: " << endl;
	for (int i = 0; i < 6; i++) {
		if (change[i]) {
			cout << change[i] << " " << names[i] << endl;
		}
	}
	if (changemade) { return; }
	else { getChange(total); }
}

