using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DivisorLibrary
{
    public class DivisorParameter
    {
        public List<int> Divisors { get; private set; }

        public List<int> Primes { get; private set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "The value entered must be a number and greater than 1.")]
        public int EntryNumber { get; set; }

        public DivisorParameter()
        {
            Divisors = new List<int>();
            Primes = new List<int>();
        }

        public DivisorParameter(int entryNumber)
        {
            EntryNumber = entryNumber;
            Divisors = new List<int>();
            Primes = new List<int>();
        }

        public DivisorParameter(int entryNumber, List<int> divisors, List<int> primes)
        {
            EntryNumber = entryNumber;
            Divisors = divisors;
            Primes = primes;
        }
    }
}