using DataProcessor.Framework_Setup;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessor
{
  class Program
  {
    static DataView _view;
    static void Main(string[] args)
    {
      Setup.SetupReader(ref _view);
      ProcessDocuments();
      WriteOutResults();
    }
   
    private static void ProcessDocuments()
    {
      //Todo: Sum up records and group the data
    }

    private static void WriteOutResults()
    {
      //Write out the data based on record type and add a total line to the bottom of each csv file
    }

  }
}
