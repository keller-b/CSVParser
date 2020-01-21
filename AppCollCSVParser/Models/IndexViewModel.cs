using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppCollCSVParser.Models
{
    public class IndexViewModel
    {
        public string TableHtml { get; set; }
        public DataTable Table { get; set; }
        public List<DataRow> Result { get; set; }
        public int AssistanceCount { get; set; }
    }
}
