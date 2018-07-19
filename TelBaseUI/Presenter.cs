using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelbaseModel.TelbaseClasses;

namespace TelBaseUI
{
    class Presenter
    {
        private readonly ITelbaseView _view;
        private readonly ITelbase _telBase;

        public Presenter(ITelbaseView view, ITelbase telBase)
        {
            _view = view;
            _telBase = telBase;
            Initialize();
        }

        private void Initialize()
        {
           _view.FindNumberButtonClick = FindNumberButtonClick;
            _telBase.Connection = _view.Connection;
            _view.AddUserButtonClick = AddUserButtonClick;
            _view.FindUserButtonClick = FindUserButtonClick;
            _view.ShowCallingDetailings = ShowCallingDetailings;
        }

        private void ShowCallingDetailings(object sender, EventArgs eventArgs)
        {
            TelEventArgs arg = (TelEventArgs)eventArgs;
            DataTable table = _telBase.GetCallDetailingByNumber(arg.Number);
            FillStatusString(table);
        }

        private void FindUserButtonClick(object sender, EventArgs eventArgs)
        {
            TelEventArgs arg = (TelEventArgs)eventArgs;
            DataTable table = _telBase.FindUser(arg.INN, arg.Name, arg.Patronymic, arg.Surname);
            FillStatusString(table);

        }

        private void AddUserButtonClick(object sender, EventArgs eventArgs)
        {
            
            TelEventArgs arg = (TelEventArgs)eventArgs;
            _view.Status = _telBase.AddUser(arg.INN, arg.Name, arg.Patronymic, arg.Surname);

        }

        private void FindNumberButtonClick(object sender, EventArgs eventArgs)
        {
            DataTable table = _telBase.FindVNumber(((TelEventArgs) eventArgs).Number);
            FillStatusString(table);
        }

        private void FillStatusString(DataTable table)
        {
            if (table != null)
            {
                _view.Status = String.Format("Found {0} records", table.Rows.Count);
                _view.MainTableSource = table;
            }
            else
            {
                _view.Status = "Records not found";
            }
        }
    }
}
