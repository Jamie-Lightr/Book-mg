using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    public class Book
    {
        public Book() { }
        public Object bkID { get; set; }
        public Object bkCode { get; set; }
        public Object bkName { get; set; }
        public Object bkAuthor { get; set; }
        public Object bkPress { get; set; }
        public Object bkDatePress { get; set; }
        public Object bkISBN { get; set; }
        public Object bkCatalog { get; set; }
        public Object bkLanguage { get; set; }
        public Object bkPages { get; set; }
        public Object bkPrice { get; set; }
        public Object bkDateIn { get; set; }
        public Object bkBrief { get; set; }
        public Object bkCover { get; set; }
        public Object bkStatus { get; set; }

    }
    public class Book_f
    {
        public Book_f() { }
        public int bkID { get; set; }
        public string bkCode { get; set; }
        public string bkName { get; set; }
        public string bkAuthor { get; set; }
        public string bkPress { get; set; }
        public DateTime bkDatePress { get; set; }
        public string bkISBN { get; set; }
        public string bkCatalog { get; set; }
        public int bkLanguage { get; set; }
        public int bkPages { get; set; }
        public Decimal bkPrice { get; set; }
        public DateTime bkDateIn { get; set; }
        public string bkBrief { get; set; }
        public Byte[] bkCover { get; set; }
        public string bkStatus { get; set; }


    }
}
