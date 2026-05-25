// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "MainWindow.h"

#ifdef __linux__
#include "bitmaps/die128.xpm"
#include "bitmaps/die16.xpm"
#include "bitmaps/die256.xpm"
#include "bitmaps/die32.xpm"
#include "bitmaps/die64.xpm"
#endif

#include "bitmaps/About24.xpm"
#include "bitmaps/Help24.xpm"
#include "bitmaps/History24.xpm"
#include "bitmaps/New24.xpm"
#include "bitmaps/Open24.xpm"
#include "bitmaps/Save24.xpm"

enum : uint8_t
{
	SBP_PLAYER = 0,
	SBP_ROUND,
	SBP_ROLL
};

enum : uint16_t
{
	TOOL_NEW_GAME = wxID_HIGHEST + 1,
	TOOL_LOAD_GAME,
	TOOL_SAVE_GAME,
	TOOL_HIGH_SCORES,
	TOOL_HOW_TO_PLAY,
	TOOL_ABOUT
};

MainWindow::MainWindow()
	: wxFrame(nullptr, wxID_ANY, "FNDice", wxDefaultPosition, wxDefaultSize,
			  wxDEFAULT_FRAME_STYLE & ~(wxRESIZE_BORDER | wxMAXIMIZE_BOX))
{
	wxFrame::SetBackgroundColour(wxSystemSettings::GetColour(wxSYS_COLOUR_FRAMEBK));

	wxIconBundle icons;

#ifdef _WINDOWS
	icons = wxIconBundle("APP_ICON", nullptr);
#elif defined(__linux__)
	icons.AddIcon(wxIcon(die16_xpm));
	icons.AddIcon(wxIcon(die32_xpm));
	icons.AddIcon(wxIcon(die64_xpm));
	icons.AddIcon(wxIcon(die128_xpm));
	icons.AddIcon(wxIcon(die256_xpm));
#endif

	wxFrame::SetIcons(icons);

	m_toolBar = wxFrame::CreateToolBar();
	m_toolBar->AddTool(TOOL_NEW_GAME, wxEmptyString, wxBitmap(New24_xpm), "Start a new game.");
	m_toolBar->AddTool(TOOL_LOAD_GAME, wxEmptyString, wxBitmap(Open24_xpm), "Load a saved game.");
	m_toolBar->AddTool(TOOL_SAVE_GAME, wxEmptyString, wxBitmap(Save24_xpm), "Save the current game.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(TOOL_HIGH_SCORES, wxEmptyString, wxBitmap(History24_xpm), "View high scores.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(TOOL_HOW_TO_PLAY, wxEmptyString, wxBitmap(Help24_xpm), "Learn how to play the game.");
	m_toolBar->AddTool(TOOL_ABOUT, wxEmptyString, wxBitmap(About24_xpm), "View the license and copyright information.");
	m_toolBar->Realize();

	m_statusBar = wxFrame::CreateStatusBar(3, wxSTB_DEFAULT_STYLE & ~wxSTB_SIZEGRIP);

	CenterOnScreen();
}
