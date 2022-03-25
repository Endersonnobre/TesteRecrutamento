using System;
using System.Collections.Generic;
using System.Text;

namespace TesteRecrutamento.src.Entities
{
    public class FindTarget
    {
        public int[] Numbers { get; set; }

        public int Target { get; set; }

        public FindTarget()
        {
                
        }

        public FindTarget(int range)
        {
            Numbers = new int[range];
        }

        public void insertNumber(int number, int pos)
        {
            Numbers[pos] = number;
        }

        public string Find(int target)
        {
            string sums = "";
            
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                while (count < Numbers.Length)
                {
                    if(i != count)
                    {
                        sums += Numbers[i] + Numbers[count] == target ? $"{Numbers[i]} na posição {i} do array + {Numbers[count]} na posição {count} do array \n" : string.Empty;
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return sums;
        }
    }
}
