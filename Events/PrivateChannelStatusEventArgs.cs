/*
* Vha.Net
* Copyright (C) 2005-2010 Remco van Oosterhout
* See Credits.txt for all aknowledgements.
*
* This program is free software; you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation; version 2 of the License only.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
* USA
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Vha.Net.Events
{
    public class PrivateChannelStatusEventArgs : EventArgs
    {
        private readonly UInt32 _channelID = 0;
        private readonly string _channel;
        private readonly UInt32 _characterID = 0;
        private readonly string _character;
        private readonly bool _join = false;
        private readonly bool _local = false;

        public PrivateChannelStatusEventArgs(UInt32 channelID, string channel, UInt32 characterID, string character, bool join, bool local)
        {
            this._channelID = channelID;
            this._channel = channel;
            this._characterID = characterID;
            this._character = character;
            this._join = join;
            this._local = local;
        }

		/// <summary>
		/// ID of the owner of the private channel the event occurs in.
		/// </summary>
        public UInt32 ChannelID { get { return this._channelID; } }
		/// <summary>
		/// Name of the owner of the private channel the event occurs in.
		/// </summary>
		public string Channel { get { return this._channel; } }
        /// <summary>
        /// ID of the user who is triggering this event.
        /// </summary>
		public UInt32 CharacterID { get { return this._characterID; } }
		/// <summary>
		/// Name of the user who is triggering this event.
		/// </summary>
        public string Character { get { return this._character; } }
        /// <summary>
        /// Whether someone has joined or left this channel. True if the user has joined, false when the user left.
        /// </summary>
		public bool Join { get { return this._join; } }
        /// <summary>
        /// Whether this channel is owned by our user.
        /// </summary>
        public bool Local { get { return this._local; } }
        /// <summary>
        /// Returns the combined private channel data
        /// </summary>
        /// <returns></returns>
        public PrivateChannel GetPrivateChannel()
        {
            return new PrivateChannel(this._channelID, this._channel, this._local);
        }
    }
}
