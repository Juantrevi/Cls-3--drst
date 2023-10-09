using Class3.lottery;

List<int> num = new List<int>();
NumberGenerator number = new NumberGenerator();
int generatedValue;

for (int i = 0; i < 6; i++)
{
    generatedValue = number.random();

    while (num.Contains(generatedValue)){
        generatedValue = number.random();
    }

    num.Add(generatedValue);
}

foreach (int var in num)
{
    Console.WriteLine(var.ToString());
}