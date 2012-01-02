﻿/*
 * Modulo Open Distributed SCAP Infrastructure Collector (modSIC)
 * 
 * Copyright (c) 2011, Modulo Solutions for GRC.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * - Redistributions of source code must retain the above copyright notice,
 *   this list of conditions and the following disclaimer.
 *   
 * - Redistributions in binary form must reproduce the above copyright 
 *   notice, this list of conditions and the following disclaimer in the
 *   documentation and/or other materials provided with the distribution.
 *   
 * - Neither the name of Modulo Security, LLC nor the names of its
 *   contributors may be used to endorse or promote products derived from
 *   this software without specific  prior written permission.
 *   
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 * */
using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modulo.Collect.Probe.Windows.File;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.Probe.Independent.Common;
using Modulo.Collect.OVAL.Common;
using Modulo.Collect.Probe.Independent.Common.File;

namespace Modulo.Collect.Probe.Windows.Test.File
{
    /// <summary>
    /// Summary description for FileItemTypeFactoryTest
    /// </summary>
    [TestClass]
    public class FileItemTypeFactoryTest
    {
        public FileItemTypeFactoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod, Owner("lcosta")]
        public void Should_be_possible_to_create_itemTypes_by_combination_of_entities_without_filepath()
        {
            IEnumerable<string> paths = new List<string>() { @"c:\projetos\demandas\resources",
                                                             @"c:\projetos\integration\resources" };
            IEnumerable<string> fileName = new List<string>() { "file.txt" };

            FileItemTypeFactory factory = new FileItemTypeFactory(FamilyEnumeration.windows);
            IEnumerable<ItemType> itemTypes = factory.CreateFileItemTypesByCombinationOfEntitiesFrom(new List<string>(), paths, fileName);
            Assert.AreEqual(2, itemTypes.Count());
            Assert.AreEqual(@"c:\projetos\demandas\resources", ((file_item)itemTypes.ElementAt(0)).path.Value); 
            Assert.AreEqual(@"c:\projetos\integration\resources", ((file_item)itemTypes.ElementAt(1)).path.Value);
        }

        [TestMethod, Owner("lcosta")]
        public void Should_be_possible_to_create_itemTypes_by_combination_of_entities_with_filePath()
        {
            var filePath = new List<string>() { @"c:\projetos\demandas\resources\file.txt",
                                                @"c:\projetos\integration\resources\file.txt" };
            var itemTypes = 
                new FileItemTypeFactory(FamilyEnumeration.windows)
                    .CreateFileItemTypesByCombinationOfEntitiesFrom(filePath, new List<string>(), new List<string>());
            
            Assert.AreEqual(2, itemTypes.Count());
            Assert.AreEqual(@"c:\projetos\demandas\resources\file.txt", ((file_item)itemTypes.ElementAt(0)).filepath.Value);
            Assert.AreEqual(@"c:\projetos\integration\resources\file.txt", ((file_item)itemTypes.ElementAt(1)).filepath.Value);
        }
    }
}
