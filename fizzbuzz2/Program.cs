for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(new FizzBuzz(i).Value);
}

class FizzBuzz
{
    public string Value { get; set; }
    public FizzBuzz(int value)
    {
        if(value % 3 == 0 && value % 5 == 0)
        {
            this.Value = "FizzBuzz";
        }
        else if(value % 5 == 0)
        {
            this.Value = "Buzz";
        } 
        else if(value % 3 == 0)
        {
            this.Value = "Fizz";
        }
        else
        {
            this.Value = value.ToString();
        }
    }
}
