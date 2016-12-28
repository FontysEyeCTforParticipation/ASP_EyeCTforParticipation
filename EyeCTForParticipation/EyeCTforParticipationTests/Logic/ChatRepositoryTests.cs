using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCTforParticipation.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Logic.Tests
{
    [TestClass()]
    public class ChatRepositoryTests
    {
        IChatContext context;
        ChatRepository testRepo;
        public ChatRepositoryTests()
        {
            context = new ChatMemoryContext();
            UserModel user1 = new UserModel();
            UserModel user2 = new UserModel();
            user1.Name = "User1";
            user2.Name = "User2";
            MessageModel message1 = new MessageModel();
            message1.User = user1;

            context.SendMessage(new MessageModel());
            testRepo = new ChatRepository(context);
        }

        [TestMethod()]
        public void ListTest()
        {
            bool testCorrect = true;

        }

        [TestMethod()]
        public void GetTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void ClearTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void SendMessageTest()
        {
            throw new NotImplementedException();
        }
    }
}