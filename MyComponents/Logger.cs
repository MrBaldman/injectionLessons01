﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MyComponents
{
	public class Logger
	{
		private static readonly ConcurrentBag<string> Logs;

		static Logger()
		{
			Logs = new ConcurrentBag<string>();
		}

		public void Log(string message)
		{
			Logs.Add(string.Format("{0} - {1}", DateTime.Now.ToShortTimeString(), message));
		}

		public IEnumerable<string> CurrentSnapshot()
		{
			return Logs.ToArray();
		}
	}
}