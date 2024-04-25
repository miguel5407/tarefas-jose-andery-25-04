    #include <iostream>
#include <cmath>
using namespace std;
double calcMediaPares(int quant){
    int num;
    double soma = 0;
    int cont = 0;
    cout << "digite: " << quant << " numeros" << endl;
    for(int i = 0; i < quant; i++){
        cin >> num;
        if(num % 2 == 0){
            soma = num+soma;
            cont++;
            //lógica que fizemos
        }
        if(cont == 0){
            cout << "nenhum numero par foi inserido";
            return 0;
        }
    }
    return soma / cont;
}
int calcSomaDigitoQuadrados(int numero){
    int quad = pow(numero,2);
    int soma = 0;
    while(quad != 0){
        soma += quad % 10;
        quad /= 10;
        //fizemos a segunda lógica
    }
    return  soma;
}
int calcsomaImparMultiplo3(){
    int soma = 0;
    for(int i = 51; i < 500; i = i + 2){
        if(i % 3 == 0){
            soma += i;
            //a terceira lógica tbm
        }
    }
    return soma;
}
int main(){
    int quant;
    int num;
    int escolha;
    while(true){
    cout << "menu: " << endl;
    cout << "1. calcular soma dos numeros pares" << endl;
    cout << "2. calcular soma dos digitos do do quadrado de um numero" << endl;
    cout << "3. calcular soma de impares multiplos de 3" << endl;
    cout << "4. sair" << endl;
    cout << "escolha uma opção";
    cin >> escolha;
    switch(escolha){
        case 1:
        cout << "digite a quantidade de numeros: " << endl;
        cin >> quant;
        cout << "voce digitou a função 1" << calcMediaPares(quant) << endl;
        break;
        case 2:
        cout << "digite um numero";
        cin >> num;
        cout << "voce digitou a função 2 e ela retornou: " << calcSomaDigitoQuadrados(num) << endl;
        break;
        case 3:
        cout << "voce digitou a função 3 e ela retornou o valor de: " << calcsomaImparMultiplo3() << endl;
        case 4:
        cout << "fim do programa" << endl;
    }
return 0;
}
}