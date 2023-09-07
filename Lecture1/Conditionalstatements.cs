using System;

	public class Conditionalstatements
	{
		public int InPutValue { get; set; }

		public Conditionalstatements(int inputvalue)
		{
			InPutValue = inputvalue;
		}
        // check the input number is smaller or larger then 10
		public void CheckInput()
		{
			if(InPutValue > 10)
			{
				Console.WriteLine($"Givenn Value is: {InPutValue} and it is Greater then 10");
			}
            else if (InPutValue < 10)
            {
                Console.WriteLine($"Givenn Value is: {InPutValue} and it is Smaller then 10");
            }
			else
			{
                Console.WriteLine($"Givenn Value is: {InPutValue}");
            }
        }
	}

