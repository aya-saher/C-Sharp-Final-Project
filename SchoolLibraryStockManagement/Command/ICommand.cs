using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }
    public interface ICommand2
    {
        DataTable Execute();
        bool CanExecute();
    }

}
