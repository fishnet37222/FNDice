// Copyright (c) 2025 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

#include "Die.h"
#include <wx/dcbuffer.h>
#include <wx/graphics.h>
#include <memory>

Die::Die(wxWindow* parent)
{
	wxControl::SetBackgroundStyle(wxBG_STYLE_PAINT);
	Create(parent, wxID_ANY, wxDefaultPosition, wxDefaultSize, wxBORDER_NONE | wxFULL_REPAINT_ON_RESIZE);
	wxControl::SetBackgroundColour(wxTheColourDatabase->Find("WHITE"));
	wxControl::SetForegroundColour(wxTheColourDatabase->Find("BLACK"));
	Bind(wxEVT_PAINT, &Die::Die_OnPaint, this);
	Bind(wxEVT_LEFT_UP, &Die::Die_OnMouseLeftUp, this);
}

void Die::Die_OnPaint([[maybe_unused]] wxPaintEvent& event)
{
	const wxAutoBufferedPaintDC dc(this);
	const auto gc = std::unique_ptr<wxGraphicsContext>(wxGraphicsContext::Create(dc));

	gc->SetBrush(GetParent()->GetBackgroundColour());
	gc->SetPen(GetParent()->GetBackgroundColour());

	gc->DrawRectangle(0, 0, GetClientSize().GetWidth(), GetClientSize().GetHeight());

	auto bg = GetBackgroundColour();
	auto fg = GetForegroundColour();

	if (m_selected)
	{
		bg = m_selectedBackgroundColor;
		fg = m_selectedForegroundColor;
	}
	else if (!IsEnabled())
	{
		bg = m_disabledBackgroundColor;
		fg = m_disabledForegroundColor;
	}

	gc->SetBrush(bg);
	gc->SetPen(wxPen(m_borderColor, m_borderThickness));
	gc->DrawRoundedRectangle(m_borderThickness / 2.0, m_borderThickness / 2.0, GetClientSize().GetWidth() - m_borderThickness - 1, GetClientSize().GetHeight() - m_borderThickness - 1, m_borderCornerRadius);

	gc->SetBrush(fg);
	gc->SetPen(fg);

	if (m_value == 1 || m_value == 3 || m_value == 5)
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_pipDiameter, m_pipDiameter);
	}

	if (m_value == 2 || m_value == 3 || m_value == 4 || m_value == 5 || m_value == 6)
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing, m_pipDiameter, m_pipDiameter);
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_pipDiameter, m_pipDiameter);
	}

	if (m_value == 4 || m_value == 5 || m_value == 6)
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_borderThickness + m_pipSpacing, m_pipDiameter, m_pipDiameter);
		gc->DrawEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_pipDiameter, m_pipDiameter);
	}

	if (m_value == 6)
	{
		gc->DrawEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_pipDiameter, m_pipDiameter);
		gc->DrawEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipDiameter * 2, m_borderThickness + m_pipSpacing * 2 + m_pipDiameter, m_pipDiameter, m_pipDiameter);
	}
}

void Die::Die_OnMouseLeftUp([[maybe_unused]] wxMouseEvent& event)
{
	m_selected = !m_selected;
	Refresh();
}

wxSize Die::DoGetBestClientSize() const
{
	const auto dimension = m_borderThickness * 2 + m_pipSpacing * 4 + m_pipDiameter * 3 + 1;
	return {dimension, dimension};
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

void Die::SetPipSpacing(int spacing)
{
	if (spacing == m_pipSpacing) return;

	m_pipSpacing = spacing;
	InvalidateBestSize();
	Refresh();
}

void Die::SetPipDiameter(int diameter)
{
	if (diameter == m_pipDiameter) return;

	m_pipDiameter = diameter;
	InvalidateBestSize();
	Refresh();
}

void Die::SetBorderThickness(int thickness)
{
	if (thickness == m_borderThickness) return;

	m_borderThickness = thickness;
	InvalidateBestSize();
	Refresh();
}

void Die::SetBorderCornerRadius(int radius)
{
	if (radius == m_borderCornerRadius) return;

	m_borderCornerRadius = radius;
	Refresh();
}

void Die::SetBorderColor(const wxColour& color)
{
	if (color == m_borderColor) return;

	m_borderColor = color;
	Refresh();
}

void Die::SetSelectedBackgroundColor(const wxColour& color)
{
	if (color == m_selectedBackgroundColor) return;

	m_selectedBackgroundColor = color;
	Refresh();
}

void Die::SetSelectedForegroundColor(const wxColour& color)
{
	if (color == m_selectedForegroundColor) return;

	m_selectedForegroundColor = color;
	Refresh();
}

void Die::SetDisabledBackgroundColor(const wxColour& color)
{
	if (color == m_disabledBackgroundColor) return;

	m_disabledBackgroundColor = color;
	Refresh();
}

void Die::SetDisabledForegroundColor(const wxColour& color)
{
	if (color == m_disabledForegroundColor) return;

	m_disabledForegroundColor = color;
	Refresh();
}
