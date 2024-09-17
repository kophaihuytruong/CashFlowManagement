using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using CentosCashFlow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CentosCashFlow.Models
{
    internal class ConnectExport
    {
        public void ExportDataTableToExcel(DataTable dataTable, string filePath)
        {
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                sheets.Append(sheet);

                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Add header row
                Row headerRow = new Row();
                foreach (DataColumn column in dataTable.Columns)
                {
                    Cell cell = new Cell(new CellValue(column.ColumnName));
                    headerRow.Append(cell);
                }
                sheetData.Append(headerRow);

                // Add data rows
                foreach (DataRow row in dataTable.Rows)
                {
                    Row newRow = new Row();
                    foreach (var cellValue in row.ItemArray)
                    {
                        Cell cell = new Cell(new CellValue(cellValue.ToString()));
                        newRow.Append(cell);
                    }
                    sheetData.Append(newRow);
                }
            }
        }
    }
}
