// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "pch.h"
#include "MainWindow.h"
#include "App.h"

#include "resources/About24.xpm"
#include "resources/Help24.xpm"
#include "resources/History24.xpm"
#include "resources/New24.xpm"
#include "resources/Open24.xpm"
#include "resources/Save24.xpm"

enum ToolId : uint16_t
{
	ID_NEW = wxID_HIGHEST + 1,
	ID_LOAD,
	ID_SAVE,
	ID_HIGH_SCORES,
	ID_HOW_TO_PLAY,
	ID_ABOUT
};

MainWindow::MainWindow() : wxFrame(nullptr, wxID_ANY, wxGetApp().GetAppName(), wxDefaultPosition, wxDefaultSize,
	wxDEFAULT_FRAME_STYLE & ~(wxRESIZE_BORDER | wxMAXIMIZE_BOX))
{
	wxFrame::SetBackgroundColour(wxSystemSettings::GetColour(wxSYS_COLOUR_FRAMEBK));

	wxFrame::SetIcons(wxIconBundle("APP_ICON", nullptr));

	m_toolBar = wxFrame::CreateToolBar(wxTB_DEFAULT_STYLE | wxTB_FLAT);
	m_toolBar->AddTool(ID_NEW, wxEmptyString, wxBitmap(New24_xpm), "Start a new game.");
	m_toolBar->AddTool(ID_LOAD, wxEmptyString, wxBitmap(Open24_xpm), "Load a game.");
	m_toolBar->AddTool(ID_SAVE, wxEmptyString, wxBitmap(Save24_xpm), "Save a game.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(ID_HIGH_SCORES, wxEmptyString, wxBitmap(History24_xpm), "View the high scores.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(ID_HOW_TO_PLAY, wxEmptyString, wxBitmap(Help24_xpm), "Learn how to play the game.");
	m_toolBar->AddTool(ID_ABOUT, wxEmptyString, wxBitmap(About24_xpm), "View the license and copyright information.");
	m_toolBar->Realize();

	CenterOnScreen();
}
