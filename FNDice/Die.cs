// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using JetBrains.Annotations;
using Microsoft.DotNet.DesignTools.Designers;

namespace FNDice;

[Designer(typeof(DieDesigner)), PublicAPI]
public sealed partial class Die : Control
{
	private enum Pip
	{
		TopLeft,
		TopRight,
		MiddleLeft,
		MiddleMiddle,
		MiddleRight,
		BottomLeft,
		BottomRight
	}

	private static Dictionary<int, List<Pip>> s_pips = new()
	{
		{ 0, [] }
		, { 1, [Pip.MiddleMiddle] }
		, { 2, [Pip.TopLeft, Pip.BottomRight] }
		, { 3, [Pip.TopLeft, Pip.MiddleMiddle, Pip.BottomRight] }
		, { 4, [Pip.TopLeft, Pip.TopRight, Pip.BottomLeft, Pip.BottomRight] }
		, { 5, [Pip.TopLeft, Pip.TopRight, Pip.BottomLeft, Pip.BottomRight, Pip.MiddleMiddle] }
		, { 6, [Pip.TopLeft, Pip.TopRight, Pip.MiddleLeft, Pip.MiddleRight, Pip.BottomLeft, Pip.BottomRight] }
	};
	private static Random s_rng = new Random(RandomNumberGenerator.GetInt32(5000));

	private int m_value;
	private bool m_selected;
	private int m_pipSpacing = 5;
	private Size m_pipSize = new(25, 25);
	private int m_borderThickness = 3;
	private int m_borderCornerRadius = 10;
	private Color m_selectedBackColor = Color.Black;
	private Color m_selectedForeColor = Color.White;
	private Color m_borderColor = Color.Black;
	private Color m_disabledBackColor = Color.LightGray;
	private Color m_disabledForeColor = Color.DarkGray;

	public Die()
	{
		InitializeComponent();
		DoubleBuffered = true;
		BackColor = Color.White;
		ForeColor = Color.Black;
	}

	protected override void OnClick(EventArgs e)
	{
		if (Enabled)
		{
			m_selected = !m_selected;
			Refresh();
		}

		base.OnClick(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		var g = e.Graphics;
		g.SmoothingMode = SmoothingMode.AntiAlias;

		g.Clear(Parent!.BackColor);

		var borderRect = new RectangleF(m_borderThickness / 2.0f, m_borderThickness / 2.0f,
			ClientSize.Width - m_borderThickness - 1, ClientSize.Height - m_borderThickness - 1);

		var bg = BackColor;
		var fg = ForeColor;

		if (!Enabled)
		{
			bg = m_disabledBackColor;
			fg = m_disabledForeColor;
		}

		if (m_selected)
		{
			bg = m_selectedBackColor;
			fg = m_selectedForeColor;
		}

		g.FillRoundedRectangle(new SolidBrush(bg), borderRect, m_borderCornerRadius);

		g.DrawRoundedRectangle(new(m_borderColor, m_borderThickness), borderRect, m_borderCornerRadius);

		var pips = s_pips[m_value];
		var path = new GraphicsPath();

		foreach (var pip in pips)
		{
			// ReSharper disable once SwitchStatementHandlesSomeKnownEnumValuesWithDefault
			switch (pip)
			{
				case Pip.TopLeft:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing, m_borderThickness + m_pipSpacing, m_pipSize.Width - 1, m_pipSize.Height - 1);

					break;
				}

				case Pip.TopRight:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipSize.Width * 2,
						m_borderThickness + m_pipSpacing, m_pipSize.Width - 1, m_pipSize.Height - 1);

					break;
				}

				case Pip.MiddleLeft:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing,
						m_borderThickness + m_pipSpacing * 2 + m_pipSize.Height, m_pipSize.Width - 1,
						m_pipSize.Height - 1);

					break;
				}

				case Pip.MiddleMiddle:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing * 2 + m_pipSize.Width,
						m_borderThickness + m_pipSpacing * 2 + m_pipSize.Height, m_pipSize.Width - 1, m_pipSize.Height - 1);

					break;
				}

				case Pip.MiddleRight:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipSize.Width * 2,
						m_borderThickness + m_pipSpacing * 2 + m_pipSize.Height, m_pipSize.Width - 1, m_pipSize.Height - 1);

					break;
				}

				case Pip.BottomLeft:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing,
						m_borderThickness + m_pipSpacing * 3 + m_pipSize.Height * 2, m_pipSize.Width - 1,
						m_pipSize.Height - 1);

					break;
				}

				case Pip.BottomRight:
				{
					path.AddEllipse(m_borderThickness + m_pipSpacing * 3 + m_pipSize.Width * 2,
						m_borderThickness + m_pipSpacing * 3 + m_pipSize.Height * 2, m_pipSize.Width - 1, m_pipSize.Height - 1);

					break;
				}
			}
		}

		g.DrawPath(new(fg), path);
		g.FillPath(new SolidBrush(fg), path);
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		width = m_borderThickness * 2 + m_pipSpacing * 4 + m_pipSize.Width * 3;
		height = m_borderThickness * 2 + m_pipSpacing * 4 + m_pipSize.Height * 3;

		base.SetBoundsCore(x, y, width, height, BoundsSpecified.Size);
	}

	[DefaultValue(typeof(Color), nameof(Color.White))]
	public override Color BackColor { get; set; }

	[DefaultValue(typeof(Color), nameof(Color.Black))]
	public override Color ForeColor { get; set; }

	[Browsable(false), DefaultValue(0)]
	public int Value
	{
		get => m_value;

		private set
		{
			if (m_value == value) return;

			m_value = value;
			Refresh();
		}
	}

	[Browsable(false), DefaultValue(false)]
	public bool Selected
	{
		get => m_selected;

		private set
		{
			if (m_selected == value) return;

			m_selected = value;
			Refresh();
		}
	}

	[Category("Layout"), DefaultValue(5)]
	public int PipSpacing
	{
		get => m_pipSpacing;

		set
		{
			if (m_pipSpacing == value) return;

			m_pipSpacing = value;
			SetBoundsCore(Location.X, Location.Y, 0, 0, BoundsSpecified.Location);
			Refresh();
		}
	}

	[Category("Layout"), DefaultValue(typeof(Size), "25, 25")]
	public Size PipSize
	{
		get => m_pipSize;

		set
		{
			if (m_pipSize == value) return;

			m_pipSize = value;
			SetBoundsCore(Location.X, Location.Y, 0, 0, BoundsSpecified.Location);
			Refresh();
		}
	}

	[Category("Layout"), DefaultValue(3)]
	public int BorderThickness
	{
		get => m_borderThickness;

		set
		{
			if (m_borderThickness == value) return;

			m_borderThickness = value;
			SetBoundsCore(Location.X, Location.Y, 0, 0, BoundsSpecified.Location);
			Refresh();
		}
	}

	[Category("Appearance"), DefaultValue(10)]
	public int BorderCornerRadius
	{
		get => m_borderCornerRadius;

		set
		{
			if (m_borderCornerRadius == value) return;

			m_borderCornerRadius = value;
			Refresh();
		}
	}

	[Category("Appearance"), DefaultValue(typeof(Color), nameof(Color.Black))]
	public Color SelectedBackColor
	{
		get => m_selectedBackColor;

		set
		{
			if (m_selectedBackColor == value) return;

			m_selectedBackColor = value;
			Refresh();
		}
	}

	[Category("Appearance"), DefaultValue(typeof(Color), nameof(Color.White))]
	public Color SelectedForeColor
	{
		get => m_selectedForeColor;

		set
		{
			if (m_selectedForeColor == value) return;

			m_selectedForeColor = value;
			Refresh();
		}
	}

	[Category("Appearance"), DefaultValue(typeof(Color), nameof(Color.Black))]
	public Color BorderColor
	{
		get => m_borderColor;

		set
		{
			if (m_borderColor == value) return;

			m_borderColor = value;
			Refresh();
		}
	}

	[Category("Appearance"), DefaultValue(typeof(Color), nameof(Color.LightGray))]
	public Color DisabledBackColor
	{
		get => m_disabledBackColor;

		set
		{
			if (m_disabledBackColor == value) return;

			m_disabledBackColor = value;
			Refresh();
		}
	}

	[Category("Appearance"), DefaultValue(typeof(Color), nameof(Color.DarkGray))]
	public Color DisabledForeColor
	{
		get => m_disabledForeColor;

		set
		{
			if (m_disabledForeColor == value) return;

			m_disabledForeColor = value;
			Refresh();
		}
	}

	public void Roll()
	{
		m_value = s_rng.Next(1, 7);
		Refresh();
	}

	public void Clear()
	{
		m_value = 0;
		m_selected = false;
		Refresh();
	}
}

public class DieDesigner : ControlDesigner
{
	public override SelectionRules SelectionRules => SelectionRules.Moveable | SelectionRules.Visible;
}
