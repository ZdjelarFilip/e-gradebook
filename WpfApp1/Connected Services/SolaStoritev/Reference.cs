﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.SolaStoritev {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DatumRojstvaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriimekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfApp1.SolaStoritev.StudentImaPredmet[] studentImaPredmeteField;
        
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
        public System.DateTime DatumRojstva {
            get {
                return this.DatumRojstvaField;
            }
            set {
                if ((this.DatumRojstvaField.Equals(value) != true)) {
                    this.DatumRojstvaField = value;
                    this.RaisePropertyChanged("DatumRojstva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ime {
            get {
                return this.ImeField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeField, value) != true)) {
                    this.ImeField = value;
                    this.RaisePropertyChanged("Ime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Priimek {
            get {
                return this.PriimekField;
            }
            set {
                if ((object.ReferenceEquals(this.PriimekField, value) != true)) {
                    this.PriimekField = value;
                    this.RaisePropertyChanged("Priimek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfApp1.SolaStoritev.StudentImaPredmet[] studentImaPredmete {
            get {
                return this.studentImaPredmeteField;
            }
            set {
                if ((object.ReferenceEquals(this.studentImaPredmeteField, value) != true)) {
                    this.studentImaPredmeteField = value;
                    this.RaisePropertyChanged("studentImaPredmete");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentImaPredmet", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class StudentImaPredmet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfApp1.SolaStoritev.Predmet PredmetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Predmet_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfApp1.SolaStoritev.Student StudentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Student_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ocenaField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfApp1.SolaStoritev.Predmet Predmet {
            get {
                return this.PredmetField;
            }
            set {
                if ((object.ReferenceEquals(this.PredmetField, value) != true)) {
                    this.PredmetField = value;
                    this.RaisePropertyChanged("Predmet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Predmet_Id {
            get {
                return this.Predmet_IdField;
            }
            set {
                if ((this.Predmet_IdField.Equals(value) != true)) {
                    this.Predmet_IdField = value;
                    this.RaisePropertyChanged("Predmet_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfApp1.SolaStoritev.Student Student {
            get {
                return this.StudentField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentField, value) != true)) {
                    this.StudentField = value;
                    this.RaisePropertyChanged("Student");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Student_Id {
            get {
                return this.Student_IdField;
            }
            set {
                if ((this.Student_IdField.Equals(value) != true)) {
                    this.Student_IdField = value;
                    this.RaisePropertyChanged("Student_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ocena {
            get {
                return this.ocenaField;
            }
            set {
                if ((this.ocenaField.Equals(value) != true)) {
                    this.ocenaField = value;
                    this.RaisePropertyChanged("ocena");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Predmet", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Predmet : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EctsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KraticaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfApp1.SolaStoritev.StudentImaPredmet[] studentiImajoPredmetField;
        
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
        public int Ects {
            get {
                return this.EctsField;
            }
            set {
                if ((this.EctsField.Equals(value) != true)) {
                    this.EctsField = value;
                    this.RaisePropertyChanged("Ects");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kratica {
            get {
                return this.KraticaField;
            }
            set {
                if ((object.ReferenceEquals(this.KraticaField, value) != true)) {
                    this.KraticaField = value;
                    this.RaisePropertyChanged("Kratica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naziv {
            get {
                return this.NazivField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivField, value) != true)) {
                    this.NazivField = value;
                    this.RaisePropertyChanged("Naziv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfApp1.SolaStoritev.StudentImaPredmet[] studentiImajoPredmet {
            get {
                return this.studentiImajoPredmetField;
            }
            set {
                if ((object.ReferenceEquals(this.studentiImajoPredmetField, value) != true)) {
                    this.studentiImajoPredmetField = value;
                    this.RaisePropertyChanged("studentiImajoPredmet");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SolaStoritev.Istoritev")]
    public interface Istoritev {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/login", ReplyAction="http://tempuri.org/Istoritev/loginResponse")]
        int login(string ime, string geslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/login", ReplyAction="http://tempuri.org/Istoritev/loginResponse")]
        System.Threading.Tasks.Task<int> loginAsync(string ime, string geslo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniVseStudente", ReplyAction="http://tempuri.org/Istoritev/vrniVseStudenteResponse")]
        WpfApp1.SolaStoritev.Student[] vrniVseStudente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniVseStudente", ReplyAction="http://tempuri.org/Istoritev/vrniVseStudenteResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Student[]> vrniVseStudenteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniVsePredmete", ReplyAction="http://tempuri.org/Istoritev/vrniVsePredmeteResponse")]
        WpfApp1.SolaStoritev.Predmet[] vrniVsePredmete();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniVsePredmete", ReplyAction="http://tempuri.org/Istoritev/vrniVsePredmeteResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet[]> vrniVsePredmeteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniStudenta", ReplyAction="http://tempuri.org/Istoritev/vrniStudentaResponse")]
        WpfApp1.SolaStoritev.Student vrniStudenta(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniStudenta", ReplyAction="http://tempuri.org/Istoritev/vrniStudentaResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Student> vrniStudentaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniPredmet", ReplyAction="http://tempuri.org/Istoritev/vrniPredmetResponse")]
        WpfApp1.SolaStoritev.Predmet vrniPredmet(string kratica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniPredmet", ReplyAction="http://tempuri.org/Istoritev/vrniPredmetResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet> vrniPredmetAsync(string kratica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniPredmetPoId", ReplyAction="http://tempuri.org/Istoritev/vrniPredmetPoIdResponse")]
        WpfApp1.SolaStoritev.Predmet vrniPredmetPoId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniPredmetPoId", ReplyAction="http://tempuri.org/Istoritev/vrniPredmetPoIdResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet> vrniPredmetPoIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/predmetKiImaNajvecStudentov", ReplyAction="http://tempuri.org/Istoritev/predmetKiImaNajvecStudentovResponse")]
        WpfApp1.SolaStoritev.Predmet predmetKiImaNajvecStudentov();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/predmetKiImaNajvecStudentov", ReplyAction="http://tempuri.org/Istoritev/predmetKiImaNajvecStudentovResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet> predmetKiImaNajvecStudentovAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/najstarejsiStudent", ReplyAction="http://tempuri.org/Istoritev/najstarejsiStudentResponse")]
        WpfApp1.SolaStoritev.Student najstarejsiStudent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/najstarejsiStudent", ReplyAction="http://tempuri.org/Istoritev/najstarejsiStudentResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Student> najstarejsiStudentAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/povprecnaOcenaStudenta", ReplyAction="http://tempuri.org/Istoritev/povprecnaOcenaStudentaResponse")]
        double povprecnaOcenaStudenta(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/povprecnaOcenaStudenta", ReplyAction="http://tempuri.org/Istoritev/povprecnaOcenaStudentaResponse")]
        System.Threading.Tasks.Task<double> povprecnaOcenaStudentaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/dodajPredmet", ReplyAction="http://tempuri.org/Istoritev/dodajPredmetResponse")]
        bool dodajPredmet(string naziv, string kratica, int ects);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/dodajPredmet", ReplyAction="http://tempuri.org/Istoritev/dodajPredmetResponse")]
        System.Threading.Tasks.Task<bool> dodajPredmetAsync(string naziv, string kratica, int ects);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/dodajStudenta", ReplyAction="http://tempuri.org/Istoritev/dodajStudentaResponse")]
        bool dodajStudenta(string ime, string priimek, System.DateTime datum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/dodajStudenta", ReplyAction="http://tempuri.org/Istoritev/dodajStudentaResponse")]
        System.Threading.Tasks.Task<bool> dodajStudentaAsync(string ime, string priimek, System.DateTime datum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/izbrisiPredmet", ReplyAction="http://tempuri.org/Istoritev/izbrisiPredmetResponse")]
        bool izbrisiPredmet(string kratica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/izbrisiPredmet", ReplyAction="http://tempuri.org/Istoritev/izbrisiPredmetResponse")]
        System.Threading.Tasks.Task<bool> izbrisiPredmetAsync(string kratica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/izbrisiStudenta", ReplyAction="http://tempuri.org/Istoritev/izbrisiStudentaResponse")]
        bool izbrisiStudenta(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/izbrisiStudenta", ReplyAction="http://tempuri.org/Istoritev/izbrisiStudentaResponse")]
        System.Threading.Tasks.Task<bool> izbrisiStudentaAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/spremeniPredmet", ReplyAction="http://tempuri.org/Istoritev/spremeniPredmetResponse")]
        bool spremeniPredmet(string kratica, string novaKratica, string naziv, int ects);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/spremeniPredmet", ReplyAction="http://tempuri.org/Istoritev/spremeniPredmetResponse")]
        System.Threading.Tasks.Task<bool> spremeniPredmetAsync(string kratica, string novaKratica, string naziv, int ects);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/spremeniStudenta", ReplyAction="http://tempuri.org/Istoritev/spremeniStudentaResponse")]
        bool spremeniStudenta(int id, string ime, string priimek, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/spremeniStudenta", ReplyAction="http://tempuri.org/Istoritev/spremeniStudentaResponse")]
        System.Threading.Tasks.Task<bool> spremeniStudentaAsync(int id, string ime, string priimek, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/dodajStudentuPredmet", ReplyAction="http://tempuri.org/Istoritev/dodajStudentuPredmetResponse")]
        bool dodajStudentuPredmet(int id, string kratica, int ocena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/dodajStudentuPredmet", ReplyAction="http://tempuri.org/Istoritev/dodajStudentuPredmetResponse")]
        System.Threading.Tasks.Task<bool> dodajStudentuPredmetAsync(int id, string kratica, int ocena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/odstraniStudentaIzPredmeta", ReplyAction="http://tempuri.org/Istoritev/odstraniStudentaIzPredmetaResponse")]
        bool odstraniStudentaIzPredmeta(int id, string kratica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/odstraniStudentaIzPredmeta", ReplyAction="http://tempuri.org/Istoritev/odstraniStudentaIzPredmetaResponse")]
        System.Threading.Tasks.Task<bool> odstraniStudentaIzPredmetaAsync(int id, string kratica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/spremeniOcenoStudenta", ReplyAction="http://tempuri.org/Istoritev/spremeniOcenoStudentaResponse")]
        bool spremeniOcenoStudenta(int id, string kratica, int ocena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/spremeniOcenoStudenta", ReplyAction="http://tempuri.org/Istoritev/spremeniOcenoStudentaResponse")]
        System.Threading.Tasks.Task<bool> spremeniOcenoStudentaAsync(int id, string kratica, int ocena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniVseStudentImaPredmete", ReplyAction="http://tempuri.org/Istoritev/vrniVseStudentImaPredmeteResponse")]
        WpfApp1.SolaStoritev.StudentImaPredmet[] vrniVseStudentImaPredmete();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Istoritev/vrniVseStudentImaPredmete", ReplyAction="http://tempuri.org/Istoritev/vrniVseStudentImaPredmeteResponse")]
        System.Threading.Tasks.Task<WpfApp1.SolaStoritev.StudentImaPredmet[]> vrniVseStudentImaPredmeteAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IstoritevChannel : WpfApp1.SolaStoritev.Istoritev, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IstoritevClient : System.ServiceModel.ClientBase<WpfApp1.SolaStoritev.Istoritev>, WpfApp1.SolaStoritev.Istoritev {
        
        public IstoritevClient() {
        }
        
        public IstoritevClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IstoritevClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IstoritevClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IstoritevClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int login(string ime, string geslo) {
            return base.Channel.login(ime, geslo);
        }
        
        public System.Threading.Tasks.Task<int> loginAsync(string ime, string geslo) {
            return base.Channel.loginAsync(ime, geslo);
        }
        
        public WpfApp1.SolaStoritev.Student[] vrniVseStudente() {
            return base.Channel.vrniVseStudente();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Student[]> vrniVseStudenteAsync() {
            return base.Channel.vrniVseStudenteAsync();
        }
        
        public WpfApp1.SolaStoritev.Predmet[] vrniVsePredmete() {
            return base.Channel.vrniVsePredmete();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet[]> vrniVsePredmeteAsync() {
            return base.Channel.vrniVsePredmeteAsync();
        }
        
        public WpfApp1.SolaStoritev.Student vrniStudenta(int id) {
            return base.Channel.vrniStudenta(id);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Student> vrniStudentaAsync(int id) {
            return base.Channel.vrniStudentaAsync(id);
        }
        
        public WpfApp1.SolaStoritev.Predmet vrniPredmet(string kratica) {
            return base.Channel.vrniPredmet(kratica);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet> vrniPredmetAsync(string kratica) {
            return base.Channel.vrniPredmetAsync(kratica);
        }
        
        public WpfApp1.SolaStoritev.Predmet vrniPredmetPoId(int id) {
            return base.Channel.vrniPredmetPoId(id);
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet> vrniPredmetPoIdAsync(int id) {
            return base.Channel.vrniPredmetPoIdAsync(id);
        }
        
        public WpfApp1.SolaStoritev.Predmet predmetKiImaNajvecStudentov() {
            return base.Channel.predmetKiImaNajvecStudentov();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Predmet> predmetKiImaNajvecStudentovAsync() {
            return base.Channel.predmetKiImaNajvecStudentovAsync();
        }
        
        public WpfApp1.SolaStoritev.Student najstarejsiStudent() {
            return base.Channel.najstarejsiStudent();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.Student> najstarejsiStudentAsync() {
            return base.Channel.najstarejsiStudentAsync();
        }
        
        public double povprecnaOcenaStudenta(int id) {
            return base.Channel.povprecnaOcenaStudenta(id);
        }
        
        public System.Threading.Tasks.Task<double> povprecnaOcenaStudentaAsync(int id) {
            return base.Channel.povprecnaOcenaStudentaAsync(id);
        }
        
        public bool dodajPredmet(string naziv, string kratica, int ects) {
            return base.Channel.dodajPredmet(naziv, kratica, ects);
        }
        
        public System.Threading.Tasks.Task<bool> dodajPredmetAsync(string naziv, string kratica, int ects) {
            return base.Channel.dodajPredmetAsync(naziv, kratica, ects);
        }
        
        public bool dodajStudenta(string ime, string priimek, System.DateTime datum) {
            return base.Channel.dodajStudenta(ime, priimek, datum);
        }
        
        public System.Threading.Tasks.Task<bool> dodajStudentaAsync(string ime, string priimek, System.DateTime datum) {
            return base.Channel.dodajStudentaAsync(ime, priimek, datum);
        }
        
        public bool izbrisiPredmet(string kratica) {
            return base.Channel.izbrisiPredmet(kratica);
        }
        
        public System.Threading.Tasks.Task<bool> izbrisiPredmetAsync(string kratica) {
            return base.Channel.izbrisiPredmetAsync(kratica);
        }
        
        public bool izbrisiStudenta(int id) {
            return base.Channel.izbrisiStudenta(id);
        }
        
        public System.Threading.Tasks.Task<bool> izbrisiStudentaAsync(int id) {
            return base.Channel.izbrisiStudentaAsync(id);
        }
        
        public bool spremeniPredmet(string kratica, string novaKratica, string naziv, int ects) {
            return base.Channel.spremeniPredmet(kratica, novaKratica, naziv, ects);
        }
        
        public System.Threading.Tasks.Task<bool> spremeniPredmetAsync(string kratica, string novaKratica, string naziv, int ects) {
            return base.Channel.spremeniPredmetAsync(kratica, novaKratica, naziv, ects);
        }
        
        public bool spremeniStudenta(int id, string ime, string priimek, System.DateTime dt) {
            return base.Channel.spremeniStudenta(id, ime, priimek, dt);
        }
        
        public System.Threading.Tasks.Task<bool> spremeniStudentaAsync(int id, string ime, string priimek, System.DateTime dt) {
            return base.Channel.spremeniStudentaAsync(id, ime, priimek, dt);
        }
        
        public bool dodajStudentuPredmet(int id, string kratica, int ocena) {
            return base.Channel.dodajStudentuPredmet(id, kratica, ocena);
        }
        
        public System.Threading.Tasks.Task<bool> dodajStudentuPredmetAsync(int id, string kratica, int ocena) {
            return base.Channel.dodajStudentuPredmetAsync(id, kratica, ocena);
        }
        
        public bool odstraniStudentaIzPredmeta(int id, string kratica) {
            return base.Channel.odstraniStudentaIzPredmeta(id, kratica);
        }
        
        public System.Threading.Tasks.Task<bool> odstraniStudentaIzPredmetaAsync(int id, string kratica) {
            return base.Channel.odstraniStudentaIzPredmetaAsync(id, kratica);
        }
        
        public bool spremeniOcenoStudenta(int id, string kratica, int ocena) {
            return base.Channel.spremeniOcenoStudenta(id, kratica, ocena);
        }
        
        public System.Threading.Tasks.Task<bool> spremeniOcenoStudentaAsync(int id, string kratica, int ocena) {
            return base.Channel.spremeniOcenoStudentaAsync(id, kratica, ocena);
        }
        
        public WpfApp1.SolaStoritev.StudentImaPredmet[] vrniVseStudentImaPredmete() {
            return base.Channel.vrniVseStudentImaPredmete();
        }
        
        public System.Threading.Tasks.Task<WpfApp1.SolaStoritev.StudentImaPredmet[]> vrniVseStudentImaPredmeteAsync() {
            return base.Channel.vrniVseStudentImaPredmeteAsync();
        }
    }
}