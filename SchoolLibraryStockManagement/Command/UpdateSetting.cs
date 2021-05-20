using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryStockManagement.Command
{
    public class UpdateSetting : ICommand
    {
        private readonly ISettingReciever _setting;
        private int _id;
        private string _name, _username, _password;
        public UpdateSetting(ISettingReciever setting, int id, string name, string username, string password)
        {
            _setting = setting;
            _id = id;
            _name = name;
            _username = username;
            _password = password;
        }
        public void Execute()
        {
            _setting.UpdateSetting(_id, _name, _username, _password);
        }
        public bool CanExecute()
        {
            if (_id > 0 && _name != "" && _username != "" && _password != "")
                return true;
            else return false;
        }
    }
}
