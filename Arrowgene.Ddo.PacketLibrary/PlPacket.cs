﻿using System;

namespace Arrowgene.Ddo.PacketLibrary
{
    public class PlPacket
    {
        public byte[] Data { get; set; }
        public string Direction { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
