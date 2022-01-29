﻿// -----------------------------------------------------------------------
// <copyright file="Matter.cs" company="Nodine Legal, LLC">
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
    using System;

    public class Matter : Core
    {
        public Guid? Id { get; set; }

        public long? IdInt { get; set; }

        public Guid? ParentId { get; set; }

        public MatterType MatterType { get; set; }

        public string Title { get; set; }

        public string Synopsis { get; set; }

        public bool Active { get; set; }

        public string CaseNumber { get; set; }

        public Contacts.Contact BillTo { get; set; }

        public decimal? MinimumCharge { get; set; }

        public decimal? EstimatedCharge { get; set; }

        public decimal? MaximumCharge { get; set; }

        public Billing.BillingRate DefaultBillingRate { get; set; }

        public Billing.BillingGroup BillingGroup { get; set; }

        public bool OverrideMatterRateWithEmployeeRate { get; set; }
        
        public string AttorneyForPartyTitle { get; set; }
        
        public CourtType CourtType { get; set; }
        
        public CourtGeographicalJurisdiction CourtGeographicalJurisdiction { get; set; }
        
        public CourtSittingInCity CourtSittingInCity { get; set; }
        
        public string CaptionPlaintiffOrSubjectShort { get; set; }
        
        public string CaptionPlaintiffOrSubjectRegular { get; set; }
        
        public string CaptionPlaintiffOrSubjectLong { get; set; }
        
        public string CaptionOtherPartyShort { get; set; }
        
        public string CaptionOtherPartyRegular { get; set; }
        
        public string CaptionOtherPartyLong { get; set; }
    }
}