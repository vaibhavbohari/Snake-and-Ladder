// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Welcome to Snake And Ladder ");

const int NO_PLAY = 1;
const int LADDER = 2;
const int SNAKE = 3;
int playerOnePosition = 0;
Random random = new Random();
int dieRoll;
dieRoll = random.Next(1, 7);
int check = random.Next(1, 4);
switch (check)
{
    case NO_PLAY:
        playerOnePosition = playerOnePosition + 0;
        break;
    case LADDER:
        playerOnePosition = playerOnePosition + dieRoll;
        break;
    case SNAKE:
        playerOnePosition = playerOnePosition - dieRoll;
        if (playerOnePosition < 0)
            playerOnePosition = 0;
        break;
}
Console.WriteLine("Position of Player 1 is at " + playerOnePosition);
       

























































































// See https://aka.ms/new-console-template for more information
//Console.WriteLine(" Welcome to Snake And Ladder ");

//Random random = new Random();


//const int NO_PLAY = 0,
//      LADDER = 1,
//      SNAKE = 2;


//int check_Player_Option = random.Next(0, 3);
//int player_Move = 0;
//int player_Roll_Dice =0;
////switch (check_Player_Option)
//{
// case LADDER:
//     player_Move = player_Roll_Dice;
//   Console.WriteLine("the player moves ahead ");
//     break;
//
//  case SNAKE:
//     player_Move = player_Roll_Dice;
//      Console.WriteLine("the player moves behind ");
//      break;
//   default:
//  Console.WriteLine("No play the player ");

//    break;
//}//
//return player_Move;
//Console.WriteLine("Player Dice value is " + player_Roll_Dice);

























// The Player then checks for a Option. They are No Play,Ladder or Snake.
//int player_move = Player_Move_Option(player_Roll_Dice);
//player_Next_Position = player_position + player_move;
//if (player_Next_Position < START)
//player_position = START;
//else
//  player_position = player_Next_Position;r
//Co//nsole.WriteLine("Player current position After rolling the Dice is " + player_position);













