// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#pragma once
#include "Die.h"
#include <array>
#include <wx/wx.h>

class MainWindow final : public wxFrame
{
public:
	MainWindow();

private:
	wxToolBar* m_toolBar{};
	wxStatusBar* m_statusBar{};
	std::array<Die*, 5> m_dice{};
	wxButton* m_btnRollDice{};

	void BtnRollDice_OnClick(wxCommandEvent& event);
};
