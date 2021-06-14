using System;
using NUnit.Framework;
using SubstrateNetApi;

namespace SubstrateNetApiTests
{
    public class UtilsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPublicKeyFromTest()
        {
            var address = "5GrwvaEF5zXb26Fz9rcQpDWS57CtERHpNehXCPcNoHGKutQY";
            var bytes = Utils.GetPublicKeyFrom(address);
            Assert.AreEqual("D43593C715FDD31C61141ABD04A99FD6822C8558854CCDE39A5684E7A56DA27D",
                BitConverter.ToString(bytes).Replace("-", ""));
        }

        [Test]
        public void GetAddressFromTest()
        {
            var publicKeyString = "0xd43593c715fdd31c61141abd04a99fd6822c8558854ccde39a5684e7a56da27d";
            var publickey = Utils.HexToByteArray(publicKeyString);
            var address = Utils.GetAddressFrom(publickey);
            Assert.AreEqual("5GrwvaEF5zXb26Fz9rcQpDWS57CtERHpNehXCPcNoHGKutQY", address);
        }

        [Test]
        public void LittleEndianIntegerTest()
        {
            Assert.AreEqual(259, Utils.Bytes2Value(Utils.HexToByteArray("0x0301")));
            Assert.AreEqual("0x0301", Utils.Bytes2HexString(Utils.Value2Bytes((ushort)259)));
        }

        [Test]
        public void StringValueArrayBytesArrayTest()
        {
            Assert.AreEqual(new byte[] { 0x01, 0x02, 0x03, 0x04 }, Utils.StringValueArrayBytesArray("[ 1, 2, 3, 4]"));
            Assert.AreEqual(new byte[] { 0x0C, 0x0D, 0x0E, 0x0F }, Utils.StringValueArrayBytesArray("12, 13, 14, 15"));
            Assert.AreEqual(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF }, Utils.StringValueArrayBytesArray("255,255,255,255"));
        }

        [Test]
        public void StringValueArrayBytesArrayFailedTest()
        {
            Assert.Throws<Exception>(delegate { Utils.StringValueArrayBytesArray("Test"); });
        }

        [Test]
        public void Byte2ValueTest()
        {
            var ushortValue = (ushort)Utils.Bytes2Value(new byte[] { 0xFF, 0xFF });
            Assert.AreEqual(65535, ushortValue);

            var uintValue = (uint)Utils.Bytes2Value(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
            Assert.AreEqual(4294967295, uintValue);

            var ulongValue = (ulong)Utils.Bytes2Value(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
            Assert.AreEqual(18446744073709551615, ulongValue);
        }

        [Test]
        public void HexToByteArrayFailedTest()
        {
            Assert.Throws<Exception>(delegate { Utils.HexToByteArray("111"); });
        }

        [Test]
        public void HexToByteArrayZeroTest()
        {
            Assert.AreEqual(new byte[] { 0x00 }, Utils.HexToByteArray("0x0"));
        }

        [Test]
        public void HexToByteArrayUnevenTest()
        {
            Assert.AreEqual(new byte[] { 0x01, 0x11 }, Utils.HexToByteArray("0x111", true));
        }

        [Test]
        public void Value2BytesTest()
        {
            Assert.AreEqual(new byte[] { 0x12, 0x11 }, Utils.Value2Bytes((ushort)0x1112));
            Assert.AreEqual(new byte[] { 0x15, 0x14, 0x13, 0x12 }, Utils.Value2Bytes((uint)0x12131415));
            Assert.AreEqual(new byte[] { 0x15, 0x14, 0x13, 0x12, 0x11, 0x10, 0x09, 0x08 }, Utils.Value2Bytes((ulong)0x0809101112131415));
            Assert.AreEqual(new byte[] { 0x11, 0x12 }, Utils.Value2Bytes((ushort)0x1112, false));
            Assert.Throws<Exception>(delegate { Utils.Value2Bytes(1.4); });
        }
    }
}