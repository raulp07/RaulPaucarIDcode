﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoIDCode.WSAlumnos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumno", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Dominio")]
    [System.SerializableAttribute()]
    public partial class Alumno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cd_alumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cd_padreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cd_pagoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ds_apellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ds_identificador_alumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ds_nombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cd_alumno {
            get {
                return this.cd_alumnoField;
            }
            set {
                if ((this.cd_alumnoField.Equals(value) != true)) {
                    this.cd_alumnoField = value;
                    this.RaisePropertyChanged("cd_alumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cd_padre {
            get {
                return this.cd_padreField;
            }
            set {
                if ((object.ReferenceEquals(this.cd_padreField, value) != true)) {
                    this.cd_padreField = value;
                    this.RaisePropertyChanged("cd_padre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cd_pago {
            get {
                return this.cd_pagoField;
            }
            set {
                if ((this.cd_pagoField.Equals(value) != true)) {
                    this.cd_pagoField = value;
                    this.RaisePropertyChanged("cd_pago");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ds_apellido {
            get {
                return this.ds_apellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ds_apellidoField, value) != true)) {
                    this.ds_apellidoField = value;
                    this.RaisePropertyChanged("ds_apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ds_identificador_alumno {
            get {
                return this.ds_identificador_alumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.ds_identificador_alumnoField, value) != true)) {
                    this.ds_identificador_alumnoField = value;
                    this.RaisePropertyChanged("ds_identificador_alumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ds_nombre {
            get {
                return this.ds_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.ds_nombreField, value) != true)) {
                    this.ds_nombreField = value;
                    this.RaisePropertyChanged("ds_nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSAlumnos.IAlumnosService")]
    public interface IAlumnosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/ConsultarAlumno", ReplyAction="http://tempuri.org/IAlumnosService/ConsultarAlumnoResponse")]
        ProyectoIDCode.WSAlumnos.Alumno ConsultarAlumno(int cd_alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/ConsultarAlumno", ReplyAction="http://tempuri.org/IAlumnosService/ConsultarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoIDCode.WSAlumnos.Alumno> ConsultarAlumnoAsync(int cd_alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/registarAlumno", ReplyAction="http://tempuri.org/IAlumnosService/registarAlumnoResponse")]
        ProyectoIDCode.WSAlumnos.Alumno registarAlumno(string cd_padre, string ds_nombre, int cd_grado, string ds_apellido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/registarAlumno", ReplyAction="http://tempuri.org/IAlumnosService/registarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoIDCode.WSAlumnos.Alumno> registarAlumnoAsync(string cd_padre, string ds_nombre, int cd_grado, string ds_apellido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/ListarAlumno", ReplyAction="http://tempuri.org/IAlumnosService/ListarAlumnoResponse")]
        ProyectoIDCode.WSAlumnos.Alumno[] ListarAlumno(string id_padre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlumnosService/ListarAlumno", ReplyAction="http://tempuri.org/IAlumnosService/ListarAlumnoResponse")]
        System.Threading.Tasks.Task<ProyectoIDCode.WSAlumnos.Alumno[]> ListarAlumnoAsync(string id_padre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlumnosServiceChannel : ProyectoIDCode.WSAlumnos.IAlumnosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlumnosServiceClient : System.ServiceModel.ClientBase<ProyectoIDCode.WSAlumnos.IAlumnosService>, ProyectoIDCode.WSAlumnos.IAlumnosService {
        
        public AlumnosServiceClient() {
        }
        
        public AlumnosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlumnosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlumnosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProyectoIDCode.WSAlumnos.Alumno ConsultarAlumno(int cd_alumno) {
            return base.Channel.ConsultarAlumno(cd_alumno);
        }
        
        public System.Threading.Tasks.Task<ProyectoIDCode.WSAlumnos.Alumno> ConsultarAlumnoAsync(int cd_alumno) {
            return base.Channel.ConsultarAlumnoAsync(cd_alumno);
        }
        
        public ProyectoIDCode.WSAlumnos.Alumno registarAlumno(string cd_padre, string ds_nombre, int cd_grado, string ds_apellido) {
            return base.Channel.registarAlumno(cd_padre, ds_nombre, cd_grado, ds_apellido);
        }
        
        public System.Threading.Tasks.Task<ProyectoIDCode.WSAlumnos.Alumno> registarAlumnoAsync(string cd_padre, string ds_nombre, int cd_grado, string ds_apellido) {
            return base.Channel.registarAlumnoAsync(cd_padre, ds_nombre, cd_grado, ds_apellido);
        }
        
        public ProyectoIDCode.WSAlumnos.Alumno[] ListarAlumno(string id_padre) {
            return base.Channel.ListarAlumno(id_padre);
        }
        
        public System.Threading.Tasks.Task<ProyectoIDCode.WSAlumnos.Alumno[]> ListarAlumnoAsync(string id_padre) {
            return base.Channel.ListarAlumnoAsync(id_padre);
        }
    }
}