// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "MainWindow.h"
#include <cstdint>
#include <wx/config.h>

#ifdef __linux
#include "resources/die16.xpm"
#include "resources/die32.xpm"
#include "resources/die64.xpm"
#include "resources/die128.xpm"
#include "resources/die256.xpm"
#endif

// Toolbar button bitmaps.
#include "resources/new24.xpm"
#include "resources/open24.xpm"
#include "resources/save24.xpm"
#include "resources/history24.xpm"
#include "resources/help24.xpm"
#include "resources/about24.xpm"

enum ToolId : uint16_t
{
	ID_NEW = wxID_HIGHEST + 1,
	ID_LOAD,
	ID_SAVE,
	ID_HIGH_SCORES,
	ID_HOW_TO_PLAY,
	ID_ABOUT
};

enum StatusLabelPos : uint8_t
{
	POS_PLAYER = 0,
	POS_ROUND,
	POS_ROLL
};

MainWindow::MainWindow() : wxFrame(nullptr, wxID_ANY, "FNDice", wxDefaultPosition, wxDefaultSize,
								   wxDEFAULT_FRAME_STYLE & ~(wxRESIZE_BORDER | wxMAXIMIZE_BOX))
{
	wxFrame::SetBackgroundColour(wxSystemSettings::GetColour(wxSYS_COLOUR_FRAMEBK));
	
	wxIconBundle icons;
#ifdef _WIN32
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
	m_toolBar->AddTool(ID_NEW, wxEmptyString, wxBitmapBundle::FromBitmap(wxBitmap(new24_xpm)), "Start a new game.");
	m_toolBar->AddTool(ID_LOAD, wxEmptyString, wxBitmapBundle::FromBitmap(wxBitmap(open24_xpm)), "Load a saved game.");
	m_toolBar->AddTool(ID_SAVE, wxEmptyString, wxBitmapBundle::FromBitmap(wxBitmap(save24_xpm)), "Save the current game.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(ID_HIGH_SCORES, wxEmptyString, wxBitmapBundle::FromBitmap(wxBitmap(history24_xpm)), "View the high scores.");
	m_toolBar->AddSeparator();
	m_toolBar->AddTool(ID_HOW_TO_PLAY, wxEmptyString, wxBitmapBundle::FromBitmap(wxBitmap(help24_xpm)), "Learn how to play the game.");
	m_toolBar->AddTool(ID_ABOUT, wxEmptyString, wxBitmapBundle::FromBitmap(wxBitmap(about24_xpm)), "View the license and copyright information.");
	m_toolBar->Realize();
	m_toolBar->Bind(wxEVT_TOOL, &MainWindow::ToolBar_OnTool, this);
	m_toolBar->EnableTool(ID_SAVE, false);
	
	m_statusBar = wxFrame::CreateStatusBar(3, wxSTB_DEFAULT_STYLE & ~wxSTB_SIZEGRIP);
	
	const auto* config = wxConfig::Create();
	const auto posX = config->ReadLong("MainWindowPosX", -1);
	const auto posY = config->ReadLong("MainWindowPosY", -1);
	
	if (posX == -1 || posY == -1)
	{
		CenterOnScreen();
	}
	else
	{
		SetPosition({ posX, posY });
	}
	
	Bind(wxEVT_CLOSE_WINDOW, &MainWindow::MainWindow_OnClose, this);
}

void MainWindow::ToolBar_OnTool(wxCommandEvent& event)
{
	switch (const auto toolId = event.GetId())
	{
		case ID_NEW:
		case ID_LOAD:
		case ID_SAVE:
		case ID_HIGH_SCORES:
		case ID_HOW_TO_PLAY:
		case ID_ABOUT:
		default:
			break;
	}
}

void MainWindow::MainWindow_OnClose([[maybe_unused]] wxCloseEvent& event)
{
	auto* config = wxConfig::Create();
	config->Write("MainWindowPosX", GetPosition().x);
	config->Write("MainWindowPosY", GetPosition().y);
	event.Skip();
}
