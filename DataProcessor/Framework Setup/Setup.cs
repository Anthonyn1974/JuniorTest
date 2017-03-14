using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor.Framework_Setup
{
  public static class Setup
  {
    internal static void SetupReader(ref DataView view)
    {
      view = new DataView();
      DataController dataControler = new Framework.DataController(view, @".\DataFiles", "*.csv", 1);

      dataControler.NewDataRow += NewDataRecord;
      dataControler.Process();
    }

    private static IDataModel NewDataRecord(object sender, NewRowEventArgs e)
    {
      DataRecordModel model = new DataRecordModel();
      model.SetData(e.Data);
      return model;
    }

  }
}
