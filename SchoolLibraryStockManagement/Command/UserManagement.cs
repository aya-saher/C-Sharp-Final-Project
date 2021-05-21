using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolLibraryStockManagement.Command
{
    public class GetAllUsers : ICommand2
    {
        private readonly IUser _user;
        public GetAllUsers(IUser user)
        {
            _user = user;
        }
        public DataTable Execute()
        {
            return _user.GetAll();
        }
        public bool CanExecute()
        {
            return true;
        }
    }
    public class SearchUser : ICommand2
    {
        private readonly IUser _user;
        private string _column, _value;
        public SearchUser(IUser user, string column, string value)
        {
            _user = user;
            _column = column;
            _value = value;
        }
        public DataTable Execute()
        {
            Console.WriteLine(_column, _value);
            return _user.Search(_column, _value);
        }
        public bool CanExecute()
        {
            if (_column != "" && _value != "")
                return true;
            else return false;
        }
    }

    public class IUpdateUserThenGetUsers : ICommand2
    {
        private readonly IUser _user;
        private string _id, _username, _name, _password, _role;
        public IUpdateUserThenGetUsers(IUser user, string id, string username, string name, string password, string role)
        {
            _user = user;
            _id = id;
            _username = username;
            _name = name;
            _password = password;
            _role = role;
        }
        public DataTable Execute()
        {
            _user.Update(_id, _username, _name, _password, _role);
            return _user.GetAll();
        }
        public bool CanExecute()
        {
            if (_id != "" && _username != "" && _name != "" && _password != "" && _role != "")
                return true;
            else return false;
        }
    }
    public class InsertUserThenGetUsers : ICommand2
    {
        private readonly IUser _user;
        private string _username, _name, _password, _role;
        public InsertUserThenGetUsers(IUser user, string username, string name, string password, string role)
        {
            _user = user;
            _username = username;
            _name = name;
            _password = password;
            _role = role;
        }
        public DataTable Execute()
        {
            _user.Insert(_username, _name, _password, _role);
            return _user.GetAll();
        }
        public bool CanExecute()
        {
            if (_username != "" && _name != "" && _password != "" && _role != "")
                return true;
            else return false;
        }
    }
    public class DeleteUserThenGetUsers : ICommand2
    {
        private readonly IUser _user;
        private string _id;
        public DeleteUserThenGetUsers(IUser user, string id)
        {
            _user = user;
            _id = id;
        }
        public DataTable Execute()
        {
            _user.Delete(_id);
            return _user.GetAll();
        }
        public bool CanExecute()
        {
            if (_id != "")
                return true;
            else return false;
        }
    }
}
