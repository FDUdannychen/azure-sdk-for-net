﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Communication.CallingServer.Models
{
    /// <summary> The participant in a call. </summary>
    public class CallParticipant
    {
        /// <summary> Initializes a new instance of CallParticipant. </summary>
        /// <param name="identifier"> The communication identifier. </param>
        /// <param name="isMuted"> Is participant muted. </param>
        internal CallParticipant(CommunicationIdentifier identifier, bool isMuted)
        {
            Identifier = identifier;
            IsMuted = isMuted;
        }

        /// <summary> Initializes a new instance of CallParticipant. </summary>
        /// <param name="callParticipantInternal"> The internal call participant. </param>
        internal CallParticipant(AcsCallParticipantDtoInternal callParticipantInternal)
        {
            Identifier = CommunicationIdentifierSerializer.Deserialize(callParticipantInternal.Identifier);
            IsMuted = (bool)callParticipantInternal.IsMuted;
        }

        /// <summary> The communication identifier. </summary>
        public CommunicationIdentifier Identifier { get; }

        /// <summary> Is participant muted. </summary>
        public bool IsMuted { get; }
    }
}
