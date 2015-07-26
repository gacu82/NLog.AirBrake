using System;
using System.Collections.Generic;
using System.Text;

namespace NLog.AirBrake.TestApp
{
  class Program
  {
    private static Logger logger = LogManager.GetCurrentClassLogger();

    static void Main(string[] args)
    {
      try
      {
          //This should be ignored if Nlog config is set up correctly
        logger.Warn("something bad is about to happen");
        throw new ApplicationException("boom");
      }
      catch (Exception ex)
      {
        logger.Info(ex, "test");
        logger.Error(ex);
        logger.Error(ex, "this is a message");
      }

      Console.WriteLine("Done.");
      Console.ReadLine();
    }
  }
}
