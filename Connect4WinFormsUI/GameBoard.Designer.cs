namespace Connect4WinFormsUI
{
    partial class GameBoard
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
            this.components = new System.ComponentModel.Container();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelPlayerLabels = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWhoseTurn = new System.Windows.Forms.TableLayoutPanel();
            this.labelWhoseTurn = new System.Windows.Forms.Label();
            this.tableLayoutPanelScores = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelForfeitButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonForfeit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panelPlayerLabels.SuspendLayout();
            this.tableLayoutPanelWhoseTurn.SuspendLayout();
            this.tableLayoutPanelScores.SuspendLayout();
            this.tableLayoutPanelForfeitButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Name.Location = new System.Drawing.Point(149, 5);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(76, 17);
            this.labelPlayer2Name.TabIndex = 3;
            this.labelPlayer2Name.Text = "Player 2: 0";
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Name.Location = new System.Drawing.Point(47, 5);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(76, 17);
            this.labelPlayer1Name.TabIndex = 5;
            this.labelPlayer1Name.Text = "Player 1: 0";
            // 
            // panelPlayerLabels
            // 
            this.panelPlayerLabels.Controls.Add(this.tableLayoutPanelWhoseTurn);
            this.panelPlayerLabels.Controls.Add(this.tableLayoutPanelScores);
            this.panelPlayerLabels.Controls.Add(this.tableLayoutPanelForfeitButton);
            this.panelPlayerLabels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayerLabels.Location = new System.Drawing.Point(0, 149);
            this.panelPlayerLabels.Name = "panelPlayerLabels";
            this.panelPlayerLabels.Size = new System.Drawing.Size(272, 94);
            this.panelPlayerLabels.TabIndex = 7;
            // 
            // tableLayoutPanelWhoseTurn
            // 
            this.tableLayoutPanelWhoseTurn.ColumnCount = 3;
            this.tableLayoutPanelWhoseTurn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWhoseTurn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWhoseTurn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWhoseTurn.Controls.Add(this.labelWhoseTurn, 1, 0);
            this.tableLayoutPanelWhoseTurn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelWhoseTurn.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanelWhoseTurn.Name = "tableLayoutPanelWhoseTurn";
            this.tableLayoutPanelWhoseTurn.RowCount = 1;
            this.tableLayoutPanelWhoseTurn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelWhoseTurn.Size = new System.Drawing.Size(272, 32);
            this.tableLayoutPanelWhoseTurn.TabIndex = 8;
            // 
            // labelWhoseTurn
            // 
            this.labelWhoseTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWhoseTurn.AutoSize = true;
            this.labelWhoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhoseTurn.Location = new System.Drawing.Point(72, 6);
            this.labelWhoseTurn.Name = "labelWhoseTurn";
            this.labelWhoseTurn.Size = new System.Drawing.Size(127, 20);
            this.labelWhoseTurn.TabIndex = 6;
            this.labelWhoseTurn.Text = "Player 1\'s Turn";
            // 
            // tableLayoutPanelScores
            // 
            this.tableLayoutPanelScores.ColumnCount = 5;
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelScores.Controls.Add(this.labelPlayer1Name, 1, 0);
            this.tableLayoutPanelScores.Controls.Add(this.labelPlayer2Name, 3, 0);
            this.tableLayoutPanelScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelScores.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelScores.Name = "tableLayoutPanelScores";
            this.tableLayoutPanelScores.RowCount = 1;
            this.tableLayoutPanelScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelScores.Size = new System.Drawing.Size(272, 27);
            this.tableLayoutPanelScores.TabIndex = 9;
            // 
            // tableLayoutPanelForfeitButton
            // 
            this.tableLayoutPanelForfeitButton.ColumnCount = 3;
            this.tableLayoutPanelForfeitButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForfeitButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelForfeitButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForfeitButton.Controls.Add(this.buttonForfeit, 1, 0);
            this.tableLayoutPanelForfeitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelForfeitButton.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanelForfeitButton.Name = "tableLayoutPanelForfeitButton";
            this.tableLayoutPanelForfeitButton.RowCount = 1;
            this.tableLayoutPanelForfeitButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelForfeitButton.Size = new System.Drawing.Size(272, 35);
            this.tableLayoutPanelForfeitButton.TabIndex = 10;
            // 
            // buttonForfeit
            // 
            this.buttonForfeit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonForfeit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForfeit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonForfeit.Location = new System.Drawing.Point(91, 5);
            this.buttonForfeit.Name = "buttonForfeit";
            this.buttonForfeit.Size = new System.Drawing.Size(90, 25);
            this.buttonForfeit.TabIndex = 7;
            this.buttonForfeit.Text = "Forfeit";
            this.buttonForfeit.UseVisualStyleBackColor = true;
            this.buttonForfeit.Click += new System.EventHandler(this.buttonForfeit_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(272, 243);
            this.Controls.Add(this.panelPlayerLabels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "GameBoard";
            this.Text = "4 in a Row!!";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panelPlayerLabels.ResumeLayout(false);
            this.tableLayoutPanelWhoseTurn.ResumeLayout(false);
            this.tableLayoutPanelWhoseTurn.PerformLayout();
            this.tableLayoutPanelScores.ResumeLayout(false);
            this.tableLayoutPanelScores.PerformLayout();
            this.tableLayoutPanelForfeitButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panelPlayerLabels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWhoseTurn;
        private System.Windows.Forms.Label labelWhoseTurn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForfeitButton;
        private System.Windows.Forms.Button buttonForfeit;
    }
}