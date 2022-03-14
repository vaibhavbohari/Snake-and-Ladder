Console.WriteLine("Welcome To Snake And Ladder");



const int NO_PLAY = 0,
                   LADDER = 1,
                   SNAKE = 2;
         int positionOne =0,
             positionTwo = 0,
             loopCount = 0,
             currentPlayer = 1,
             currentPlayerPos = 0;

         Random random = new Random();

while(positionOne < 100 && positionTwo <100)
{
    loopCount++;
    if (currentPlayerPos == 1)
    {
        currentPlayerPos = positionOne;
    }
    else
    {
        currentPlayerPos = positionTwo;

    }

    int diceNum = random.Next(0, 7),
    result = random.Next(0, 3);
    
    if(result ==LADDER)
    {
{
        if (currentPlayerPos + diceNum <= 100)
            {
                currentPlayerPos += diceNum;
            }
    else if (result ==SNAKE)
        if (currentPlayerPos - diceNum >=0)

            { 
                currentPlayerPos -= diceNum;
            }
        else    
            {
                    currentPlayerPos = 0;
            }

        }
        if(currentPlayer == 1)
        {
            positionOne = currentPlayerPos;
            currentPlayer = 2;
        }
        else
        {    
            positionTwo = currentPlayerPos;
            currentPlayer = 1;
        }
     }
}

if (positionOne == 100)
{
    Console.WriteLine("Player One Wins");
}
else if (positionTwo ==100)
{
    Console.WriteLine("Player Two Wins");
}
Console.WriteLine("Dice Rolled :" + loopCount + "times");



