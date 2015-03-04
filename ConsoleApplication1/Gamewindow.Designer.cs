namespace ConsoleApplication1
{
    partial class Gamewindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1_label = new System.Windows.Forms.Label();
            this.player1chips_label = new System.Windows.Forms.Label();
            this.desc_chips1_label = new System.Windows.Forms.Label();
            this.playerinfo_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ai_label = new System.Windows.Forms.Label();
            this.aiplayerchips_label = new System.Windows.Forms.Label();
            this.desc_chips2_label = new System.Windows.Forms.Label();
            this.desc_pot = new System.Windows.Forms.Label();
            this.currentpot = new System.Windows.Forms.Label();
            this.river = new System.Windows.Forms.PictureBox();
            this.turn = new System.Windows.Forms.PictureBox();
            this.ai_card2 = new System.Windows.Forms.PictureBox();
            this.ai_card1 = new System.Windows.Forms.PictureBox();
            this.player_card2 = new System.Windows.Forms.PictureBox();
            this.flop_2 = new System.Windows.Forms.PictureBox();
            this.flop_3 = new System.Windows.Forms.PictureBox();
            this.flop_1 = new System.Windows.Forms.PictureBox();
            this.player_card1 = new System.Windows.Forms.PictureBox();
            this.pokerTable_box = new System.Windows.Forms.PictureBox();
            this.eventtext_label = new System.Windows.Forms.Label();
            this.check_button = new System.Windows.Forms.Button();
            this.fold_button = new System.Windows.Forms.Button();
            this.bet_button = new System.Windows.Forms.Button();
            this.call_button = new System.Windows.Forms.Button();
            this.bet_amount = new System.Windows.Forms.NumericUpDown();
            this.player_bet_amount = new System.Windows.Forms.Label();
            this.aiplayer_bet_amount = new System.Windows.Forms.Label();
            this.determine_button = new System.Windows.Forms.Button();
            this.playerinfo_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.river)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flop_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flop_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flop_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerTable_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // player1_label
            // 
            this.player1_label.AutoSize = true;
            this.player1_label.BackColor = System.Drawing.Color.Transparent;
            this.player1_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1_label.Location = new System.Drawing.Point(3, 0);
            this.player1_label.Name = "player1_label";
            this.player1_label.Size = new System.Drawing.Size(109, 22);
            this.player1_label.TabIndex = 0;
            this.player1_label.Text = "player1_label";
            // 
            // player1chips_label
            // 
            this.player1chips_label.AutoSize = true;
            this.player1chips_label.BackColor = System.Drawing.Color.Transparent;
            this.player1chips_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1chips_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player1chips_label.Location = new System.Drawing.Point(58, 45);
            this.player1chips_label.Name = "player1chips_label";
            this.player1chips_label.Size = new System.Drawing.Size(54, 22);
            this.player1chips_label.TabIndex = 2;
            this.player1chips_label.Text = "label1";
            // 
            // desc_chips1_label
            // 
            this.desc_chips1_label.AutoSize = true;
            this.desc_chips1_label.BackColor = System.Drawing.Color.Transparent;
            this.desc_chips1_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_chips1_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desc_chips1_label.Location = new System.Drawing.Point(3, 45);
            this.desc_chips1_label.Name = "desc_chips1_label";
            this.desc_chips1_label.Size = new System.Drawing.Size(56, 22);
            this.desc_chips1_label.TabIndex = 3;
            this.desc_chips1_label.Text = "Chips:";
            // 
            // playerinfo_panel
            // 
            this.playerinfo_panel.Controls.Add(this.player1_label);
            this.playerinfo_panel.Controls.Add(this.player1chips_label);
            this.playerinfo_panel.Controls.Add(this.desc_chips1_label);
            this.playerinfo_panel.Location = new System.Drawing.Point(779, 522);
            this.playerinfo_panel.Name = "playerinfo_panel";
            this.playerinfo_panel.Size = new System.Drawing.Size(180, 105);
            this.playerinfo_panel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ai_label);
            this.panel1.Controls.Add(this.aiplayerchips_label);
            this.panel1.Controls.Add(this.desc_chips2_label);
            this.panel1.Location = new System.Drawing.Point(779, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 105);
            this.panel1.TabIndex = 23;
            // 
            // ai_label
            // 
            this.ai_label.AutoSize = true;
            this.ai_label.BackColor = System.Drawing.Color.Transparent;
            this.ai_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ai_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ai_label.Location = new System.Drawing.Point(3, 0);
            this.ai_label.Name = "ai_label";
            this.ai_label.Size = new System.Drawing.Size(68, 22);
            this.ai_label.TabIndex = 0;
            this.ai_label.Text = "ai_label";
            // 
            // aiplayerchips_label
            // 
            this.aiplayerchips_label.AutoSize = true;
            this.aiplayerchips_label.BackColor = System.Drawing.Color.Transparent;
            this.aiplayerchips_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiplayerchips_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aiplayerchips_label.Location = new System.Drawing.Point(58, 45);
            this.aiplayerchips_label.Name = "aiplayerchips_label";
            this.aiplayerchips_label.Size = new System.Drawing.Size(54, 22);
            this.aiplayerchips_label.TabIndex = 2;
            this.aiplayerchips_label.Text = "label1";
            // 
            // desc_chips2_label
            // 
            this.desc_chips2_label.AutoSize = true;
            this.desc_chips2_label.BackColor = System.Drawing.Color.Transparent;
            this.desc_chips2_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_chips2_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.desc_chips2_label.Location = new System.Drawing.Point(3, 45);
            this.desc_chips2_label.Name = "desc_chips2_label";
            this.desc_chips2_label.Size = new System.Drawing.Size(56, 22);
            this.desc_chips2_label.TabIndex = 3;
            this.desc_chips2_label.Text = "Chips:";
            // 
            // desc_pot
            // 
            this.desc_pot.AutoSize = true;
            this.desc_pot.BackColor = System.Drawing.Color.Transparent;
            this.desc_pot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_pot.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.desc_pot.Location = new System.Drawing.Point(694, 269);
            this.desc_pot.Name = "desc_pot";
            this.desc_pot.Size = new System.Drawing.Size(95, 17);
            this.desc_pot.TabIndex = 24;
            this.desc_pot.Text = "Current pot:";
            this.desc_pot.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentpot
            // 
            this.currentpot.AutoSize = true;
            this.currentpot.BackColor = System.Drawing.Color.Transparent;
            this.currentpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentpot.Location = new System.Drawing.Point(795, 269);
            this.currentpot.Name = "currentpot";
            this.currentpot.Size = new System.Drawing.Size(0, 17);
            this.currentpot.TabIndex = 25;
            // 
            // river
            // 
            this.river.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.river.Location = new System.Drawing.Point(614, 230);
            this.river.Name = "river";
            this.river.Size = new System.Drawing.Size(62, 94);
            this.river.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.river.TabIndex = 19;
            this.river.TabStop = false;
            // 
            // turn
            // 
            this.turn.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.turn.Location = new System.Drawing.Point(546, 230);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(62, 94);
            this.turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turn.TabIndex = 18;
            this.turn.TabStop = false;
            // 
            // ai_card2
            // 
            this.ai_card2.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.ai_card2.Location = new System.Drawing.Point(500, 2);
            this.ai_card2.Name = "ai_card2";
            this.ai_card2.Size = new System.Drawing.Size(83, 128);
            this.ai_card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ai_card2.TabIndex = 16;
            this.ai_card2.TabStop = false;
            // 
            // ai_card1
            // 
            this.ai_card1.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.ai_card1.Location = new System.Drawing.Point(399, 2);
            this.ai_card1.Name = "ai_card1";
            this.ai_card1.Size = new System.Drawing.Size(83, 128);
            this.ai_card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ai_card1.TabIndex = 15;
            this.ai_card1.TabStop = false;
            // 
            // player_card2
            // 
            this.player_card2.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.player_card2.Location = new System.Drawing.Point(500, 450);
            this.player_card2.Name = "player_card2";
            this.player_card2.Size = new System.Drawing.Size(83, 128);
            this.player_card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_card2.TabIndex = 14;
            this.player_card2.TabStop = false;
            // 
            // flop_2
            // 
            this.flop_2.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.flop_2.Location = new System.Drawing.Point(377, 230);
            this.flop_2.Name = "flop_2";
            this.flop_2.Size = new System.Drawing.Size(62, 94);
            this.flop_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flop_2.TabIndex = 13;
            this.flop_2.TabStop = false;
            // 
            // flop_3
            // 
            this.flop_3.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.flop_3.Location = new System.Drawing.Point(445, 230);
            this.flop_3.Name = "flop_3";
            this.flop_3.Size = new System.Drawing.Size(62, 94);
            this.flop_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flop_3.TabIndex = 12;
            this.flop_3.TabStop = false;
            // 
            // flop_1
            // 
            this.flop_1.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.flop_1.Location = new System.Drawing.Point(309, 230);
            this.flop_1.Name = "flop_1";
            this.flop_1.Size = new System.Drawing.Size(62, 94);
            this.flop_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flop_1.TabIndex = 11;
            this.flop_1.TabStop = false;
            // 
            // player_card1
            // 
            this.player_card1.Image = global::ConsoleApplication1.Properties.Resources.BackofCard;
            this.player_card1.Location = new System.Drawing.Point(399, 450);
            this.player_card1.Name = "player_card1";
            this.player_card1.Size = new System.Drawing.Size(83, 128);
            this.player_card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_card1.TabIndex = 6;
            this.player_card1.TabStop = false;
            // 
            // pokerTable_box
            // 
            this.pokerTable_box.Image = global::ConsoleApplication1.Properties.Resources.poker_table_environment;
            this.pokerTable_box.Location = new System.Drawing.Point(1, 2);
            this.pokerTable_box.Name = "pokerTable_box";
            this.pokerTable_box.Size = new System.Drawing.Size(958, 625);
            this.pokerTable_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokerTable_box.TabIndex = 4;
            this.pokerTable_box.TabStop = false;
            // 
            // eventtext_label
            // 
            this.eventtext_label.AutoSize = true;
            this.eventtext_label.BackColor = System.Drawing.Color.Transparent;
            this.eventtext_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eventtext_label.Location = new System.Drawing.Point(109, 273);
            this.eventtext_label.Name = "eventtext_label";
            this.eventtext_label.Size = new System.Drawing.Size(82, 13);
            this.eventtext_label.TabIndex = 26;
            this.eventtext_label.Text = "Game is starting";
            // 
            // check_button
            // 
            this.check_button.Enabled = false;
            this.check_button.Location = new System.Drawing.Point(874, 493);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(75, 23);
            this.check_button.TabIndex = 27;
            this.check_button.Text = "Check";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // fold_button
            // 
            this.fold_button.Enabled = false;
            this.fold_button.Location = new System.Drawing.Point(874, 464);
            this.fold_button.Name = "fold_button";
            this.fold_button.Size = new System.Drawing.Size(75, 23);
            this.fold_button.TabIndex = 28;
            this.fold_button.Text = "Fold";
            this.fold_button.UseVisualStyleBackColor = true;
            this.fold_button.Click += new System.EventHandler(this.fold_button_Click);
            // 
            // bet_button
            // 
            this.bet_button.Enabled = false;
            this.bet_button.Location = new System.Drawing.Point(775, 464);
            this.bet_button.Name = "bet_button";
            this.bet_button.Size = new System.Drawing.Size(75, 23);
            this.bet_button.TabIndex = 29;
            this.bet_button.Text = "Bet";
            this.bet_button.UseVisualStyleBackColor = true;
            this.bet_button.Click += new System.EventHandler(this.bet_button_Click);
            // 
            // call_button
            // 
            this.call_button.Enabled = false;
            this.call_button.Location = new System.Drawing.Point(874, 406);
            this.call_button.Name = "call_button";
            this.call_button.Size = new System.Drawing.Size(75, 23);
            this.call_button.TabIndex = 31;
            this.call_button.Text = "Call";
            this.call_button.UseVisualStyleBackColor = true;
            this.call_button.Click += new System.EventHandler(this.call_button_Click);
            // 
            // bet_amount
            // 
            this.bet_amount.Enabled = false;
            this.bet_amount.Location = new System.Drawing.Point(730, 493);
            this.bet_amount.Name = "bet_amount";
            this.bet_amount.Size = new System.Drawing.Size(120, 20);
            this.bet_amount.TabIndex = 32;
            // 
            // player_bet_amount
            // 
            this.player_bet_amount.AutoSize = true;
            this.player_bet_amount.BackColor = System.Drawing.Color.Transparent;
            this.player_bet_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_bet_amount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.player_bet_amount.Location = new System.Drawing.Point(611, 391);
            this.player_bet_amount.Name = "player_bet_amount";
            this.player_bet_amount.Size = new System.Drawing.Size(0, 17);
            this.player_bet_amount.TabIndex = 33;
            // 
            // aiplayer_bet_amount
            // 
            this.aiplayer_bet_amount.AutoSize = true;
            this.aiplayer_bet_amount.BackColor = System.Drawing.Color.Transparent;
            this.aiplayer_bet_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiplayer_bet_amount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aiplayer_bet_amount.Location = new System.Drawing.Point(583, 164);
            this.aiplayer_bet_amount.Name = "aiplayer_bet_amount";
            this.aiplayer_bet_amount.Size = new System.Drawing.Size(0, 17);
            this.aiplayer_bet_amount.TabIndex = 34;
            // 
            // determine_button
            // 
            this.determine_button.Location = new System.Drawing.Point(706, 289);
            this.determine_button.Name = "determine_button";
            this.determine_button.Size = new System.Drawing.Size(74, 43);
            this.determine_button.TabIndex = 41;
            this.determine_button.Text = "Determine winner";
            this.determine_button.UseVisualStyleBackColor = true;
            this.determine_button.Visible = false;
            this.determine_button.Click += new System.EventHandler(this.determine_button_Click);
            // 
            // Gamewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 628);
            this.Controls.Add(this.determine_button);
            this.Controls.Add(this.aiplayer_bet_amount);
            this.Controls.Add(this.player_bet_amount);
            this.Controls.Add(this.bet_amount);
            this.Controls.Add(this.call_button);
            this.Controls.Add(this.bet_button);
            this.Controls.Add(this.fold_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.eventtext_label);
            this.Controls.Add(this.currentpot);
            this.Controls.Add(this.desc_pot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.river);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.ai_card2);
            this.Controls.Add(this.ai_card1);
            this.Controls.Add(this.player_card2);
            this.Controls.Add(this.flop_2);
            this.Controls.Add(this.flop_3);
            this.Controls.Add(this.flop_1);
            this.Controls.Add(this.player_card1);
            this.Controls.Add(this.playerinfo_panel);
            this.Controls.Add(this.pokerTable_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Gamewindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamewindow";
            this.Load += new System.EventHandler(this.Gamewindow_Load);
            this.playerinfo_panel.ResumeLayout(false);
            this.playerinfo_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.river)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flop_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flop_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flop_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokerTable_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bet_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label player1_label;
        public System.Windows.Forms.Label player1chips_label;
        private System.Windows.Forms.Label desc_chips1_label;
        private System.Windows.Forms.PictureBox pokerTable_box;
        private System.Windows.Forms.Panel playerinfo_panel;
        public System.Windows.Forms.PictureBox player_card1;
        public System.Windows.Forms.PictureBox flop_1;
        public System.Windows.Forms.PictureBox flop_3;
        public System.Windows.Forms.PictureBox flop_2;
        public System.Windows.Forms.PictureBox player_card2;
        public System.Windows.Forms.PictureBox ai_card1;
        public System.Windows.Forms.PictureBox ai_card2;
        public System.Windows.Forms.PictureBox turn;
        public System.Windows.Forms.PictureBox river;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label ai_label;
        public System.Windows.Forms.Label aiplayerchips_label;
        private System.Windows.Forms.Label desc_chips2_label;
        private System.Windows.Forms.Label desc_pot;
        public System.Windows.Forms.Label currentpot;
        public System.Windows.Forms.Label eventtext_label;
        public System.Windows.Forms.Button check_button;
        public System.Windows.Forms.Button fold_button;
        public System.Windows.Forms.Button bet_button;
        public System.Windows.Forms.Button call_button;
        public System.Windows.Forms.NumericUpDown bet_amount;
        public System.Windows.Forms.Label player_bet_amount;
        public System.Windows.Forms.Label aiplayer_bet_amount;
        public System.Windows.Forms.Button determine_button;


    }
}