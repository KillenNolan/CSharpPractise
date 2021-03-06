//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://LSSFTXProdEAI02/sync_OMS_SFC/writeToCenDB_wms_WS", ConfigurationName="ServiceReference1.writeToCenDB_wms_WS_PortType")]
    public interface writeToCenDB_wms_WS_PortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="sync_OMS_SFC_writeToCenDB_wms_WS_Binder_writeToCenDB_wms", ReplyAction="*")]
        ConsoleApp2.ServiceReference1.writeToCenDB_wmsResponse writeToCenDB_wms(ConsoleApp2.ServiceReference1.writeToCenDB_wmsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="sync_OMS_SFC_writeToCenDB_wms_WS_Binder_writeToCenDB_wms", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.writeToCenDB_wmsResponse> writeToCenDB_wmsAsync(ConsoleApp2.ServiceReference1.writeToCenDB_wmsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="process3A4Input", WrapperNamespace="http://LSSFTXProdEAI02/sync_OMS_SFC/writeToCenDB_wms_WS", IsWrapped=true)]
    public partial class writeToCenDB_wmsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string PLANT;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string CARTONID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string PALLETID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string WORKORDERNO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=4)]
        public string SKUNO;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=5)]
        public string CARTONQTY;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=6)]
        public string PO_NUMBER;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=7)]
        public string OM_FLAG;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=8)]
        public string LASTEDITBY;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=9)]
        public string LASTEDITDT;
        
        public writeToCenDB_wmsRequest() {
        }
        
        public writeToCenDB_wmsRequest(string PLANT, string CARTONID, string PALLETID, string WORKORDERNO, string SKUNO, string CARTONQTY, string PO_NUMBER, string OM_FLAG, string LASTEDITBY, string LASTEDITDT) {
            this.PLANT = PLANT;
            this.CARTONID = CARTONID;
            this.PALLETID = PALLETID;
            this.WORKORDERNO = WORKORDERNO;
            this.SKUNO = SKUNO;
            this.CARTONQTY = CARTONQTY;
            this.PO_NUMBER = PO_NUMBER;
            this.OM_FLAG = OM_FLAG;
            this.LASTEDITBY = LASTEDITBY;
            this.LASTEDITDT = LASTEDITDT;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="process3A4Output", WrapperNamespace="http://LSSFTXProdEAI02/sync_OMS_SFC/writeToCenDB_wms_WS", IsWrapped=true)]
    public partial class writeToCenDB_wmsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string flag;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string errorMessage;
        
        public writeToCenDB_wmsResponse() {
        }
        
        public writeToCenDB_wmsResponse(string flag, string errorMessage) {
            this.flag = flag;
            this.errorMessage = errorMessage;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface writeToCenDB_wms_WS_PortTypeChannel : ConsoleApp2.ServiceReference1.writeToCenDB_wms_WS_PortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class writeToCenDB_wms_WS_PortTypeClient : System.ServiceModel.ClientBase<ConsoleApp2.ServiceReference1.writeToCenDB_wms_WS_PortType>, ConsoleApp2.ServiceReference1.writeToCenDB_wms_WS_PortType {
        
        public writeToCenDB_wms_WS_PortTypeClient() {
        }
        
        public writeToCenDB_wms_WS_PortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public writeToCenDB_wms_WS_PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public writeToCenDB_wms_WS_PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public writeToCenDB_wms_WS_PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp2.ServiceReference1.writeToCenDB_wmsResponse ConsoleApp2.ServiceReference1.writeToCenDB_wms_WS_PortType.writeToCenDB_wms(ConsoleApp2.ServiceReference1.writeToCenDB_wmsRequest request) {
            return base.Channel.writeToCenDB_wms(request);
        }
        
        public string writeToCenDB_wms(string PLANT, string CARTONID, string PALLETID, string WORKORDERNO, string SKUNO, string CARTONQTY, string PO_NUMBER, string OM_FLAG, string LASTEDITBY, string LASTEDITDT, out string errorMessage) {
            ConsoleApp2.ServiceReference1.writeToCenDB_wmsRequest inValue = new ConsoleApp2.ServiceReference1.writeToCenDB_wmsRequest();
            inValue.PLANT = PLANT;
            inValue.CARTONID = CARTONID;
            inValue.PALLETID = PALLETID;
            inValue.WORKORDERNO = WORKORDERNO;
            inValue.SKUNO = SKUNO;
            inValue.CARTONQTY = CARTONQTY;
            inValue.PO_NUMBER = PO_NUMBER;
            inValue.OM_FLAG = OM_FLAG;
            inValue.LASTEDITBY = LASTEDITBY;
            inValue.LASTEDITDT = LASTEDITDT;
            ConsoleApp2.ServiceReference1.writeToCenDB_wmsResponse retVal = ((ConsoleApp2.ServiceReference1.writeToCenDB_wms_WS_PortType)(this)).writeToCenDB_wms(inValue);
            errorMessage = retVal.errorMessage;
            return retVal.flag;
        }
        
        public System.Threading.Tasks.Task<ConsoleApp2.ServiceReference1.writeToCenDB_wmsResponse> writeToCenDB_wmsAsync(ConsoleApp2.ServiceReference1.writeToCenDB_wmsRequest request) {
            return base.Channel.writeToCenDB_wmsAsync(request);
        }
    }
}
