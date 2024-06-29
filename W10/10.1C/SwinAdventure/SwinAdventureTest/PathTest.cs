using SwinAdventure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Path = SwinAdventure.Path;

namespace SwinAdventureTest
{
    public class PathTest
    {
        Player _testPlayer;
        Location _testMyRoom;
        Location _testYourRoom;
        Path _testPath;

        [Test]
        public void TestPathLocation()
        {
            _testPlayer = new Player("Thi", "The Player!");

            _testMyRoom = new Location("My Room", "My Room");
            _testYourRoom = new Location("Your Room", "Your Room");

            _testPlayer.Location = _testMyRoom;
            _testPath = new Path(new string[] { "left" }, "Door", "A test door", _testMyRoom, _testYourRoom);
            _testMyRoom.AddPath(_testPath);

            Location _expected = _testYourRoom;
            Location _actual = _testPath.Destination;

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void TestPathName()
        {
            _testPlayer = new Player("Thi", "The Player!");

            _testMyRoom = new Location("My Room", "My Room");
            _testMyRoom = new Location("Your Room", "Your Room");

            _testPlayer.Location = _testMyRoom;
            _testPath = new Path(new string[] { "left" }, "Door", "A test door", _testMyRoom, _testYourRoom);
            _testMyRoom.AddPath(_testPath);

            string _expected = "A test door";
            string _actual = _testPath.FullDesciption;

            Assert.AreEqual(_expected, _actual);
        }

        [Test]
        public void TestLocatePath()
        {
            _testPlayer = new Player("Thi", "The Player!");

            _testMyRoom = new Location("My Room", "My Room");
            _testYourRoom = new Location("Your Room", "Your Room");

            _testPlayer.Location = _testMyRoom;
            _testPath = new Path(new string[] { "left" }, "Door", "A test door", _testMyRoom, _testYourRoom);
            _testMyRoom.AddPath(_testPath);

            GameObject _expected = _testMyRoom.Locate("left");
            GameObject _actual = _testPath;

            Assert.AreEqual(_expected, _actual);
        }
    }
}
