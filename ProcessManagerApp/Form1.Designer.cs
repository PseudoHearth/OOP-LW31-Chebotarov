namespace ProcessManagerApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            processListView = new ListView();
            contextMenuStrip = new ContextMenuStrip(components);
            detailsToolStripMenuItem = new ToolStripMenuItem();
            stopProcessToolStripMenuItem = new ToolStripMenuItem();
            refreshButton = new Button();
            exportButton = new Button();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // processListView
            // 
            processListView.ContextMenuStrip = contextMenuStrip;
            processListView.Location = new Point(11, 11);
            processListView.Name = "processListView";
            processListView.Size = new Size(550, 389);
            processListView.TabIndex = 0;
            processListView.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { detailsToolStripMenuItem, stopProcessToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(181, 70);
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(180, 22);
            detailsToolStripMenuItem.Text = "Детально";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // stopProcessToolStripMenuItem
            // 
            stopProcessToolStripMenuItem.Name = "stopProcessToolStripMenuItem";
            stopProcessToolStripMenuItem.Size = new Size(180, 22);
            stopProcessToolStripMenuItem.Text = "Зупинити";
            stopProcessToolStripMenuItem.Click += stopProcessToolStripMenuItem_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(583, 123);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(154, 100);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Перезавантажити";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(583, 229);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(154, 95);
            exportButton.TabIndex = 2;
            exportButton.Text = "Експорт";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exportButton);
            Controls.Add(refreshButton);
            Controls.Add(processListView);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView processListView;
        private Button refreshButton;
        private Button exportButton;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem stopProcessToolStripMenuItem;
    }
}