using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CourseProject
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel()
        {
        }

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
            ws.Columns.EntireColumn.AutoFit();
        }

        public void WriteToCell(int i, int j, string data)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = data;
        }

        public void CreateNewFile() => this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

        public void Save() => wb.Save();

        public void SaveAs(string path) => wb.SaveAs(path);

        public void Close()
        {
            wb.Close();
            excel.Quit();
            excel = null;
            wb = null;
            ws = null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
    }
}