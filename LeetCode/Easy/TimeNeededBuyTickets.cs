using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class TimeNeededBuyTickets
    {

        public int TimeRequiredToBuyWithQueue(int[] tickets, int k)
        {
            Queue<int> queue = new Queue<int>();
            int seconds = 0;

            while (true)
            {
                int requests = queue.Dequeue()-1;
                seconds++;

                if (requests == 0 && k == 0) {
                    return seconds;
                }

                if (requests > 0)
                {
                    queue.Enqueue(requests);
                }

                if (k == 0) { 
                    k = queue.Count-1;
                } else
                {
                    k--;
                }
            }

            return seconds;
        }

        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            var res = 0;
            var ticketKValue = tickets[k];

            for (int i = 0; i < tickets.Length; i++)
            {
                var value = Math.Min(tickets[i], ticketKValue - 1);
                tickets[i] -= value;
                res += value;
            }

            for (int i = 0; i <= k; i++)
            {
                res += Math.Min(tickets[i], 1);
            }

            return res;
        }
        public int TimeRequiredToBuyBruteForce(int[] tickets, int k)
        {
            int timeCount = 0;
            int index = 0;
            while (tickets[k] > 0)
            {
                if (tickets[k] == 0) break;
                
                if (tickets[index] > 0)
                {
                    tickets[index]--;
                    timeCount++;
                }

                index++;
                if(index == tickets.Length)
                    index = 0;
            }

            return timeCount;
        }
    }
}
