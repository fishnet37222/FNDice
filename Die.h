// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#pragma once
#include <wx/wx.h>
#include <random>

class Die final : public wxControl
{
public:
	explicit Die(wxWindow* parent);
	void Roll();
	void Clear();
	[[nodiscard]] int GetValue() const { return m_value; }
	[[nodiscard]] int GetPipSpacing() const { return m_pipSpacing; }
	void SetPipSpacing(int value);
	[[nodiscard]] int GetPipDiameter() const { return m_pipDiameter; }
	void SetPipDiameter(int value);
	[[nodiscard]] int GetBorderThickness() const { return m_borderThickness; }
	void SetBorderThickness(int value);
	[[nodiscard]] int GetBorderCornerRadius() const { return m_borderCornerRadius; }
	void SetBorderCornerRadius(int value);
	[[nodiscard]] bool IsSelected() const { return m_selected; }
	[[nodiscard]] wxColour GetBorderColor() const { return m_borderColor; }
	void SetBorderColor(const wxColour& value);
	[[nodiscard]] wxColour GetSelectedBackgroundColor() const { return m_selectedBackgroundColor; }
	void SetSelectedBackgroundColor(const wxColour& value);
	[[nodiscard]] wxColour GetSelectedForegroundColor() const { return m_selectedForegroundColor; }
	void SetSelectedForegroundColor(const wxColour& value);
	[[nodiscard]] wxColour GetDisabledBackgroundColor() const { return m_disabledBackgroundColor; }
	void SetDisabledBackgroundColor(const wxColour& value);
	[[nodiscard]] wxColour GetDisabledForegroundColor() const { return m_disabledForegroundColor; }
	void SetDisabledForegroundColor(const wxColour& value);

private:
	inline static std::mt19937 m_rng{ std::random_device{}() };
	inline static std::uniform_int_distribution m_dist{1, 6};

	int m_value{0};
	int m_pipSpacing{5};
	int m_pipDiameter{20};
	int m_borderThickness{3};
	int m_borderCornerRadius{10};
	bool m_selected{false};
	wxColour m_borderColor{wxTheColourDatabase->Find("BLACK")};
	wxColour m_selectedBackgroundColor{wxTheColourDatabase->Find("BLACK")};
	wxColour m_selectedForegroundColor{wxTheColourDatabase->Find("WHITE")};
	wxColour m_disabledBackgroundColor{wxTheColourDatabase->Find("LIGHT GREY")};
	wxColour m_disabledForegroundColor{wxTheColourDatabase->Find("DARK GREY")};

	void Die_OnPaint(wxPaintEvent& event);
	void Die_OnMouseLeftUp(wxMouseEvent& event);
	[[nodiscard]] wxSize DoGetBestClientSize() const override;
};
