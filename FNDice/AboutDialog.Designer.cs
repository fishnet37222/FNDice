// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

namespace FNDice;

partial class AboutDialog
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		Label label1;
		Label label2;
		Label label3;
		this.m_btnClose = new Button();
		this.m_webView = new Microsoft.Web.WebView2.WinForms.WebView2();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		((System.ComponentModel.ISupportInitialize)this.m_webView).BeginInit();
		this.SuspendLayout();
		// 
		// label1
		// 
		label1.Anchor = AnchorStyles.Top;
		label1.AutoSize = true;
		label1.Location = new Point(364, 9);
		label1.Name = "label1";
		label1.Size = new Size(72, 15);
		label1.TabIndex = 2;
		label1.Text = "FNDice 1.0.0";
		// 
		// label2
		// 
		label2.Anchor = AnchorStyles.Top;
		label2.AutoSize = true;
		label2.Location = new Point(291, 24);
		label2.Name = "label2";
		label2.Size = new Size(218, 15);
		label2.TabIndex = 3;
		label2.Text = "Copyright © 2024 David A. Frischknecht";
		// 
		// label3
		// 
		label3.Anchor = AnchorStyles.Top;
		label3.AutoSize = true;
		label3.Location = new Point(273, 39);
		label3.Name = "label3";
		label3.Size = new Size(254, 15);
		label3.TabIndex = 4;
		label3.Text = "Licensed under the Apache License, version 2.0";
		// 
		// m_btnClose
		// 
		this.m_btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		this.m_btnClose.DialogResult = DialogResult.OK;
		this.m_btnClose.Location = new Point(713, 415);
		this.m_btnClose.Name = "m_btnClose";
		this.m_btnClose.Size = new Size(75, 23);
		this.m_btnClose.TabIndex = 0;
		this.m_btnClose.Text = "Close";
		this.m_btnClose.UseVisualStyleBackColor = true;
		// 
		// m_webView
		// 
		this.m_webView.AllowExternalDrop = true;
		this.m_webView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_webView.CreationProperties = null;
		this.m_webView.DefaultBackgroundColor = Color.White;
		this.m_webView.Location = new Point(12, 57);
		this.m_webView.Name = "m_webView";
		this.m_webView.Size = new Size(776, 352);
		this.m_webView.TabIndex = 1;
		this.m_webView.ZoomFactor = 1D;
		this.m_webView.CoreWebView2InitializationCompleted += this.WebView_CoreWebView2InitializationCompleted;
		this.m_webView.NavigationStarting += this.m_webView_NavigationStarting;
		// 
		// AboutDialog
		// 
		this.AcceptButton = this.m_btnClose;
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.CancelButton = this.m_btnClose;
		this.ClientSize = new Size(800, 450);
		this.Controls.Add(label3);
		this.Controls.Add(label2);
		this.Controls.Add(label1);
		this.Controls.Add(this.m_webView);
		this.Controls.Add(this.m_btnClose);
		this.FormBorderStyle = FormBorderStyle.FixedDialog;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "AboutDialog";
		this.StartPosition = FormStartPosition.CenterParent;
		this.Text = "About FNDice";
		this.Load += this.AboutDialog_Load;
		((System.ComponentModel.ISupportInitialize)this.m_webView).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Button m_btnClose;
	private Microsoft.Web.WebView2.WinForms.WebView2 m_webView;
}