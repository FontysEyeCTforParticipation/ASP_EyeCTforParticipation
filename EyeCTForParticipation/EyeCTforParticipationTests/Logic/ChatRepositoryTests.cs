using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCTforParticipation.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;

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

            testRepo = new ChatRepository(context);
        }
        
        [TestMethod()]
        public void ListTest()
        {
            
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