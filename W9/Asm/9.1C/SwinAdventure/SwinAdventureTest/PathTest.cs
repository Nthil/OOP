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
        Location _testRoomA;
        Location _testRoomB;
        Path _testPath;

        [Test]
        public void TestPathLocation()
        {
            _testPlayer = new Player("Thi", "The Player");
            _testRoomA = new Location("Room A", "Room A");
            _testRoomB = new Location("Room B", "Room B");

            _testPlayer.Location = _testRoomA;
            _testPath = new Path(new string[] { "Left" }, "Table", "Test table", _testRoomA, _testRoomB);
            _testRoomA.AddPath(_testPath);

            Location _expected = _testRoomB;
            Location _actual = _testPath.Destination;

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [Test]
        public void TestPathName()
        {
            _testPlayer = new Player("Thi", "The Player");

            _testRoomA = new Location("Room A", "Room A");
            _testRoomB = new Location("Room B", "Room B");

            _testPlayer.Location = _testRoomA;
            _testPath = new Path(new string[] { "Left" }, "Table", "Test table", _testRoomA, _testRoomB);
            _testRoomA.AddPath(_testPath);

            string _expected = "Test table";
            string _actual = _testPath.FullDescription;

            Assert.That(_actual, Is.EqualTo(_expected));
        }

        [Test]
        public void TestLocatePath()
        {
            _testPlayer = new Player("Thi", "The Player");

            _testRoomA = new Location("Room A", "Room A");
            _testRoomB = new Location("Room B", "Room B");

            _testPlayer.Location = _testRoomA;
            _testPath = new Path(new string[] { "Left" }, "Table", "Test table", _testRoomA, _testRoomB);
            _testRoomA.AddPath(_testPath);

            GameObject _expected = _testRoomA.Locate("Left");
            GameObject _actual = null;

            Assert.That(_actual, Is.EqualTo(_expected));
        }
    }
}
