namespace NewOctree
{
    partial class QuantizedForm
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
            this.picBoxQuantized = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuantized)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxQuantized
            // 
            this.picBoxQuantized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxQuantized.Location = new System.Drawing.Point(0, 0);
            this.picBoxQuantized.Name = "picBoxQuantized";
            this.picBoxQuantized.Size = new System.Drawing.Size(659, 398);
            this.picBoxQuantized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQuantized.TabIndex = 0;
            this.picBoxQuantized.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 398);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(659, 47);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // QuantizedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.picBoxQuantized);
            this.Controls.Add(this.flowLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "QuantizedForm";
            this.Text = "Quantized picture";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuantized)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxQuantized;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}