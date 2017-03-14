using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
  public class DataController
  {
    private IDataView _view;
    private string _path;
    private string _mask;
    private int _numberOfRowsToSkip;

    public delegate IDataModel NewRowEventHandler(object sender, NewRowEventArgs e);

    public event NewRowEventHandler NewDataRow;

    public  DataController(IDataView view ,string path, string mask, int numberOfRowsToSkip)
    {
      _path = path;
      _mask = mask;
      _view = view;
      _numberOfRowsToSkip = numberOfRowsToSkip;
    }

    public void Process()
    {
      this.ReadInputDataFiles();
    }

    public IDataView GetView()
    {
      return _view;
    }

    private void ReadInputDataFiles()
    {
      var files = Directory.GetFiles(_path, _mask);

      foreach (var file in files)
      {
        int rowCount = 0;
        using (StreamReader reader = new StreamReader(file))
        {
          while (reader.Peek() > -1)
          {
            if (NewDataRow != null)
            {
              rowCount++;
              if(rowCount <= _numberOfRowsToSkip)
              {
                reader.ReadLine();
                continue;
              }
              _view.AddRecord(NewDataRow(this, 
                new NewRowEventArgs() { Data = reader.ReadLine() }));
            }
          }
        }
      }
    }
  }
}
