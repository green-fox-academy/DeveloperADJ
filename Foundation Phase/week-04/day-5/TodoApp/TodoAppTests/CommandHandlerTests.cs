using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TodoApp;

namespace TodoAppTests
{
    [TestFixture]
    class CommandHandlerTests
    {
        CommandHandler commandHandler = new CommandHandler();

        [TestCase]
        public void Connected()
        {
            string[] args = {
                "-l",
                "Feed the monkey"
            };

            commandHandler.ProcessArgs(args);
        }
    }
}
