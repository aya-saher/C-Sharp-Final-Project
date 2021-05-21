using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
    public class Invoker
    {
        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
                command.Execute();
        }
        public DataTable Invoke(ICommand2 command)
        {
            if (command.CanExecute())
                return command.Execute();
            else
                return new DataTable();
        }
    }
}