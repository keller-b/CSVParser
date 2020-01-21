using AppCollCSVParser.Models;
using CsvHelper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AppCollCSVParser.Tests
{
    [TestFixture]
    public class CSVReaderTests
    {
        [Test]
        public void ReadCSV_TableHasRowData()
        {
            int result = 1 + 2;
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
