using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
