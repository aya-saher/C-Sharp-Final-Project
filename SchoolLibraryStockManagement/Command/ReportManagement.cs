using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
    public class GetOutofStock : ICommand2
    {
        private readonly IReport _report;
        public GetOutofStock(IReport report)
        {
            _report = report;
        }
        public DataTable Execute()
        {
            return _report.GetOutofStock();
        }
        public bool CanExecute()
        {
            return true;
        }
    }
    public class SearchOutofStock : ICommand2
    {
        private readonly IReport _report;
        private string _column, _value;
        public SearchOutofStock(IReport report, string column, string value)
        {
            _report = report;
            _column = column;
            _value = value;
        }
        public DataTable Execute()
        {
            return _report.SearchOutofStock(_column, _value);
        }
        public bool CanExecute()
        {
            if(_column != "" && _value != "")
            return true;
            else return false;
        }
    }
    public class GetTopSelling : ICommand2
    {
        private readonly IReport _report;
        public GetTopSelling(IReport report)
        {
            _report = report;
        }
        public DataTable Execute()
        {
            return _report.GetTopSelling();
        }
        public bool CanExecute()
        {
                return true;
        }
    }
    public class SearchTopSelling : ICommand2
    {
        private readonly IReport _report;
        private string _column, _value;
        public SearchTopSelling(IReport report, string column, string value)
        {
            _report = report;
            _column = column;
            _value = value;
        }
        public DataTable Execute()
        {
            return _report.SearchTopSelling(_column, _value);
        }
        public bool CanExecute()
        {
            if (_column != "" && _value != "")
                return true;
            else return false;
        }
    }
    public class GetProductMovement : ICommand2
    {
        private readonly IReport _report;
        private string _column, _value;
        public GetProductMovement(IReport report, string column, string value)
        {
            _report = report;
            _column = column;
            _value = value;
        }
        public DataTable Execute()
        {
            return _report.GetProductMovement(_column, _value);
        }
        public bool CanExecute()
        {
            if (_column != "" && _value != "")
                return true;
            else return false;
        }
    }
}
