﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eInventory.Account_WebService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://exprohelp.com/", ConfigurationName="Account_WebService.Accounts_WebServiceSoap")]
    public interface Accounts_WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/Account_BooksInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Account_BooksInfo(out string processInfo, string unit_id, string from, string to, string ledgercode, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/AC_UnitsLedger", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet AC_UnitsLedger(out string processInfo, string unit_id, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/AC_GetLedgerInfoForEntry", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet AC_GetLedgerInfoForEntry(out string processInfo, string unit_id, string ledgerfor, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/AC_GetVoucherSummary", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet AC_GetVoucherSummary(out string processInfo, string unit_id, string vch_type, string vch_date, string login_id, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/AC_VoucherPosting", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string AC_VoucherPosting(out string processInfo, string unit_id, string vch_type, string cr_Ledger, string dr_ledger, decimal amount, string narration, string login_id, string voucher_no, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/AC_NewVoucherNo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string AC_NewVoucherNo(out string processInfo, string unit_id, string voucher_no, string login_id, string database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/GetQueryResult", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet GetQueryResult(string query, string Database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://exprohelp.com/QueryExecute", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string QueryExecute(string query, string Database);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Accounts_WebServiceSoapChannel : eInventory.Account_WebService.Accounts_WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Accounts_WebServiceSoapClient : System.ServiceModel.ClientBase<eInventory.Account_WebService.Accounts_WebServiceSoap>, eInventory.Account_WebService.Accounts_WebServiceSoap {
        
        public Accounts_WebServiceSoapClient() {
        }
        
        public Accounts_WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Accounts_WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Accounts_WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Accounts_WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Data.DataSet Account_BooksInfo(out string processInfo, string unit_id, string from, string to, string ledgercode, string database) {
            return base.Channel.Account_BooksInfo(out processInfo, unit_id, from, to, ledgercode, database);
        }
        
        public System.Data.DataSet AC_UnitsLedger(out string processInfo, string unit_id, string database) {
            return base.Channel.AC_UnitsLedger(out processInfo, unit_id, database);
        }
        
        public System.Data.DataSet AC_GetLedgerInfoForEntry(out string processInfo, string unit_id, string ledgerfor, string database) {
            return base.Channel.AC_GetLedgerInfoForEntry(out processInfo, unit_id, ledgerfor, database);
        }
        
        public System.Data.DataSet AC_GetVoucherSummary(out string processInfo, string unit_id, string vch_type, string vch_date, string login_id, string database) {
            return base.Channel.AC_GetVoucherSummary(out processInfo, unit_id, vch_type, vch_date, login_id, database);
        }
        
        public string AC_VoucherPosting(out string processInfo, string unit_id, string vch_type, string cr_Ledger, string dr_ledger, decimal amount, string narration, string login_id, string voucher_no, string database) {
            return base.Channel.AC_VoucherPosting(out processInfo, unit_id, vch_type, cr_Ledger, dr_ledger, amount, narration, login_id, voucher_no, database);
        }
        
        public string AC_NewVoucherNo(out string processInfo, string unit_id, string voucher_no, string login_id, string database) {
            return base.Channel.AC_NewVoucherNo(out processInfo, unit_id, voucher_no, login_id, database);
        }
        
        public System.Data.DataSet GetQueryResult(string query, string Database) {
            return base.Channel.GetQueryResult(query, Database);
        }
        
        public string QueryExecute(string query, string Database) {
            return base.Channel.QueryExecute(query, Database);
        }
    }
}
