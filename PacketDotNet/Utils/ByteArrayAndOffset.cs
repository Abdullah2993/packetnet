/*
This file is part of Packet.Net

Packet.Net is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Packet.Net is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with Packet.Net.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;

namespace Packet.Net.Utils
{
    internal class ByteArrayAndOffset
    {
        public byte[] Bytes { get; set; }
        public int Offset { get; set; }

        public ByteArrayAndOffset(byte[] Bytes, int Offset)
        {
            this.Bytes = Bytes;
            this.Offset = Offset;
        }
    }
}
