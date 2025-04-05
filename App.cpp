// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "App.h"
#include "MainWindow.h"
#include  <wx/stdpaths.h>

wxIMPLEMENT_APP(App);

bool App::OnInit()
{
	if (!wxApp::OnInit()) return false;
	
	SetVendorName("FishNetSoft");
	SetAppName("FNDice");

#ifdef __linux
	wxStandardPaths::Get().SetFileLayout(wxStandardPaths::FileLayout_XDG);
#endif
	
	auto* mainWindow = new MainWindow();
	SetTopWindow(mainWindow);
	mainWindow->Show();
	
	return true;
}
