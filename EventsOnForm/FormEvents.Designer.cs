
namespace EventsOnForm
{
    partial class FormEvents
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
            this.labelCoord = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCoord.Location = new System.Drawing.Point(12, 50);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(51, 25);
            this.labelCoord.TabIndex = 0;
            this.labelCoord.Text = "X: Y:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Location = new System.Drawing.Point(12, 13);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(171, 25);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Ширина: Высота:";
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 280);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelCoord);
            this.Name = "FormEvents";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.Label labelSize;
    }
}

