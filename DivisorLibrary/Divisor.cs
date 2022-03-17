namespace DivisorLibrary
{
    public class Divisor
    {

        public static DivisorParameter GetPrimesAndDivisorsNumbers(DivisorParameter parameter)
        {
            DivisorParameter newParameter = parameter;

            if (parameter.EntryNumber >= 1)
            {
                for (int i = 1; i <= (parameter.EntryNumber / 2); i++)
                {
                    if (parameter.EntryNumber % i == 0)
                    {
                        var result = GetPrimesAndDivisorsNumbers(new DivisorParameter(i));
                        if (result.Divisors.Count == 2)
                            newParameter.Primes.Add(i);

                        newParameter.Divisors.Add(i);
                    }
                }
                newParameter.Divisors.Add(parameter.EntryNumber);

                if (newParameter.Divisors.Count == 2)
                    newParameter.Primes.Add(parameter.EntryNumber);
            }

            return newParameter;
        }
    }
}

