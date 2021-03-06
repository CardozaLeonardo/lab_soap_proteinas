//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlProteinasClient.ServicioControlProteinas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://simpleprogrammer.com")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private int GoalField;
        
        private int TotalField;
        
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int Goal {
            get {
                return this.GoalField;
            }
            set {
                if ((this.GoalField.Equals(value) != true)) {
                    this.GoalField = value;
                    this.RaisePropertyChanged("Goal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://simpleprogrammer.com", ConfigurationName="ServicioControlProteinas.ProteinTrackingServiceSoap")]
    public interface ProteinTrackingServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://simpleprogrammer.com/AddProtein", ReplyAction="*")]
        int AddProtein(int amount, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://simpleprogrammer.com/AddProtein", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddProteinAsync(int amount, int userId);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres http://simpleprogrammer.com no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://simpleprogrammer.com/AddUser", ReplyAction="*")]
        ControlProteinasClient.ServicioControlProteinas.AddUserResponse AddUser(ControlProteinasClient.ServicioControlProteinas.AddUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://simpleprogrammer.com/AddUser", ReplyAction="*")]
        System.Threading.Tasks.Task<ControlProteinasClient.ServicioControlProteinas.AddUserResponse> AddUserAsync(ControlProteinasClient.ServicioControlProteinas.AddUserRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ListUsersResult del espacio de nombres http://simpleprogrammer.com no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://simpleprogrammer.com/ListUsers", ReplyAction="*")]
        ControlProteinasClient.ServicioControlProteinas.ListUsersResponse ListUsers(ControlProteinasClient.ServicioControlProteinas.ListUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://simpleprogrammer.com/ListUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<ControlProteinasClient.ServicioControlProteinas.ListUsersResponse> ListUsersAsync(ControlProteinasClient.ServicioControlProteinas.ListUsersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddUser", Namespace="http://simpleprogrammer.com", Order=0)]
        public ControlProteinasClient.ServicioControlProteinas.AddUserRequestBody Body;
        
        public AddUserRequest() {
        }
        
        public AddUserRequest(ControlProteinasClient.ServicioControlProteinas.AddUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://simpleprogrammer.com")]
    public partial class AddUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int goal;
        
        public AddUserRequestBody() {
        }
        
        public AddUserRequestBody(string name, int goal) {
            this.name = name;
            this.goal = goal;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddUserResponse", Namespace="http://simpleprogrammer.com", Order=0)]
        public ControlProteinasClient.ServicioControlProteinas.AddUserResponseBody Body;
        
        public AddUserResponse() {
        }
        
        public AddUserResponse(ControlProteinasClient.ServicioControlProteinas.AddUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://simpleprogrammer.com")]
    public partial class AddUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddUserResult;
        
        public AddUserResponseBody() {
        }
        
        public AddUserResponseBody(int AddUserResult) {
            this.AddUserResult = AddUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListUsersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListUsers", Namespace="http://simpleprogrammer.com", Order=0)]
        public ControlProteinasClient.ServicioControlProteinas.ListUsersRequestBody Body;
        
        public ListUsersRequest() {
        }
        
        public ListUsersRequest(ControlProteinasClient.ServicioControlProteinas.ListUsersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListUsersRequestBody {
        
        public ListUsersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListUsersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListUsersResponse", Namespace="http://simpleprogrammer.com", Order=0)]
        public ControlProteinasClient.ServicioControlProteinas.ListUsersResponseBody Body;
        
        public ListUsersResponse() {
        }
        
        public ListUsersResponse(ControlProteinasClient.ServicioControlProteinas.ListUsersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://simpleprogrammer.com")]
    public partial class ListUsersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ControlProteinasClient.ServicioControlProteinas.User[] ListUsersResult;
        
        public ListUsersResponseBody() {
        }
        
        public ListUsersResponseBody(ControlProteinasClient.ServicioControlProteinas.User[] ListUsersResult) {
            this.ListUsersResult = ListUsersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProteinTrackingServiceSoapChannel : ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProteinTrackingServiceSoapClient : System.ServiceModel.ClientBase<ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap>, ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap {
        
        public ProteinTrackingServiceSoapClient() {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackingServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProteinTrackingServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddProtein(int amount, int userId) {
            return base.Channel.AddProtein(amount, userId);
        }
        
        public System.Threading.Tasks.Task<int> AddProteinAsync(int amount, int userId) {
            return base.Channel.AddProteinAsync(amount, userId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ControlProteinasClient.ServicioControlProteinas.AddUserResponse ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap.AddUser(ControlProteinasClient.ServicioControlProteinas.AddUserRequest request) {
            return base.Channel.AddUser(request);
        }
        
        public int AddUser(string name, int goal) {
            ControlProteinasClient.ServicioControlProteinas.AddUserRequest inValue = new ControlProteinasClient.ServicioControlProteinas.AddUserRequest();
            inValue.Body = new ControlProteinasClient.ServicioControlProteinas.AddUserRequestBody();
            inValue.Body.name = name;
            inValue.Body.goal = goal;
            ControlProteinasClient.ServicioControlProteinas.AddUserResponse retVal = ((ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap)(this)).AddUser(inValue);
            return retVal.Body.AddUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ControlProteinasClient.ServicioControlProteinas.AddUserResponse> ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap.AddUserAsync(ControlProteinasClient.ServicioControlProteinas.AddUserRequest request) {
            return base.Channel.AddUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ControlProteinasClient.ServicioControlProteinas.AddUserResponse> AddUserAsync(string name, int goal) {
            ControlProteinasClient.ServicioControlProteinas.AddUserRequest inValue = new ControlProteinasClient.ServicioControlProteinas.AddUserRequest();
            inValue.Body = new ControlProteinasClient.ServicioControlProteinas.AddUserRequestBody();
            inValue.Body.name = name;
            inValue.Body.goal = goal;
            return ((ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap)(this)).AddUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ControlProteinasClient.ServicioControlProteinas.ListUsersResponse ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap.ListUsers(ControlProteinasClient.ServicioControlProteinas.ListUsersRequest request) {
            return base.Channel.ListUsers(request);
        }
        
        public ControlProteinasClient.ServicioControlProteinas.User[] ListUsers() {
            ControlProteinasClient.ServicioControlProteinas.ListUsersRequest inValue = new ControlProteinasClient.ServicioControlProteinas.ListUsersRequest();
            inValue.Body = new ControlProteinasClient.ServicioControlProteinas.ListUsersRequestBody();
            ControlProteinasClient.ServicioControlProteinas.ListUsersResponse retVal = ((ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap)(this)).ListUsers(inValue);
            return retVal.Body.ListUsersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ControlProteinasClient.ServicioControlProteinas.ListUsersResponse> ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap.ListUsersAsync(ControlProteinasClient.ServicioControlProteinas.ListUsersRequest request) {
            return base.Channel.ListUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<ControlProteinasClient.ServicioControlProteinas.ListUsersResponse> ListUsersAsync() {
            ControlProteinasClient.ServicioControlProteinas.ListUsersRequest inValue = new ControlProteinasClient.ServicioControlProteinas.ListUsersRequest();
            inValue.Body = new ControlProteinasClient.ServicioControlProteinas.ListUsersRequestBody();
            return ((ControlProteinasClient.ServicioControlProteinas.ProteinTrackingServiceSoap)(this)).ListUsersAsync(inValue);
        }
    }
}
