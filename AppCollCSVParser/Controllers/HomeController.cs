using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppCollCSVParser.Models;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Data;
using System.ComponentModel;
using Newtonsoft.Json;

namespace AppCollCSVParser.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            IndexViewModel viewModel = new IndexViewModel();
            DataTable dt = new DataTable();
            using (var reader = new StreamReader(".\\Resources\\Demographic_Statistics_By_Zip_Code.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Do any configuration to `CsvReader` before creating CsvDataReader.
                using (var dr = new CsvDataReader(csv))
                {
                    //var dt = new DataTable();
                    //dt.Load(dr);
                    viewModel.Table = new DataTable();
                    viewModel.Table.Load(dr);
                    viewModel.TableHtml = ConvertDataTableToHTML(viewModel.Table);
                }
            }
            //  THIS LOOKS LIKE IT WORKS!!!!
            viewModel.AssistanceCount = viewModel.Table.Select("[COUNT RECEIVES PUBLIC ASSISTANCE] > '0'").Count();
            viewModel.Result = viewModel.Table.Select("[COUNT RECEIVES PUBLIC ASSISTANCE] > '0'").ToList();

            return View(viewModel);
        }

        //  https://stackoverflow.com/questions/19682996/datatable-to-html-table
        public static string ConvertDataTableToHTML(DataTable dt)
        {
            string html = "<table class=\"table table-bordered table-striped table-hover\" style=\"display: block; width: 75%; height: 600px; overflow - y: scroll; \">";
            //add header row
            html += "<thead class=\"thead-dark\">";
            html += "<tr>";
            for (int i = 0; i < dt.Columns.Count; i++)
                html += "<th>" + dt.Columns[i].ColumnName + "</th>";
            html += "</tr>";
            html += "</thead>";
            //add rows
            html += "<tbody>";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                    html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
                html += "</tr>";
            }
            html += "</tbody>";
            html += "</table>";
            return html;
        }

        public IActionResult Privacy() {
            return View();
        }

        public void Parse() {
            using (var reader = new StreamReader("//Resources/Demographic_Statistics_By_Zip_Code.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {
                //var records = csv.GetRecords<Foo>();
            }
        }
    }
}
