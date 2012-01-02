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
using Modulo.Collect.OVAL.Definitions;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.OVAL.Definitions.VariableEvaluators.Evaluators;
using Modulo.Collect.OVAL.Tests.helpers;

namespace Modulo.Collect.OVAL.Tests.Variables
{
    /// <summary>
    /// Summary description for LocalVariableEvaluatorTest
    /// </summary>
    [TestClass]
    public class LocalVariableEvaluatorTest
    {
        public LocalVariableEvaluatorTest()
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
        public void Should_be_possible_to_get_value_of_local_variable()
        {
            VariablesTypeVariableLocal_variable variable = CreateALocalVariable();
            oval_system_characteristics systemCharacteristics = new OvalDocumentLoader().GetFakeOvalSystemCharacteristics("system_characteristics_with_local_variable.xml");

            LocalVariableEvaluator localVariableEvaluator = new LocalVariableEvaluator(variable, systemCharacteristics,null);
            IEnumerable<string> values = localVariableEvaluator.GetValue();
            Assert.IsTrue(values.Count() > 0, "the quantity of values is not expected.");
            Assert.IsTrue(values.ElementAt(0) == @"Software\Microsoft\Windows NT\CurrentVersion", "the value is not expected");
        }

        [TestMethod, Owner("lcosta")]
        public void Should_be_possible_to_get_value_of_local_variable_without_system_characteristics()
        {
            VariablesTypeVariableLocal_variable variable = CreateALocalVariable();            

            LocalVariableEvaluator localVariableEvaluator = new LocalVariableEvaluator(variable, null, null);
            IEnumerable<string> values = localVariableEvaluator.GetValue();
            Assert.IsTrue(values.Count() == 0, "the quantity of values is not expected.");            
        }

        private static VariablesTypeVariableLocal_variable CreateALocalVariable()
        {
            VariablesTypeVariableLocal_variable variable = new VariablesTypeVariableLocal_variable();
            variable.id = "oval:org.mitre.oval:var:4000";
            variable.datatype = Modulo.Collect.OVAL.Common.SimpleDatatypeEnumeration.@string;

            ObjectComponentType objecttype = new ObjectComponentType();
            objecttype.object_ref = "oval:org.mitre.oval:obj:3000";
            objecttype.item_field = "key";
            variable.Item = objecttype;
            return variable;
        }
    }
}
