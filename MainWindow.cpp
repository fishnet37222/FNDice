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

	CenterOnScreen();
}
