// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Web.WebView2.Core;

namespace FNDice;

public partial class AboutDialog
{
	public AboutDialog()
	{
		InitializeComponent();
	}

	// ReSharper disable once AsyncVoidMethod
	private async void AboutDialog_OnLoaded(object sender, RoutedEventArgs e)
	{
		await m_webView.EnsureCoreWebView2Async();
	}

	// ReSharper disable once AsyncVoidMethod
	private async void WebView_OnCoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
	{
		m_webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
		m_webView.CoreWebView2.Settings.AreDevToolsEnabled = false;

		var licenseResourceInfo = Application.GetResourceStream(new("pack://application:,,,/LICENSE-2.0.html"));
		using var reader = new StreamReader(licenseResourceInfo!.Stream);
		var licenseHtml = await reader.ReadToEndAsync();

		m_webView.NavigateToString(licenseHtml);
	}

	private void WebView_OnNavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
	{
		if (e.Uri.StartsWith("data:")) return;
		var startInfo = new ProcessStartInfo(e.Uri)
		{
			UseShellExecute = true
		};

		Process.Start(startInfo);
		e.Cancel = true;
	}
}
