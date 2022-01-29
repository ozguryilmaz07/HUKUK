﻿// -----------------------------------------------------------------------
// <copyright file="MatterContact.cs" company="Nodine Legal, LLC">
// Licensed to Nodine Legal, LLC under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  Nodine Legal, LLC licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
// </copyright>
// -----------------------------------------------------------------------

namespace OpenLawOffice.Common.Models.Matters
{
    public class MatterContact : Core
    {
        public int? Id { get; set; }

        public Matter Matter { get; set; }

        public Contacts.Contact Contact { get; set; }

        public bool IsClient { get; set; }

        public bool IsClientContact { get; set; }

        public bool IsAppointed { get; set; }

        public bool IsParty { get; set; }

        public string PartyTitle { get; set; }

        public bool IsJudge { get; set; }

        public bool IsWitness { get; set; }

        public bool IsAttorney { get; set; }

        public Contacts.Contact AttorneyFor { get; set; }

        public bool IsLeadAttorney { get; set; }

        public bool IsSupportStaff { get; set; }

        public Contacts.Contact SupportStaffFor { get; set; }

        public bool IsThirdPartyPayor { get; set; }

        public Contacts.Contact ThirdPartyPayorFor { get; set; }
    }
}