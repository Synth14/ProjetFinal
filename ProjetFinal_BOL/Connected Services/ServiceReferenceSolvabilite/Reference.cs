﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetFinal_BOL.ServiceReferenceSolvabilite {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSolvabilite.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Solvabilite", ReplyAction="http://tempuri.org/IService1/SolvabiliteResponse")]
        int Solvabilite();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Solvabilite", ReplyAction="http://tempuri.org/IService1/SolvabiliteResponse")]
        System.Threading.Tasks.Task<int> SolvabiliteAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ProjetFinal_BOL.ServiceReferenceSolvabilite.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ProjetFinal_BOL.ServiceReferenceSolvabilite.IService1>, ProjetFinal_BOL.ServiceReferenceSolvabilite.IService1 {
        
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
        
        public int Solvabilite() {
            return base.Channel.Solvabilite();
        }
        
        public System.Threading.Tasks.Task<int> SolvabiliteAsync() {
            return base.Channel.SolvabiliteAsync();
        }
    }
}
