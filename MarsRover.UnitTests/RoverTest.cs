using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.UnitTests
{
    [TestClass]
    public class RoverTest
    {
        /// <summary>
        /// Case : Turn Right When Direction Is N
        /// Input : Direction = N
        /// Result : Direction = E
        /// </summary>
        [TestMethod]
        public void TurnRight_WhenDirectionIsNorth_NewDirectionIsEast()
        {
            Rover rover = new(5, 5, "N");
            rover.TurnRight();
            Assert.AreEqual("E", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Right When Direction Is E
        /// Input : Direction = E
        /// Result : Direction = S
        /// </summary>
        [TestMethod]
        public void TurnRight_WhenDirectionIsEast_NewDirectionIsSouth()
        {
            Rover rover = new(5, 5, "E");
            rover.TurnRight();
            Assert.AreEqual("S", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Right When Direction Is S
        /// Input : Direction = S
        /// Result : Direction = W
        /// </summary>
        [TestMethod]
        public void TurnRight_WhenDirectionIsSouth_NewDirectionIsWest()
        {
            Rover rover = new(5, 5, "S");
            rover.TurnRight();
            Assert.AreEqual("W", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Right When Direction Is W
        /// Input : Direction = W
        /// Result : Direction = N
        /// </summary>
        [TestMethod]
        public void TurnRight_WhenDirectionIsWest_NewDirectionIsNorth()
        {
            Rover rover = new(5, 5, "W");
            rover.TurnRight();
            Assert.AreEqual("N", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Left When Direction Is N
        /// Input : Direction = N
        /// Result : Direction = W
        /// </summary>
        [TestMethod]
        public void TurnLeft_WhenDirectionIsNorth_NewDirectionIsWest()
        {
            Rover rover = new(5, 5, "N");
            rover.TurnLeft();
            Assert.AreEqual("W", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Left When Direction Is E
        /// Input : Direction = E
        /// Result : Direction = N
        /// </summary>
        [TestMethod]
        public void TurnLeft_WhenDirectionIsEast_NewDirectionIsNorth()
        {
            Rover rover = new(5, 5, "E");
            rover.TurnLeft();
            Assert.AreEqual("N", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Left When Direction Is S
        /// Input : Direction = S
        /// Result : Direction = E
        /// </summary>
        [TestMethod]
        public void TurnLeft_WhenDirectionIsSouth_NewDirectionIsEast()
        {
            Rover rover = new(5, 5, "S");
            rover.TurnLeft();
            Assert.AreEqual("E", rover.Direction);
        }

        /// <summary>
        /// Case : Turn Left When Direction Is W
        /// Input : Direction = W
        /// Result : Direction = S
        /// </summary>
        [TestMethod]
        public void TurnLeft_WhenDirectionIsWest_NewDirectionIsSouth()
        {
            Rover rover = new(5, 5, "W");
            rover.TurnLeft();
            Assert.AreEqual("S", rover.Direction);
        }

        /// <summary>
        /// Case : Move Forward When Direction Is N And Y Coordinate Is 2
        /// Input : Direction = N 
        /// Input : Y Coordinate = 2
        /// Result : Y Coordinate = 3
        /// </summary>
        [TestMethod]
        public void MoveForward_WhenDirectionIsNorthAndYCoordinateIs2_NewYCoordinateIs3()
        {
            Rover rover = new(5, 5, "N");
            rover.Y = 2;
            rover.MoveForward();
            Assert.AreEqual(3, rover.Y);
        }

        /// <summary>
        /// Case : Move Forward When Direction Is S And Y Coordinate Is 2
        /// Input : Direction = S
        /// Input : Y Coordinate = 2
        /// Result : Y Coordinate = 1
        /// </summary>
        [TestMethod]
        public void MoveForward_WhenDirectionIsSouthAndYCoordinateIs2_NewYCoordinateIs1()
        {
            Rover rover = new(5, 5, "S");
            rover.Y = 2;
            rover.MoveForward();
            Assert.AreEqual(1, rover.Y);
        }

        /// <summary>
        /// Case : Move Forward When Direction Is W And X Coordinate Is 2
        /// Input : Direction = W
        /// Input : X Coordinate = 2
        /// Result : X Coordinate = 1
        /// </summary>
        [TestMethod]
        public void MoveForward_WhenDirectionIsWestAndXCoordinateIs2_NewXCoordinateIs1()
        {
            Rover rover = new(5, 5, "W");
            rover.X = 2;
            rover.MoveForward();
            Assert.AreEqual(1, rover.X);
        }

        /// <summary>
        /// Case : Move Forward When Direction Is E And X Coordinate Is 2
        /// Input : Direction = E
        /// Input : X Coordinate = 2
        /// Result : X Coordinate = 3
        /// </summary>
        [TestMethod]
        public void MoveForward_WhenDirectionIsEastAndXCoordinateIs2_NewXCoordinateIs3()
        {
            Rover rover = new(5, 5, "E");
            rover.X = 2;
            rover.MoveForward();
            Assert.AreEqual(3, rover.X);
        }

        /// <summary>
        /// Case : Check Direction Information When Direction Information Is LMLMLMLMM And Key Is LRM
        /// Input : Direction Information = LMLMLMLMM
        /// Input : Key = LRM
        /// Result : True
        /// </summary>
        [TestMethod]
        public void CheckDirectionInformation_WhenDirectionInformationOrValueIs_LMLMLMLMM_AndKeyIs_LRM_ReturnTrue()
        {
            Rover rover = new();
            var result = rover.CheckDirectionInformation("LRM", "LMLMLMLMM");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Case : Check Direction Information When Direction Information Is LMLMLMLMMTRS And Key Is LRM
        /// Input : Direction Information = LMLMLMLMMTRS
        /// Input : Key = LRM
        /// Result : False
        /// </summary>
        [TestMethod]
        public void CheckDirectionInformation_WhenDirectionInformationOrValueIs_LMLMLMLMMTRS_AndKeyIs_LRM_ReturnFalse()
        {
            Rover rover = new();
            var result = rover.CheckDirectionInformation("LRM", "LMLMLMLMMTRS");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Case : Check Direction Information When Direction Information Is N And Key Is NSWE
        /// Input : Direction Information = N
        /// Input : Key = NSWE
        /// Result : True
        /// </summary>
        [TestMethod]
        public void CheckDirectionInformation_WhenDirectionInformationOrValueIs_N_AndKeyIs_NSWE_ReturnTrue()
        {
            Rover rover = new();
            var result = rover.CheckDirectionInformation("NSWE", "N");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Case : Check Direction Information When Direction Information Is Y And Key Is NSWE
        /// Input : Direction Information = Y
        /// Input : Key = NSWE
        /// Result : False
        /// </summary>
        [TestMethod]
        public void CheckDirectionInformation_WhenDirectionInformationOrValueIs_Y_AndKeyIs_NSWE_ReturnFalse()
        {
            Rover rover = new();
            var result = rover.CheckDirectionInformation("NSWE", "Y");
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Case : Check Coordinate When X Coordinate Greater Than XMax
        /// Input : XMax = 5
        /// Input : X Coordinate = 6
        /// Result : X koordinatý aþýldý.
        /// </summary>
        [TestMethod]
        public void CheckCoordinate_WhenXGreaterThanXMax_Return_Xkoordinatýaþýldý()
        {
            Rover rover = new(6, 0, "E");
            rover.XMax = 5;
            var result = rover.CheckCoordinate();
            Assert.AreEqual("X koordinatý aþýldý.", result);
        }

        /// <summary>
        /// Case : Check Coordinate When Y Coordinate Greater Than YMax
        /// Input : YMax = 5
        /// Input : Y Coordinate = 6
        /// Result : Y koordinatý aþýldý.
        /// </summary>
        [TestMethod]
        public void CheckCoordinate_WhenYGreaterThanYMax_Return_Ykoordinatýaþýldý()
        {
            Rover rover = new(0, 6, "E");
            rover.YMax = 5;
            var result = rover.CheckCoordinate();
            Assert.AreEqual("Y koordinatý aþýldý.", result);
        }

        /// <summary>
        /// Case : Check Coordinate When Y Coordinate Greater Than YMax And X Coordinate Greater Than XMax
        /// Input : YMax = 5
        /// Input : Y Coordinate = 6
        /// Input : XMax = 5
        /// Input : X Coordinate = 6
        /// Result : X ve Y koordinatlarý aþýldý.
        /// </summary>
        [TestMethod]
        public void CheckCoordinate_WhenYGreaterThanYMaxAndXGreaterThanXMax_Return_XveYkoordinatlarýaþýldý()
        {
            Rover rover = new(6, 6, "E");
            rover.YMax = 5;
            rover.XMax = 5;
            var result = rover.CheckCoordinate();
            Assert.AreEqual("X ve Y koordinatlarý aþýldý.", result);
        }

        /// <summary>
        /// Case : Check Coordinate When X Coordinate Is 2 And Y Coordinate Is 2 And Direction Is E
        /// Input : X Coordinate = 2
        /// Input : Y Coordinate = 2
        /// Input : Direction = E
        /// Input : XMax = 5
        /// Input : YMax = 5
        /// Result : Rover Coordinate : 2 2 E
        /// </summary>
        [TestMethod]
        public void CheckCoordinate_WhenXCoordinateIs2AndYCoordinateIs2AndDirectionIsE_ReturnRoverCoordinate22E()
        {
            Rover rover = new(2, 2, "E");
            rover.YMax = 5;
            rover.XMax = 5;
            var result = rover.CheckCoordinate();
            Assert.AreEqual($"Rover Coordinate : 2 2 E", result);
        }

        /// <summary>
        /// Case : Calculate Direction When XMax Is 5 And YMax Is 5 And X Coordinate Is 1 And Y Coordinate Is 2 And Direction Is N And Move Informations Is LMLMLMLMM
        /// Input : X Coordinate = 1
        /// Input : Y Coordinate = 2
        /// Input : Direction = N
        /// Input : XMax = 5
        /// Input : YMax = 5
        /// Input : Move Informations = LMLMLMLMM
        /// Result : Rover Coordinate : 1 3 N
        /// </summary>
        [TestMethod]
        public void CalculateDirection_WhenXMaxIs5_And_YMaxIs5_And_XCoordinateIs1_And_YCoordinateIs2_And_DirectionIsN_And_MoveInformationIsLMLMLMLMM_Return_RoverCoordinate13N()
        {
            Rover rover = new(1, 2, "N");
            rover.YMax = 5;
            rover.XMax = 5;
            rover.CalculateDirection("LMLMLMLMM");
            Assert.AreEqual($"Rover Coordinate : 1 3 N", rover.ToString());
        }

        /// <summary>
        /// Case : Calculate Direction When XMax Is 5 And YMax Is 5 And X Coordinate Is 3 And Y Coordinate Is 3 And Direction Is E And Move Informations Is MMRMMRMRRM
        /// Input : X Coordinate = 3
        /// Input : Y Coordinate = 3
        /// Input : Direction = E
        /// Input : XMax = 5
        /// Input : YMax = 5
        /// Input : Move Informations = MMRMMRMRRM
        /// Result : Rover Coordinate : 5 1 E
        /// </summary>
        [TestMethod]
        public void CalculateDirection_WhenXMaxIs5_And_YMaxIs5_And_XCoordinateIs3_And_YCoordinateIs3_And_DirectionIsE_And_MoveInformationIsMMRMMRMRRM_Return_RoverCoordinate51E()
        {
            Rover rover = new(3, 3, "E");
            rover.YMax = 5;
            rover.XMax = 5;
            rover.CalculateDirection("MMRMMRMRRM");
            Assert.AreEqual($"Rover Coordinate : 5 1 E", rover.ToString());
        }
    }
}