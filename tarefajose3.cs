using System;
static bool cadastrarHeroi(ref string nome1, ref string poder1,  ref int pontuacao1, ref string nome2, ref string, ref string poder2, ref int pontuacao2, ref string nome3, ref string poder3, ref int pontuacao3, ref string nome4, ref string poder4, ref int pontuacao4, ref string nome5, ref string poder5, ref int pontuacao5){
Console.WriteLine("cadastre um herói");
if(nome1 == " "){
    Console.WriteLine("digite o nome do herói: ");
    nome1 = Console.ReadLine(); 
    Console.WriteLine("digite o poder do herói: ");
    poder1 = Console.ReadLine();
    Console.WriteLine("pontuação do herói: ")
    pontuacao1 = int.Parse(Console.ReadLine());
    Console.WriteLine("herói cadastrado! ");
    return true;
}
else if(nome2 == " ")
{
    Console.WriteLine("digite o segundo herói: ");
    nome2 = Console.ReadLine();
    Console.WriteLine("digite o poder dele: ");
    poder2 = Console.ReadLine();
    Console.WriteLine("digite a pontuação dele: ");
    pontuacao2 = Console.ReadLine();
    Console.WriteLine("herói cadastrado!");
    return true;
}
else if(nome3 == " ")
{
 Console.WriteLine("digite o nome do terceiro herói: ");
 nome3 = Console.ReadLine();
 Console.WriteLine("digite o poder dele: ");
 poder3 = Console.ReadLine();
 Console.WriteLine("digite a pontuação dele: ");
 pontuacao3 = Console.ReadLine();
 Console.WriteLine("seu herói foi cadastrado!");
 return true;
}
else if(nome4 == " ")
{
    Console.WriteLine("digite o quarto herói: ");
    nome4 = Console.ReadLine();
    Console.WriteLine("digite o poder dele: ");
    poder4 = Console.ReadLine();
    Console.WriteLine("digite a pontuação dele: ");
    pontuacao4 = Console.ReadLine();
    Console.WriteLine("seu herói foi cadastrado!");
    return true;
}
else if(nome5 == " ")
{
    Console.WriteLine("digite o quinto herói: ");
    nome5 = Console.ReadLine();
    Console.WriteLine("digite o poder dele: ");
    poder5 = Console.ReadLine();
    Console.WriteLine("digite a pontuação dele: ");
    pontuacao5 = Console.ReadLine();
    Console.WriteLine("seu herói foi cadastrado!");
    return true;
}    
else{
    return false;
}
}
static void selecionarEquipe(ref string heroi1, ref string heroi2, ref string heroi3, string nome1, string nome2, string nome3, string nome4, string nome5){
    Console.WriteLine("seleção de equipe: ");
    Console.Writeline("heróis disponiveis");
    if(nome1 !=  " "){
    Console.WriteLine($"1. {nome1}");
    }
    if(nome2 != " "){
    Console.WriteLine($"2. {nome2}");
    }
    if(nome3 != " "){
    Console.WriteLine($"3. {nome3}");
    }
    if(nome4 != " "){
    Console.WriteLine($"4. {nome4}");
    }
    if(nome5 != " "){
    Console.WriteLine($"5. {nome5}");
    }
Console.WriteLine("selecione 3 heróis para sua equipe");
Console.Writeline("herói1: ");
heroi1 = Console.ReadLine();
Console.WriteLine("herói2: ");
heroi2 = Console.ReadLine();
Console.WriteLine("herói3: ");
heroi3 = Console.ReadLine();
static void exibirEquipe(string heroi1, string heroi2, string heroi3, string poder1, string poder2, string poder3, string poder4, string poder5, int pontuacao1, int pontuacao2, int pontuacao3, int pontuacao4, int pontuacao5){
Console.WriteLine("a equipe foi montada! ");
Console.WriteLine($"nome do herói: {heroi1}, poder do herói: {poder1}, pontuação do herói: {pontuacao1}  ");
Console.WriteLine($"nome do herói: {heroi2}, poder do herói: {poder2}, pontuação do herói: {pontuacao2}  ");
Console.WriteLine($"nome do herói: {heroi3}, poder do herói: {poder3}, pontuação do herói: {pontuacao3}  ");
}
class Program{
    static void Main(string[]args){
        bool sair = false;
        int opcao;
        string nome1 = " ",nome2 = " ",nome3 " ",nome4 = " ",nome5 = " ";
        string poder1 = " ", poder2 = " ", poder3  = " ", poder4 = " ", poder5 = " "; 
        int pontuacao1 = 0, pontuacao2 = 0, pontuacao3 = 0, pontuacao4 = 0, pontuacao5 = 0;
        string heroi1 = " ", heroi2 = " ", heroi3 = " ";
        while(!sair){
            Console.WriteLine("1. cadastrar herói");
            Console.WriteLine("2. cadastrar poder");
            Console.WriteLine("3. cadastrar equipe");
            Console.WriteLine("4. sair");
            Console.WriteLine("escolha uma opção");
            Console.ReadLine(opcao);
            switch(opcao){
                case 1:
                
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
            }
    }