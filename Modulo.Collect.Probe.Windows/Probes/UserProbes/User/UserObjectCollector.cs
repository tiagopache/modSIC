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
using System.Collections.Generic;
using System.Linq;
using Modulo.Collect.OVAL.SystemCharacteristics;
using Modulo.Collect.Probe.Common;
using Modulo.Collect.Probe.Common.BasicClasses;
using Modulo.Collect.Probe.Common.Helpers;
using Modulo.Collect.Probe.Windows.Providers;

namespace Modulo.Collect.Probe.Windows.User
{
    public class UserObjectCollector : BaseObjectCollector
    {
        private WindowsUsersProvider WindowsAccountProvider;

        public UserObjectCollector(WindowsUsersProvider windowsAccountProvider)
        {
            this.WindowsAccountProvider = windowsAccountProvider;
        }


        public override IList<string> GetValues(Dictionary<string, object> parameters)
        {
            throw new NotImplementedException("This method should not being called");
            //var computerName = this.WmiDataProvider.SearchWmiObjects("Win32_ComputerSystem", null).FirstOrDefault().GetValueOf("Name");
            //var wqlGetAllLocalUsers = new WQLBuilder().WithWmiClass("Win32_UserAccount").AddParameter("LocalAccount ", true).Build();
            //IEnumerable<WmiObject> allLocalUsers = this.WmiDataProvider.ExecuteWQL(wqlGetAllLocalUsers);

            //var values = new List<String>();
            //foreach (var item in allLocalUsers)
            //{
            //    values.Add(item.GetValueOf("Caption").ToString());
            //}
            //return values;            
        }

        protected override IEnumerable<CollectedItem> collectDataForSystemItem(ItemType systemItem)
        {
            if (systemItem.status.Equals(StatusEnumeration.notcollected))
            {
                var userToBeCollected = ((user_item)systemItem).user.Value;
                try
                {
                    var collectedUser = this.WindowsAccountProvider.GetUserByName(userToBeCollected);
                    systemItem = new user_item()
                    {
                        status = StatusEnumeration.exists,
                        user = OvalHelper.CreateItemEntityWithStringValue(collectedUser.Name),
                        enabled = OvalHelper.CreateBooleanEntityItemFromBoolValue((bool)collectedUser.Enabled),
                    };
                    
                    var userGroups = this.WindowsAccountProvider.GetUserGroups(userToBeCollected, AccountSearchReturnType.Name);
                    if (userGroups.Count() > 0)
                        ((user_item)systemItem).group = userGroups.Select(grp => new EntityItemStringType() { Value = grp }).ToArray();
                    else
                        ((user_item)systemItem).group = new EntityItemStringType[] { new EntityItemStringType() { status = StatusEnumeration.doesnotexist } };
                }
                catch (WindowsUserNotFound)
                {
                    systemItem.status = StatusEnumeration.doesnotexist;
                    ((user_item)systemItem).user.status = systemItem.status;
                }
            }

            return new ItemTypeHelper().CreateCollectedItemsWithOneItem(systemItem, BuildExecutionLog());
        }
        
    }
}
