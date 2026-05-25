// Copyright (c) 2026 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "Die.h"
#include <algorithm> // or <ranges>
#include <array>
#include <wx/dcbuffer.h>
#include <wx/graphics.h>

Die::Die(wxWindow* parent)
{
	wxControl::SetBackgroundStyle(wxBG_STYLE_PAINT);
	Create(parent, wxID_ANY, wxDefaultPosition, wxDefaultSize, wxBORDER_NONE | wxFULL_REPAINT_ON_RESIZE);
	Bind(wxEVT_PAINT, &Die::Die_OnPaint, this);
	Bind(wxEVT_LEFT_UP, &Die::Die_OnLeftUp, this);
	wxControl::SetBackgroundColour(wxTheColourDatabase->Find("WHITE"));
	wxControl::SetForegroundColour(wxTheColourDatabase->Find("BLACK"));
}

void Die::Die_OnPaint(wxPaintEvent& event)
{
	const wxAutoBufferedPaintDC dc(this);
	const std::unique_ptr<wxGraphicsContext> gc(wxGraphicsContext::Create(dc));

	gc->SetAntialiasMode(wxANTIALIAS_DEFAULT);

	gc->SetBrush(GetParent()->GetBackgroundColour());
	gc->SetPen(wxPen(GetParent()->GetBackgroundColour()));

	gc->DrawRectangle(0, 0, GetSize().GetWidth(), GetSize().GetHeight());

	auto fg = GetForegroundColour();
	auto bg = GetBackgroundColour();

	if (!IsEnabled())
	{
		fg = m_disabledForegroundColor;
		bg = m_disabledBackgroundColor;
	}
	else if (m_selected)
	{
		fg = m_selectedForegroundColor;
		bg = m_selectedBackgroundColor;
	}

	gc->SetBrush(bg);
	gc->SetPen(wxPen(m_borderColor, m_borderThickness));
	gc->DrawRoundedRectangle(static_cast<float>(m_borderThickness) / 2.0f, static_cast<float>(m_borderThickness) / 2.0f, static_cast<float>(GetSize().GetWidth() - m_borderThickness - 1), static_cast<float>(GetSize().GetHeight() - m_borderThickness - 1), m_borderCornerRadius);

	gc->SetBrush(fg);
	gc->SetPen(wxPen(fg));

	if (std::array values{1, 3, 5}; std::ranges::contains(values, m_value))
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_pipDiameter, m_pipDiameter);
	}

	if (std::array values{2, 3, 4, 5, 6}; std::ranges::contains(values, m_value))
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing, m_pipDiameter, m_pipDiameter);
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_pipDiameter, m_pipDiameter);
	}

	if (std::array values{4, 5, 6}; std::ranges::contains(values, m_value))
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_pipDiameter, m_pipDiameter);
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_borderThickness + m_pipSpacing, m_pipDiameter, m_pipDiameter);
	}

	if (m_value == 6)
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_pipDiameter, m_pipDiameter);
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_pipDiameter, m_pipDiameter);
	}
}

wxSize Die::DoGetBestClientSize() const
{
	const auto dimension = 2 * m_borderThickness + 4 * m_pipSpacing + 3 * m_pipDiameter;
	return {dimension + 1, dimension + 1};
}

void Die::Roll()
{
	m_value = m_dist(m_rng);
	Refresh();
}

void Die::Clear()
{
	m_value = 0;
	m_selected = false;
	Refresh();
}

void Die::Die_OnLeftUp([[maybe_unused]] wxMouseEvent& event)
{
	m_selected = !m_selected;
	Refresh();
}
