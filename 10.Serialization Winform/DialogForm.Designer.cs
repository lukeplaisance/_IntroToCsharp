namespace _4.Serialization
{
    partial class DialogForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConversationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmoteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyAnimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversationSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConversationID,
            this.EmoteType,
            this.Side,
            this.Line,
            this.SpecialtyAnimation,
            this.SpecialtyCamera,
            this.Participants,
            this.ConversationSummary,
            this.ParticipantName});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ConversationID
            // 
            this.ConversationID.HeaderText = "ConversationID";
            this.ConversationID.Name = "ConversationID";
            this.ConversationID.ReadOnly = true;
            this.ConversationID.Width = 125;
            // 
            // EmoteType
            // 
            this.EmoteType.HeaderText = "EmoteType";
            this.EmoteType.Name = "EmoteType";
            this.EmoteType.ReadOnly = true;
            this.EmoteType.Width = 125;
            // 
            // Side
            // 
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Width = 125;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Width = 125;
            // 
            // SpecialtyAnimation
            // 
            this.SpecialtyAnimation.HeaderText = "SpecialtyAnimation";
            this.SpecialtyAnimation.Name = "SpecialtyAnimation";
            this.SpecialtyAnimation.ReadOnly = true;
            this.SpecialtyAnimation.Width = 125;
            // 
            // SpecialtyCamera
            // 
            this.SpecialtyCamera.HeaderText = "SpecialtyCamera";
            this.SpecialtyCamera.Name = "SpecialtyCamera";
            this.SpecialtyCamera.ReadOnly = true;
            this.SpecialtyCamera.Width = 125;
            // 
            // Participants
            // 
            this.Participants.HeaderText = "Participants";
            this.Participants.Name = "Participants";
            this.Participants.ReadOnly = true;
            this.Participants.Width = 125;
            // 
            // ConversationSummary
            // 
            this.ConversationSummary.HeaderText = "ConversationSummary";
            this.ConversationSummary.Name = "ConversationSummary";
            this.ConversationSummary.ReadOnly = true;
            this.ConversationSummary.Width = 125;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "ParticipantName";
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            this.ParticipantName.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(504, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next Dialogue";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Previous Conversation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(591, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Next Conversation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-1, 374);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1157, 119);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 678);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmoteType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyAnimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}