//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.StorageProviders.RedisStorage.GrainInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class Grain1Factory
    {
        

            public static IGrain1 Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return Grain1Reference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1")]
        internal class Grain1Reference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1
        {
            

            public static IGrain1 Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (IGrain1) global::Orleans.Runtime.GrainReference.CastInternal(typeof(IGrain1), (global::Orleans.Runtime.GrainReference gr) => { return new Grain1Reference(gr);}, grainRef, 1743709865);
            }
            
            protected internal Grain1Reference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal Grain1Reference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return 1743709865;
                }
            }
            
            public override string InterfaceName
            {
                get
                {
                    return "Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                Grain1Reference input = ((Grain1Reference)(original));
                return ((Grain1Reference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                Grain1Reference input = ((Grain1Reference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return Grain1Reference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return Grain1MethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1.Set(string @stringValue, int @intValue, System.DateTime @dateTimeValue, System.Guid @guidValue, Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1 @grainValue)
            {

                return base.InvokeMethodAsync<object>(-394250501, new object[] {@stringValue, @intValue, @dateTimeValue, @guidValue, @grainValue is global::Orleans.Grain ? @grainValue.AsReference<Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1>() : @grainValue} );
            }
            
            System.Threading.Tasks.Task<System.Tuple<string, int, System.DateTime, System.Guid, Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1>> Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1.Get()
            {

                return base.InvokeMethodAsync<System.Tuple<System.String,System.Int32,System.DateTime,System.Guid,Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1>>(-940922787, null );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.10.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("Orleans.StorageProviders.RedisStorage.GrainInterfaces.IGrain1", 1743709865)]
    internal class Grain1MethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return 1743709865;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1743709865:  // IGrain1
                        switch (methodId)
                        {
                            case -394250501: 
                                return ((IGrain1)grain).Set((System.String)arguments[0], (System.Int32)arguments[1], (System.DateTime)arguments[2], (System.Guid)arguments[3], (IGrain1)arguments[4]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            case -940922787: 
                                return ((IGrain1)grain).Get().ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)t.Result; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 1743709865:  // IGrain1
                    switch (methodId)
                    {
                        case -394250501:
                            return "Set";
                    case -940922787:
                            return "Get";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
