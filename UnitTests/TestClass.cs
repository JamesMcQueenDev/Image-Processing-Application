using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUI;
using Server;

/// <summary>
/// Just adding this comment in for the SOP
/// </summary>
namespace UnitTests
{
    [TestClass]
    public class TestClass
    {
        //Tests for the server to see if a value is successfully being passed through

        [TestMethod]
        public void TestClockwiseRotateImage()
        {
            ServerClass _serverClass = new ServerClass();

            _serverClass.RotateClockwiseImage("Test Path");
        }

        [TestMethod]
        public void TestAnticlockwiseRotateImage()
        {
            ServerClass _serverClass = new ServerClass();

            _serverClass.RotateAnticlockwiseImage("Test Path");
        }

        [TestMethod]
        public void TestFlipXImage()
        {
            ServerClass _serverClass = new ServerClass();

            _serverClass.HorizontalFlipImage("Test Path");
        }

        [TestMethod]
        public void TesFlipYImage()
        {
            ServerClass _serverClass = new ServerClass();

            _serverClass.VerticalFlipImage("Test Path");
        }
    }
}
