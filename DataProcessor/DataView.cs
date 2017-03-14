using Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
  public class DataView : IDataView
  {
   // private IDataModel _model;
    ObservableCollection<DataRecordModel> _data;

    //Use: the below get setter if you are not visual studio 2017
    //public ObservableCollection<DataRecordModel> Data { get{ return _data;} set {_data = value;} }
    public ObservableCollection<DataRecordModel> Data { get => _data; set => _data = value; }

    public DataView()
    {
      Data = new ObservableCollection<DataRecordModel>();
    }


    public void AddRecord(IDataModel dataModel)
    {
      Data.Add(dataModel as DataRecordModel);
    }
  }
}
