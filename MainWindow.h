// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#pragma once
#include <wx/wx.h>

class MainWindow final : public wxFrame
{
public:
	MainWindow();
	
private:
	wxToolBar* m_toolBar{};
	wxStatusBar* m_statusBar{};
	
	void ToolBar_OnTool(wxCommandEvent& event);
	void MainWindow_OnClose(wxCloseEvent& event);
};
