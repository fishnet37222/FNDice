// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "MainWindow.h"

#ifdef __linux
#include "resources/die16.xpm"
#include "resources/die32.xpm"
#include "resources/die64.xpm"
#include "resources/die128.xpm"
#include "resources/die256.xpm"
#endif

#include "resources/About24.xpm"
#include "resources/Help24.xpm"
#include "resources/History24.xpm"
#include "resources/New24.xpm"
#include "resources/Open24.xpm"
#include "resources/Save24.xpm"

enum ToolId
{
	ID_TOOL_NEW_GAME = wxID_HIGHEST + 1,
	ID_TOOL_LOAD_GAME,
	ID_TOOL_SAVE_GAME,
	ID_TOOL_HIGH_SCORES,
	ID_TOOL_HOW_TO_PLAY,
	ID_TOOL_ABOUT
};

MainWindow::MainWindow() : wxFrame(nullptr, wxID_ANY, "FNDice", wxDefaultPosition, wxDefaultSize,
	wxDEFAULT_FRAME_STYLE & ~(wxRESIZE_BORDER | wxMAXIMIZE_BOX))
{
	wxFrame::SetBackgroundColour(wxSystemSettings::GetColour(wxSYS_COLOUR_FRAMEBK));

	wxIconBundle icons;
#ifdef __WIN32__
	icons = wxIconBundle("APP_ICON", nullptr);
#elif defined(__linux)
	icons.AddIcon(wxIcon(die16_xpm));
	icons.AddIcon(wxIcon(die32_xpm));
	icons.AddIcon(wxIcon(die64_xpm));
	icons.AddIcon(wxIcon(die128_xpm));
	icons.AddIcon(wxIcon(die256_xpm));
#endif
	wxFrame::SetIcons(icons);
	
	m_toolBar = wxFrame::CreateToolBar(wxTB_FLAT);
	m_toolBar->AddTool(ID_TOOL_NEW_GAME, wxEmptyString, wxBitmap(New24_xpm), "Start a new game.");
	m_toolBar->AddTool(ID_TOOL_LOAD_GAME, wxEmptyString, wxBitmap(Open24_xpm), "Load a saved game.");
	m_toolBar->AddTool(ID_TOOL_SAVE_GAME, wxEmptyString, wxBitmap(Save24_xpm), "Save the current game.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(ID_TOOL_HIGH_SCORES, wxEmptyString, wxBitmap(History24_xpm), "View the high scores.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(ID_TOOL_HOW_TO_PLAY, wxEmptyString, wxBitmap(Help24_xpm), "Learn how to play the game.");
	m_toolBar->AddTool(ID_TOOL_ABOUT, wxEmptyString, wxBitmap(About24_xpm), "View the license and copyright information.");
	m_toolBar->Realize();
	m_toolBar->EnableTool(ID_TOOL_SAVE_GAME, false);
	m_toolBar->Bind(wxEVT_TOOL, &MainWindow::ToolBar_OnItemSelect, this);

	CenterOnScreen();
}

void MainWindow::ToolBar_OnItemSelect(wxCommandEvent& event)
{
	switch (event.GetId())
	{
		// TODO: Implement the event handlers for the toolbar buttons.
		default: break;
	}
}
