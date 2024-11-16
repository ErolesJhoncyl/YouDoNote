namespace YouDoNote
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btnAddNote = new Button();
            NotePanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddNote);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(298, 40);
            label1.TabIndex = 1;
            label1.Text = "YouDoNote App";
            // 
            // btnAddNote
            // 
            btnAddNote.BackColor = Color.FromArgb(192, 255, 192);
            btnAddNote.Font = new Font("Stencil", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNote.Location = new Point(671, 24);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(98, 29);
            btnAddNote.TabIndex = 0;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = false;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // NotePanel
            // 
            NotePanel.AutoScroll = true;
            NotePanel.BackColor = Color.FromArgb(255, 255, 192);
            NotePanel.FlowDirection = FlowDirection.TopDown;
            NotePanel.Location = new Point(1, 79);
            NotePanel.Name = "NotePanel";
            NotePanel.Size = new Size(797, 368);
            NotePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NotePanel);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAddNote;
        private FlowLayoutPanel NotePanel;
    }
}
