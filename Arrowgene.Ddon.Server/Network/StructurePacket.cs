﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Arrowgene.Ddon.Shared.Entity;
using Arrowgene.Ddon.Shared.Network;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.TypeInspectors;

namespace Arrowgene.Ddon.Server.Network
{
    public class StructurePacket<TStruct> : StructurePacket where TStruct : class, IPacketStructure, new()
    {
        private TStruct _structure;

        public StructurePacket(Packet packet) : base(packet)
        {
        }

        public StructurePacket(TStruct structure) : base(structure.Id, null)
        {
            SetStructure(structure);
        }

        public TStruct Structure
        {
            get => GetStructure();
            set => SetStructure(value);
        }

        private void SetStructure(TStruct structure)
        {
            Data = EntitySerializer.Get<TStruct>().Write(structure);
            _structure = structure;
        }

        private TStruct GetStructure()
        {
            if (_structure == null)
            {
                _structure = EntitySerializer.Get<TStruct>().Read(AsBuffer());
            }

            return _structure;
        }
    }

    public class StructurePacket : Packet, IStructurePacket
    {
        private static readonly ISerializer Serializer = new SerializerBuilder()
            .WithTypeInspector(inspector => new MyTypeInspector(inspector))
            .Build();

        private static readonly Dictionary<PacketId, IStructurePacketFactory> LoginPacketFactories;
        private static readonly Dictionary<PacketId, IStructurePacketFactory> GamePacketFactories;

        static StructurePacket()
        {
            LoginPacketFactories = new Dictionary<PacketId, IStructurePacketFactory>();
            
            GamePacketFactories = new Dictionary<PacketId, IStructurePacketFactory>();
        }
        
        public static StructurePacket Make(Packet packet)
        {
            PacketId packetId = packet.Id;
            if (packetId.ServerType == ServerType.Login && LoginPacketFactories.ContainsKey(packetId))
            {
                return LoginPacketFactories[packetId].Create(packet);
            }

            if (packetId.ServerType == ServerType.Game && GamePacketFactories.ContainsKey(packetId))
            {
                return GamePacketFactories[packetId].Create(packet);
            }

            return null;
        }

        protected StructurePacket(Packet packet) : base(packet.Id, packet.Data, packet.Source, packet.Count)
        {
        }

        protected StructurePacket(PacketId id, byte[] data) : base(id, data)
        {
        }

        public string PrintStructure()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(PrintHeader());
            stringBuilder.Append(Environment.NewLine);
            Serializer.Serialize(new IndentedTextWriter(new StringWriter(stringBuilder)), this);
            return stringBuilder.ToString();
        }

        private class MyTypeInspector : TypeInspectorSkeleton
        {
            private readonly ITypeInspector _innerTypeDescriptor;

            public MyTypeInspector(ITypeInspector innerTypeDescriptor)
            {
                _innerTypeDescriptor = innerTypeDescriptor;
            }

            public override IEnumerable<IPropertyDescriptor> GetProperties(Type type, object container)
            {
                IEnumerable<IPropertyDescriptor> props = _innerTypeDescriptor.GetProperties(type, container);
                List<IPropertyDescriptor> filtered = new List<IPropertyDescriptor>();
                IPropertyDescriptor structure = null;
                bool hasData = false;
                bool hasCount = false;
                foreach (IPropertyDescriptor prop in props)
                {
                    if (prop.Name == "Structure")
                    {
                        structure = prop;
                    }

                    if (prop.Name == "Data")
                    {
                        hasData = true;
                    }

                    if (prop.Name == "Count")
                    {
                        hasCount = true;
                    }

                    if (prop.Type == typeof(PacketId) && prop.Name == "Id")
                    {
                        // exclude PacketIds from serialisation
                        continue;
                    }

                    filtered.Add(prop);
                }

                if (structure != null && hasData && hasCount)
                {
                    // assuming this is the top level of StructurePacket.Structure,
                    // in this case only serialize the `.Structure` property.
                    filtered.Clear();
                    filtered.Add(structure);
                }

                return filtered;
            }
        }
    }
}
