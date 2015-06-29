using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShitChatCore;

namespace ShitChatCoreTest
{
    [TestClass]
    public class ShitChatCore
    {
        [TestMethod]
        public void AddUserToOnDeck()
        {
            var guid = new Guid("406be1b2-d733-412e-a1df-165d2c8cb576");

            ShitChatSandbox.GetAvailableUser(guid);

            var list = ShitChatSandbox.GetMessages(guid);
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddUserGetFriend()
        {
            var guid = new Guid("406be1b2-d733-412e-a1df-165d2c8cb576");
            var guid2 = new Guid("406be1b2-d733-412e-a1df-165d2c8cb577");
            ShitChatSandbox.GetAvailableUser(guid);
            ShitChatSandbox.GetAvailableUser(guid2);

            var list = ShitChatSandbox.GetMessages(guid);
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void SendMessageFriendToFriend()
        {
            var guid = new Guid("406be1b2-d733-412e-a1df-165d2c8cb576");
            var guid2 = new Guid("406be1b2-d733-412e-a1df-165d2c8cb577");
            ShitChatSandbox.GetAvailableUser(guid);
            ShitChatSandbox.GetAvailableUser(guid2);

            ShitChatSandbox.SendMessage(guid, "It Worked");

            var list = ShitChatSandbox.GetMessages(guid2);
            Assert.AreEqual(list.Count, 2);
        }

        [TestMethod]
        public void AddSameUserTwiceOnDeck()
        {
            var guid = new Guid("406be1b2-d733-412e-a1df-165d2c8cb576");
            var guid2 = new Guid("406be1b2-d733-412e-a1df-165d2c8cb577");
            ShitChatSandbox.GetAvailableUser(guid);
            ShitChatSandbox.GetAvailableUser(guid);

            var list = ShitChatSandbox.GetMessages(guid);
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void AddSameUserTwiceAfterPair()
        {
            var guid = new Guid("406be1b2-d733-412e-a1df-165d2c8cb576");
            var guid2 = new Guid("406be1b2-d733-412e-a1df-165d2c8cb577");

            ShitChatSandbox.GetAvailableUser(guid);
            ShitChatSandbox.GetAvailableUser(guid2);
            ShitChatSandbox.GetAvailableUser(guid);

            var list = ShitChatSandbox.GetMessages(guid);
            Assert.AreEqual(list.Count, 0);
        }
    }
}
