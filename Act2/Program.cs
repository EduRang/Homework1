int[] numbers = new int[20];
int opera2 = 1;


for (int i = 0; i < 3; i++){
    Console.Write($"Ingrese el numero {i+1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    opera2 *= numbers[i];
}

int opera1 = numbers[0] + numbers[1] - numbers[2];
int opera3 = numbers[1] % numbers[2];

bool contraste_1 = numbers[0] == numbers[2];
bool contraste_2 = numbers[0] > numbers[1] || numbers[0] > numbers[2];
bool contraste_3 = contraste_1 == contraste_2;


Console.WriteLine("OPERACIONES");
Console.WriteLine(opera1);
Console.WriteLine(opera2);
Console.WriteLine(opera3);

Console.WriteLine("CONTRASTES");
Console.WriteLine(contraste_1);
Console.WriteLine(contraste_2);
Console.WriteLine(contraste_3);