using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _4.Serialization
{
    public partial class DialogForm : Form
    {
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn ConversationID;
        private DataGridViewTextBoxColumn ParticipantName;
        private DataGridViewTextBoxColumn EmoteType;
        private DataGridViewTextBoxColumn Side;
        private DataGridViewTextBoxColumn Line;
        private DataGridViewTextBoxColumn SpecialtyAnimation;
        private DataGridViewTextBoxColumn SpecialtyCamera;
        private DataGridViewTextBoxColumn Participants;
        private DataGridViewTextBoxColumn ConversationSummary;
        private DataGridView dataGridView1;

        public DialogForm()
        {
            InitializeComponent();
            dataGridView1.CurrentCell.Clone();
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ConversationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmoteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyAnimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversationSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConversationID,
            this.ParticipantName,
            this.EmoteType,
            this.Side,
            this.Line,
            this.SpecialtyAnimation,
            this.SpecialtyCamera,
            this.Participants,
            this.ConversationSummary});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1196, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 372);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1143, 144);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Next Dialogue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Previous Conversation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 65);
            this.button3.TabIndex = 4;
            this.button3.Text = "Next Conversation";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ConversationID
            // 
            this.ConversationID.HeaderText = "ConversationID";
            this.ConversationID.Name = "ConversationID";
            this.ConversationID.ReadOnly = true;
            this.ConversationID.Width = 125;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "ParticipantName";
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            this.ParticipantName.Width = 125;
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
            // DialogForm
            // 
            this.ClientSize = new System.Drawing.Size(1167, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
