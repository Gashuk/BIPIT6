﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Веб_приложение.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Data.DataSet GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillOboryd", ReplyAction="http://tempuri.org/IService1/FillOborydResponse")]
        System.Data.DataSet FillOboryd();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillOboryd", ReplyAction="http://tempuri.org/IService1/FillOborydResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FillOborydAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillVid_rabot", ReplyAction="http://tempuri.org/IService1/FillVid_rabotResponse")]
        System.Data.DataSet FillVid_rabot();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillVid_rabot", ReplyAction="http://tempuri.org/IService1/FillVid_rabotResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FillVid_rabotAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRec", ReplyAction="http://tempuri.org/IService1/NewRecResponse")]
        void NewRec(string ID_OBORYD, string ID_VID_RABOT, string Data_polychen, string Data_vipolnen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRec", ReplyAction="http://tempuri.org/IService1/NewRecResponse")]
        System.Threading.Tasks.Task NewRecAsync(string ID_OBORYD, string ID_VID_RABOT, string Data_polychen, string Data_vipolnen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillStaff", ReplyAction="http://tempuri.org/IService1/FillStaffResponse")]
        System.Data.DataSet FillStaff();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillStaff", ReplyAction="http://tempuri.org/IService1/FillStaffResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FillStaffAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillPositions", ReplyAction="http://tempuri.org/IService1/FillPositionsResponse")]
        System.Data.DataSet FillPositions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FillPositions", ReplyAction="http://tempuri.org/IService1/FillPositionsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> FillPositionsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Веб_приложение.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Веб_приложение.ServiceReference1.IService1>, Веб_приложение.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public System.Data.DataSet FillOboryd() {
            return base.Channel.FillOboryd();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FillOborydAsync() {
            return base.Channel.FillOborydAsync();
        }
        
        public System.Data.DataSet FillVid_rabot() {
            return base.Channel.FillVid_rabot();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FillVid_rabotAsync() {
            return base.Channel.FillVid_rabotAsync();
        }
        
        public void NewRec(string ID_OBORYD, string ID_VID_RABOT, string Data_polychen, string Data_vipolnen) {
            base.Channel.NewRec(ID_OBORYD, ID_VID_RABOT, Data_polychen, Data_vipolnen);
        }
        
        public System.Threading.Tasks.Task NewRecAsync(string ID_OBORYD, string ID_VID_RABOT, string Data_polychen, string Data_vipolnen) {
            return base.Channel.NewRecAsync(ID_OBORYD, ID_VID_RABOT, Data_polychen, Data_vipolnen);
        }
        
        public System.Data.DataSet FillStaff() {
            return base.Channel.FillStaff();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FillStaffAsync() {
            return base.Channel.FillStaffAsync();
        }
        
        public System.Data.DataSet FillPositions() {
            return base.Channel.FillPositions();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FillPositionsAsync() {
            return base.Channel.FillPositionsAsync();
        }
    }
}
