using System;

namespace myApp 
{
    public class Agent 
    {
        public string SecurityLevel { get; set; }
        public int number { get; set; }

        public Agent(int number)
        {
            this.number = number;
        }
    }
}