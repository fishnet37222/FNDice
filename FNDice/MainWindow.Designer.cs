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
		this.m_statusStrip = new StatusStrip();
		this.m_stlPlayer = new ToolStripStatusLabel();
		this.m_stlRound = new ToolStripStatusLabel();
		this.m_stlRoll = new ToolStripStatusLabel();
		this.m_die1 = new Die();
		this.m_die2 = new Die();
		this.m_die3 = new Die();
		this.m_die4 = new Die();
		this.m_die5 = new Die();
		this.m_btnRollDice = new Button();
		this.m_rbAces = new RadioButton();
		this.m_rbTwos = new RadioButton();
		this.m_rbThrees = new RadioButton();
		this.m_rbFours = new RadioButton();
		this.m_rbFives = new RadioButton();
		this.m_rbSixes = new RadioButton();
		this.m_rbBonus = new RadioButton();
		this.m_rbThreeOfAKind = new RadioButton();
		this.m_rbFourOfAKind = new RadioButton();
		this.m_rbFullHouse = new RadioButton();
		this.m_rbSmallStraight = new RadioButton();
		this.m_rbLargeStraight = new RadioButton();
		this.m_rbFNDice = new RadioButton();
		this.m_rbChance = new RadioButton();
		this.m_lblSeparator = new Label();
		this.m_lblAces = new Label();
		this.m_lblTwos = new Label();
		this.m_lblThrees = new Label();
		this.m_lblFours = new Label();
		this.m_lblFives = new Label();
		this.m_lblSixes = new Label();
		this.m_lblBonus = new Label();
		this.m_lblThreeOfAKind = new Label();
		this.m_lblFourOfAKind = new Label();
		this.m_lblFullHouse = new Label();
		this.m_lblSmallStraight = new Label();
		this.m_lblLargeStraight = new Label();
		this.m_lblFNDice = new Label();
		this.m_lblChance = new Label();
		this.m_txtAces = new TextBox();
		this.m_txtTwos = new TextBox();
		this.m_txtThrees = new TextBox();
		this.m_txtFours = new TextBox();
		this.m_txtFives = new TextBox();
		this.m_txtSixes = new TextBox();
		this.m_txtBonus = new TextBox();
		this.m_txtThreeOfAKind = new TextBox();
		this.m_txtFourOfAKind = new TextBox();
		this.m_txtFullHouse = new TextBox();
		this.m_txtSmallStraight = new TextBox();
		this.m_txtLargeStraight = new TextBox();
		this.m_txtFNDice = new TextBox();
		this.m_txtChance = new TextBox();
		this.m_btnEndTurn = new Button();
		this.m_tlpTotals = new TableLayoutPanel();
		this.label1 = new Label();
		this.label2 = new Label();
		this.label3 = new Label();
		this.m_txtUpperTotal = new TextBox();
		this.m_txtLowerTotal = new TextBox();
		this.m_txtGrandTotal = new TextBox();
		m_toolStrip = new ToolStrip();
		m_toolStrip.SuspendLayout();
		this.m_statusStrip.SuspendLayout();
		this.m_tlpTotals.SuspendLayout();
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
		this.m_tsbSaveGame.Enabled = false;
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
		this.m_tsbAbout.Click += this.TsbAbout_Click;
		// 
		// m_statusStrip
		// 
		this.m_statusStrip.Items.AddRange(new ToolStripItem[] { this.m_stlPlayer, this.m_stlRound, this.m_stlRoll });
		this.m_statusStrip.Location = new Point(0, 577);
		this.m_statusStrip.Name = "m_statusStrip";
		this.m_statusStrip.RenderMode = ToolStripRenderMode.System;
		this.m_statusStrip.Size = new Size(800, 22);
		this.m_statusStrip.SizingGrip = false;
		this.m_statusStrip.TabIndex = 1;
		this.m_statusStrip.Text = "statusStrip1";
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
		// m_die1
		// 
		this.m_die1.Location = new Point(12, 34);
		this.m_die1.Name = "m_die1";
		this.m_die1.Size = new Size(101, 101);
		this.m_die1.TabIndex = 2;
		this.m_die1.Text = "die1";
		// 
		// m_die2
		// 
		this.m_die2.Location = new Point(119, 34);
		this.m_die2.Name = "m_die2";
		this.m_die2.Size = new Size(101, 101);
		this.m_die2.TabIndex = 3;
		this.m_die2.Text = "die2";
		// 
		// m_die3
		// 
		this.m_die3.Location = new Point(226, 34);
		this.m_die3.Name = "m_die3";
		this.m_die3.Size = new Size(101, 101);
		this.m_die3.TabIndex = 4;
		this.m_die3.Text = "die3";
		// 
		// m_die4
		// 
		this.m_die4.Location = new Point(333, 34);
		this.m_die4.Name = "m_die4";
		this.m_die4.Size = new Size(101, 101);
		this.m_die4.TabIndex = 5;
		this.m_die4.Text = "die4";
		// 
		// m_die5
		// 
		this.m_die5.Location = new Point(440, 34);
		this.m_die5.Name = "m_die5";
		this.m_die5.Size = new Size(101, 101);
		this.m_die5.TabIndex = 6;
		this.m_die5.Text = "die5";
		// 
		// m_btnRollDice
		// 
		this.m_btnRollDice.Location = new Point(12, 141);
		this.m_btnRollDice.Name = "m_btnRollDice";
		this.m_btnRollDice.Size = new Size(529, 23);
		this.m_btnRollDice.TabIndex = 7;
		this.m_btnRollDice.Text = "Roll Dice";
		this.m_btnRollDice.UseVisualStyleBackColor = true;
		this.m_btnRollDice.Click += this.m_btnRollDice_Click;
		// 
		// m_rbAces
		// 
		this.m_rbAces.AutoSize = true;
		this.m_rbAces.Location = new Point(12, 174);
		this.m_rbAces.Name = "m_rbAces";
		this.m_rbAces.Size = new Size(14, 13);
		this.m_rbAces.TabIndex = 8;
		this.m_rbAces.TabStop = true;
		this.m_rbAces.UseVisualStyleBackColor = true;
		// 
		// m_rbTwos
		// 
		this.m_rbTwos.AutoSize = true;
		this.m_rbTwos.Location = new Point(12, 203);
		this.m_rbTwos.Name = "m_rbTwos";
		this.m_rbTwos.Size = new Size(14, 13);
		this.m_rbTwos.TabIndex = 9;
		this.m_rbTwos.TabStop = true;
		this.m_rbTwos.UseVisualStyleBackColor = true;
		// 
		// m_rbThrees
		// 
		this.m_rbThrees.AutoSize = true;
		this.m_rbThrees.Location = new Point(12, 232);
		this.m_rbThrees.Name = "m_rbThrees";
		this.m_rbThrees.Size = new Size(14, 13);
		this.m_rbThrees.TabIndex = 10;
		this.m_rbThrees.TabStop = true;
		this.m_rbThrees.UseVisualStyleBackColor = true;
		// 
		// m_rbFours
		// 
		this.m_rbFours.AutoSize = true;
		this.m_rbFours.Location = new Point(12, 261);
		this.m_rbFours.Name = "m_rbFours";
		this.m_rbFours.Size = new Size(14, 13);
		this.m_rbFours.TabIndex = 11;
		this.m_rbFours.TabStop = true;
		this.m_rbFours.UseVisualStyleBackColor = true;
		// 
		// m_rbFives
		// 
		this.m_rbFives.AutoSize = true;
		this.m_rbFives.Location = new Point(12, 290);
		this.m_rbFives.Name = "m_rbFives";
		this.m_rbFives.Size = new Size(14, 13);
		this.m_rbFives.TabIndex = 12;
		this.m_rbFives.TabStop = true;
		this.m_rbFives.UseVisualStyleBackColor = true;
		// 
		// m_rbSixes
		// 
		this.m_rbSixes.AutoSize = true;
		this.m_rbSixes.Location = new Point(12, 319);
		this.m_rbSixes.Name = "m_rbSixes";
		this.m_rbSixes.Size = new Size(14, 13);
		this.m_rbSixes.TabIndex = 13;
		this.m_rbSixes.TabStop = true;
		this.m_rbSixes.UseVisualStyleBackColor = true;
		// 
		// m_rbBonus
		// 
		this.m_rbBonus.AutoSize = true;
		this.m_rbBonus.Location = new Point(12, 348);
		this.m_rbBonus.Name = "m_rbBonus";
		this.m_rbBonus.Size = new Size(14, 13);
		this.m_rbBonus.TabIndex = 14;
		this.m_rbBonus.TabStop = true;
		this.m_rbBonus.UseVisualStyleBackColor = true;
		this.m_rbBonus.Visible = false;
		// 
		// m_rbThreeOfAKind
		// 
		this.m_rbThreeOfAKind.AutoSize = true;
		this.m_rbThreeOfAKind.Location = new Point(284, 174);
		this.m_rbThreeOfAKind.Name = "m_rbThreeOfAKind";
		this.m_rbThreeOfAKind.Size = new Size(14, 13);
		this.m_rbThreeOfAKind.TabIndex = 15;
		this.m_rbThreeOfAKind.TabStop = true;
		this.m_rbThreeOfAKind.UseVisualStyleBackColor = true;
		// 
		// m_rbFourOfAKind
		// 
		this.m_rbFourOfAKind.AutoSize = true;
		this.m_rbFourOfAKind.Location = new Point(284, 203);
		this.m_rbFourOfAKind.Name = "m_rbFourOfAKind";
		this.m_rbFourOfAKind.Size = new Size(14, 13);
		this.m_rbFourOfAKind.TabIndex = 16;
		this.m_rbFourOfAKind.TabStop = true;
		this.m_rbFourOfAKind.UseVisualStyleBackColor = true;
		// 
		// m_rbFullHouse
		// 
		this.m_rbFullHouse.AutoSize = true;
		this.m_rbFullHouse.Location = new Point(284, 232);
		this.m_rbFullHouse.Name = "m_rbFullHouse";
		this.m_rbFullHouse.Size = new Size(14, 13);
		this.m_rbFullHouse.TabIndex = 17;
		this.m_rbFullHouse.TabStop = true;
		this.m_rbFullHouse.UseVisualStyleBackColor = true;
		// 
		// m_rbSmallStraight
		// 
		this.m_rbSmallStraight.AutoSize = true;
		this.m_rbSmallStraight.Location = new Point(284, 261);
		this.m_rbSmallStraight.Name = "m_rbSmallStraight";
		this.m_rbSmallStraight.Size = new Size(14, 13);
		this.m_rbSmallStraight.TabIndex = 18;
		this.m_rbSmallStraight.TabStop = true;
		this.m_rbSmallStraight.UseVisualStyleBackColor = true;
		// 
		// m_rbLargeStraight
		// 
		this.m_rbLargeStraight.AutoSize = true;
		this.m_rbLargeStraight.Location = new Point(284, 290);
		this.m_rbLargeStraight.Name = "m_rbLargeStraight";
		this.m_rbLargeStraight.Size = new Size(14, 13);
		this.m_rbLargeStraight.TabIndex = 19;
		this.m_rbLargeStraight.TabStop = true;
		this.m_rbLargeStraight.UseVisualStyleBackColor = true;
		// 
		// m_rbFNDice
		// 
		this.m_rbFNDice.AutoSize = true;
		this.m_rbFNDice.Location = new Point(284, 319);
		this.m_rbFNDice.Name = "m_rbFNDice";
		this.m_rbFNDice.Size = new Size(14, 13);
		this.m_rbFNDice.TabIndex = 20;
		this.m_rbFNDice.TabStop = true;
		this.m_rbFNDice.UseVisualStyleBackColor = true;
		// 
		// m_rbChance
		// 
		this.m_rbChance.AutoSize = true;
		this.m_rbChance.Location = new Point(284, 348);
		this.m_rbChance.Name = "m_rbChance";
		this.m_rbChance.Size = new Size(14, 13);
		this.m_rbChance.TabIndex = 21;
		this.m_rbChance.TabStop = true;
		this.m_rbChance.UseVisualStyleBackColor = true;
		// 
		// m_lblSeparator
		// 
		this.m_lblSeparator.BackColor = Color.Black;
		this.m_lblSeparator.Location = new Point(275, 170);
		this.m_lblSeparator.Name = "m_lblSeparator";
		this.m_lblSeparator.Size = new Size(3, 197);
		this.m_lblSeparator.TabIndex = 22;
		// 
		// m_lblAces
		// 
		this.m_lblAces.AutoSize = true;
		this.m_lblAces.Location = new Point(32, 173);
		this.m_lblAces.Name = "m_lblAces";
		this.m_lblAces.Size = new Size(32, 15);
		this.m_lblAces.TabIndex = 23;
		this.m_lblAces.Text = "Aces";
		// 
		// m_lblTwos
		// 
		this.m_lblTwos.AutoSize = true;
		this.m_lblTwos.Location = new Point(32, 202);
		this.m_lblTwos.Name = "m_lblTwos";
		this.m_lblTwos.Size = new Size(34, 15);
		this.m_lblTwos.TabIndex = 24;
		this.m_lblTwos.Text = "Twos";
		// 
		// m_lblThrees
		// 
		this.m_lblThrees.AutoSize = true;
		this.m_lblThrees.Location = new Point(32, 231);
		this.m_lblThrees.Name = "m_lblThrees";
		this.m_lblThrees.Size = new Size(42, 15);
		this.m_lblThrees.TabIndex = 25;
		this.m_lblThrees.Text = "Threes";
		// 
		// m_lblFours
		// 
		this.m_lblFours.AutoSize = true;
		this.m_lblFours.Location = new Point(32, 260);
		this.m_lblFours.Name = "m_lblFours";
		this.m_lblFours.Size = new Size(36, 15);
		this.m_lblFours.TabIndex = 26;
		this.m_lblFours.Text = "Fours";
		// 
		// m_lblFives
		// 
		this.m_lblFives.AutoSize = true;
		this.m_lblFives.Location = new Point(32, 289);
		this.m_lblFives.Name = "m_lblFives";
		this.m_lblFives.Size = new Size(33, 15);
		this.m_lblFives.TabIndex = 27;
		this.m_lblFives.Text = "Fives";
		// 
		// m_lblSixes
		// 
		this.m_lblSixes.AutoSize = true;
		this.m_lblSixes.Location = new Point(32, 318);
		this.m_lblSixes.Name = "m_lblSixes";
		this.m_lblSixes.Size = new Size(32, 15);
		this.m_lblSixes.TabIndex = 28;
		this.m_lblSixes.Text = "Sixes";
		// 
		// m_lblBonus
		// 
		this.m_lblBonus.AutoSize = true;
		this.m_lblBonus.Location = new Point(32, 347);
		this.m_lblBonus.Name = "m_lblBonus";
		this.m_lblBonus.Size = new Size(40, 15);
		this.m_lblBonus.TabIndex = 29;
		this.m_lblBonus.Text = "Bonus";
		// 
		// m_lblThreeOfAKind
		// 
		this.m_lblThreeOfAKind.AutoSize = true;
		this.m_lblThreeOfAKind.Location = new Point(304, 173);
		this.m_lblThreeOfAKind.Name = "m_lblThreeOfAKind";
		this.m_lblThreeOfAKind.Size = new Size(63, 15);
		this.m_lblThreeOfAKind.TabIndex = 30;
		this.m_lblThreeOfAKind.Text = "3 of a Kind";
		// 
		// m_lblFourOfAKind
		// 
		this.m_lblFourOfAKind.AutoSize = true;
		this.m_lblFourOfAKind.Location = new Point(304, 202);
		this.m_lblFourOfAKind.Name = "m_lblFourOfAKind";
		this.m_lblFourOfAKind.Size = new Size(63, 15);
		this.m_lblFourOfAKind.TabIndex = 31;
		this.m_lblFourOfAKind.Text = "4 of a Kind";
		// 
		// m_lblFullHouse
		// 
		this.m_lblFullHouse.AutoSize = true;
		this.m_lblFullHouse.Location = new Point(304, 231);
		this.m_lblFullHouse.Name = "m_lblFullHouse";
		this.m_lblFullHouse.Size = new Size(63, 15);
		this.m_lblFullHouse.TabIndex = 32;
		this.m_lblFullHouse.Text = "Full House";
		// 
		// m_lblSmallStraight
		// 
		this.m_lblSmallStraight.AutoSize = true;
		this.m_lblSmallStraight.Location = new Point(304, 260);
		this.m_lblSmallStraight.Name = "m_lblSmallStraight";
		this.m_lblSmallStraight.Size = new Size(80, 15);
		this.m_lblSmallStraight.TabIndex = 33;
		this.m_lblSmallStraight.Text = "Small Straight";
		// 
		// m_lblLargeStraight
		// 
		this.m_lblLargeStraight.AutoSize = true;
		this.m_lblLargeStraight.Location = new Point(304, 289);
		this.m_lblLargeStraight.Name = "m_lblLargeStraight";
		this.m_lblLargeStraight.Size = new Size(80, 15);
		this.m_lblLargeStraight.TabIndex = 34;
		this.m_lblLargeStraight.Text = "Large Straight";
		// 
		// m_lblFNDice
		// 
		this.m_lblFNDice.AutoSize = true;
		this.m_lblFNDice.Location = new Point(304, 318);
		this.m_lblFNDice.Name = "m_lblFNDice";
		this.m_lblFNDice.Size = new Size(45, 15);
		this.m_lblFNDice.TabIndex = 35;
		this.m_lblFNDice.Text = "FNDice";
		// 
		// m_lblChance
		// 
		this.m_lblChance.AutoSize = true;
		this.m_lblChance.Location = new Point(304, 347);
		this.m_lblChance.Name = "m_lblChance";
		this.m_lblChance.Size = new Size(47, 15);
		this.m_lblChance.TabIndex = 36;
		this.m_lblChance.Text = "Chance";
		// 
		// m_txtAces
		// 
		this.m_txtAces.Location = new Point(80, 170);
		this.m_txtAces.Name = "m_txtAces";
		this.m_txtAces.ReadOnly = true;
		this.m_txtAces.Size = new Size(189, 23);
		this.m_txtAces.TabIndex = 37;
		this.m_txtAces.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtTwos
		// 
		this.m_txtTwos.Location = new Point(80, 199);
		this.m_txtTwos.Name = "m_txtTwos";
		this.m_txtTwos.ReadOnly = true;
		this.m_txtTwos.Size = new Size(189, 23);
		this.m_txtTwos.TabIndex = 38;
		this.m_txtTwos.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtThrees
		// 
		this.m_txtThrees.Location = new Point(80, 228);
		this.m_txtThrees.Name = "m_txtThrees";
		this.m_txtThrees.ReadOnly = true;
		this.m_txtThrees.Size = new Size(189, 23);
		this.m_txtThrees.TabIndex = 39;
		this.m_txtThrees.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtFours
		// 
		this.m_txtFours.Location = new Point(80, 257);
		this.m_txtFours.Name = "m_txtFours";
		this.m_txtFours.ReadOnly = true;
		this.m_txtFours.Size = new Size(189, 23);
		this.m_txtFours.TabIndex = 40;
		this.m_txtFours.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtFives
		// 
		this.m_txtFives.Location = new Point(80, 286);
		this.m_txtFives.Name = "m_txtFives";
		this.m_txtFives.ReadOnly = true;
		this.m_txtFives.Size = new Size(189, 23);
		this.m_txtFives.TabIndex = 41;
		this.m_txtFives.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtSixes
		// 
		this.m_txtSixes.Location = new Point(80, 315);
		this.m_txtSixes.Name = "m_txtSixes";
		this.m_txtSixes.ReadOnly = true;
		this.m_txtSixes.Size = new Size(189, 23);
		this.m_txtSixes.TabIndex = 42;
		this.m_txtSixes.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtBonus
		// 
		this.m_txtBonus.Location = new Point(80, 344);
		this.m_txtBonus.Name = "m_txtBonus";
		this.m_txtBonus.ReadOnly = true;
		this.m_txtBonus.Size = new Size(189, 23);
		this.m_txtBonus.TabIndex = 43;
		this.m_txtBonus.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtThreeOfAKind
		// 
		this.m_txtThreeOfAKind.Location = new Point(390, 170);
		this.m_txtThreeOfAKind.Name = "m_txtThreeOfAKind";
		this.m_txtThreeOfAKind.ReadOnly = true;
		this.m_txtThreeOfAKind.Size = new Size(151, 23);
		this.m_txtThreeOfAKind.TabIndex = 44;
		this.m_txtThreeOfAKind.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtFourOfAKind
		// 
		this.m_txtFourOfAKind.Location = new Point(390, 199);
		this.m_txtFourOfAKind.Name = "m_txtFourOfAKind";
		this.m_txtFourOfAKind.ReadOnly = true;
		this.m_txtFourOfAKind.Size = new Size(151, 23);
		this.m_txtFourOfAKind.TabIndex = 45;
		this.m_txtFourOfAKind.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtFullHouse
		// 
		this.m_txtFullHouse.Location = new Point(390, 228);
		this.m_txtFullHouse.Name = "m_txtFullHouse";
		this.m_txtFullHouse.ReadOnly = true;
		this.m_txtFullHouse.Size = new Size(151, 23);
		this.m_txtFullHouse.TabIndex = 46;
		this.m_txtFullHouse.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtSmallStraight
		// 
		this.m_txtSmallStraight.Location = new Point(390, 257);
		this.m_txtSmallStraight.Name = "m_txtSmallStraight";
		this.m_txtSmallStraight.ReadOnly = true;
		this.m_txtSmallStraight.Size = new Size(151, 23);
		this.m_txtSmallStraight.TabIndex = 47;
		this.m_txtSmallStraight.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtLargeStraight
		// 
		this.m_txtLargeStraight.Location = new Point(390, 286);
		this.m_txtLargeStraight.Name = "m_txtLargeStraight";
		this.m_txtLargeStraight.ReadOnly = true;
		this.m_txtLargeStraight.Size = new Size(151, 23);
		this.m_txtLargeStraight.TabIndex = 48;
		this.m_txtLargeStraight.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtFNDice
		// 
		this.m_txtFNDice.Location = new Point(390, 315);
		this.m_txtFNDice.Name = "m_txtFNDice";
		this.m_txtFNDice.ReadOnly = true;
		this.m_txtFNDice.Size = new Size(151, 23);
		this.m_txtFNDice.TabIndex = 49;
		this.m_txtFNDice.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtChance
		// 
		this.m_txtChance.Location = new Point(390, 344);
		this.m_txtChance.Name = "m_txtChance";
		this.m_txtChance.ReadOnly = true;
		this.m_txtChance.Size = new Size(151, 23);
		this.m_txtChance.TabIndex = 50;
		this.m_txtChance.TextAlign = HorizontalAlignment.Right;
		// 
		// m_btnEndTurn
		// 
		this.m_btnEndTurn.Location = new Point(12, 373);
		this.m_btnEndTurn.Name = "m_btnEndTurn";
		this.m_btnEndTurn.Size = new Size(529, 23);
		this.m_btnEndTurn.TabIndex = 51;
		this.m_btnEndTurn.Text = "End Turn";
		this.m_btnEndTurn.UseVisualStyleBackColor = true;
		// 
		// m_tlpTotals
		// 
		this.m_tlpTotals.ColumnCount = 3;
		this.m_tlpTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		this.m_tlpTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		this.m_tlpTotals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
		this.m_tlpTotals.Controls.Add(this.label1, 0, 0);
		this.m_tlpTotals.Controls.Add(this.label2, 1, 0);
		this.m_tlpTotals.Controls.Add(this.label3, 2, 0);
		this.m_tlpTotals.Controls.Add(this.m_txtUpperTotal, 0, 1);
		this.m_tlpTotals.Controls.Add(this.m_txtLowerTotal, 1, 1);
		this.m_tlpTotals.Controls.Add(this.m_txtGrandTotal, 2, 1);
		this.m_tlpTotals.Location = new Point(12, 402);
		this.m_tlpTotals.Name = "m_tlpTotals";
		this.m_tlpTotals.RowCount = 2;
		this.m_tlpTotals.RowStyles.Add(new RowStyle());
		this.m_tlpTotals.RowStyles.Add(new RowStyle());
		this.m_tlpTotals.Size = new Size(529, 44);
		this.m_tlpTotals.TabIndex = 52;
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new Point(3, 0);
		this.label1.Name = "label1";
		this.label1.Size = new Size(68, 15);
		this.label1.TabIndex = 0;
		this.label1.Text = "Upper Total";
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new Point(179, 0);
		this.label2.Name = "label2";
		this.label2.Size = new Size(68, 15);
		this.label2.TabIndex = 1;
		this.label2.Text = "Lower Total";
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Location = new Point(355, 0);
		this.label3.Name = "label3";
		this.label3.Size = new Size(68, 15);
		this.label3.TabIndex = 2;
		this.label3.Text = "Grand Total";
		// 
		// m_txtUpperTotal
		// 
		this.m_txtUpperTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_txtUpperTotal.Location = new Point(3, 18);
		this.m_txtUpperTotal.Name = "m_txtUpperTotal";
		this.m_txtUpperTotal.ReadOnly = true;
		this.m_txtUpperTotal.Size = new Size(170, 23);
		this.m_txtUpperTotal.TabIndex = 3;
		this.m_txtUpperTotal.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtLowerTotal
		// 
		this.m_txtLowerTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_txtLowerTotal.Location = new Point(179, 18);
		this.m_txtLowerTotal.Name = "m_txtLowerTotal";
		this.m_txtLowerTotal.ReadOnly = true;
		this.m_txtLowerTotal.Size = new Size(170, 23);
		this.m_txtLowerTotal.TabIndex = 4;
		this.m_txtLowerTotal.TextAlign = HorizontalAlignment.Right;
		// 
		// m_txtGrandTotal
		// 
		this.m_txtGrandTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_txtGrandTotal.Location = new Point(355, 18);
		this.m_txtGrandTotal.Name = "m_txtGrandTotal";
		this.m_txtGrandTotal.ReadOnly = true;
		this.m_txtGrandTotal.Size = new Size(171, 23);
		this.m_txtGrandTotal.TabIndex = 5;
		this.m_txtGrandTotal.TextAlign = HorizontalAlignment.Right;
		// 
		// MainWindow
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(800, 599);
		this.Controls.Add(this.m_tlpTotals);
		this.Controls.Add(this.m_btnEndTurn);
		this.Controls.Add(this.m_txtChance);
		this.Controls.Add(this.m_txtFNDice);
		this.Controls.Add(this.m_txtLargeStraight);
		this.Controls.Add(this.m_txtSmallStraight);
		this.Controls.Add(this.m_txtFullHouse);
		this.Controls.Add(this.m_txtFourOfAKind);
		this.Controls.Add(this.m_txtThreeOfAKind);
		this.Controls.Add(this.m_txtBonus);
		this.Controls.Add(this.m_txtSixes);
		this.Controls.Add(this.m_txtFives);
		this.Controls.Add(this.m_txtFours);
		this.Controls.Add(this.m_txtThrees);
		this.Controls.Add(this.m_txtTwos);
		this.Controls.Add(this.m_txtAces);
		this.Controls.Add(this.m_lblChance);
		this.Controls.Add(this.m_lblFNDice);
		this.Controls.Add(this.m_lblLargeStraight);
		this.Controls.Add(this.m_lblSmallStraight);
		this.Controls.Add(this.m_lblFullHouse);
		this.Controls.Add(this.m_lblFourOfAKind);
		this.Controls.Add(this.m_lblThreeOfAKind);
		this.Controls.Add(this.m_lblBonus);
		this.Controls.Add(this.m_lblSixes);
		this.Controls.Add(this.m_lblFives);
		this.Controls.Add(this.m_lblFours);
		this.Controls.Add(this.m_lblThrees);
		this.Controls.Add(this.m_lblTwos);
		this.Controls.Add(this.m_lblAces);
		this.Controls.Add(this.m_lblSeparator);
		this.Controls.Add(this.m_rbChance);
		this.Controls.Add(this.m_rbFNDice);
		this.Controls.Add(this.m_rbLargeStraight);
		this.Controls.Add(this.m_rbSmallStraight);
		this.Controls.Add(this.m_rbFullHouse);
		this.Controls.Add(this.m_rbFourOfAKind);
		this.Controls.Add(this.m_rbThreeOfAKind);
		this.Controls.Add(this.m_rbBonus);
		this.Controls.Add(this.m_rbSixes);
		this.Controls.Add(this.m_rbFives);
		this.Controls.Add(this.m_rbFours);
		this.Controls.Add(this.m_rbThrees);
		this.Controls.Add(this.m_rbTwos);
		this.Controls.Add(this.m_rbAces);
		this.Controls.Add(this.m_btnRollDice);
		this.Controls.Add(this.m_die5);
		this.Controls.Add(this.m_die4);
		this.Controls.Add(this.m_die3);
		this.Controls.Add(this.m_die2);
		this.Controls.Add(this.m_die1);
		this.Controls.Add(this.m_statusStrip);
		this.Controls.Add(m_toolStrip);
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.Icon = (Icon)resources.GetObject("$this.Icon");
		this.Name = "MainWindow";
		this.Text = "FNDice";
		this.Load += this.MainWindow_Load;
		m_toolStrip.ResumeLayout(false);
		m_toolStrip.PerformLayout();
		this.m_statusStrip.ResumeLayout(false);
		this.m_statusStrip.PerformLayout();
		this.m_tlpTotals.ResumeLayout(false);
		this.m_tlpTotals.PerformLayout();
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
	private Die m_die1;
	private Die m_die2;
	private Die m_die3;
	private Die m_die4;
	private Die m_die5;
	private Button m_btnRollDice;
	private StatusStrip m_statusStrip;
	private RadioButton m_rbAces;
	private RadioButton m_rbTwos;
	private RadioButton m_rbThrees;
	private RadioButton m_rbFours;
	private RadioButton m_rbFives;
	private RadioButton m_rbSixes;
	private RadioButton m_rbBonus;
	private RadioButton m_rbThreeOfAKind;
	private RadioButton m_rbFourOfAKind;
	private RadioButton m_rbFullHouse;
	private RadioButton m_rbSmallStraight;
	private RadioButton m_rbLargeStraight;
	private RadioButton m_rbFNDice;
	private RadioButton m_rbChance;
	private Label m_lblSeparator;
	private Label m_lblAces;
	private Label m_lblTwos;
	private Label m_lblThrees;
	private Label m_lblFours;
	private Label m_lblFives;
	private Label m_lblSixes;
	private Label m_lblBonus;
	private Label m_lblThreeOfAKind;
	private Label m_lblFourOfAKind;
	private Label m_lblFullHouse;
	private Label m_lblSmallStraight;
	private Label m_lblLargeStraight;
	private Label m_lblFNDice;
	private Label m_lblChance;
	private TextBox m_txtAces;
	private TextBox m_txtTwos;
	private TextBox m_txtThrees;
	private TextBox m_txtFours;
	private TextBox m_txtFives;
	private TextBox m_txtSixes;
	private TextBox m_txtBonus;
	private TextBox m_txtThreeOfAKind;
	private TextBox m_txtFourOfAKind;
	private TextBox m_txtFullHouse;
	private TextBox m_txtSmallStraight;
	private TextBox m_txtLargeStraight;
	private TextBox m_txtFNDice;
	private TextBox m_txtChance;
	private Button m_btnEndTurn;
	private TableLayoutPanel m_tlpTotals;
	private Label label1;
	private Label label2;
	private Label label3;
	private TextBox m_txtUpperTotal;
	private TextBox m_txtLowerTotal;
	private TextBox m_txtGrandTotal;
}
