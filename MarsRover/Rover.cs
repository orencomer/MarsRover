using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MarsRover
{
    public class Rover
    {
        /// <summary>
        /// It is the data indicating the position that should be according to the current position when the rover turns to the right.
        /// </summary>
        private readonly Dictionary<string, string> TurnRightDatas = new()
        {
            { "N", "E" },
            { "S", "W" },
            { "W", "N" },
            { "E", "S" }
        };

        /// <summary>
        /// It is the data indicating the position that should be according to the current position when the rover turns to the left.
        /// </summary>
        private readonly Dictionary<string, string> TurnLeftDatas = new()
        {
            { "N", "W" },
            { "S", "E" },
            { "W", "S" },
            { "E", "N" }
        };

        /// <summary>
        /// It is the data that is added or subtracted from the X or Y coordinates according to the position when the rover is commanded to move forward.
        /// </summary>
        private readonly Dictionary<string, int> MoveForwardDatas = new()
        {
            { "N", 1 },
            { "S", -1 },
            { "W", -1 },
            { "E", 1 }
        };

        public Rover(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction.ToUpper();
        }

        public Rover()
        {

        }

        /// <summary>
        /// Rover Horizontal Coordinate
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Expresses the maximum value of the X coordinate
        /// </summary>
        public int XMax { get; set; }
        /// <summary>
        /// Rover Vertical Coordinate
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Expresses the maximum value of the Y coordinate
        /// </summary>
        public int YMax { get; set; }
        /// <summary>
        /// Rover Direction
        /// </summary>
        public string Direction { get; set; }

        public void MoveForward()
        {
            switch (Direction)
            {
                case "N":
                case "S":
                    Y += MoveForwardDatas[Direction];
                    break;
                case "W":
                case "E":
                    X += MoveForwardDatas[Direction];
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            Direction = TurnRightDatas[Direction];
        }

        public void TurnLeft()
        {
            Direction = TurnLeftDatas[Direction];
        }

        public bool CheckDirectionInformation(string key, string value)
        {
            return string.IsNullOrEmpty(new Regex(@$"[{key}]").Replace(value, string.Empty));
        }

        public void CalculateDirection(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                switch (value[i].ToString())
                {
                    case "L":
                        TurnLeft();
                        break;
                    case "R":
                        TurnRight();
                        break;
                    case "M":
                        MoveForward();
                        break;
                    default:
                        break;
                }
            }
        }

        public override string ToString() => CheckCoordinate();

        public string CheckCoordinate()
        {
            if ((X > XMax || X < 0) && (Y > YMax || Y < 0))
            {
                return "X ve Y koordinatları aşıldı.";
            }
            else if (X > XMax || X < 0)
            {
                return "X koordinatı aşıldı.";
            }
            else if (Y > YMax || Y < 0)
            {
                return "Y koordinatı aşıldı.";
            }
            return $"Rover Coordinate : {X} {Y} {Direction}";
        }
    }
}