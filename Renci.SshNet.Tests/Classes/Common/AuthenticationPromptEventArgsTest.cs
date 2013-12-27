﻿using Renci.SshNet.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Renci.SshNet.Tests.Common;

namespace Renci.SshNet.Tests.Classes.Common
{
    
    
    /// <summary>
    ///This is a test class for AuthenticationPromptEventArgsTest and is intended
    ///to contain all AuthenticationPromptEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AuthenticationPromptEventArgsTest : TestBase
    {
        /// <summary>
        ///A test for AuthenticationPromptEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void AuthenticationPromptEventArgsConstructorTest()
        {
            string username = string.Empty; // TODO: Initialize to an appropriate value
            string instruction = string.Empty; // TODO: Initialize to an appropriate value
            string language = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<AuthenticationPrompt> prompts = null; // TODO: Initialize to an appropriate value
            AuthenticationPromptEventArgs target = new AuthenticationPromptEventArgs(username, instruction, language, prompts);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
