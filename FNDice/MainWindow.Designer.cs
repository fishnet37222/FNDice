// Copyright (c) 2024 David A. Frischknecht
//
// SPDX-License-Identifier: Apache-2.0

namespace FNDice;

partial class MainWindow
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		ToolStrip m_toolStrip;
		StatusStrip m_statusStrip;
		var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
		this.m_tsbNewGame = new ToolStripButton();
		this.m_tsbLoadGame = new ToolStripButton();
		this.m_tsbSaveGame = new ToolStripButton();
		this.toolStripSeparator1 = new ToolStripSeparator();
		this.m_tsbHighScores = new ToolStripButton();
		this.toolStripSeparator2 = new ToolStripSeparator();
		this.m_tsbSettings = new ToolStripButton();
		this.toolStripSeparator3 = new ToolStripSeparator();
		this.m_tsbHowToPlay = new ToolStripButton();
		this.m_tsbAbout = new ToolStripButton();
		this.m_stlPlayer = new ToolStripStatusLabel();
		this.m_stlRound = new ToolStripStatusLabel();
		this.m_stlRoll = new ToolStripStatusLabel();
		m_toolStrip = new ToolStrip();
		m_statusStrip = new StatusStrip();
		m_toolStrip.SuspendLayout();
		m_statusStrip.SuspendLayout();
		this.SuspendLayout();
		// 
		// m_toolStrip
		// 
		m_toolStrip.GripStyle = ToolStripGripStyle.Hidden;
		m_toolStrip.Items.AddRange(new ToolStripItem[] { this.m_tsbNewGame, this.m_tsbLoadGame, this.m_tsbSaveGame, this.toolStripSeparator1, this.m_tsbHighScores, this.toolStripSeparator2, this.m_tsbSettings, this.toolStripSeparator3, this.m_tsbHowToPlay, this.m_tsbAbout });
		m_toolStrip.Location = new Point(0, 0);
		m_toolStrip.Name = "m_toolStrip";
		m_toolStrip.RenderMode = ToolStripRenderMode.System;
		m_toolStrip.Size = new Size(800, 31);
		m_toolStrip.TabIndex = 0;
		m_toolStrip.Text = "toolStrip1";
		// 
		// m_tsbNewGame
		// 
		this.m_tsbNewGame.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbNewGame.Image = Properties.Resources.New24;
		this.m_tsbNewGame.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbNewGame.ImageTransparentColor = Color.Magenta;
		this.m_tsbNewGame.Name = "m_tsbNewGame";
		this.m_tsbNewGame.Size = new Size(28, 28);
		// 
		// m_tsbLoadGame
		// 
		this.m_tsbLoadGame.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbLoadGame.Image = Properties.Resources.Open24;
		this.m_tsbLoadGame.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbLoadGame.ImageTransparentColor = Color.Magenta;
		this.m_tsbLoadGame.Name = "m_tsbLoadGame";
		this.m_tsbLoadGame.Size = new Size(28, 28);
		// 
		// m_tsbSaveGame
		// 
		this.m_tsbSaveGame.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbSaveGame.Image = Properties.Resources.Save24;
		this.m_tsbSaveGame.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbSaveGame.ImageTransparentColor = Color.Magenta;
		this.m_tsbSaveGame.Name = "m_tsbSaveGame";
		this.m_tsbSaveGame.Size = new Size(28, 28);
		// 
		// toolStripSeparator1
		// 
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new Size(6, 31);
		// 
		// m_tsbHighScores
		// 
		this.m_tsbHighScores.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbHighScores.Image = Properties.Resources.History24;
		this.m_tsbHighScores.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbHighScores.ImageTransparentColor = Color.Magenta;
		this.m_tsbHighScores.Name = "m_tsbHighScores";
		this.m_tsbHighScores.Size = new Size(28, 28);
		// 
		// toolStripSeparator2
		// 
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new Size(6, 31);
		// 
		// m_tsbSettings
		// 
		this.m_tsbSettings.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbSettings.Image = Properties.Resources.Preferences24;
		this.m_tsbSettings.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbSettings.ImageTransparentColor = Color.Magenta;
		this.m_tsbSettings.Name = "m_tsbSettings";
		this.m_tsbSettings.Size = new Size(28, 28);
		// 
		// toolStripSeparator3
		// 
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new Size(6, 31);
		// 
		// m_tsbHowToPlay
		// 
		this.m_tsbHowToPlay.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbHowToPlay.Image = Properties.Resources.Help24;
		this.m_tsbHowToPlay.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbHowToPlay.ImageTransparentColor = Color.Magenta;
		this.m_tsbHowToPlay.Name = "m_tsbHowToPlay";
		this.m_tsbHowToPlay.Size = new Size(28, 28);
		// 
		// m_tsbAbout
		// 
		this.m_tsbAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.m_tsbAbout.Image = Properties.Resources.About24;
		this.m_tsbAbout.ImageScaling = ToolStripItemImageScaling.None;
		this.m_tsbAbout.ImageTransparentColor = Color.Magenta;
		this.m_tsbAbout.Name = "m_tsbAbout";
		this.m_tsbAbout.Size = new Size(28, 28);
		// 
		// m_statusStrip
		// 
		m_statusStrip.Items.AddRange(new ToolStripItem[] { this.m_stlPlayer, this.m_stlRound, this.m_stlRoll });
		m_statusStrip.Location = new Point(0, 428);
		m_statusStrip.Name = "m_statusStrip";
		m_statusStrip.RenderMode = ToolStripRenderMode.System;
		m_statusStrip.Size = new Size(800, 22);
		m_statusStrip.SizingGrip = false;
		m_statusStrip.TabIndex = 1;
		m_statusStrip.Text = "statusStrip1";
		// 
		// m_stlPlayer
		// 
		this.m_stlPlayer.Name = "m_stlPlayer";
		this.m_stlPlayer.Size = new Size(261, 17);
		this.m_stlPlayer.Spring = true;
		this.m_stlPlayer.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// m_stlRound
		// 
		this.m_stlRound.Name = "m_stlRound";
		this.m_stlRound.Size = new Size(261, 17);
		this.m_stlRound.Spring = true;
		this.m_stlRound.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// m_stlRoll
		// 
		this.m_stlRoll.Name = "m_stlRoll";
		this.m_stlRoll.Size = new Size(261, 17);
		this.m_stlRoll.Spring = true;
		this.m_stlRoll.TextAlign = ContentAlignment.MiddleLeft;
		// 
		// MainWindow
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(800, 450);
		this.Controls.Add(m_statusStrip);
		this.Controls.Add(m_toolStrip);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.Icon = (Icon)resources.GetObject("$this.Icon");
		this.Name = "MainWindow";
		this.Text = "FNDice";
		m_toolStrip.ResumeLayout(false);
		m_toolStrip.PerformLayout();
		m_statusStrip.ResumeLayout(false);
		m_statusStrip.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private ToolStripStatusLabel m_stlPlayer;
	private ToolStripStatusLabel m_stlRound;
	private ToolStripStatusLabel m_stlRoll;
	private ToolStripButton m_tsbNewGame;
	private ToolStripButton m_tsbLoadGame;
	private ToolStripButton m_tsbSaveGame;
	private ToolStripSeparator toolStripSeparator1;
	private ToolStripButton m_tsbHighScores;
	private ToolStripSeparator toolStripSeparator2;
	private ToolStripButton m_tsbSettings;
	private ToolStripSeparator toolStripSeparator3;
	private ToolStripButton m_tsbHowToPlay;
	private ToolStripButton m_tsbAbout;
}
