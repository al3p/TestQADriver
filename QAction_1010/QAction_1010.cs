using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: QACountUp.
/// </summary>
public static class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocol protocol)
	{
		try
		{
            int count = Convert.ToInt32(protocol.GetParameter(10));
            count++;
            protocol.SetParameter(10, count);

            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Count is {count}", LogType.Error, LogLevel.NoLogging);

        }
        catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}