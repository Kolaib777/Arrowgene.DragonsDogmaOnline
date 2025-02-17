﻿using System.Collections.Generic;
using Arrowgene.Ddon.GameServer.Chat;
using Arrowgene.Ddon.Server.Network;
using Arrowgene.Ddon.Shared.Entity;
using Arrowgene.Ddon.Shared.Entity.PacketStructure;

namespace Arrowgene.Ddon.GameServer
{
    /// <summary>
    /// Convenience methods for sending to a specific groups of clients,
    /// or special packets that could be handy.
    /// </summary>
    public class GameRouter
    {
        public void Send<TResStruct>(Client client, TResStruct res) where TResStruct : class, IPacketStructure, new ()
        {
            client.Send(res);
        }

        public void Send(ChatResponse response)
        {
            //   Logger.Debug(requestingClient, $"{request.Structure.Type}, {request.Structure.Unk2}, {request.Structure.Unk3}, {request.Structure.Unk4}, {request.Structure.Unk5}: {request.Structure.StrMessage}"); // Log chat message

            //  S2CLobbyChatMsgRes response = new S2CLobbyChatMsgRes();
            //  requestingClient.Send(response);

            S2CLobbyChatMsgNotice notice = new S2CLobbyChatMsgNotice();
            notice.Unk0 = (byte) response.Type;
            notice.StrMessage = response.Message;
            notice.CharacterBaseInfo.characterId = response.CharacterId;
            notice.CharacterBaseInfo.strFirstName = response.FirstName;
            notice.CharacterBaseInfo.strLastName = response.LastName;
            notice.CharacterBaseInfo.strClanName = response.ClanName;
            foreach (GameClient client in Unique(response.Recipients))
            {
                client.Send(notice);
            }
        }

        private List<T> GetClients<T>(List<T> clients, params T[] excepts)
        {
            if (excepts.Length == 0)
            {
                return clients;
            }

            foreach (T except in excepts)
            {
                clients.Remove(except);
            }

            return clients;
        }
        
        private List<T> Unique<T>(List<T> clients)
        {
            HashSet<T> unique = new HashSet<T>(clients);
            return new List<T>(unique);
        }
    }
}
