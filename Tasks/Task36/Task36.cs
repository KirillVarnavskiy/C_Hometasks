Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Resulting array: ");
PrintArray(numbers);
int sum = 0;

for (int a = 1; a < numbers.Length; a+=2)
    sum = sum + numbers[a];

    Console.WriteLine($"Sum of elements of an array of odd positions = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}