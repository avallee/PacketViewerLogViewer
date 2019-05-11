﻿namespace PacketViewerLogViewer
{
    partial class SearchForm
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
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOutgoing = new System.Windows.Forms.RadioButton();
            this.rbIncoming = new System.Windows.Forms.RadioButton();
            this.rbAny = new System.Windows.Forms.RadioButton();
            this.btnAsNewTab = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbUInt32 = new System.Windows.Forms.RadioButton();
            this.rbUInt16 = new System.Windows.Forms.RadioButton();
            this.rbByte = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eValue = new System.Windows.Forms.TextBox();
            this.eSync = new System.Windows.Forms.TextBox();
            this.ePacketID = new System.Windows.Forms.TextBox();
            this.gbRawValues = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eFieldValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFieldNames = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbRawValues.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.Enabled = false;
            this.btnFindNext.Location = new System.Drawing.Point(331, 12);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 10;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.BtnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(331, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbOutgoing);
            this.groupBox1.Controls.Add(this.rbIncoming);
            this.groupBox1.Controls.Add(this.rbAny);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Packet Types to search in";
            // 
            // rbOutgoing
            // 
            this.rbOutgoing.AutoSize = true;
            this.rbOutgoing.Location = new System.Drawing.Point(210, 19);
            this.rbOutgoing.Name = "rbOutgoing";
            this.rbOutgoing.Size = new System.Drawing.Size(68, 17);
            this.rbOutgoing.TabIndex = 2;
            this.rbOutgoing.Text = "Outgoing";
            this.rbOutgoing.UseVisualStyleBackColor = true;
            // 
            // rbIncoming
            // 
            this.rbIncoming.AutoSize = true;
            this.rbIncoming.Location = new System.Drawing.Point(98, 19);
            this.rbIncoming.Name = "rbIncoming";
            this.rbIncoming.Size = new System.Drawing.Size(68, 17);
            this.rbIncoming.TabIndex = 1;
            this.rbIncoming.Text = "Incoming";
            this.rbIncoming.UseVisualStyleBackColor = true;
            // 
            // rbAny
            // 
            this.rbAny.AutoSize = true;
            this.rbAny.Checked = true;
            this.rbAny.Location = new System.Drawing.Point(6, 19);
            this.rbAny.Name = "rbAny";
            this.rbAny.Size = new System.Drawing.Size(43, 17);
            this.rbAny.TabIndex = 0;
            this.rbAny.TabStop = true;
            this.rbAny.Text = "Any";
            this.rbAny.UseVisualStyleBackColor = true;
            // 
            // btnAsNewTab
            // 
            this.btnAsNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsNewTab.Enabled = false;
            this.btnAsNewTab.Location = new System.Drawing.Point(331, 89);
            this.btnAsNewTab.Name = "btnAsNewTab";
            this.btnAsNewTab.Size = new System.Drawing.Size(75, 23);
            this.btnAsNewTab.TabIndex = 13;
            this.btnAsNewTab.Text = "As New Tab";
            this.btnAsNewTab.UseVisualStyleBackColor = true;
            this.btnAsNewTab.Click += new System.EventHandler(this.BtnAsNewTab_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.eSync);
            this.groupBox2.Controls.Add(this.ePacketID);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search for packet";
            // 
            // rbUInt32
            // 
            this.rbUInt32.AutoSize = true;
            this.rbUInt32.Location = new System.Drawing.Point(329, 22);
            this.rbUInt32.Name = "rbUInt32";
            this.rbUInt32.Size = new System.Drawing.Size(54, 17);
            this.rbUInt32.TabIndex = 8;
            this.rbUInt32.Text = "uint32";
            this.rbUInt32.UseVisualStyleBackColor = true;
            this.rbUInt32.CheckedChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // rbUInt16
            // 
            this.rbUInt16.AutoSize = true;
            this.rbUInt16.Location = new System.Drawing.Point(269, 22);
            this.rbUInt16.Name = "rbUInt16";
            this.rbUInt16.Size = new System.Drawing.Size(54, 17);
            this.rbUInt16.TabIndex = 7;
            this.rbUInt16.Text = "uint16";
            this.rbUInt16.UseVisualStyleBackColor = true;
            this.rbUInt16.CheckedChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // rbByte
            // 
            this.rbByte.AutoSize = true;
            this.rbByte.Checked = true;
            this.rbByte.Location = new System.Drawing.Point(218, 22);
            this.rbByte.Name = "rbByte";
            this.rbByte.Size = new System.Drawing.Size(45, 17);
            this.rbByte.TabIndex = 6;
            this.rbByte.TabStop = true;
            this.rbByte.Text = "byte";
            this.rbByte.UseVisualStyleBackColor = true;
            this.rbByte.CheckedChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Raw Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sync Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Packet ID";
            // 
            // eValue
            // 
            this.eValue.Location = new System.Drawing.Point(85, 21);
            this.eValue.Name = "eValue";
            this.eValue.Size = new System.Drawing.Size(119, 20);
            this.eValue.TabIndex = 2;
            this.eValue.TextChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // eSync
            // 
            this.eSync.Location = new System.Drawing.Point(136, 41);
            this.eSync.Name = "eSync";
            this.eSync.Size = new System.Drawing.Size(68, 20);
            this.eSync.TabIndex = 1;
            this.eSync.TextChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // ePacketID
            // 
            this.ePacketID.Location = new System.Drawing.Point(136, 15);
            this.ePacketID.Name = "ePacketID";
            this.ePacketID.Size = new System.Drawing.Size(68, 20);
            this.ePacketID.TabIndex = 0;
            this.ePacketID.TextChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // gbRawValues
            // 
            this.gbRawValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRawValues.Controls.Add(this.rbUInt32);
            this.gbRawValues.Controls.Add(this.label3);
            this.gbRawValues.Controls.Add(this.rbUInt16);
            this.gbRawValues.Controls.Add(this.eValue);
            this.gbRawValues.Controls.Add(this.rbByte);
            this.gbRawValues.Location = new System.Drawing.Point(12, 151);
            this.gbRawValues.Name = "gbRawValues";
            this.gbRawValues.Size = new System.Drawing.Size(394, 62);
            this.gbRawValues.TabIndex = 15;
            this.gbRawValues.TabStop = false;
            this.gbRawValues.Text = "Search for RAW value";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbFieldNames);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.eFieldValue);
            this.groupBox3.Location = new System.Drawing.Point(12, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 78);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search for PARSED value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Field Name";
            // 
            // eFieldValue
            // 
            this.eFieldValue.Location = new System.Drawing.Point(285, 21);
            this.eFieldValue.Name = "eFieldValue";
            this.eFieldValue.Size = new System.Drawing.Size(103, 20);
            this.eFieldValue.TabIndex = 2;
            this.eFieldValue.TextChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Field Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Note: parsed values are always treated as strings";
            // 
            // cbFieldNames
            // 
            this.cbFieldNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbFieldNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFieldNames.FormattingEnabled = true;
            this.cbFieldNames.Location = new System.Drawing.Point(85, 19);
            this.cbFieldNames.Name = "cbFieldNames";
            this.cbFieldNames.Size = new System.Drawing.Size(119, 21);
            this.cbFieldNames.TabIndex = 8;
            this.cbFieldNames.TextChanged += new System.EventHandler(this.SearchFieldsChanged);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(415, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbRawValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAsNewTab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbRawValues.ResumeLayout(false);
            this.gbRawValues.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOutgoing;
        private System.Windows.Forms.RadioButton rbIncoming;
        private System.Windows.Forms.RadioButton rbAny;
        public System.Windows.Forms.Button btnAsNewTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbUInt32;
        private System.Windows.Forms.RadioButton rbUInt16;
        private System.Windows.Forms.RadioButton rbByte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eValue;
        private System.Windows.Forms.TextBox eSync;
        private System.Windows.Forms.TextBox ePacketID;
        private System.Windows.Forms.GroupBox gbRawValues;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbFieldNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eFieldValue;
    }
}