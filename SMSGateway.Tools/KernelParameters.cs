﻿/*
 * EasySMPP - SMPP protocol library for fast and easy
 * SMSC(Short Message Service Centre) client development
 * even for non-telecom guys.
 * 
 * Easy to use classes covers all needed functionality
 * for SMS applications developers and Content Providers.
 * 
 * Written for .NET 2.0 in C#
 * 
 * Copyright (C) 2006 Balan Andrei, http://balan.name
 * 
 * Licensed under the terms of the GNU Lesser General Public License:
 * 		http://www.opensource.org/licenses/lgpl-license.php
 * 
 * For further information visit:
 * 		http://easysmpp.sf.net/
 * 
 * 
 * "Support Open Source software. What about a donation today?"
 *
 * 
 * File Name: KernelParameters.cs
 * 
 * File Authors:
 * 		Balan Name, http://balan.name
 */
using System;

namespace SMSGateway.Tools
{
    public class KernelParameters
    {
        public const int MaxBufferSize = 1048576; // 1MB

        public const int MaxPduSize = 131072;

        public const int ReconnectTimeout = 45000; // miliseconds

        public const int WaitPacketResponse = 30; //seconds

        public const int CanBeDisconnected = 180; //seconds - BETTER TO BE MORE THAN TryToReconnectTimeOut

        public const int NationalNumberLength = 8;

        public const int MaxUndeliverableMessages = 30;

        public const int AskDeliveryReceipt = 0; //NoReceipt = 0;

        public const bool SplitLongText = false;

        public const bool UseEnquireLink = false;

        public const int EnquireLinkTimeout = 45000; //miliseconds

        public const uint MaxSequenceNumber = UInt32.MaxValue; //100000000; // 99999999 + 1
        public const byte MaxIdentificationNumber = Byte.MaxValue; //0xFF;

        //public const int waitForResponse = 30; // wait for submit_SM response in seconds

        public const int DeliveryLoadTimeout = 100;
        public const int DeliverySendTimeout = 5;
    }
}
