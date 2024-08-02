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
	public static void CountUp5(SLProtocolExt protocol)
	{
		try
		{
			/// instead of int count = Convert.ToInt32(protocol.GetParameter(10));
			int count = Convert.ToInt32(protocol.Loopcounter);

			count += 5;

			/// protocol.SetParameter(10, count);
			protocol.Loopcounter = count;

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
	public static void CountDown5(SLProtocolExt protocol)
	{
		try
		{
			/// instead of int count = Convert.ToInt32(protocol.GetParameter(10));
			int count = Convert.ToInt32(protocol.Loopcounter);

			if (count > 4)
			{
				count -= 5;

				/// protocol.SetParameter(10, count);
				protocol.Loopcounter = count;
			}

			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Count is {count}", LogType.Error, LogLevel.NoLogging);

		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}

}