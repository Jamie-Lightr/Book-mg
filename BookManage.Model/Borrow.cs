using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    public class Borrow
    {
        public Borrow()
        {
            this.BorrowID = null;
            this.rdID = null;
            this.bkID = null;
            this.IdContinueTimes = null;
            this.ldDateOut = null;
            this.ldDateRetPlan = null;
            this.ldDateRetAct = null;
            this.ldOverDay = null;
            this.ldOverMoney = null;
            this.ldPunishMoney = null;
            this.IsHasReturn = null;
            this.OperatorLend = null;
            this.OperatorRet = null;

        }
        public Object BorrowID { get; set; }
        public Object rdID { get; set; }
        public Object bkID { get; set; }
        public Object IdContinueTimes { get; set; }
        public Object ldDateOut { get; set; }
        public Object ldDateRetPlan { get; set; }
        public Object ldDateRetAct { get; set; }
        public Object ldOverDay { get; set; }
        public Object ldOverMoney { get; set; }
        public Object ldPunishMoney { get; set; }
        public Object IsHasReturn { get; set; }
        public Object OperatorLend { get; set; }
        public Object OperatorRet { get; set; }






    }
    public class Borrow_f
    {
        public Borrow_f() { }
        public Decimal BorrowID { get; set; }
        public int rdID { get; set; }
        public int bkID { get; set; }
        public int IdContinueTimes { get; set; }
        public DateTime ldDateOut { get; set; }
        public DateTime ldDateRetPlan { get; set; }
        public DateTime ldDateRetAct { get; set; }
        public int ldOverDay { get; set; }
        public Decimal ldOverMoney { get; set; }
        public Decimal ldPunishMoney { get; set; }
        public bool IsHasReturn { get; set; }
        public string OperatorLend { get; set; }
        public string OperatorRet { get; set; }






    }
}
