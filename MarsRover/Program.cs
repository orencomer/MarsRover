using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                bool isDirection = true;
                bool isValidCoordinate = true;
                try
                {
                    Console.WriteLine("***************************");
                    Rover rover = new();
                    Console.Write("XMax :");
                    rover.XMax = Convert.ToInt32(Console.ReadLine());
                    Console.Write("YMax :");
                    rover.YMax = Convert.ToInt32(Console.ReadLine());
                    while (isValidCoordinate)
                    {
                        Console.Write("X Coordinate :");
                        int coordinate = Convert.ToInt32(Console.ReadLine());
                        if (coordinate <= rover.XMax)
                        {
                            isValidCoordinate = !isValidCoordinate;
                            rover.X = coordinate;
                        }
                    }
                    isValidCoordinate = true;
                    while (isValidCoordinate)
                    {
                        Console.Write("Y Coordinate :");
                        int coordinate = Convert.ToInt32(Console.ReadLine());
                        if (coordinate <= rover.YMax)
                        {
                            isValidCoordinate = !isValidCoordinate;
                            rover.Y = coordinate;
                        }
                    }                    
                    while (isDirection)
                    {
                        Console.Write("Direction (N,S,W,E) :");
                        var direction = Console.ReadLine().ToUpper();
                        if (direction.Length == 1 && rover.CheckDirectionInformation("NSWE", direction))
                        {
                            isDirection = !isDirection;
                            rover.Direction = direction;
                        }
                    }
                    isDirection = true;
                    while (isDirection)
                    {
                        Console.Write("Move Information (L,R,M) :");
                        var moveInformation = Console.ReadLine().ToUpper();
                        if (rover.CheckDirectionInformation("LRM", moveInformation))
                        {
                            isDirection = !isDirection;
                            rover.CalculateDirection(moveInformation);
                            Console.WriteLine(rover.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}