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

		var position = Settings.MainWindowLocation;

		if (position == null)
		{
			var workArea = Screen.FromControl(this).WorkingArea;

			Location = new(workArea.Width / 2 - Size.Width / 2, workArea.Height / 2 - Size.Height / 2);
		}
		else
		{
			Location = position.Value;
		}

		m_showPossibleScoresToolStripMenuItem.Checked = Settings.ShowPossibleScores ?? true;
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

	private void TsbAbout_Click(object sender, EventArgs e)
	{
		new AboutDialog().ShowDialog(this);
	}

	private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
	{
		Settings.MainWindowLocation = Location;
	}

	private void ShowPossibleScoresToolStripMenuItem_Click(object sender, EventArgs e)
	{
		m_showPossibleScoresToolStripMenuItem.Checked = !m_showPossibleScoresToolStripMenuItem.Checked;
		Settings.ShowPossibleScores = m_showPossibleScoresToolStripMenuItem.Checked;
	}
}
