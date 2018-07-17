using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
            int hammingDistance = 0;
            if(original == null)
            {
                throw new System.ArgumentNullException("original");
            }
            else if (current == null)
            {
                throw new System.ArgumentNullException("current");
            }
            else if (original.Length != current.Length) {
                throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
            }
            else
            {
                for (int i = 0; i < original.Length; i++)
                {
                    if (current[i] != original[i])
                    {
                        hammingDistance++;
                    }
                }
            }
       
            return hammingDistance;
        }
    }
}
