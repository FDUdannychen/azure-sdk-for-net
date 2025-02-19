// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication;
using Azure.Communication.CallingServer;
using Azure.Core;

namespace Azure.Communication.CallingServer.Models
{
    /// <summary> The CallConnectionPropertiesDto. </summary>
    internal partial class CallConnectionPropertiesDtoInternal
    {
        /// <summary> Initializes a new instance of CallConnectionPropertiesDtoInternal. </summary>
        internal CallConnectionPropertiesDtoInternal()
        {
            Targets = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of CallConnectionPropertiesDtoInternal. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="alternateCallerId"> The alternate identity of the source of the call if dialing out to a pstn number. </param>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <param name="subject"> The subject. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        internal CallConnectionPropertiesDtoInternal(string callConnectionId, string serverCallId, CommunicationIdentifierModel source, PhoneNumberIdentifierModel alternateCallerId, IReadOnlyList<CommunicationIdentifierModel> targets, CallConnectionState? callConnectionState, string subject, string callbackUri)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            Source = source;
            AlternateCallerId = alternateCallerId;
            Targets = targets;
            CallConnectionState = callConnectionState;
            Subject = subject;
            CallbackUri = callbackUri;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; }
        /// <summary> The source of the call. </summary>
        public CommunicationIdentifierModel Source { get; }
        /// <summary> The alternate identity of the source of the call if dialing out to a pstn number. </summary>
        public PhoneNumberIdentifierModel AlternateCallerId { get; }
        /// <summary> The targets of the call. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState? CallConnectionState { get; }
        /// <summary> The subject. </summary>
        public string Subject { get; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
    }
}
