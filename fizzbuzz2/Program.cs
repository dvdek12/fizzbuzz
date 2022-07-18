// See https://aka.ms/new-console-template for more information


for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(new FizzBuzz(i).value);
}



class FizzBuzz
{
    public string value { get; set; }
    public FizzBuzz(int value)
    {
        if(value % 3 == 0)
        {
            this.value = "Fizz";
        }else if(value % 5 == 0)
        {
            this.value = "Buzz";
        } else if(value % 3 == 0 && value % 5 == 0)
        {
            this.value = "FizzBuzz";
        }
        else
        {
            this.value = value.ToString();
        }
    }
}
