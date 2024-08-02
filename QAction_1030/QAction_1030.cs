using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: QActionName.
/// </summary>
public static class QAction
{
	/// <summary>
	/// First QAction entry point on trigger "1030".
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void CountUp2(SLProtocol protocol)
	{
		try
		{
			int count = Convert.ToInt32(protocol.GetParameter(10));
			count += 2;
				protocol.SetParameter(10, count);

			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Count is {count}", LogType.Error, LogLevel.NoLogging);

		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}

	/// <summary>
	/// Second QAction entry point on trigger "1040".
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void CountDown2(SLProtocol protocol)
	{
		try
		{
			int count = Convert.ToInt32(protocol.GetParameter(10));
			if (count > 1)
			{
				count -= 2;
				protocol.SetParameter(10, count);
			}

			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Count is {count}", LogType.Error, LogLevel.NoLogging);

		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}

}