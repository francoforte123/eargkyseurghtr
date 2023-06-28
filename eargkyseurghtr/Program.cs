/*
 scriviamo tre versioni: 
    la prima scrivendo le funzioni in se per se, 
    la seconda tramite l'ordinamento e prendendo i valori ordinati,
    la terza tramite le funzioni della libreria Math
*/
using eargkyseurghtr;

Min_Max min_max = new Min_Max();

List<int> ListOfNumbers=  new List<int>();
Random random= new Random();
int number=0;

for (int i = 0; i < 1000; i++)
{
    Random rnd = new Random();
    number = rnd.Next(0, 1000);
    ListOfNumbers.Add(number);
}

Console.WriteLine("i numeri random presenti nella lista sono:");

foreach (int i in ListOfNumbers)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");

int NumberMin = min_max.MinNumber(ListOfNumbers);
int NumberMax = min_max.MaxNumber(ListOfNumbers);

Console.WriteLine("questa è la versione con l'uso delle due funzioni scritte direttamente");
Console.WriteLine("il numero più piccolo della lista è " + NumberMin);
Console.WriteLine("il numero più grande della lista è " + NumberMax);
Console.WriteLine("\n");

Console.WriteLine("---------------------------------------------------");

Console.WriteLine("questa è la versione con l'uso dell'ordinamento andando a selezionare il primo numero e l'ultmo numero dell'array");
int[] ArrayNumbers= new int[1000];

ArrayNumbers = ListOfNumbers.ToArray();
Array.Sort(ArrayNumbers);

foreach(int x in ArrayNumbers)
{
    Console.WriteLine(x);
}

int MinNumberOfArray = ArrayNumbers[0];
int ManNumberOfArray= ArrayNumbers[ArrayNumbers.Length-1];

Console.WriteLine("il numero piccolo è " + MinNumberOfArray);
Console.WriteLine("il numero grande è " + ManNumberOfArray);
Console.WriteLine("\n");


Console.WriteLine("---------------------------------------------------");


Console.WriteLine("questa è la versione tramite l'uso delle funzioni della libreria Math");

/*
    volevo provare ad usare i metodi della libreria ma servono due parametri, e io ho solo una lista 
int min = Math.Min(ListOfNumbers);
int man= Math.Min(ListOfNumbers);


Console.WriteLine("il numero piccolo è " + min);
Console.WriteLine("il numero grande è " + max);
*/





