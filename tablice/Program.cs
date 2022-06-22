//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//for (int i = 0; i < uczestnicy.Length; i++)
//    Console.WriteLine(uczestnicy[i]);
//Console.ReadKey();
//int[] uczestnicy = { 19, 34, 23, 54, 31 };
//foreach (int x in uczestnicy)
//    Console.WriteLine(x);
//Console.ReadKey();

int[] uczestnicy = { 19, 34, 23, 54, 31 };
int suma = 0;
double srednia;
Console.Write("Wiek uczestników: ");
foreach (int x in uczestnicy)
{
    Console.Write("{0}, ", x);
    suma += x;
}
srednia = (double)suma / uczestnicy.Length;
Console.WriteLine();
Console.WriteLine("Średnia: {0}", srednia);
Console.ReadKey();
