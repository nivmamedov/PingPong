﻿using System.Threading.Tasks;

namespace PingPong.Server.BL.Communicators.Abstractions
{
    public interface ICommunicator
    {
        public byte[] Recieve();
        public void Send(byte[] data);
        public void CloseCommunication();
    }
}
