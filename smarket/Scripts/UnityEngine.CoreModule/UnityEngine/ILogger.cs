using System;

namespace UnityEngine
{
	public interface ILogger : ILogHandler
	{
		ILogHandler logHandler { get; }

		bool logEnabled { get; }

		bool IsLogTypeAllowed(LogType logType);

		void Log(LogType logType, object message);

		void Log(LogType logType, object message, Object context);

		void Log(LogType logType, string tag, object message, Object context);

		void LogError(string tag, object message);

		void LogFormat(LogType logType, string format, params object[] args);

		void LogException(Exception exception);
	}
}
