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

enum StatusTextIndex
{
	STATUS_TEXT_PLAYER = 0,
	STATUS_TEXT_ROLLS,
	STATUS_TEXT_ROUND
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
	
	m_statusBar = wxFrame::CreateStatusBar(3, wxSTB_DEFAULT_STYLE & ~wxSTB_SIZEGRIP);

	auto* szrMainOuter = new wxBoxSizer(wxHORIZONTAL);
	szrMainOuter->AddSpacer(12);
	auto* szrMainInner = new wxBoxSizer(wxVERTICAL);
	szrMainInner->AddSpacer(5);
	auto* szrDice = new wxStaticBoxSizer(wxHORIZONTAL, this, "Dice");
	szrDice->AddSpacer(5);

	auto* szrDiceInner = new wxBoxSizer(wxVERTICAL);
	szrDiceInner->AddSpacer(5);

	auto* szrDiceTop = new wxBoxSizer(wxHORIZONTAL);

	auto* die = new Die(szrDice->GetStaticBox());
	szrDiceTop->Add(die, wxSizerFlags(0).CenterVertical());
	m_dice[0] = die;

	szrDiceTop->AddSpacer(5);
	szrDiceTop->AddStretchSpacer(1);

	die = new Die(szrDice->GetStaticBox());
	szrDiceTop->Add(die, wxSizerFlags(0).CenterVertical());
	m_dice[1] = die;

	szrDiceTop->AddSpacer(5);
	szrDiceTop->AddStretchSpacer(1);

	die = new Die(szrDice->GetStaticBox());
	szrDiceTop->Add(die, wxSizerFlags(0).CenterVertical());
	m_dice[2] = die;

	szrDiceTop->AddSpacer(5);
	szrDiceTop->AddStretchSpacer(1);

	die = new Die(szrDice->GetStaticBox());
	szrDiceTop->Add(die, wxSizerFlags(0).CenterVertical());
	m_dice[3] = die;

	szrDiceTop->AddSpacer(5);
	szrDiceTop->AddStretchSpacer(1);

	die = new Die(szrDice->GetStaticBox());
	szrDiceTop->Add(die, wxSizerFlags(0).CenterVertical());
	m_dice[4] = die;

	szrDiceInner->Add(szrDiceTop, wxSizerFlags(0).Expand());
	szrDiceInner->AddSpacer(5);

	m_btnRollDice = new wxButton(szrDice->GetStaticBox(), wxID_ANY, "Roll");
	m_btnRollDice->Bind(wxEVT_BUTTON, &MainWindow::BtnRollDice_OnClick, this);
	szrDiceInner->Add(m_btnRollDice, wxSizerFlags(0).Expand());

	szrDiceInner->AddSpacer(5);
	szrDice->Add(szrDiceInner, wxSizerFlags(1).Expand());

	szrDice->AddSpacer(5);
	szrMainInner->Add(szrDice, wxSizerFlags(0).Expand());
	szrMainInner->AddSpacer(12);
	szrMainOuter->Add(szrMainInner, wxSizerFlags(1).Expand());
	szrMainOuter->AddSpacer(12);
	wxFrame::SetSizerAndFit(szrMainOuter);

	CenterOnScreen();
}

// ReSharper disable once CppMemberFunctionMayBeStatic
void MainWindow::ToolBar_OnItemSelect(wxCommandEvent& event) // NOLINT(*-convert-member-functions-to-static)
{
	switch (event.GetId())
	{
		// TODO: Implement the event handlers for the toolbar buttons.
		default: break;
	}
}

// ReSharper disable once CppMemberFunctionMayBeConst
void MainWindow::BtnRollDice_OnClick([[maybe_unused]] wxCommandEvent& event)
{
	for (auto* die : m_dice)
	{
		if (die->IsSelected()) continue;
		die->Roll();
	}
}
