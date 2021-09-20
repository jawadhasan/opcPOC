/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace OPCUAServer
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the MotorConveyor_Start Method.
        /// </summary>
        public const uint MotorConveyor_Start = 29;

        /// <summary>
        /// The identifier for the MotorConveyor_Stop Method.
        /// </summary>
        public const uint MotorConveyor_Stop = 30;

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Start Method.
        /// </summary>
        public const uint MachineType_Conveyor_Start = 53;

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Stop Method.
        /// </summary>
        public const uint MachineType_Conveyor_Stop = 54;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Start Method.
        /// </summary>
        public const uint OPCUAServerType_Machine_Conveyor_Start = 78;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Stop Method.
        /// </summary>
        public const uint OPCUAServerType_Machine_Conveyor_Stop = 79;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Start Method.
        /// </summary>
        public const uint OPCUAServer1_Machine_Conveyor_Start = 103;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Stop Method.
        /// </summary>
        public const uint OPCUAServer1_Machine_Conveyor_Stop = 104;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the MachineType_Temperature Object.
        /// </summary>
        public const uint MachineType_Temperature = 32;

        /// <summary>
        /// The identifier for the MachineType_Proximity Object.
        /// </summary>
        public const uint MachineType_Proximity = 39;

        /// <summary>
        /// The identifier for the MachineType_Conveyor Object.
        /// </summary>
        public const uint MachineType_Conveyor = 46;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine Object.
        /// </summary>
        public const uint OPCUAServerType_Machine = 56;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Temperature Object.
        /// </summary>
        public const uint OPCUAServerType_Machine_Temperature = 57;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Proximity Object.
        /// </summary>
        public const uint OPCUAServerType_Machine_Proximity = 64;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor Object.
        /// </summary>
        public const uint OPCUAServerType_Machine_Conveyor = 71;

        /// <summary>
        /// The identifier for the OPCUAServer1 Object.
        /// </summary>
        public const uint OPCUAServer1 = 80;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine Object.
        /// </summary>
        public const uint OPCUAServer1_Machine = 81;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Temperature Object.
        /// </summary>
        public const uint OPCUAServer1_Machine_Temperature = 82;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Proximity Object.
        /// </summary>
        public const uint OPCUAServer1_Machine_Proximity = 89;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor Object.
        /// </summary>
        public const uint OPCUAServer1_Machine_Conveyor = 96;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 1;

        /// <summary>
        /// The identifier for the TemperatureSensor ObjectType.
        /// </summary>
        public const uint TemperatureSensor = 8;

        /// <summary>
        /// The identifier for the ProximitySensor ObjectType.
        /// </summary>
        public const uint ProximitySensor = 15;

        /// <summary>
        /// The identifier for the MotorConveyor ObjectType.
        /// </summary>
        public const uint MotorConveyor = 22;

        /// <summary>
        /// The identifier for the MachineType ObjectType.
        /// </summary>
        public const uint MachineType = 31;

        /// <summary>
        /// The identifier for the OPCUAServerType ObjectType.
        /// </summary>
        public const uint OPCUAServerType = 55;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Value Variable.
        /// </summary>
        public const uint GenericSensorType_Value = 2;

        /// <summary>
        /// The identifier for the GenericSensorType_Value_EURange Variable.
        /// </summary>
        public const uint GenericSensorType_Value_EURange = 6;

        /// <summary>
        /// The identifier for the TemperatureSensor_Value_EURange Variable.
        /// </summary>
        public const uint TemperatureSensor_Value_EURange = 13;

        /// <summary>
        /// The identifier for the ProximitySensor_Value_EURange Variable.
        /// </summary>
        public const uint ProximitySensor_Value_EURange = 20;

        /// <summary>
        /// The identifier for the MotorConveyor_Speed Variable.
        /// </summary>
        public const uint MotorConveyor_Speed = 23;

        /// <summary>
        /// The identifier for the MotorConveyor_Speed_EURange Variable.
        /// </summary>
        public const uint MotorConveyor_Speed_EURange = 27;

        /// <summary>
        /// The identifier for the MachineType_Temperature_Value Variable.
        /// </summary>
        public const uint MachineType_Temperature_Value = 33;

        /// <summary>
        /// The identifier for the MachineType_Temperature_Value_EURange Variable.
        /// </summary>
        public const uint MachineType_Temperature_Value_EURange = 37;

        /// <summary>
        /// The identifier for the MachineType_Proximity_Value Variable.
        /// </summary>
        public const uint MachineType_Proximity_Value = 40;

        /// <summary>
        /// The identifier for the MachineType_Proximity_Value_EURange Variable.
        /// </summary>
        public const uint MachineType_Proximity_Value_EURange = 44;

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Speed Variable.
        /// </summary>
        public const uint MachineType_Conveyor_Speed = 47;

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Speed_EURange Variable.
        /// </summary>
        public const uint MachineType_Conveyor_Speed_EURange = 51;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Temperature_Value Variable.
        /// </summary>
        public const uint OPCUAServerType_Machine_Temperature_Value = 58;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Temperature_Value_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_Machine_Temperature_Value_EURange = 62;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Proximity_Value Variable.
        /// </summary>
        public const uint OPCUAServerType_Machine_Proximity_Value = 65;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Proximity_Value_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_Machine_Proximity_Value_EURange = 69;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Speed Variable.
        /// </summary>
        public const uint OPCUAServerType_Machine_Conveyor_Speed = 72;

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Speed_EURange Variable.
        /// </summary>
        public const uint OPCUAServerType_Machine_Conveyor_Speed_EURange = 76;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Temperature_Value Variable.
        /// </summary>
        public const uint OPCUAServer1_Machine_Temperature_Value = 83;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Temperature_Value_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_Machine_Temperature_Value_EURange = 87;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Proximity_Value Variable.
        /// </summary>
        public const uint OPCUAServer1_Machine_Proximity_Value = 90;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Proximity_Value_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_Machine_Proximity_Value_EURange = 94;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Speed Variable.
        /// </summary>
        public const uint OPCUAServer1_Machine_Conveyor_Speed = 97;

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Speed_EURange Variable.
        /// </summary>
        public const uint OPCUAServer1_Machine_Conveyor_Speed_EURange = 101;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the MotorConveyor_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId MotorConveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.MotorConveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MotorConveyor_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId MotorConveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.MotorConveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Conveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.MachineType_Conveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Conveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.MachineType_Conveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_Machine_Conveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServerType_Machine_Conveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Start = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_Machine_Conveyor_Start, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Stop = new ExpandedNodeId(OPCUAServer.Methods.OPCUAServer1_Machine_Conveyor_Stop, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the MachineType_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Temperature = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Temperature, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Proximity Object.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Proximity = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Proximity, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Conveyor = new ExpandedNodeId(OPCUAServer.Objects.MachineType_Conveyor, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Temperature, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Proximity Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Proximity, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServerType_Machine_Conveyor, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1 Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1 = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Temperature Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Temperature, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Proximity Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Proximity, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor = new ExpandedNodeId(OPCUAServer.Objects.OPCUAServer1_Machine_Conveyor, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(OPCUAServer.ObjectTypes.GenericSensorType, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the TemperatureSensor ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensor = new ExpandedNodeId(OPCUAServer.ObjectTypes.TemperatureSensor, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the ProximitySensor ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProximitySensor = new ExpandedNodeId(OPCUAServer.ObjectTypes.ProximitySensor, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MotorConveyor ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MotorConveyor = new ExpandedNodeId(OPCUAServer.ObjectTypes.MotorConveyor, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MachineType = new ExpandedNodeId(OPCUAServer.ObjectTypes.MachineType, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType = new ExpandedNodeId(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Value = new ExpandedNodeId(OPCUAServer.Variables.GenericSensorType_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the GenericSensorType_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.GenericSensorType_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the TemperatureSensor_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId TemperatureSensor_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.TemperatureSensor_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the ProximitySensor_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProximitySensor_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.ProximitySensor_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MotorConveyor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId MotorConveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.MotorConveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MotorConveyor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MotorConveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.MotorConveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Temperature_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Temperature_Value = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Temperature_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Temperature_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Temperature_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Temperature_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Proximity_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Proximity_Value = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Proximity_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Proximity_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Proximity_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Proximity_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Conveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Conveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the MachineType_Conveyor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Conveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.MachineType_Conveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Temperature_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Temperature_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Temperature_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Temperature_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Temperature_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Proximity_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Proximity_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Proximity_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Proximity_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Proximity_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Conveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServerType_Machine_Conveyor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServerType_Machine_Conveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServerType_Machine_Conveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Temperature_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Temperature_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Temperature_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Temperature_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Temperature_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Proximity_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity_Value = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Proximity_Value, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Proximity_Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Proximity_Value_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Proximity_Value_EURange, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Speed = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Conveyor_Speed, OPCUAServer.Namespaces.OPCUAServer);

        /// <summary>
        /// The identifier for the OPCUAServer1_Machine_Conveyor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId OPCUAServer1_Machine_Conveyor_Speed_EURange = new ExpandedNodeId(OPCUAServer.Variables.OPCUAServer1_Machine_Conveyor_Speed_EURange, OPCUAServer.Namespaces.OPCUAServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Conveyor component.
        /// </summary>
        public const string Conveyor = "Conveyor";

        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the Machine component.
        /// </summary>
        public const string Machine = "Machine";

        /// <summary>
        /// The BrowseName for the MachineType component.
        /// </summary>
        public const string MachineType = "MachineType";

        /// <summary>
        /// The BrowseName for the MotorConveyor component.
        /// </summary>
        public const string MotorConveyor = "MotorConveyor";

        /// <summary>
        /// The BrowseName for the OPCUAServer1 component.
        /// </summary>
        public const string OPCUAServer1 = "Line";

        /// <summary>
        /// The BrowseName for the OPCUAServerType component.
        /// </summary>
        public const string OPCUAServerType = "OPCUAServerType";

        /// <summary>
        /// The BrowseName for the Proximity component.
        /// </summary>
        public const string Proximity = "Proximity";

        /// <summary>
        /// The BrowseName for the ProximitySensor component.
        /// </summary>
        public const string ProximitySensor = "ProximitySensor";

        /// <summary>
        /// The BrowseName for the Speed component.
        /// </summary>
        public const string Speed = "Speed";

        /// <summary>
        /// The BrowseName for the Start component.
        /// </summary>
        public const string Start = "Start";

        /// <summary>
        /// The BrowseName for the Stop component.
        /// </summary>
        public const string Stop = "Stop";

        /// <summary>
        /// The BrowseName for the Temperature component.
        /// </summary>
        public const string Temperature = "Temperature";

        /// <summary>
        /// The BrowseName for the TemperatureSensor component.
        /// </summary>
        public const string TemperatureSensor = "TemperatureSensor";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OPCUAServer namespace (.NET code namespace is 'OPCUAServer').
        /// </summary>
        public const string OPCUAServer = "http://opcfoundation.org/OPCUAServer";
    }
    #endregion

    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <summary>
    /// Stores an instance of the GenericSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.GenericSensorType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQEBAAEBAQABAAAA/////wEAAAAVYIkKAgAAAAEABQAA" +
           "AFZhbHVlAQECAAAvAQBACQIAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEG" +
           "AAAuAEQGAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Value
        {
            get
            {
                return m_value;
            }

            set
            {
                if (!Object.ReferenceEquals(m_value, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_value = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_value != null)
            {
                children.Add(m_value);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.Value:
                {
                    if (createOrReplace)
                    {
                        if (Value == null)
                        {
                            if (replacement == null)
                            {
                                Value = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Value = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Value;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_value;
        #endregion
    }
    #endif
    #endregion

    #region TemperatureSensorState Class
    #if (!OPCUA_EXCLUDE_TemperatureSensorState)
    /// <summary>
    /// Stores an instance of the TemperatureSensor ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureSensorState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.TemperatureSensor, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABkA" +
           "AABUZW1wZXJhdHVyZVNlbnNvckluc3RhbmNlAQEIAAEBCAAIAAAA/////wEAAAAVYIkKAgAAAAEABQAA" +
           "AFZhbHVlAQEJAAAvAQBACQkAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEN" +
           "AAAuAEQNAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ProximitySensorState Class
    #if (!OPCUA_EXCLUDE_ProximitySensorState)
    /// <summary>
    /// Stores an instance of the ProximitySensor ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProximitySensorState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProximitySensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.ProximitySensor, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABcA" +
           "AABQcm94aW1pdHlTZW5zb3JJbnN0YW5jZQEBDwABAQ8ADwAAAP////8BAAAAFWCJCgIAAAABAAUAAABW" +
           "YWx1ZQEBEAAALwEAQAkQAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBFAAA" +
           "LgBEFAAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MotorConveyorState Class
    #if (!OPCUA_EXCLUDE_MotorConveyorState)
    /// <summary>
    /// Stores an instance of the MotorConveyor ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MotorConveyorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MotorConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.MotorConveyor, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABUA" +
           "AABNb3RvckNvbnZleW9ySW5zdGFuY2UBARYAAQEWABYAAAD/////AwAAABVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQBARcAAC8BAEAJFwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARsAAC4A" +
           "RBsAAAABAHQD/////wEB/////wAAAAAEYYIKBAAAAAEABQAAAFN0YXJ0AQEdAAAvAQEdAB0AAAABAf//" +
           "//8AAAAABGGCCgQAAAABAAQAAABTdG9wAQEeAAAvAQEeAB4AAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }

        /// <remarks />
        public MethodState Start
        {
            get
            {
                return m_startMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startMethod = value;
            }
        }

        /// <remarks />
        public MethodState Stop
        {
            get
            {
                return m_stopMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            if (m_startMethod != null)
            {
                children.Add(m_startMethod);
            }

            if (m_stopMethod != null)
            {
                children.Add(m_stopMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }

                case OPCUAServer.BrowseNames.Start:
                {
                    if (createOrReplace)
                    {
                        if (Start == null)
                        {
                            if (replacement == null)
                            {
                                Start = new MethodState(this);
                            }
                            else
                            {
                                Start = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Start;
                    break;
                }

                case OPCUAServer.BrowseNames.Stop:
                {
                    if (createOrReplace)
                    {
                        if (Stop == null)
                        {
                            if (replacement == null)
                            {
                                Stop = new MethodState(this);
                            }
                            else
                            {
                                Stop = (MethodState)replacement;
                            }
                        }
                    }

                    instance = Stop;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_speed;
        private MethodState m_startMethod;
        private MethodState m_stopMethod;
        #endregion
    }
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <summary>
    /// Stores an instance of the MachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.MachineType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////BGCAAgEAAAABABMA" +
           "AABNYWNoaW5lVHlwZUluc3RhbmNlAQEfAAEBHwAfAAAA/////wMAAACEYIAKAQAAAAEACwAAAFRlbXBl" +
           "cmF0dXJlAQEgAAAvAQEIACAAAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFZhbHVlAQEhAAAvAQBACSEA" +
           "AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQElAAAuAEQlAAAAAQB0A/////8B" +
           "Af////8AAAAAhGCACgEAAAABAAkAAABQcm94aW1pdHkBAScAAC8BAQ8AJwAAAAH/////AQAAABVgiQoC" +
           "AAAAAQAFAAAAVmFsdWUBASgAAC8BAEAJKAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBASwAAC4ARCwAAAABAHQD/////wEB/////wAAAACEYIAKAQAAAAEACAAAAENvbnZleW9yAQEu" +
           "AAAvAQEWAC4AAAAB/////wMAAAAVYIkKAgAAAAEABQAAAFNwZWVkAQEvAAAvAQBACS8AAAAAC/////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEzAAAuAEQzAAAAAQB0A/////8BAf////8AAAAA" +
           "BGGCCgQAAAABAAUAAABTdGFydAEBNQAALwEBHQA1AAAAAQH/////AAAAAARhggoEAAAAAQAEAAAAU3Rv" +
           "cAEBNgAALwEBHgA2AAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public TemperatureSensorState Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }

        /// <remarks />
        public ProximitySensorState Proximity
        {
            get
            {
                return m_proximity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_proximity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_proximity = value;
            }
        }

        /// <remarks />
        public MotorConveyorState Conveyor
        {
            get
            {
                return m_conveyor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            if (m_proximity != null)
            {
                children.Add(m_proximity);
            }

            if (m_conveyor != null)
            {
                children.Add(m_conveyor);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new TemperatureSensorState(this);
                            }
                            else
                            {
                                Temperature = (TemperatureSensorState)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }

                case OPCUAServer.BrowseNames.Proximity:
                {
                    if (createOrReplace)
                    {
                        if (Proximity == null)
                        {
                            if (replacement == null)
                            {
                                Proximity = new ProximitySensorState(this);
                            }
                            else
                            {
                                Proximity = (ProximitySensorState)replacement;
                            }
                        }
                    }

                    instance = Proximity;
                    break;
                }

                case OPCUAServer.BrowseNames.Conveyor:
                {
                    if (createOrReplace)
                    {
                        if (Conveyor == null)
                        {
                            if (replacement == null)
                            {
                                Conveyor = new MotorConveyorState(this);
                            }
                            else
                            {
                                Conveyor = (MotorConveyorState)replacement;
                            }
                        }
                    }

                    instance = Conveyor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private TemperatureSensorState m_temperature;
        private ProximitySensorState m_proximity;
        private MotorConveyorState m_conveyor;
        #endregion
    }
    #endif
    #endregion

    #region OPCUAServerState Class
    #if (!OPCUA_EXCLUDE_OPCUAServerState)
    /// <summary>
    /// Stores an instance of the OPCUAServerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OPCUAServerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OPCUAServerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAServer.ObjectTypes.OPCUAServerType, OPCUAServer.Namespaces.OPCUAServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACQAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvT1BDVUFTZXJ2ZXL/////hGCAAgEAAAABABcA" +
           "AABPUENVQVNlcnZlclR5cGVJbnN0YW5jZQEBNwABATcANwAAAAH/////AQAAAIRggAoBAAAAAQAHAAAA" +
           "TWFjaGluZQEBOAAALwEBHwA4AAAAAf////8DAAAAhGCACgEAAAABAAsAAABUZW1wZXJhdHVyZQEBOQAA" +
           "LwEBCAA5AAAAAf////8BAAAAFWCJCgIAAAABAAUAAABWYWx1ZQEBOgAALwEAQAk6AAAAAAv/////AQH/" +
           "////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBPgAALgBEPgAAAAEAdAP/////AQH/////AAAAAIRg" +
           "gAoBAAAAAQAJAAAAUHJveGltaXR5AQFAAAAvAQEPAEAAAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFZh" +
           "bHVlAQFBAAAvAQBACUEAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFFAAAu" +
           "AERFAAAAAQB0A/////8BAf////8AAAAAhGCACgEAAAABAAgAAABDb252ZXlvcgEBRwAALwEBFgBHAAAA" +
           "Af////8DAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBSAAALwEAQAlIAAAAAAv/////AwP/////AQAAABVg" +
           "iQoCAAAAAAAHAAAARVVSYW5nZQEBTAAALgBETAAAAAEAdAP/////AQH/////AAAAAARhggoEAAAAAQAF" +
           "AAAAU3RhcnQBAU4AAC8BAR0ATgAAAAEB/////wAAAAAEYYIKBAAAAAEABAAAAFN0b3ABAU8AAC8BAR4A" +
           "TwAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MachineState Machine
        {
            get
            {
                return m_machine;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machine, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machine = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_machine != null)
            {
                children.Add(m_machine);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case OPCUAServer.BrowseNames.Machine:
                {
                    if (createOrReplace)
                    {
                        if (Machine == null)
                        {
                            if (replacement == null)
                            {
                                Machine = new MachineState(this);
                            }
                            else
                            {
                                Machine = (MachineState)replacement;
                            }
                        }
                    }

                    instance = Machine;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MachineState m_machine;
        #endregion
    }
    #endif
    #endregion
}