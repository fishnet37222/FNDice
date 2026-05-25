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

enum : uint8_t
{
	SBP_PLAYER = 0,
	SBP_ROUND,
	SBP_ROLL
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

	m_statusBar = wxFrame::CreateStatusBar(3, wxSTB_DEFAULT_STYLE & ~wxSTB_SIZEGRIP);

	CenterOnScreen();
}
