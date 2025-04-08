// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#pragma once
#include <wx/wx.h>
#include "Die.h"
#include <array>

class MainWindow final : public wxFrame
{
public:
	MainWindow();
	
private:
	wxToolBar* m_toolBar{};
	wxStatusBar* m_statusBar{};
	std::array<Die*, 5> m_dice{};
	wxButton* m_btnRollDice{};
	
	void ToolBar_OnItemSelect(wxCommandEvent& event);
	void BtnRollDice_OnClick(wxCommandEvent& event);
};
