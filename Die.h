// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#pragma once
#include <random>
#include <wx/wx.h>

class Die final : public wxControl
{
public:
	explicit Die(wxWindow* parent);
	void Roll();
	void Clear();
	bool IsSelected() const { return m_selected; }
	int GetValue() const { return m_value; }

private:
	inline static std::mt19937 m_rng{std::random_device()()};
	inline static std::uniform_int_distribution<> m_dist{1, 6};

	wxColour m_borderColor{wxTheColourDatabase->Find("BLACK")};
	wxColour m_selectedBackgroundColor{wxTheColourDatabase->Find("BLACK")};
	wxColour m_selectedForegroundColor{wxTheColourDatabase->Find("WHITE")};
	wxColour m_disabledBackgroundColor{wxTheColourDatabase->Find("LIGHT GREY")};
	wxColour m_disabledForegroundColor{wxTheColourDatabase->Find("DARK GREY")};
	int m_borderThickness{3};
	int m_borderCornerRadius{10};
	int m_pipSpacing{5};
	int m_pipDiameter{25};
	int m_value{0};
	bool m_selected{false};

	void Die_OnPaint(wxPaintEvent& event);
	void Die_OnLeftUp(wxMouseEvent& event);
	[[nodiscard]] wxSize DoGetBestClientSize() const override;
};
