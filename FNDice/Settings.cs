// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using Microsoft.Win32;

namespace FNDice;

internal static class Settings
{
	private const string regSubPath = @"SOFTWARE\FishNetSoft\FNDice";

	internal static Point? MainWindowLocation
	{
		get
		{
			var reg = Registry.CurrentUser.CreateSubKey(regSubPath);
			var x = reg.GetValue("MainWindowPositionX", "").ToString();
			var y = reg.GetValue("MainWindowPositionY", "").ToString();

			if (string.IsNullOrEmpty(x) && string.IsNullOrEmpty(y)) return null;

			return new(int.Parse(x!), int.Parse(y!));
		}

		set
		{
			if (!value.HasValue)
			{
				throw new ArgumentNullException(nameof(value));
			}

			var reg = Registry.CurrentUser.CreateSubKey(regSubPath);
			reg.SetValue("MainWindowPositionX", value.Value.X);
			reg.SetValue("MainWindowPositionY", value.Value.Y);
		}
	}

	internal static bool? ShowPossibleScores
	{
		get
		{
			var reg = Registry.CurrentUser.CreateSubKey(regSubPath);
			var showPossibleScores = reg.GetValue("ShowPossibleScores", "").ToString();

			if (string.IsNullOrEmpty(showPossibleScores)) return null;

			return bool.Parse(showPossibleScores);
		}

		set
		{
			if (!value.HasValue)
			{
				throw new ArgumentNullException(nameof(value));
			}

			var reg = Registry.CurrentUser.CreateSubKey(regSubPath);
			reg.SetValue("ShowPossibleScores", value.Value);
		}
	}
}
