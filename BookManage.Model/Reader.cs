using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    public class Reader
    {
        public Reader(){}
        public object rdID { get; set; }
        public object rdType { get; set; }
        public object rdName { get; set; }
        public object rdDept { get; set; }
        public object rdSex { get; set; }
        public object rdPwd { get; set; }
        public object rdStatus { get; set; }
        public object rdPhoto { get; set; }
        public object rdDateReg { get; set; }
        public object rdEmail { get; set; }
        public object rdPhone { get; set; }
        public object rdQQ { get; set; }
        public object rdBorrowQty { get; set; }
        public object rdAdminRoles { get; set; }
    }
    public class Reader_f
    {

        public Reader_f() { }
        public int rdID { get; set; }
        public int rdType { get; set; }
        public string rdName { get; set; }
        public string rdDept { get; set; }
        public string rdSex { get; set; }
        public string rdPwd { get; set; }
        public string rdStatus { get; set; }
        public string rdPhoto { get; set; }
        public DateTime rdDateReg { get; set; }
        public string rdEmail { get; set; }
        public string rdPhone { get; set; }
        public int rdQQ { get; set; }
        public int rdBorrowQty { get; set; }
        public int rdAdminRoles { get; set; }
        
       
        /*
        
        
        
        */
    }
    
}
