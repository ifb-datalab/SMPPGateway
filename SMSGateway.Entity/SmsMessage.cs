﻿using SMSGateway.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SMSGateway.Entity
{
    public class SmsMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Coding { get; set; }
        public string Message { get; set; }
        public bool AskDeliveryReceipt { get; set; }
        public byte Priority { get; set; }
        public string RefId { get; set; }
        public string PEID { get; set; }
        public string TMID { get; set; }
        public string TemplateId { get;set; }
        public string CommunicationType {  get; set; }
        public string Operator { get; set; }
        public int RetryIndex { get; set; }
        public IDictionary<string, object> AdditionalData { get; set; }
        public SmsMessage()
        {
            AskDeliveryReceipt = true;
            Priority = PriorityFlags.Normal;
            AdditionalData = new Dictionary<string, object>();
        }
    }
}
