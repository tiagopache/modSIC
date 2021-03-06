﻿/*
 * Modulo Open Distributed SCAP Infrastructure Collector (modSIC)
 * 
 * Copyright (c) 2011, Modulo Solutions for GRC.
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 *   * Redistributions of source code must retain the above copyright notice,
 *     this list of conditions and the following disclaimer.
 *   * Redistributions in binary form must reproduce the above copyright 
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 *   * Neither the name of Modulo Security, LLC nor the names of its
 *     contributors may be used to endorse or promote products derived from
 *     this software without specific  prior written permission.
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
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modulo.Collect.Probe.CiscoIOS.Probes.Version;
using Modulo.Collect.Probe.Common.Test;
using Modulo.Collect.OVAL.SystemCharacteristics.Ios;
using Modulo.Collect.Probe.Common.BasicClasses;
using Modulo.Collect.Probe.Common.Test.Helpers;
using Modulo.Collect.OVAL.Definitions.Ios;
using Modulo.Collect.OVAL.Definitions;

namespace Modulo.Collect.Probe.CiscoIOS.Tests.ProbeTests.Version55
{
    [TestClass]
    public class VersionProberTests: ProberTestBase
    {
        private version55_object FakeVersionObject;
        private Common.BasicClasses.CollectInfo FakeCollectInfo;

        public VersionProberTests()
        {
            this.FakeVersionObject =
                new version55_object();
            this.FakeCollectInfo = ProbeHelper.CreateFakeCollectInfo(new ObjectType[] { FakeVersionObject });
        }

        [TestMethod, Owner("dgomes, cpaiva")]
        public void Should_be_possible_to_call_version_prober_execution_without_errors()
        {
            var versionProber = new VersionProber();
            ProberBehaviorCreator
                .CreateBehaviorForNormalFlowExecution
                    (versionProber,
                     new OVAL.SystemCharacteristics.ItemType[] { new version_item() },
                     new CollectedItem[] { ProbeHelper.CreateFakeCollectedItem(new version_item()) });

            var proberResult = versionProber.Execute(base.FakeContext, base.FakeTargetInfo, this.FakeCollectInfo);

            base.DoAssertForSingleCollectedObject(proberResult, typeof(version_item));
        }

        [TestMethod, Owner("cpaiva, dgomes")]
        public void Should_be_possible_to_handle_version_prober_execution_errors()
        {
            var versionProber = new VersionProber();
            ProberBehaviorCreator.CreateBehaviorWithExceptionThrowing(versionProber);

            var proberResult = versionProber.Execute(base.FakeContext, base.FakeTargetInfo, this.FakeCollectInfo);

            base.DoAssertForExecutionWithErrors(proberResult, typeof(version_item));
        }


        [TestMethod, Owner("cpaiva, dgomes")]
        public void Should_be_possible_to_handle_version_object_with_set()
        {
        }
    }
}
