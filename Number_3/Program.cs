Console.Write("Введи длину масива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n ; i++)
    array[i] = int.Parse(Console.ReadLine());
    
string arrayString = "[" + string.Join(", ", array) + "]";

Console.WriteLine("Введенный массив: " + arrayString);