using System;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Roll 5 Dice (Random Array?))))))))
            //Ask user to choose which dice to keep 
            //Roll remaining dice
            //Ask user to choose which dice to keep 
            //Roll remaining dice 
            //Count the number of dice rolled most 

            //Computer rolls dice 3 times
            //Each roll count number of die rolled most
            //Print winner with tie going to player
            //int die = 0;
            //int[] firstRoll = new int[6];

            int[] roll = new int[5];
            int die = 0;
            int[] rollKeep = new int[5];
            int[] secondRoll = new int[5];
            int[] thirdRoll = new int[5];
            int[] finalRoll = new int[5];
            int[] finalRollKeep = new int[5];
            int[] newRoll = new int[5];
            int userScore = 0;
            int[] firstComputerRoll = new int[5];
            int[] secondComputerRoll = new int[5];
            int[] finalComputerRoll = new int[5];
            int bestComputerScore = 0;
            int score = 0;
            
            

            Console.WriteLine("Let's Play Yahtzee!");

            roll = FirstRoll(roll, die);
            Console.WriteLine(String.Join(", ",roll));
            Console.WriteLine("Choose which number die you would like to keep.");
            int result = int.Parse(Console.ReadLine());

            secondRoll = RollKeep(roll, rollKeep, result);
            Console.WriteLine($"Your new roll including previously kept die is: " +
                $"\n{String.Join(", ",SecondRoll(die,secondRoll))}");

            thirdRoll = SecondRoll(die, secondRoll);
            Console.WriteLine("Choose which number die you would like to keep.");
            int newResult = int.Parse(Console.ReadLine());

            finalRoll = RollKeep(thirdRoll, finalRollKeep, newResult);
            finalRoll = SecondRoll(die, finalRoll);
            Console.WriteLine(String.Join(", ",finalRoll));
            
            Console.WriteLine($"Your final score is: {Counters(finalRoll)}");
            userScore = Counters(finalRoll);

            Console.Clear();
            Console.WriteLine("Now it's the computer's turn!");

            firstComputerRoll = FirstRoll(newRoll, die);
            Console.WriteLine(String.Join(", ", firstComputerRoll));

            int firstComputerRollTotal = Counters(firstComputerRoll);
            Console.WriteLine($"First score: {firstComputerRollTotal}");

            secondComputerRoll = FirstRoll(newRoll, die);
            Console.WriteLine(String.Join(", ", secondComputerRoll));

            int secondComputerRollTotal = Counters(secondComputerRoll);
            Console.WriteLine($"Second score: {secondComputerRollTotal}");

            finalComputerRoll = FirstRoll(newRoll, die);
            Console.WriteLine(String.Join(", ", finalComputerRoll));

            int finalComputerRollTotal = Counters(finalComputerRoll);
            Console.WriteLine($"Third score: {finalComputerRollTotal}");



            if (firstComputerRollTotal >= secondComputerRollTotal)
            {
                score = firstComputerRollTotal;
            }
            else if (secondComputerRollTotal < firstComputerRollTotal)
            {
                score = secondComputerRollTotal;
            }

            if (score >= finalComputerRollTotal)
            {
                bestComputerScore = score;
            }
            else if (score < finalComputerRollTotal)
            {
                bestComputerScore = finalComputerRollTotal;
            }

            Console.WriteLine($"The highest computer score is {bestComputerScore}");
            Console.WriteLine($"Your score was {userScore}");

            if (userScore >= bestComputerScore)
            {
                Console.WriteLine("You are the winner!");
            }
            else if (bestComputerScore > userScore)
            {
                Console.WriteLine("You lose. Better luck next time!");
            }



        }

        public static int[] FirstRoll(int[] roll, int die)
        {
          
            for (int i = 0; i < roll.Length; i++)
            {

                die = new Random().Next(1, 7);
                roll.SetValue(die, i);
                
            }
             
            return roll;
       
        }

        public static int[] SecondRoll(int die, int[] secondRoll)
        {
            for (int i = 0; i < secondRoll.Length; i++)
            {
                if (secondRoll[i] == 0)
                {
                    die = new Random().Next(1, 7);
                    secondRoll.SetValue(die, i);
                }

            }
            return secondRoll;
        }

        

        public static int[] RollKeep(int[] roll, int[] rollKeep, int result)
        {
         
            if (result == 1)
            {
                for (int i = 0; i < rollKeep.Length; i++)
                {
                    if (roll[i] == 1)
                    {
                        rollKeep.SetValue(1, i);
                    }

                }

            }
            else if (result == 2)
            {
                for (int i = 0; i < rollKeep.Length; i++)
                {
                    if (roll[i] == 2)
                    {
                        rollKeep.SetValue(2, i);
                    }
                    
                }
            }
            else if (result == 3)
            {
                for (int i = 0; i < rollKeep.Length; i++)
                {
                    if (roll[i] == 3)
                    {
                        rollKeep.SetValue(3, i);
                    }
                    
                }

            }
            else if (result == 4)
            {
                for (int i = 0; i < rollKeep.Length; i++)
                {
                    if (roll[i] == 4)
                    {
                        rollKeep.SetValue(4, i);
                    }
                    
                }

            }
            else if (result == 5)
            {
                for (int i = 0; i < rollKeep.Length; i++)
                {
                    if (roll[i] == 5)
                    {
                        rollKeep.SetValue(5, i);
                    }
                   
                }

            }
            else if (result == 6)
            {
                for (int i = 0; i < rollKeep.Length; i++)
                {
                    if (roll[i] == 6)
                    {
                        rollKeep.SetValue(6, i);
                    }
                   
                }

            }
            return rollKeep;
        }

        public static int Counters(int[] finalRoll)
        {
            int counterOne = 0;
            int counterTwo = 0;
            int counterThree = 0;
            int counterFour = 0;
            int counterFive = 0;
            int counterSix = 0;
            for (int i = 0; i < finalRoll.Length; i++)
            {
                if (finalRoll[i] == 1)
                {
                    counterOne++;
                }
                else if (finalRoll[i] == 2)
                {
                    counterTwo++;
                }
                else if (finalRoll[i] == 3)
                {
                    counterThree++;
                }
                else if (finalRoll[i] == 4)
                {
                    counterFour++;
                }
                else if (finalRoll[i] == 5)
                {
                    counterFive++;
                }
                else if (finalRoll[i] == 6)
                {
                    counterSix++;
                }
            }

            int[] totalCount = new int[] {counterOne, counterTwo,
                counterThree, counterFour, counterFive, counterSix };
            int biggestNumber = 0;

            for (int i = 0; i < totalCount.Length; i++)
            {
                if (totalCount[i] > biggestNumber)
                {
                    biggestNumber = totalCount[i];
                }
            }
            return biggestNumber;


        }




    }
}
