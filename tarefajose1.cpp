#include <iostream>
using namespace std;
int reverso(int num){
    int reverso = 0;
    while(num>0){
    int digito = num % 10;
    reverso = reverso*10 + digito;
    num /= 10;
    }
    return reverso;
}
int main(){
    int numero;
    cout << "digite um numero: ";
    cin >> numero;
    cout << "o reverso de: " << numero << "é: " << reverso(numero);
    return 0;
}