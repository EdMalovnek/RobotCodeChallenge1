using System;
using System.Text.RegularExpressions;

namespace RobotCodeChallenge
{
    public class Class1
    {
        static void Main(string[] args)
        {
            /*
             * CODE CHALLENGE INSTRUCTIONS:
             * 
             * Table must be 5 x 5
             * PLACE X,Y,F - places the robot
             * MOVE - moves robot once in direction its facing
             * LEFT - makes robot rotate 90 degrees to the left
             * RIGHT - makes robot rotate 90 degrees to the right
             * REPORT - stops prgram and displays current coordinates
             */

            int posX = 0; //position of Robot on x axis
            int posY = 0; //position of Robot on y axis
            string[] splitInput; //stores the user's PLACE command
            string[] directions = { "NORTH", "EAST", "SOUTH", "WEST" };
            Regex pattern = new Regex(@"\b(\w*PLACE\w*)\b\s\d,\d,\b(?:NORTH|SOUTH|EAST|WEST)\b"); //ensures the user inputs the right command syntax for PLACE

            bool offTable = false;
            string input = ""; //the user's input
            string facing = ""; //which way the Robot is facing

            /*
             * Welcome Message and Instuctions
             */
            Console.WriteLine("Welcome to, Move the Robot. " +
                "\nTo place the robot, type 'PLACE X,Y,F' " +
                "\nWhere X, and Y are coordinates and F in the cardinal direction the robot will face. " +
                "\nType 'REPORT' at any point to end the program and display the robot's position. " +
                "\nType 'quit' to exit program"
                );

            while (!pattern.IsMatch(input))
            {
                input = Console.ReadLine();

                splitInput = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (pattern.IsMatch(input))
                {
                    posX = Int32.Parse(splitInput[1]);
                    posY = Int32.Parse(splitInput[2]);
                    facing = splitInput[3];

                    //Console.WriteLine("Robot placed at (" + posX + ", " + posY + ") facing " + facing.ToLower());

                    if (posX > 5 || posY > 5 || posX < 0 || posX < 0)
                    {
                        offTable = true;
                    }
                    else
                    {
                        offTable = false;
                    }
                }
                else if (input == "quit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }

            while (true)
            {
                input = Console.ReadLine();

                if (pattern.IsMatch(input))
                {
                    splitInput = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    posX = Int32.Parse(splitInput[1]);
                    posY = Int32.Parse(splitInput[2]);
                    facing = splitInput[3];

                    //Console.WriteLine("Robot placed at (" + posX + ", " + posY + ") facing " + facing.ToLower());

                    if (posX > 5 || posY > 5 || posX < 0 || posX < 0)
                    {
                        offTable = true;
                    }
                    else
                    {
                        offTable = false;
                    }
                }
                else if (input == "MOVE")
                {
                    if (offTable != true)
                    {
                        switch (facing)
                        {
                            case "NORTH":
                                posY++;
                                break;

                            case "SOUTH":
                                posY--;
                                break;

                            case "EAST":
                                posX++;
                                break;

                            case "WEST":
                                posX--;
                                break;
                        }

                        if (posX > 5)
                        {
                            posX = 5;
                        }

                        if (posY > 5)
                        {
                            posY = 5;
                        }

                        if (posX < 0)
                        {
                            posX = 0;
                        }

                        if (posY < 0)
                        {
                            posY = 0;
                        }

                        //Console.WriteLine("Robot is currently at position: (" + posX + ", " + posY + ") facing " + facing.ToLower());
                    }
                    else
                    {
                        Console.WriteLine("Robot is off the table, please use PLACE command to place it on the table again.");
                    }
                }
                else if (input == "LEFT")
                {
                    if (offTable != true)
                    {
                        switch (facing)
                        {
                            case "NORTH":
                                facing = "WEST";
                                break;

                            case "SOUTH":
                                facing = "EAST";
                                break;

                            case "EAST":
                                facing = "NORTH";
                                break;

                            case "WEST":
                                facing = "SOUTH";
                                break;
                        }
                    }
                }

                else if (input == "RIGHT")
                {
                    if (offTable != true)
                    {
                        switch (facing)
                        {
                            case "NORTH":
                                facing = "EAST";
                                break;

                            case "SOUTH":
                                facing = "WEST";
                                break;

                            case "EAST":
                                facing = "SOUTH";
                                break;

                            case "WEST":
                                facing = "NORTH";
                                break;
                        }
                    }
                }
                else if (input == "REPORT")
                {
                    Console.WriteLine(posX + "," + posY + "," + facing);
                }
                else if (input == "quit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
        }
    }
}
