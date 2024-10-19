// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

namespace FNDice;

public partial class MainWindow : Form
{
	private readonly List<Die> m_dice = [];

	public MainWindow()
	{
		InitializeComponent();
	}

	private void MainWindow_Load(object sender, EventArgs e)
	{
		m_dice.AddRange([m_die1, m_die2, m_die3, m_die4, m_die5]);

		var desiredClientWidth = m_die5.Right + m_die1.Left;
		var desiredClientHeight = m_tlpTotals.Bottom + 5 + m_statusStrip.Height;
		ClientSize = new(desiredClientWidth, desiredClientHeight);
	}

	private void m_btnRollDice_Click(object sender, EventArgs e)
	{
		// ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
		foreach (var die in m_dice)
		{
			if (!die.Selected)
			{
				die.Roll();
			}
		}
	}
}
