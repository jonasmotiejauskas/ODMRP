﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace ODMRP.ODMRPelements
{
    class Node
    {
        public static event EventHandler NodeUpdate;

        public int NodeId { get; private set; }
        private int _coordinateX;
        private int _coordinateY;
        private int _range;
        private int _sequenceId = 0;
        ControlCollection AllNodes;
        List<MessagePrint> MessageCache = new List<MessagePrint>();
        List<RoutingTableElement> RoutingTable = new List<RoutingTableElement>();
        List<ForwardingTableElement> ForwardingTable = new List<ForwardingTableElement>();

        public void SendMessage(int receiveIp)
        {
            if(!ForwardingTable.Contains(new ForwardingTableElement(receiveIp)))
            {
                JoinData newJoinDataPacket = new JoinData(20, SequenceId, NodeId, NodeId, receiveIp);
                ReceiveJoinDataPacket(newJoinDataPacket);
            }
            else
            {
                //SendData(receiveIp);
            }
        }

        public void ReceiveJoinDataPacket(JoinData packet)
        {
            if(!MessageCache.Contains(new MessagePrint(packet.SourceIp, packet.SequenceNumber)))
            {
                MessageCache.Add(new MessagePrint(packet.SourceIp, packet.SequenceNumber));
                RoutingTable.Add(new RoutingTableElement(packet.SourceIp, packet.PreviousHopIp));

                if (packet.MulticastGroupIp == NodeId)
                {
                    JoinTable newJoinTablePacket = new JoinTable(packet.PreviousHopIp, packet.SequenceNumber, packet.SourceIp, NodeId, NodeId);
                    SendJoinTable(newJoinTablePacket);
                }
                else
                {
                    JoinData newPacket = new JoinData(packet.TTL-1, packet.SequenceNumber, packet.SourceIp, NodeId, packet.MulticastGroupIp);
                    newPacket.HopCount = packet.HopCount + 1;
                    
                    if (newPacket.TTL > 0)
                    {
                        SendJoinData(newPacket);
                    }
                }          
            }
        }

        public void ReceiveJoinTablePacket(JoinTable packet)
        {
            if (NodeId == packet.NextHopIp)
            {
                ForwardingTable.Add(new ForwardingTableElement(packet.MulticastGroupIp));

                if (NodeId == packet.SourceIp)
                {
                    SendMessage(packet.MulticastGroupIp);
                }
                else
                {
                    int nextHop = 0;

                    foreach(var a in RoutingTable)
                    {
                        if(a.SourceIp == packet.SourceIp)
                        {
                            nextHop = a.NextHop;
                        }
                    }

                    JoinTable newJoinTable = new JoinTable( nextHop, packet.SequenceNumber, packet.SourceIp, NodeId, packet.MulticastGroupIp);
                    SendJoinTable(newJoinTable);
                }
            }
        }

        private void SendJoinData(JoinData packet)
        {
            foreach(var nnode in NodeScanner.GetNearbyNodes(this, AllNodes))
            {
                int timeElapsed = 0;
                new Thread(() =>
                {
                    Thread.Sleep((int)(nnode.Key * 110) - timeElapsed);
                    timeElapsed += (int)(nnode.Key * 110);
                    Thread.CurrentThread.IsBackground = true;
                    nnode.Value.ReceiveJoinDataPacket(packet);
                }).Start();
            }
        }

        private void SendJoinTable(JoinTable packet)
        {
            foreach (var nnode in NodeScanner.GetNearbyNodes(this, AllNodes))
            {
                new Thread(() =>
                {
                    int timeElapsed = 0;
                    Thread.Sleep((int)(nnode.Key * 110) - timeElapsed);
                    timeElapsed += (int)(nnode.Key * 110);
                    Thread.CurrentThread.IsBackground = true;
                    nnode.Value.ReceiveJoinTablePacket(packet);
                }).Start();
            }
        }

        public virtual void OnThresholdReached(object sender, EventArgs e)
        {
            NodeUpdate?.Invoke(sender, e);
        }

        public Node(ControlCollection all)
        {
            NodeId = new IncrementalNumberGenerator().Number;
            Range = 100;
            AllNodes = all;
        }

        public int CoordinateX
        {
            get { return _coordinateX; }
            set
            {
                OnThresholdReached(this, new EventArgs());
                _coordinateX = value;
            }
        }

        public int CoordinateY
        {
            get { return _coordinateY; }
            set
            {
                OnThresholdReached(this, new EventArgs());
                _coordinateY = value;
            }
        }

        public int Range
        {
            get { return _range; }
            private set
            {
                OnThresholdReached(this, new EventArgs());
                _range = value;
            }
        }

        public int SequenceId
        {
            get
            {
                _sequenceId++;
                return _sequenceId;
            }
            private set { }
        }
    }
}
