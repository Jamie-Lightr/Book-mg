using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    public class ReaderType
    {
        public ReaderType() { }
        public object rdType { get; set; }
        public object rdTypeName { get; set; }
        public object CanLendQty { get; set; }
        public object CanLendDay { get; set; }
        public object CanContinueTimes { get; set; }
        public object PunishRate { get; set; }
        public object DateValid { get; set; }






    }
    public class ReaderType_f
    {
        public ReaderType_f() { }
        public int rdType { get; set; }
        public string rdTypeName { get; set; }
        public int CanLendQty { get; set; }
        public int CanLendDay { get; set; }
        public int CanContinueTimes { get; set; }
        public float PunishRate { get; set; }
        public int DateValid { get; set; }
        
        
        
        
    
    
    }
}
