using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace OPCUAServer
{
    class NodeManager : CustomNodeManager2
    {
        private static OPCUAServerState opcUaServer;
        private Random _random = new Random();

        public NodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = Namespaces.OPCUAServer;
            namespaceUrls[1] = Namespaces.OPCUAServer + "/Instance";
            SetNamespaces(namespaceUrls);
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                @"Data\OPCUAServer.PredefinedNodes.uanodes",
                typeof(NodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Batch Plant 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(OPCUAServer.Objects.OPCUAServer1,
                    NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                opcUaServer = new OPCUAServerState(null);
                opcUaServer.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, opcUaServer);

                // here add the methods handler
                opcUaServer.Machine.Conveyor.Start.OnCallMethod = new GenericMethodCalledEventHandler(OnStart);
                opcUaServer.Machine.Conveyor.Stop.OnCallMethod = new GenericMethodCalledEventHandler(OnStop);
                
                //custom code example
                SetInterval(() => Console.WriteLine("Interval passed"), TimeSpan.FromSeconds(2));
                SetInterval(() => Simulate(), TimeSpan.FromSeconds(4));
            }
        }

        // method handlers
        private ServiceResult OnStart(ISystemContext context, MethodState method, IList<object> inputArgs, IList<object> outputArgs)
        {
            Console.WriteLine("Conveyor started.");
       

            Console.WriteLine(opcUaServer.Machine.Conveyor.Speed.Value);
            return ServiceResult.Good;
        }

        private ServiceResult OnStop(ISystemContext context, MethodState method, IList<object> inputArgs, IList<object> outputArgs)
        {
            Console.WriteLine("Conveyor stopped.");

            return ServiceResult.Good;
        }


        private void Simulate()
        {
            Console.WriteLine("Simulate called");
            opcUaServer.Machine.Proximity.Value.Value = _random.NextDouble() * 100;   
            opcUaServer.Machine.Proximity.Value.ClearChangeMasks(SystemContext, false);
        }


        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);

            action();

            await SetInterval(action, timeout);
        }
    }
}
