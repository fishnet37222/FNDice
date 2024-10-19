// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics;
using FNDice.Properties;
using Microsoft.Web.WebView2.Core;

namespace FNDice;

public partial class AboutDialog : Form
{
	public AboutDialog()
	{
		InitializeComponent();
	}

	private void m_webView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
	{
		if (e.Uri.StartsWith("data:")) return;

		e.Cancel = true;

		var proc = new ProcessStartInfo(e.Uri)
		{
			UseShellExecute = true
		};

		Process.Start(proc);
	}

	private async void AboutDialog_Load(object sender, EventArgs e)
	{
		await m_webView.EnsureCoreWebView2Async();
	}

	private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
	{
		m_webView.NavigateToString(Resources.License);
	}
}
