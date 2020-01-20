using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppCollCSVParser.Models
{
    public class IndexViewModel
    {
        //private DataTable _table;


        //public DataTable Table
        //{
        //    get
        //    {
        //        return this._table;
        //    }
        //    set
        //    {
        //        _table = value;
        //        AssistanceCount = Table.Select("[COUNT RECEIVES PUBLIC ASSISTANCE] > '0'").Count();
        //    }
        //}


        public string TableHtml { get; set; }
        public DataTable Table { get; set; }
        public List<DataRow> Result { get; set; }
        public int AssistanceCount { get; set; }
        public string Hello { get
            {
                return "Hello world.";
            } }
    }
}
