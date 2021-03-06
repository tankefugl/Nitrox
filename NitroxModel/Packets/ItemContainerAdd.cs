﻿using System;
using UnityEngine;

namespace NitroxModel.Packets
{
    [Serializable]
    public class ItemContainerAdd : DeferrablePacket
    {
        public string OwnerGuid { get; }
        public byte[] ItemData { get; }

        public ItemContainerAdd(string ownerGuid, byte[] itemData, Vector3 ownerPositon) : base(ownerPositon, ITEM_INTERACTION_CELL_LEVEL)
        {
            OwnerGuid = ownerGuid;
            ItemData = itemData;
        }

        public override string ToString()
        {
            return "[ItemContainerAdd OwnerGuid: " + OwnerGuid + " Total Bytes: " + ItemData.Length + "]";
        }
    }
}
